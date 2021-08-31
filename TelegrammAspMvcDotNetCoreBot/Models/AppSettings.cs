using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TelegrammAspMvcDotNetCoreBot.Models
{
    public class AppSettings
    {
        public static string Url { get; set; } = "https://URL:443/{0}";
        public static string Name { get; set; } = "@proverka_avto_bot";
        public static string Key { get; set; } = "your token";
    }
}
