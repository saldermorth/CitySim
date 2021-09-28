using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitySimLibrary.Models.NPCs
{   
    public class NPC : INPC
    {
        private enum DirectionEnum { Up, UpLeft, UpRight, Left, Right, Down, DownLeft, DownRight }
        
        public Location Location { get; set ;  }
        public int Direction { get; set ;  }
        public string[] Inventory { get ; set  ; }
        public char NPC_TYPE { get; set; }

        public NPC()
        {
            Location = GiveLocation();
            Direction = GiveDirection();
            Inventory = ShowInventory();
            NPC_TYPE = CitizenType();
        }
        public char CitizenType()
        {
            char Char =' ';
            Random rnd = new Random();
            int temp = rnd.Next(1, 4);
            switch (temp)
            {
                case 1:
                    Char = 'P';
                    break;
                case 2:
                    Char = 'T';
                    break;
                case 3:
                    Char = 'M';
                    break;                
            }
            return Char;
        }
        public List<NPC> MakeAllNPC()
        {
            List<NPC> Populus = new List<NPC>();
            for (int i = 0; i < 500000; i++)
            {
                NPC test = new NPC();
                Populus.Add(test);

            }
            return Populus;
        }
        public int GiveDirection()
        {
            Random rnd = new Random();
            int dir = rnd.Next(0, 7);
           
            return dir;
        }

        public Location GiveLocation()
        {
            Location location = new Location('A',1);
            Random rnd = new Random();

            location.GridChar = Convert.ToChar(rnd.Next(41, 59));
            location.GridInt  = rnd.Next(1, 30);
            return location;

        }

        public string[] ShowInventory()
        {
            string[] tmp = {"Nycklar", "Mobil", "Pengar", "Klocka" };
            //TODO -MakeClass
            return tmp;
        }

        void INPC.GiveDirection()
        {
            throw new NotImplementedException();
        }

        void INPC.GiveLocation()
        {
            throw new NotImplementedException();
        }

        void INPC.ShowInventory()
        {
            throw new NotImplementedException();
        }

        void INPC.MakeAllNPC()
        {
            throw new NotImplementedException();
        }
    }
}
