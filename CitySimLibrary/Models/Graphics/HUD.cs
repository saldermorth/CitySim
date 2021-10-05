using CitySimLibrary.Models.NPCs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TjuvOchPolis
{
    public class HUD
    {
        
        
        public static void Builder(Saver save ,string typeOfIncounter,  int itemsStolen,  int tjuvArrested)//string event int count of events.
        {
           
            
                save.stolenItems += itemsStolen;
            
            
                save.arrests += tjuvArrested;
          
            
            
            //Todo - keep stats in memory. And switsh items.
           
            
            string s = $"{typeOfIncounter,15}";
           
            string t = $"Number of stolen items: {save.stolenItems}| Number of arrests: {save.arrests} ";
            Console.SetCursorPosition(0, 28);
            Console.Write(t);
            Console.SetCursorPosition(0, 29);
            Console.Write(s + "                          ");
            


        }
        public void HUDWriter(Saver save, int typeOfIncounter)
        {
            
            switch (typeOfIncounter)
            {                
                case 1:
                    Builder(save,"Polis griper tjuv, stöldgods beslagtas",0,1);
                    break;
                case 2:
                    Builder(save, "Polis griper tjuv, stöldgods beslagtas", 0, 1);
                    break;
                case 3:
                    Builder(save, "Tjuv rånar medborgare",1,0);
                    break;
                case 4:
                    Builder(save, "Tjuv rånar medborgare", 1, 0);
                    break;
                case 5:
                    Builder(save, "Polis hälsar på medborgare", 0, 0 );
                    break;
                case 6:
                    Builder(save, "Polis hälsar på medborgare", 0, 0);
                    break;
                case 7:
                    Builder(save, "Tjuv försöker råna medborgare", 0, 0);
                    break;
                case 8:
                    Builder(save, "Polis griper tjuv, inget stöldgods", 0, 1);
                    break;
                default:
                    break;
            }
        }
    }
}