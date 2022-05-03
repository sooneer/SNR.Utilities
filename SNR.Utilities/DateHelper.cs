namespace SNR.Utilities;

public static class DateHelper
{
    public static string GetDayTime()
    {
        DateTime now = DateTime.Now;
        if (now.Hour > 06 && now.Hour < 12)
        {
            return "Günaydın";
        }
        if (now.Hour >= 12 && now.Hour < 16)
        {
            return "İyi Günler";
        }

        if (now.Hour >= 16 && now.Hour < 23)
        {
            return "İyi Akşamlar";
        }

        return "İyi Geceler";
    }
}