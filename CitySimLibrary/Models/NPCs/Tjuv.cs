using CitySimLibrary.Models.NPCs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TjuvOchPolis
{
    public class Tjuv : NPC
    {
        public Tjuv()
        { 
        }
        public Tjuv(int[] _location, int _direction, string[] _inventory, char _nPC_TYPE) 
        {
            NPC_TYPE = CitizenType();
        }
        public override char CitizenType()
        {
            char Char = 'T';
            
            return Char;
        }
        public new virtual List<string> MakeInventory
        {
            get
            {
                List<string> items = new List<string>();
                return items;

            }
        }
    }
}