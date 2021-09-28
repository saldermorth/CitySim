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
            DrawingNPCs placer = new DrawingNPCs();
            DrawingCity builder = new DrawingCity();
            Logic logic = new Logic();
            builder.BlockDrawer();
            foreach (var item in Populus)
            {
                placer.NPCPlacer(item);
            }

            Console.ReadKey();
            
            

        }
    }
}
