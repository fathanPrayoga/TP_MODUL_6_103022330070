using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpModul6_103022330070
{
    class SayaTubeVideo
    {
        private int id;
        private String title;
        private int playCount;

        public SayaTubeVideo(String title)
        {
            Random random = new Random();
            this.id = random.Next(10000, 100000);
            this.title = title;
            this.playCount = 0;
        }

        public void TambahPlayCount(int count)
        {
            this.playCount += count;
        }

        public void PrintVideo()
        {
            Console.WriteLine("Video ID: " + id);
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Play Count: " + playCount);
        }
    }
}
