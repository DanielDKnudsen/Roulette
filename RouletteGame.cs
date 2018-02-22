using System;
using System.Collections.Generic;

namespace RouletteGame.Legacy
{
    public class RouletteGame
    {
        private readonly List<IBet> _bets;
        private readonly IRoulette _roulette;
        public bool RoundIsOpen { get; private set; }

        public RouletteGame(IRoulette roulette, List<IBet> bets)
        {
            _bets = bets;
            _roulette = roulette;
        }

        public void OpenBets()
        {
            Console.WriteLine("Round is open for bets");
            RoundIsOpen = true;
        }

        public void CloseBets()
        {
            Console.WriteLine("Round is closed for bets");
            RoundIsOpen = false;
        }

        public void PlaceBet(Bet bet)
        {
            if (RoundIsOpen) _bets.Add(bet);
            else throw new RouletteGameException("Bet placed while round closed");
        }

        public void SpinRoulette()
        {
            Console.Write("Spinning...");
            _roulette.Spin(_roulette.GenerateRandomNumber(0, 37));
            Console.WriteLine("Result: {0}", _roulette.GetResult());
        }

        public void PayUp()
        {
            var result = _roulette.GetResult();

            foreach (var bet in _bets)
            {
                var won = bet.WonAmount(result);
                if (won > 0)
                    Console.WriteLine("{0} just won {1}$ on a {2}", bet.PlayerName, won, bet);
            }
        }
    }
}