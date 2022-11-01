namespace Config
{
    public interface IConfig
    {
        float CoinsDensity { get; }
        float TotalTime { get; }
        float PlayerSpeed { get; }
        int ArenaSizeX { get; }
        int ArenaSizeY { get; }
        float CoinRotationSpeed { get; }
    }
}