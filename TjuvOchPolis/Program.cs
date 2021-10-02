using CitySimLibrary.Models.NPCs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace TjuvOchPolis
{
    class Program
    {
        static void Main(string[] args)
        {
            NPC main = new NPC();
            List<NPC> Populus = main.MakeAllNPC();
            DrawingNPCs placer = new DrawingNPCs();
            DrawingCity builder = new DrawingCity();
            Logic logic = new Logic();
            logic.CollisonChecker(Populus);

           
            Console.ReadKey();
            do
            {
            
            } while (true);
            
                     
            

            Console.ReadKey();
            
            

        }
    }
}
