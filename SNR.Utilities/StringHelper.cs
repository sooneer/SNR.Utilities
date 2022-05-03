namespace SNR.Utilities;

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

    public static bool IsValidEmail(string email)
    {
        var trimmedEmail = email.Trim();

        if (trimmedEmail.EndsWith("."))
        {
            return false; // suggested by @TK-421
        }
        try
        {
            var addr = new System.Net.Mail.MailAddress(email);
            return addr.Address == trimmedEmail;
        }
        catch
        {
            return false;
        }
    }
}