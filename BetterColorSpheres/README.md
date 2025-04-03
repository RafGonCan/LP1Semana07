+-----------------+
|      Color      |
+-----------------+
| - Red: byte     |
| - Green: byte   |
| - Blue: byte    |
| - Alpha: byte   |
+-----------------+
| + Color(red: byte, gree: byte, blue: byte, alpha: byte)   |
| + Color(red: byte, gree: byte, blue: byte)                |
| + Grey: byte {get}                                        |
+-----------------+

+-----------------+
|      Sphere     |
+-----------------+
| - Color: Color  |
| - Radius: float |
| - Throws: int   |
+-----------------+
| + Sphere(color: Color, radius: float)                     |
| + Pop(): void                                             |
| + Throw(): void                                           |
| + GetTimesThrown(): int                                   |
+-----------------+

+-----------------+
|      Program    |
+-----------------+
| + Main(args[]: void)                                      |
+-----------------+