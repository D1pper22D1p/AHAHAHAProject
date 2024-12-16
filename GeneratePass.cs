using System;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace GeneratePass
{
    public class Program
    {
        static String str;

        [STAThread]
        static void Main()
        {
            Console.WriteLine(str);
            Random rnd = new Random();
            GeneratePass(rnd, 10);
            Clipboard.SetText(str);
        }

        private static void GeneratePass(Random rnd, int MaxVal)
        {
            char[] pass = new char[MaxVal];
            for (int i = 0; i < MaxVal; i++)
            {
                int asciiValue = rnd.Next(32, 127);
                pass[i] = (char)asciiValue;
            }
            str = new string(pass);
        }
    }
}