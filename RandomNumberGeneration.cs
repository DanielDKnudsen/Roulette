using System;

namespace RouletteGame.Legacy
{
    public class RandomNumberGeneration : IRandomNumberGeneration
    {
        public int GenerateRandomNumber(int low, int high)
        {
            return new Random().Next(low, high);
        }
    }
}