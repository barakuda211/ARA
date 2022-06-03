using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VkBotFramework;

namespace ARA
{
    class Server
    {
        public static string url = "https://vk.com/ara_test";
        public static VkBot bot;

        public void Start(string token)
        {
            bot = new VkBot(token, url, longPollTimeoutWaitSeconds: 0);
        }
    }
}
