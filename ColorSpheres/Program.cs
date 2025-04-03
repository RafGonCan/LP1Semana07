using System;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography.X509Certificates;

namespace ColorSpheres
{
    public class Program
    {
        private static void Main(string[] args)
        {     
            Color redColor = new Color(255,0,0);

            Console.WriteLine(redColor.GetRed());
        }
        public class Color
        {
            private byte red;
            private byte green;
            private byte blue;
            private byte alpha;
            
            private Color (byte red, byte green, byte blue, byte alpha)
            {
                this.red = red;
                this.green = green;
                this.blue = blue;
                this.alpha = alpha;
            }

            internal Color (byte red, byte green, byte blue) : this(red, green, blue, 255)
            {
            }

            public byte GetRed() => red;
            public byte GetGreen() => green;
            public byte GetBlue() => blue;
            public byte GetAlpha() => alpha;

            public byte GetGrey()
            {
                return (byte)((red+green+blue)/3);
            }
        }
    }
}
