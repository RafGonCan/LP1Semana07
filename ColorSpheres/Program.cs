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
            Sphere sphere = new  Sphere(redColor, 5.0f);

            sphere.Throw();
            sphere.Throw();
            sphere.Throw();
            sphere.Pop();
            sphere.Throw();

            Console.WriteLine(redColor.GetRed());
            Console.WriteLine(sphere.GetTimesThrown());
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
        
        public class Sphere
        {
            private Color color;
            private float radius;
            private int throws;

            internal Sphere(Color color, float radius)
            {
                this.color = color;
                this.radius = radius;
                this.throws = 0;
            }

            internal float Pop()
            {
                return radius = 0.0f;
            }

            internal void Throw()
            {
                if (radius > 0)
                {
                    throws++;
                }
            } 
            internal int GetTimesThrown()
            {
                return throws;
            }
        }
    }
}
