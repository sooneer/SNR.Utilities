using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNR.Utilities;

public static class UrlHelper
{
    public static string ConvertUrl(string text, bool isFileName = false)
    {
        if (string.IsNullOrEmpty(text))
        {
            return "";
        }

        if (text.Length > 120)
        {
            text = text.Substring(0, 120);
            text = text.Substring(0, text.LastIndexOf(" "));
        }
        text = text.ToLower();

        text = text
            // Boşluk
            .Replace(" ", "-")
            .Replace("--", "-")
            .Replace("--", "-")
            .Replace("--", "-")
            .Replace("--", "-")

            // Harfler
            .Replace("ı", "i")
            .Replace("ş", "s")
            .Replace("ç", "c")
            .Replace("ö", "o")
            .Replace("ğ", "g")
            .Replace("ü", "u")
            .Replace("â", "a")
            .Replace("ã", "a")
            .Replace("ä", "a")
            .Replace("à", "a")
            .Replace("á", "a")
            .Replace("é", "e")
            .Replace("è", "e")
            .Replace("ê", "e")
            .Replace("ë", "e")
            .Replace("î", "i")
            .Replace("í", "i")
            .Replace("û", "u")
            .Replace("ó", "o")
            .Replace("ô", "o")
            .Replace("ñ", "n")
            .Replace("ž", "z")

            // Özel Karakterler

            .Replace(",", "")
            .Replace("!", "")
            .Replace("'", "")
            .Replace(":", "")
            .Replace(";", "")
            .Replace("?", "")
            .Replace("(", "")
            .Replace(")", "")
            .Replace("&", "")
            .Replace("#", "")
            .Replace("\"", "")
            .Replace("\\", "")
            .Replace("/", "")
            .Replace("%", "")
            .Replace("*", "")
            .Replace("=", "")
            .Replace("+", "")
            .Replace("<", "")
            .Replace(">", "")
            .Replace("’", "")
            .Replace("‘", "")
            .Replace("“", "")
            .Replace("”", "")
            .Replace("@", "")
            .Replace("…", "")
            .Replace("´", "")
            .Replace("|", "")
            .Replace("^", "")
            .Replace("$", "")
            .Replace("_", "")
            .Replace("~", "");

        if (!isFileName)
        {
            text = text.Replace(".", "");
        }
        return text;
    }
}

