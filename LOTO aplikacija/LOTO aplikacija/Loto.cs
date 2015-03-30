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
        public List<int> izvuceniBrojevi { get; set;}
        public List<int> odigraniBrojevi { get;set; }
        public Loto() {}
        

            
        public void izbacivanjeBrojeva(FrmLoto forma) 
        {

            Random r = new Random();
            int broj;            
            for (int i = 0; i < 7; i++)
            {
                broj = r.Next(1, 39);
                if (izvuceniBrojevi.Contains(broj))
                {
                    i--;
                }
                else
                {
                    izvuceniBrojevi.Add(broj);
                }
            }
            forma.textBox1.Text = izvuceniBrojevi[0].ToString();
            forma.textBox2.Text = izvuceniBrojevi[1].ToString();
            forma.textBox3.Text = izvuceniBrojevi[2].ToString();
            forma.textBox4.Text = izvuceniBrojevi[3].ToString();
            forma.textBox5.Text = izvuceniBrojevi[4].ToString();
            forma.textBox6.Text = izvuceniBrojevi[5].ToString();
            forma.textBox9.Text = izvuceniBrojevi[6].ToString();
        
        }
        public void provjeraDobitka(FrmLoto forma) 
        {
            int a,b,c,d,e,f,g;
            a = int.Parse(forma.textBox14.Text);
            b = int.Parse(forma.textBox13.Text);
            c = int.Parse(forma.textBox12.Text);
            d = int.Parse(forma.textBox11.Text);
            e = int.Parse(forma.textBox10.Text);
            f = int.Parse(forma.textBox8.Text);
            g = int.Parse(forma.textBox7.Text);
            odigraniBrojevi.Add(a);
            odigraniBrojevi.Add(b);
            odigraniBrojevi.Add(c);
            odigraniBrojevi.Add(d);
            odigraniBrojevi.Add(e);
            odigraniBrojevi.Add(f);
            odigraniBrojevi.Add(g);
            foreach (int zbroj in odigraniBrojevi)
            {
                if (izvuceniBrojevi.Contains(zbroj))
                {
                    forma.label1.Text = zbroj.ToString() + ",";
                }
            }
        
        }
    }
}
