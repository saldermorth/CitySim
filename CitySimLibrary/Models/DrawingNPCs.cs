using CitySimLibrary.Models.NPCs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TjuvOchPolis
{
    public class DrawingNPCs
    {
        public  int[] NPCPlacer(NPC person)
        {
            int[] pos = new int[2];
            char one = person.Location.GridChar;
            int two = person.Location.GridInt;
            int xPos = 1;
            int yPos = 1;

            switch (two)
            {
                case 1:
                    yPos = 2;
                    break;
                case 2:
                    yPos = 5;
                    break;
                case 3:
                    yPos = 8;
                    break;
                case 4:
                    yPos = 11;
                    break;
                case 5:
                    yPos = 14;
                    break;
                case 6:
                    yPos = 17;
                    break;
                case 7:
                    yPos = 20;
                    break;             
                   
                
                default:
                    break;
            }

            switch (one)
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
                case 'Q':
                    xPos = 87;
                    break;
                case 'R':
                    xPos = 93;
                    break;

                    
            }

            pos[0] = xPos;
            pos[1] = yPos;
            return pos;
        }
    }
}