using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitySimLibrary.Models.NPCs
{   enum direction { Up, UpLeft, UpRight, Left, Right, Down, DownLeft, DownRight }
    public abstract class NPC : INPC
    {
        public int[] Location { get; set; }
        public int Direction { get; set; }
        public string[] Inventory { get; set; }
        public char NPC_TYPE { get; set; }

        public NPC(int[] _location, int _direction, string[] _inventory, char _nPC_TYPE)
        {
            Location = _location;
            Direction = _direction;
            Inventory = _inventory;
            NPC_TYPE = _nPC_TYPE;
        }
        public void MakeAllNPC(NPC person)
        {

        }
        public void GiveDirection(NPC person)
        {
            throw new NotImplementedException();
        }

        public void GiveLocation(NPC person)
        {
            throw new NotImplementedException();
        }

        public void ShowInventory(NPC person)
        {
            throw new NotImplementedException();
        }
    }
}
