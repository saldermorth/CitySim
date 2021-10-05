using CitySimLibrary.Models.NPCs;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TjuvOchPolis
{
    public class Medborgare : NPC
    {
       
        public Medborgare()
        {

        }
        public Medborgare(int[] _location, int _direction, string[] _inventory, char _nPC_TYPE)
        {
            Inventory = MakeInventory;
            NPC_TYPE = CitizenType();
        }
        public override char CitizenType()
        {
            char Char = 'M';
            
            return Char;
        }
        public new virtual List<string> MakeInventory
        {
            get
            {
                List<string> items = new List<string>();


                items.Add("Nycklar");
                items.Add("Klocka");
                items.Add("Mobil");
                items.Add("Pengar");

                return items;


            }
        }
    }
}