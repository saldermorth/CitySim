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
        private static int counter = 1;
        public void Run()
        {
        
            Console.SetWindowSize(110, 30);
            Saver save = new Saver(0, 0);
            NPC main = new NPC();
            //List<NPC> Populus = main.MakeAllNPC();
            
            DrawingCity city = new DrawingCity();
            DrawingNPCs npcs = new DrawingNPCs();
            Saver logg = new Saver(0,0);
            Medborgare med = new Medborgare();
            Polis pol = new Polis();
            Tjuv tju = new Tjuv();

            List<NPC> Populus = new List<NPC>(50);
            for (int i = 0; i < 70; i++) // Number of npcs
            {

                NPC test = new NPC();


                Populus.Add(test);
                
            }
            foreach (var i in Populus)
            {
                i.Location = main.GiveLocation();
                i.Direction = main.GiveDirection();
                i.Id = counter;
                counter++;
                i.Grid = main.GiveGrid();
                if (i.Id <50)
                {
                    i.NPC_TYPE = 'M';
                    i.Inventory = med.MakeInventory();
                }
                else if (i.Id > 50 && i.Id <65)
                {
                  i.NPC_TYPE = 'P';
                    i.Inventory = pol.MakeInventory();
                }
                else
                {
                    i.NPC_TYPE = 'T';
                   i.Inventory = tju.MakeInventory();
                }

            }
            //for (int i = 1; i < 50; i++)
            //{
            //    Populus[i].Location = main.GiveLocation();
            //    Populus[i].Direction = main.GiveDirection();
            //    Populus[i].Id = counter;
            //    counter++;
            //    Populus[i].Grid = main.GiveGrid();
            //    if (i < 25)
            //    {
            //        Populus[i].NPC_TYPE = 'M';
            //        Populus[i].Inventory = med.MakeInventory();
            //    }
            //    else if (i>25 && i <35)
            //    {
            //        Populus[i].NPC_TYPE = 'P';
            //        Populus[i].Inventory = pol.MakeInventory();
            //    }
            //    else
            //    {
            //        Populus[i].NPC_TYPE = 'T';
            //        Populus[i].Inventory = tju.MakeInventory();
            //    }


            //}
            
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
                    CollisonChecker(save, Populus);
                    
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
        
        public void CollisonChecker(Saver save, List<NPC> Citizens)
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
                            Thread.Sleep(80);
                            if (Citizens[i].NPC_TYPE == Citizens[j].NPC_TYPE)
                            {
                                //Same type if citizen nothing happens.
                            }
                            else if (Citizens[i].NPC_TYPE == 'P' && Citizens[j].NPC_TYPE == 'T')
                            {
                                if (Citizens[j].Inventory.Count>0)
                                {
                                    Citizens[i].Inventory = Citizens[j].Inventory.GetRange(0, Citizens[j].Inventory.Count);
                                    Citizens[j].Inventory.Clear();
                                    writer.HUDWriter(save, 1);
                                }
                                writer.HUDWriter(save, 8);

                            }
                            else if (Citizens[i].NPC_TYPE == 'T' && Citizens[j].NPC_TYPE == 'P')
                            {
                                if (Citizens[i].Inventory.Count >0)
                                {
                                    Citizens[j].Inventory = Citizens[i].Inventory.GetRange(0, Citizens[i].Inventory.Count);
                                    Citizens[i].Inventory.Clear();                                    
                                    writer.HUDWriter(save, 2);
                                }
                                
                            }
                            else if (Citizens[i].NPC_TYPE == 'T' && Citizens[j].NPC_TYPE == 'M')
                            {
                                if (Citizens[j].Inventory.Count>0)
                                {
                                    Citizens[i].Inventory = Citizens[j].Inventory.GetRange(0, 1);
                                    Citizens[j].Inventory.RemoveAt(0);
                                    writer.HUDWriter(save, 3);
                                }

                                writer.HUDWriter(save, 7);
                            }
                            else if (Citizens[i].NPC_TYPE == 'M' && Citizens[j].NPC_TYPE == 'T')
                            {
                                if (Citizens[i].Inventory.Count >0)
                                {
                                    Citizens[j].Inventory = Citizens[i].Inventory.GetRange(0, 1);
                                    Citizens[i].Inventory.RemoveAt(0);
                                    writer.HUDWriter(save, 4);
                                }
                                writer.HUDWriter(save, 7);
                            }
                            else if (Citizens[i].NPC_TYPE == 'P' && Citizens[j].NPC_TYPE == 'M')
                            {
                                 
                                writer.HUDWriter(save, 5);
                            }
                            else if (Citizens[i].NPC_TYPE == 'M' && Citizens[j].NPC_TYPE == 'P')
                            {
                                Console.WriteLine();//To do - Polis hälsar på polis
                                writer.HUDWriter(save, 6);
                            }

                            inConflict.Add(Citizens[j]);
                            
                        }

                    }

                }
            }
                       
           
        }


    }   }
