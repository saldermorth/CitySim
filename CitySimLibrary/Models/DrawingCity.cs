using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TjuvOchPolis
{
    public class DrawingCity
    {
        public void BlockDrawer()
        {            
            int MaxWidth = Console.WindowWidth;
            int MaxHeight = Console.WindowHeight;
            int UpperLeft = 1;
           
            for (int i = UpperLeft; i < 110; i++)
            {
                if (i % 6 == 0)
                {

                }
                else
                {
                    for (int j = UpperLeft; j < 30; j++)
                    {
                        if (j % 4 == 0)
                        {

                        }
                        else
                        {
                            Console.SetCursorPosition(i, j);
                            Console.Write("░");
                        }

                    }

                }

            }
        }
        public void GridDrawer()
        {
            int CursorPosX = 0;
            int CursorPosY = 0;

            int MaxWidth = Console.WindowWidth;
            int MaxHeight = Console.WindowHeight;
            Console.CursorVisible = false;
            Random rnd = new Random();

            do
            {

                for (int i = 0; i < MaxWidth; i++)
                {
                    Console.SetCursorPosition(i, CursorPosY);
                    Console.Write("═");
                }
                CursorPosY += 4;

            } while (CursorPosY < MaxHeight);
            do
            {

                for (int i = 0; i < MaxHeight; i++)
                {
                    Console.SetCursorPosition(CursorPosX, i);
                    Console.Write("║");
                }
                CursorPosX += 6;

            } while (CursorPosX < MaxWidth);

        }
    }
}