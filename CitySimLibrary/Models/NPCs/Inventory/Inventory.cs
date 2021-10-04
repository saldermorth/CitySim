using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitySimLibrary.Models.NPCs
{
    public abstract class Inventorys : NPC
    {

        public List<string> _items = new List<string>();


        public List<string> Items
        {
            get { return _items; }
            set
            {
                if (this.NPC_TYPE == 'M')
                {
                    this._items.Add("Klocka");
                    this._items.Add("Mobil");
                    this._items.Add("Pengar");
                    this._items.Add("Nycklar");
                }
                value = Items;
            }
        }
        public Inventorys(List<string> items) 
        {
            Items = items;
        }
    }
    
    
}
