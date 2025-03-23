using System;
using tpModul6_103022330070;

class Program
{
    static void Main(string[] args)
    {
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract – Fathan Prayoga Wicaksono");       
        video.TambahPlayCount(5);
        video.TambahPlayCount(3);        
        video.PrintVideo();

        try
        {
            SayaTubeVideo invalidVideo = new SayaTubeVideo("karakter kelebihan");
        }
        catch(Exception ex)
        {
            Console.WriteLine("Terjadi kesalahan: " + ex.Message);
        }

        try
        {
            video.TambahPlayCount(2000000000);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Terjadi kesalahan saat menambah play count: " + ex.Message);
        }

        video.PrintVideo();
    }
}
