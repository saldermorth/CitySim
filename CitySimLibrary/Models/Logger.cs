using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TjuvOchPolis
{
    /// <summary>
    /// Keeps stats in memory.
    /// </summary>
    public class Saver
    {
        public int stolenItems { get; set; }
        public int arrests { get; set; }

        public Saver(int _stolenItems, int _arrests) 
        {
            stolenItems = _stolenItems;
            arrests = _arrests;
        }
    }
}