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
        
        public int Id { get; set; }
        public Location Location { get; set ;  }
        public int Direction { get; set ;  }
        // public Inventorys inventory { get; set; }
        public List<String> Inventory { get; set; }
        public char NPC_TYPE { get; set; }
        private static int counter = 1;
        public string Grid { get; set; }
        public NPC()
        {

            Id = ID(ref counter);
            Location = GiveLocation();
            Direction = GiveDirection();            
            NPC_TYPE = CitizenType();
            Inventory = ;

        }
        public static int ID(ref int i)
        {
            
            i++;

            return i;
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
            for (int i = 0; i <45 ; i++) // Number of npcs
            {
                NPC test = new NPC();
                Populus.Add(test);
                MakeInventory(Populus[i]);
            }
            return Populus;
        }
        public int GiveDirection()
        {
            Random rnd = new Random();
            int dir = rnd.Next(0, 7);
           
            return dir;
        }
        /// <summary>
        /// Initiatez a location based on a grid system. A - 
        /// </summary>
        /// <returns></returns>
        public Location GiveLocation()
        {
            Location location = new Location('A',1);
            Random rnd = new Random();

            location.GridChar = Convert.ToChar(rnd.Next(65, 83));
            location.GridInt  = rnd.Next(1, 9);
            string grid = location.GridChar.ToString() + location.GridInt.ToString();
            Grid = grid;
            return location;

        }

        public NPC MakeInventory(NPC n)
        {
            
            if (this.NPC_TYPE == 'M')
            {
                n.Inventory.Add("Klocka");
                n.Items.("Mobil");
                n.inventory.Add("Pengar");
                n.inventory.Add("Nycklar");
            }
            return n;
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
