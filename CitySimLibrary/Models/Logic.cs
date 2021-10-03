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
        public void Run()
        {
            NPC main = new NPC();
            List<NPC> Populus = main.MakeAllNPC();
            DrawingCity city = new DrawingCity();
            DrawingNPCs npcs = new DrawingNPCs();
            
            Console.WriteLine("Press ESC to stop");
            do
            {
                while (!Console.KeyAvailable)
                {
                    Console.Clear();
                    city.BlockDrawer();
                    city.GridDrawer();
                    
                    foreach (var person in Populus)
                    {
                        
                        npcs.NPCPlacer(person);
                        NPCMover(person);
                    }
                    CollisonChecker(Populus);
                    Console.ReadKey();
                }
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);

            
            
            
            
            

            


        }
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
        
        public void CollisonChecker(List<NPC> Citizens)
        {
            List<NPC> inConflict = new List<NPC>();
            HUD writer = new HUD();

            for (int i = 0; i < Citizens.Count; i++)
            {
                for (int j = 0; j < Citizens.Count; j++)
                {
                    string S = Citizens[i].Grid;
                    if (S == Citizens[j].Grid)
                    {
                        if (Citizens[i].Id != Citizens[j].Id)
                        {
                            if (Citizens[i].NPC_TYPE == Citizens[j].NPC_TYPE)
                            {
                                //Same type if citizen dose nothing
                            }
                            else if (Citizens[i].NPC_TYPE == 'P' && Citizens[j].NPC_TYPE == 'T')
                            {
                                //To do - skriv ut tjuv gripen 
                                writer.HUDWriter(1);
                            }
                            else if (Citizens[i].NPC_TYPE == 'T' && Citizens[j].NPC_TYPE == 'P')
                            {
                                //To do - skriv ut tjuv gripen
                                writer.HUDWriter(2);
                            }
                            else if (Citizens[i].NPC_TYPE == 'T' && Citizens[j].NPC_TYPE == 'M')
                            {
                                //To do - medborgare rånad
                                writer.HUDWriter(3);
                            }
                            else if (Citizens[i].NPC_TYPE == 'M' && Citizens[j].NPC_TYPE == 'T')
                            {
                                //To do - medborgare rånad
                                writer.HUDWriter(4);
                            }
                            else if (Citizens[i].NPC_TYPE == 'P' && Citizens[j].NPC_TYPE == 'M')
                            {
                                 //To do - Polis hälsar på polis
                                writer.HUDWriter(5);
                            }
                            else if (Citizens[i].NPC_TYPE == 'M' && Citizens[j].NPC_TYPE == 'P')
                            {
                                Console.WriteLine();//To do - Polis hälsar på polis
                                writer.HUDWriter(6);
                            }


                            inConflict.Add(Citizens[j]);
                            
                        }

                    }

                }
            }

            //foreach (var item in inConflict)
            //{
            //    Console.WriteLine($"ID :{item.Id}| Grid:{item.Grid}| Type: {item.NPC_TYPE}");
            //}
           
        }


    }   }
