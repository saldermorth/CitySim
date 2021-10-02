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
        public void Meny()
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
        
        public void CollisonChecker(List<NPC> Citizens)//Linq probebile solution
        {


            List<NPC> inConflict = new List<NPC>();

            for (int i = 0; i < Citizens.Count; i++)
            {


                for (int j = 0; j < Citizens.Count; j++)
                {
                    string S = Citizens[i].Grid;
                    if (S == Citizens[j].Grid)
                    {
                        if (Citizens[i].Id != Citizens[j].Id)
                        {
                            if (Citizens[i].CitizenType == Citizens[j].CitizenType)
                            {

                            }
                            else if (Citizens[i].CitizenType == P && Citizens[j].CitizenType == T)
                            {
                                //To do - skriv ut tjuv gripen 
                            }
                            else if (Citizens[i].CitizenType == T && Citizens[j].CitizenType == P)
                            {
                                //To do - skriv ut tjuv gripen
                            }
                            else if (Citizens[i].CitizenType == T && Citizens[j].CitizenType == M)
                            {
                                //To do - medborgare rånad
                            }
                            else if (Citizens[i].CitizenType == M && Citizens[j].CitizenType == T)
                            {
                                //To do - medborgare rånad
                            }
                            else if (Citizens[i].CitizenType == P && Citizens[j].CitizenType == M)
                            {
                                //To do - Polis hälsar på polis
                            }
                            else (Citizens[i].CitizenType == M && Citizens[j].CitizenType == P)
                            {
                                //To do - Polis hälsar på polis
                            }


                            inConflict.Add(Citizens[j]);
                            Console.WriteLine("Test");
                        }

                    }

                }
            }

            foreach (var item in inConflict)
            {
                Console.WriteLine($"ID :{item.Id}| Grid:{item.Grid}| Type: {item.NPC_TYPE}");
            }
           
        }


    }   }
