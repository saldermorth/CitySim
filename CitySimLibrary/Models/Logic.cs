using CitySimLibrary.Models;
using CitySimLibrary.Models.NPCs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace TjuvOchPolis
{
    public class Logic
    {
        public void Logics()
        {


        }
        /// <summary>
        /// Modifies the x and y coordinates. By number of Direction
        /// </summary>
        /// <param name="one"></param>
        /// <returns></returns>
        public NPC NPCMover(NPC one)//Y grid = 4 . X grid = 6
        {
            int dir = one.Direction;
            int yPos = one.Location.GridInt;
            int xPos = one.Location.GridChar;
            switch (dir)
            {
                case 0://UP
                    yPos = yPos+1;
                    break;
                case 1://UpLeft
                    yPos = yPos+1;
                    xPos = xPos - 1;
                    break;
                case 2://UpRight
                    yPos = yPos +1;
                    xPos = xPos +1;
                    break;
                case 3://Left
                    yPos = yPos - 1;                    
                        break;
                case 4://Right
                    yPos = yPos + 1;                    
                        break;
                case 5://Down
                    xPos = xPos - 1;
                        break;
                case 6://DownLeft              
                    yPos = yPos - 1;
                    xPos = xPos - 1;
                        break;
                case 7://DownRight
                    yPos = yPos + 1;
                    xPos = xPos -1;
                        break;
                
                default:
                    break;
            }
            

            if (yPos<1)
            {
                yPos = 8;
            }
            else if (yPos > 8)
            {
                yPos = 1;
            }

            one.Location.GridInt = yPos;
                        
            
            if (xPos < 'A')
            {
                xPos = 'S'; 
            }
            else if (xPos> 'S')
            {
                xPos = 'A';
            }
            one.Location.GridChar = ((char)xPos);
            return one;
        }

        public void CollisonChecker(List<NPC> Citizens)
        {
            for (int i = 0; i < Citizens.Count-1; i++)//TODO -Går alltid in i if satsen
            {
                
               //problem
                for (int j = 1; j < Citizens.Count; j++)
                {
                    int intTemp = Citizens[i].Location.GridInt;
                    char charTemp = Citizens[i].Location.GridChar;

                    if (Citizens[j].Location.GridInt.Equals(intTemp) && Citizens[j].Location.GridChar.Equals(charTemp))
                    {
                        Console.SetCursorPosition(0, 28);
                        Console.Write($"{Citizens[j].Location.GridChar}{Citizens[j].Location.GridInt}| is occupied");
                        Thread.Sleep(200);
                    }
                }
                
                
            }

            
            //ToDo - se över något fel för på 500 Citizens bara 2 i samma ruta??

           



        }


 }   }
