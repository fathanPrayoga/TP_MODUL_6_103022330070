using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            if (title == null)
                throw new ArgumentNullException(nameof(title), "Judul video tidak boleh kosong");

            if (title.Length > 100)
                throw new ArgumentException("Judul video tidak boleh lebih dari 100 karakter", nameof(title));

            Random random = new Random();
            this.id = random.Next(10000, 100000);
            this.title = title;
            this.playCount = 0;
        }

        public void TambahPlayCount(int count)
        {
            if (count > 10000000)
                throw new ArgumentOutOfRangeException(nameof(count), "Tambah play count tidak boleh lebih dari 10 juta");

            try
            {
                checked
                {
                    this.playCount += count;
                }

            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Terjadi overflow saat menambah play count!" + ex.Message);
            }
        }

        public void PrintVideo()
        {
            Console.WriteLine("Video ID: " + id);
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Play Count: " + playCount);
        }
    }
}
