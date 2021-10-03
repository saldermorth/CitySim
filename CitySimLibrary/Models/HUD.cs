using CitySimLibrary.Models.NPCs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TjuvOchPolis
{
    public class HUD
    {
        public static void Builder(string typeOfIncounter,  int itemsStolen,  int tjuvArrested)//string event int count of events.
        {
            

            Console.SetCursorPosition(0, 28);
            string s = $"{typeOfIncounter}  |";
            string t = $"Number of stolen items: {itemsStolen}| Number of arrests: {tjuvArrested} ";
            Console.Write(s + t );
            Console.ReadKey();

        }
        public void HUDWriter(int typeOfIncounter)
        {
            
            switch (typeOfIncounter)
            {
                
                case 1:
                    Builder("Polis griper tjuv, stöldgods beslagtas",0,1);
                    break;
                case 2:
                    Builder("Polis griper tjuv, stöldgods beslagtas", 0, 1);
                    break;
                case 3:
                    Builder("Tjuv rånar medborgare",1,0);
                    break;
                case 4:
                    Builder("Tjuv rånar medborgare", 1, 0);
                    break;
                case 5:
                    Builder("Polis hälsar på medborgare", 0, 0 );
                    break;
                case 6:
                    Builder("Polis hälsar på medborgare", 0, 0);
                    break;

                default:
                    break;
            }
        }
    }
}