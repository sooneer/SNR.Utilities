namespace SNR.Utilities;

public static class FileHelper
{
    public static string Upload(byte[] fileByte, string fileName, string uploadPath)
    {
        string fileExtension = Path.GetExtension(fileName).ToLower();
        string fileNameNew = UrlHelper.ConvertUrl(fileName, true).Replace(fileExtension, "") + "-" + DateTime.Now.ToString("HHmmssfff").ToLower() + fileExtension;

        string dirPath = uploadPath + "\\" + DateTime.Now.Year.ToString() + "\\" + DateTime.Now.Month.ToString() + "\\" + DateTime.Now.Day.ToString() + "\\";

        if (!Directory.Exists(dirPath))
        {
            Directory.CreateDirectory(dirPath);
        }

        string fullName = Path.Combine(dirPath, fileNameNew);

        File.WriteAllBytes(fullName, fileByte);

        return "/Upload/" + DateTime.Now.Year.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Day.ToString() + "/" + fileNameNew;
    }

    public static byte[] FromBase64String(string base64string)
    {
        if (base64string.IndexOf("data:image/jpeg") == 0)
        {
            base64string = base64string.Replace("data:image/jpeg;base64,", "");
        }
        else if (base64string.IndexOf("data:image/jpg") == 0)
        {
            base64string = base64string.Replace("data:image/jpg;base64,", "");
        }
        else if (base64string.IndexOf("data:image/png") == 0)
        {
            base64string = base64string.Replace("data:image/png;base64,", "");
        }
        return Convert.FromBase64String(base64string);
    }
}