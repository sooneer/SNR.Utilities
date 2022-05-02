using Microsoft.AspNetCore.Http;
using System.Net;

namespace Utilities;

public static class RequestExtension
{
    public static string GetClientName(this HttpRequest request)
    {
        return System.Net.Dns.GetHostName();
    }

    public static string GetClientIp(this HttpRequest request)
    {
        string ip = request.HttpContext.Connection.RemoteIpAddress.ToString();

        if (ip == "::1")
        {
            //TODO 2 ??
            ip = Dns.GetHostEntry(Dns.GetHostName()).AddressList[2].ToString();
        }

        return ip;
    }
}