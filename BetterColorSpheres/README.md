# UML Diagram BetterColorSphere

```mermaid

classDiagram
    class Color {
        - byte Red
        - byte Green
        - byte Blue
        - byte Alpha
        + Color(byte red, byte green, byte blue, byte alpha)
        + Color(byte red, byte green, byte blue)
        + byte Grey
    }

    class Sphere {
        - Color Color
        - float Radius
        - int Throws
        + Sphere(Color color, float radius)
        + void Pop()
        + void Throw()
        + int GetTimesThrown()
    }

    class Program {
        + void Main(string[] args)
    }

    Program --> Sphere
    Sphere --> Color
