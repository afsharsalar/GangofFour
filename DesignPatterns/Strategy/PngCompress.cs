﻿namespace DesignPatterns.Strategy
{
    public class PngCompress : ICompressor
    {
        public void Compress(string fileName)
        {
            Console.WriteLine("compress png");
        }
    }
}
