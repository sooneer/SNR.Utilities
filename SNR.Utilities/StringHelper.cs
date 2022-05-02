namespace Utilities;

public static class StringHelper
{
    public static string ConnectionString(string server, string database, string userId, string password)
    {
        return $"server={server}; database={database}; User ID={userId}; Password={password};";
    }

    public static string TokenTemplate(int idUser)
    {
        return $"{idUser.ToString().PadLeft(10, '0')}:{DateTime.Now.AddHours(2):yyyy-MM-dd-HH-mm-ss}";
    }
}