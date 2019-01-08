using System;
using System.IO;

namespace ch2_PostFuzzer
{
    class PostFuzzer
    {
        static void Main(string[] args)
        {
            string[] requestLines = File.ReadAllLines(args[0]);
            string[] parms = requestLines[requestLines.Length - 1].Split('&');
        }
    }
}