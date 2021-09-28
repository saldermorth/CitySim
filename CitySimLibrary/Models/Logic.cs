using CitySimLibrary.Models;
using CitySimLibrary.Models.NPCs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TjuvOchPolis
{
    public class Logic
    {
        public void Logics()
        {
            
            
        }
        
        public void CollisonChecker(List <NPC> Citizens)
        {
            //ToDo - se över något fel för på 500 Citizens bara 2 i samma ruta??

            for (int j = 0; j < Citizens.Count - 1; j++)
            {
                if (Citizens[j].Location.GridChar.Equals( Citizens[j + 1].Location.GridChar) &&
                    Citizens[j].Location.GridInt.Equals(Citizens[j + 1].Location.GridInt) && Citizens[j].Id != Citizens[j + 1].Id)
                {

                    Console.WriteLine($"ID :{Citizens[j].Id}/ / +  ID :{Citizens[j + 1].Id} //");
                    Console.WriteLine("Same location");
                }
            }
            
            //int[] PossiblePositions = new int[126];
            //foreach (var location in PossiblePositions)
            //{
            //    if (location == one.Location[0] && location == one.Location[1])
            //    {
            //        //TODO - run interactor
            //    }
            }
        }
        


    }
