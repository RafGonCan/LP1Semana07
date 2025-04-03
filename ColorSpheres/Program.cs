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
            Sphere redSphere = new  Sphere(redColor, 5.0f);
            Color greenColor = new Color(0,255,0);
            Sphere greenSphere = new  Sphere(redColor, 5.0f);
            Color blueColor = new Color(0,0,255);
            Sphere blueSphere = new  Sphere(redColor, 5.0f);

            redSphere.Throw();
            redSphere.Throw();
            greenSphere.Throw();
            greenSphere.Throw();
            greenSphere.Throw();
            blueSphere.Throw();
            redSphere.Pop();
            greenSphere.Pop();
            blueSphere.Pop();

            Console.WriteLine($"Red: {redColor.GetRed()}");
            Console.WriteLine($"Green: {greenColor.GetGreen()}");
            Console.WriteLine($"Blue: {blueColor.GetBlue()}");

            Console.WriteLine(redSphere.GetTimesThrown());
            Console.WriteLine(greenSphere.GetTimesThrown());
            Console.WriteLine(blueSphere.GetTimesThrown());
        }
        public class Color
        {
            private byte red;
            private byte green;
            private byte blue;
            private byte alpha;
            
            public Color (byte red, byte green, byte blue, byte alpha)
            {
                this.red = red;
                this.green = green;
                this.blue = blue;
                this.alpha = alpha;
            }

            public Color (byte red, byte green, byte blue) : this(red, green, blue, 255)
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
            readonly Color color;
            private float radius;
            private int throws;

            public Sphere(Color color, float radius)
            {
                this.color = color;
                this.radius = radius;
                throws = 0;
            }

            public float Pop()
            {
                return radius = 0.0f;
            }

            public void Throw()
            {
                if (radius > 0)
                {
                    throws++;
                }
            } 
            public int GetTimesThrown()
            {
                return throws;
            }
        }
    }
}
