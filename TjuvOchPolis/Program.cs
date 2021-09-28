using CitySimLibrary.Models.NPCs;
using System;
using System.Collections.Generic;

namespace TjuvOchPolis
{
    class Program
    {
        static void Main(string[] args)
        {
            NPC main = new NPC();
            List<NPC> Populus = main.MakeAllNPC();

            DrawingCity builder = new DrawingCity();
            Logic logic = new Logic();
            
            
            foreach (var item in Populus)
            {
                Console.WriteLine($"{item.NPC_TYPE } + {item.Direction}"  );
            }
            logic.CollisonChecker(Populus);

        }
    }
}
