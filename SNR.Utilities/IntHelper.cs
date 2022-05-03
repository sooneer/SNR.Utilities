namespace SNR.Utilities;

public static class IntHelper
{
    public static int RandomNumber(int min, int max)
    {
        Random _random = new Random();

        return _random.Next(min, max);
    }
}
