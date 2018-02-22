namespace RouletteGame.Legacy
{
    public interface IBet
    {
        uint WonAmount(Field field);
        string PlayerName { get; }
        uint Amount { get; }
    }
}