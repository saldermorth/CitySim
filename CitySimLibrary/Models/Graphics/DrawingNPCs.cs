using CitySimLibrary.Models.NPCs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TjuvOchPolis
{
    public class DrawingNPCs
    {

        public void NPCWriter(NPC person, int[] pos)
        {
            Console.SetCursorPosition(pos[0], pos[1]); // Todo - sometimes goes out of bounds
            switch (person.NPC_TYPE)
            {
                case 'P':
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case 'M':
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case 'T':
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
               
            }
            
            Console.Write(person.NPC_TYPE);
            Console.ForegroundColor = ConsoleColor.Gray;

        }
        public void NPCPlacer(NPC person)
        {
            int[] pos = new int[2];
            char one = person.Location.GridChar;
            int two = person.Location.GridInt;
            int xPos = 110;
            int yPos = 1;

            switch (two)//Y Axis
            {
                case 0:
                    yPos = 1;
                    break;
                case 1:
                    yPos = 2;
                    break;
                case 2:
                    yPos = 6;
                    break;
                case 3:
                    yPos = 10;
                    break;
                case 4:
                    yPos = 14;
                    break;
                case 5:
                    yPos = 14;
                    break;
                case 6:
                    yPos = 18;
                    break;
                case 7:
                    yPos = 22;
                    break;
                case 8:
                    yPos = 26;
                    break;          
                                         
                
                default:
                    break;
            }

            switch (one)//X axis 
            {
                case 'A':
                    xPos = 3;
                    break;
                case 'B':
                    xPos = 9;
                    break;
                case 'C':
                    xPos = 15;
                    break;
                case 'D':
                    xPos = 21;
                    break;
                case 'E':
                    xPos = 27;
                    break;
                case 'F':
                    xPos = 33;
                    break;
                case 'G':
                    xPos = 39;
                    break;
                case 'H':
                    xPos = 45;
                    break;
                case 'I':
                    xPos = 51;
                    break;
                case 'J':
                    xPos = 57;
                    break;
                case 'K':
                    xPos = 63;
                    break;
                case 'L':
                    xPos = 69;
                    break;
                case 'M':
                    xPos = 75;
                    break;
                case 'N':
                    xPos = 81;
                    break;
                case 'O':
                    xPos = 87;
                    break;
                case 'P':
                    xPos = 93;
                    break;
                case 'Q':
                    xPos = 99;
                    break;
                case 'R':
                    xPos = 105;
                    break;
                case 'S':
                    xPos = 105;
                    break;

            }
                       
            pos[0]= xPos;
            pos[1] = yPos;
                     

            NPCWriter(person, pos);

        }
    }
}