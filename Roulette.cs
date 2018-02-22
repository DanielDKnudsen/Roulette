using System;
using System.Collections.Generic;

namespace RouletteGame.Legacy
{
    public class Roulette : IRoulette
    {
        private readonly List<Field> _fields;
        private Field _result;
        private readonly IRandomNumberGeneration _randomNumberGeneration;

        public Roulette(List<Field> fields, IRandomNumberGeneration randomNumberGeneration)
        {
            _fields = fields;
            _result = _fields[0];
            _randomNumberGeneration = randomNumberGeneration;
        }

        public void Spin(int number)
        {
            _result = _fields[number];
        }

        public Field GetResult()
        {
            return _result;
        }

        public int GenerateRandomNumber(int low, int high)
        {
            return _randomNumberGeneration.GenerateRandomNumber(low, high);
        }

    }
}