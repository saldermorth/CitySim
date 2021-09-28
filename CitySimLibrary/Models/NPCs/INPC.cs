using CitySimLibrary.Models.NPCs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitySimLibrary
{
    interface INPC
    {
        void ShowInventory(NPC person);
        void GiveLocation(NPC person);
        void GiveDirection(NPC person);
        void MakeAllNPC(NPC person);
    }
}
