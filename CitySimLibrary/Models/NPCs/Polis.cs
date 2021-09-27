using CitySimLibrary.Models.NPCs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TjuvOchPolis
{
    public class Polis : NPC
    {
        public enum Direction { UP, UPLeft, UpRight,
                                Down, DownLeft, DownRight,
                                Left, Right}
    }
}