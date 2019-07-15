using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Day2.Prototype.WebInfo
{
    public class Program
    {


        public static void WebInfo(string[] args)
        {
            WebInfoFactory factory = new WebInfoFactory();
            string url = "http://www.IntelliTect.com";
            string url2 = "http://www.google.com";

            Console.Write(url);

            Task<WebInfo> taskInfo = factory.CreateWebInfo(url);
            Task<WebInfo> taskInfo2 = factory.CreateWebInfo(url2);
            while (!taskInfo.Wait(100))
            {
                Console.Write(".");
            }
            Task.WaitAll(taskInfo, taskInfo2);
            Task<WebInfo> taskInfo3 = factory.CreateWebInfo(url);
            Task<WebInfo> taskInfo4 = factory.CreateWebInfo(url2);
        }
    }
}
