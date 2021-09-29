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
            //List<NPC> npcInConflict = new List<NPC>();
            //foreach (var collection in Citizens)
            //{
                
            //    foreach (var item in collection.Grid)
            //    {
            //        if (collection.Grid == )
            //        {
            //            if (collection.Id != item.Id)
            //            {
            //                npcInConflict.Add(collection);
                            
            //            }
                        
            //        }
            //    }
            //    List<NPC> SortedList = npcInConflict.OrderBy(o => o.Id).ToList();
                
            //    foreach (var pers in SortedList)
            //    {
            //        Console.WriteLine($"|ID :{pers.Id} + |Type :{pers.NPC_TYPE} " +
            //            $"|Grid :{pers.Grid}");
            //    }
                   
            //}





            foreach (var collection in Citizens)  // Outer loop
            {
                // Code that should run for each collection

                foreach (var item in collection.Grid)  // Inner loop
                {
                    // Code that should run for each item
                }
            }






            //var uniqueValues = Citizens.Select(k => k.Grid) MAll
            //      .GroupBy(g => g)
            //      .Where(c => c.Count() == 1)
            //      .Select(k => k.Key)
            //      .ToList();

            //var uniqueValues = myItems.Select(k => k.MyProperty)
            //      .GroupBy(g => g)
            //      .Where(c => c.Count() == 1)
            //      .Select(k => k.Key)
            //      .To();

            //foreach (var item in uniqueValues)
            //{
            //    Console.WriteLine(item);
            //}
            //var collList = Citizens;
            //List<NPC> uniques = new List<NPC>();
            //foreach (var item in Citizens)
            //{
            //    if (!Citizens.Contains(item.Grid)) uniques.Add(item);

            //}
            //foreach (var item in uniques)
            //{
            //    Console.WriteLine(item.Id);
            //}

            //List<NPC> uniqueNumbers =
            // from n in Citizens
            //group n by n.Grid into nGroup
            // where n.G == 1
            //    select nGroup.Key;

            //collList = collList.OrderBy(x => x.Grid).ToList();// Keep
            //foreach (var m in Citizens)
            //{
            //    foreach (var innerKey in m.Grid)
            //    {
            //        if (!collList.Contains(innerKey))
            //        {
            //            collList.Add(innerKey, m[innerKey]);
            //        }
            //    }
            //}

            //foreach (var item in Citizens)
            //{

            //}

            //foreach (var item in Citizens)
            //{

            //    string tmp = item.Grid;
            //    collList = from a in Citizens
            //               where a.Grid = tmp
            //              select item;
            //}



            //for (int i = 0; i < Citizens.Count-1; i++)//TODO -Går alltid in i if satsen
            //{

            //   //problem
            //    for (int j = 1; j < Citizens.Count; j++)
            //    {
            //        int intTemp = Citizens[i].Location.GridInt;
            //        char charTemp = Citizens[i].Location.GridChar;

            //        if (Citizens[j].Location.GridInt.Equals(intTemp) && Citizens[j].Location.GridChar.Equals(charTemp))
            //        {
            //            Console.SetCursorPosition(0, 28);
            //            Console.Write($"{Citizens[j].Location.GridChar}{Citizens[j].Location.GridInt}| is occupied");
            //            Thread.Sleep(200);
            //        }
            //    }


            //}


            //ToDo - se över något fel för på 500 Citizens bara 2 i samma ruta??





        }


 }   }
