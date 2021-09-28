using CitySimLibrary.Models.NPCs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TjuvOchPolis
{
    public class Polis : NPC
    {
        public Polis(int[] _location, int _direction, string[] _inventory, char _nPC_TYPE) : base(_location, _direction, _inventory, _nPC_TYPE)
        {
        }
    }
}