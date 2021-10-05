using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CitySimLibrary.Models
{
    public class Location
    {
        public char GridChar { get; set; }
        public int GridInt { get; set; }

        public Location(char _gridChar, int _gridInt)
        {
            GridChar = _gridChar;
            GridInt = _gridInt;
        }
    }
}
