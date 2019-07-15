using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Day2.Prototype.WebInfo
{
    public class WebInfoFactory
    {
        public Dictionary<string,WebInfo> WebInfos { get; set; }

        public WebInfoFactory()
        {
            WebInfos = new Dictionary<string, WebInfo>();
        }

        public async Task<WebInfo> CreateWebInfo(string url)
        {
            if (!WebInfos.ContainsKey(url))
            {
                Console.WriteLine("Going to the web to get size...");
                WebInfo webInfo = await WriteWebRequestSizeAsync(url);
                WebInfos.Add(webInfo.Url, webInfo);
            }
            else
            {
                WebInfo currWebInfo = WebInfos[url];
                Console.WriteLine("Getting size from cache...");
                Console.WriteLine($"Url: {currWebInfo.Url} Size: {currWebInfo.Size} Timestamp: {currWebInfo.Timestamp}");
            }

            return await Task.FromResult(WebInfos[url].Clone());
        }

        static public string FormatBytes(long bytes)
        {
            string[] magnitudes =
                new string[] { "GB", "MB", "KB", "Bytes" };
            long max =
                (long)Math.Pow(1024, magnitudes.Length);

            return string.Format("{1:##.##} {0}",
                magnitudes.FirstOrDefault(
                    magnitude =>
                    bytes > (max /= 1024)) ?? "0 Bytes",
              (decimal)bytes / (decimal)max);
        }


        private static async Task<WebInfo> WriteWebRequestSizeAsync(string url)
        {
            WebInfo webInfo = new WebInfo();
            webInfo.Url = url;
            webInfo.Timestamp = DateTime.Now;
            try
            {
                WebRequest webRequest =
                    WebRequest.Create(url);
                WebResponse response =
                    await webRequest.GetResponseAsync();
                using (StreamReader reader =
                    new StreamReader(
                        response.GetResponseStream()))
                {
                    string text =
                        await reader.ReadToEndAsync();
                    Console.WriteLine(
                        FormatBytes(text.Length));
                    webInfo.Size = FormatBytes(text.Length);
                }
            }
            catch (WebException)
            {
                // ...
            }
            catch (IOException)
            {

                // ...
            }
            catch (NotSupportedException)
            {
                // ...
            }
            return await Task.FromResult(webInfo);
        }
    }
}
