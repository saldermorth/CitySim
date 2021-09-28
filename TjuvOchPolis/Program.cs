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
            builder.BlockDrawer();
            

        }
    }
}
