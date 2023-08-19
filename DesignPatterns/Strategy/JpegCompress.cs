﻿namespace DesignPatterns.Strategy
{
    public class JpegCompress : ICompressor
    {
        public void Compress(string fileName)
        {
            Console.WriteLine("Compress jpeg");
        }
    }
}
