using System;


namespace SnakeGame
{
    public readonly struct Pixel
    {

        private const char PixelChar = '█';

        public Pixel(int x,int y,ConsoleColor color,int pixelSize = 3)
        {
            X = x;
            Y = y;
            Color = color;
            PixelSize = pixelSize;
        }
        public int X { get;}

        public int Y { get;}

        public ConsoleColor Color { get;}

        public int PixelSize { get; }


        public void Draw()
        {
            Console.ForegroundColor = Color;
            
            for (int i= 0; i < PixelSize; i++)
            {
                for(int j = 0; j < PixelSize; j++)
                {
                    Console.SetCursorPosition(X * PixelSize +i, Y * PixelSize +j);
                    Console.Write(PixelChar);
                }
            }
            
            
        }

        public void Clear()
        {
            for (int i = 0; i < PixelSize; i++)
            {
                for (int j = 0; j < PixelSize; j++)
                {
                    Console.SetCursorPosition(X * PixelSize + i, Y * PixelSize + j);
                    Console.Write(' ');
                }
            }
        }

    }
}

