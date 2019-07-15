using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2.Prototype.WebInfo
{
    public class WebInfo : IPrototype<WebInfo>
    {
        public DateTime Timestamp { get; set; }
        public string Size { get; set; }
        public string Url { get; set; }

        public WebInfo()
        {
        }

        public WebInfo(DateTime timestamp, string size, string url)
        {
            Timestamp = timestamp;
            Size = size;
            Url = url;
        }

        public WebInfo Clone()
        {
            return new WebInfo(this.Timestamp, this.Size, this.Url);
        }
    }
}
