using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace LOTO_aplikacija
{
    class Loto
    {
        public List<int> UplaceniBrojevi { get; set;}
        public List<int> DobitniBrojevi { get; set;}

        // Konstruktor klase

        public Loto()
        {

            UplaceniBrojevi = new List<int>();
            DobitniBrojevi = new List<int>();

        }
        // Metoda koja nakon provjere unosi brojeve u korisnicku listu vrijednosti, odnosno uplacenih brojeva
        public bool UnesiUplaceneBrojeve(List<string> korisnickeVrijednosti) 
        {
            bool ispravni = false;
            UplaceniBrojevi.Clear();

            foreach (string v in korisnickeVrijednosti)
            {
                int broj = 0;
                if (int.TryParse(v, out broj) == true)
                {

                    if (broj >= 1 && broj <= 39)
                    {
                        if (UplaceniBrojevi.Contains(broj) == false)
                        {
                            UplaceniBrojevi.Add(broj);
                        }
                    }

                }
            }
            if (UplaceniBrojevi.Count==7)
            {
                ispravni = true;
            }
            return ispravni;
	   }
        /// <summary>
        /// Generator nasumičnih brojevau rasponu od 1 do 39
        /// </summary>
        public void GenerirajDobitnuKombinaciju() 
        {

            DobitniBrojevi.Clear();
            Random generatorBrojeva = new Random();
            while (DobitniBrojevi.Count < 7)
            {
                int broj = generatorBrojeva.Next(1, 39);
                if (DobitniBrojevi.Contains(broj)==false)
                {
                    DobitniBrojevi.Add(broj);
                }
            }
            DobitniBrojevi.Sort();
        
        }
        /// <summary>
        /// Izračunava broj pogođenih brojeva
        /// </summary>
        /// <returns>Broj pogođenih brojeva
        public int IzracunBrojPogodaka() 
        {

            int brojPogodaka= 0;
            foreach (int broj in UplaceniBrojevi)
            {
                if (DobitniBrojevi.Contains(broj)==true)
                {
                    brojPogodaka++;
                }
            }
            return brojPogodaka;
        
        }


 
    }
}
