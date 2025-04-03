using System;

namespace BetterColorSpheres
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

            Console.WriteLine($"Red: {redColor.Red}");
            Console.WriteLine($"Green: {greenColor.Green}");
            Console.WriteLine($"Blue: {blueColor.Blue}");

            Console.WriteLine(redSphere.Throws);
            Console.WriteLine(greenSphere.Throws);
            Console.WriteLine(blueSphere.Throws);
        }
        public class Color
        {
            public byte Red {get; private set;}
            public byte Green {get; private set;}
            public byte Blue {get; private set;}
            public byte Alpha {get; private set;}
            
            public Color (byte red, byte green, byte blue, byte alpha)
            {
                Red = red;
                Green = green;
                Blue = blue;
                Alpha = alpha;
            }

            public Color (byte red, byte green, byte blue) : this(red, green, blue, 255)
            {
            }

            public byte Grey => (byte)((Red+Green+Blue)/3);
        }
        
        public class Sphere
        {
            public Color Color {get;}
            public float Radius {get; private set;}
            public int Throws {get; private set;}

            public Sphere(Color color, float radius)
            {
                Color = color;
                Radius = radius;
                Throws = 0;
            }

            public void Pop()
            {
                Radius = 0.0f;
            }

            public void Throw()
            {
                if (Radius > 0)
                {
                    Throws++;
                }
            } 
        }
    }
}
