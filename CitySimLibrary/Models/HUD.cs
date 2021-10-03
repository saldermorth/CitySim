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
            Saver save = new Saver(0,0);
            if (itemsStolen>0)
            {
                save.stolenItems += itemsStolen;
            }
            if (tjuvArrested>0)
            {
                save.arrests += tjuvArrested;
            }
            
            
            //Todo - keep stats in memory. And switsh items.
           
            Console.SetCursorPosition(0, 28);
            string s = $"{typeOfIncounter}  |";
            string t = $"Number of stolen items: {save.stolenItems}| Number of arrests: {save.arrests} ";
            Console.Write(s + t );
            

        }
        public void HUDWriter( int typeOfIncounter)
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