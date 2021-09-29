using CitySimLibrary.Models.NPCs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TjuvOchPolis
{
    public class HUD
    {
        public void Builder(NPC n)
        {
            string npc = "Polis";
            string npc2 = "Tjuv";
            string action = "Beslagtar från";
            int stolen = 2;
            int arrests = 12;

            Console.SetCursorPosition(0, 28);
            string s = $"{npc} {action} {npc2}";
            string t = $"Number of stolen items: {stolen}, Number of arrests: {arrests} ";
            Console.Write(s + t );
            Console.ReadKey();

        }
    }
}