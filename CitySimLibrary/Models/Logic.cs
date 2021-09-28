using CitySimLibrary.Models;
using CitySimLibrary.Models.NPCs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TjuvOchPolis
{
    public class Logic : Location
    {
        public void Logics()
        {
            
            
        }
        public void CollisonChecker(List <NPC> Citizens)
        {
            for (int i = 0; i < Citizens.Count-1; i++)
            {
                for (int j = 0; j < Citizens.Count-1; j++)
                {
                    if (Citizens[j].Location == Citizens[j+1].Location)
                    {
                        Console.WriteLine("Same lokation");
                    }
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
