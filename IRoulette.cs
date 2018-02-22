namespace RouletteGame.Legacy
{
    public interface IRoulette
    {
        int GenerateRandomNumber(int low, int high);
        Field GetResult();
        void Spin(int number);
    }
}