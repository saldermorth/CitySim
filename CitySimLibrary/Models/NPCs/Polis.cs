using CitySimLibrary.Models.NPCs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace TjuvOchPolis
{
    public class Polis : NPC
    {
        public Polis()
        {
            NPC_TYPE = CitizenType();
            Inventory = MakeInventory();
        }
        public Polis(int[] _location, int _direction, string[] _inventory, char _nPC_TYPE) 
        {
            NPC_TYPE = CitizenType();
        }
        public override char CitizenType()
        {
            char Char = 'P';
            return Char;
        }
        public virtual List<string> MakeInventory()
        {
            List<string> items = new List<string>();

                        

            return items;


        }

    }
}