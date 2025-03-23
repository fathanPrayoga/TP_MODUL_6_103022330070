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
    }
}
