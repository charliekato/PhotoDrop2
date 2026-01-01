using System.Net;
using System.Net.Sockets;
namespace PhotoDrop2;

public static class NetworkUtil
{
    public static string GetLocalIP()
    {
        foreach (var ip in Dns.GetHostEntry(Dns.GetHostName()).AddressList)
        {
            if (ip.AddressFamily == AddressFamily.InterNetwork)
                return ip.ToString();
        }
        return "127.0.0.1";
    }
}

