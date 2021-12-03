using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IS_2_19_KalinichenkoPV
{
    public partial class Задание1 : Form
    {
        public Задание1()
        {
            InitializeComponent();
        }
        abstract class Accessories<k>
        {
            protected string cena;
            protected string GodVblpyska;
            public Accessories(string Cena, string godVblpyska)
            {
                cena = Cena;
                GodVblpyska = godVblpyska;

            }
            public abstract void Display(ListBox listbox1);
        }
            class Cp : Accessories<string>
            {
                public string chastota1;
                public string Yadra;
                public string Potoki;
                public Cp(string Cena, string godVblpyska, string Chastota, string yadra, string potoki)
                   :base(Cena, godVblpyska)
                {
                    chastota = Chastota;
                    Yadraa = yadra;
                    Potokii = potoki;

                }
                public string chastota { get { return chastota1; } set { chastota1 = value; } }
                public string Yadraa { get { return Yadra; } set { Yadra = value; } }
                public string Potokii { get { return Potoki; } set { Potoki = value; } }
                public override void Display(ListBox listBox1)
                {
                    listBox1.Items.Add($"Цена {cena},Год выпуска {GodVblpyska},Частота {chastota},Количество ядер {Yadra}, Количество потоков {Potoki}");
                }
            }
        class videocart : Accessories<string>
        {
            public string chastota1;
            public string Sozdatel1;
            public string obiempameti1;

            public videocart(string Cena, string GodVblpyska, string Chastota, string Sozdatel, string Obiempameti)
               : base(Cena, GodVblpyska)
            {
                chastota = Chastota;
                sozdatel = Sozdatel;
                obiempameti = Obiempameti;

            }
            public string chastota { get { return chastota1; } set { chastota1 = value; } }
            public string sozdatel { get { return Sozdatel1; } set { Sozdatel1 = value; } }
            public string obiempameti { get { return obiempameti1; } set { obiempameti1 = value; } }
            public override void Display(ListBox listBox1)  
            {
                listBox1.Items.Add($"Цена{cena},Год выпуска{GodVblpyska},Частота {chastota},Производитель {sozdatel},Обьем памяти {obiempameti}");
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            string cena = Convert.ToString(textBox1.Text);
            string GodVblpyska = Convert.ToString(textBox2.Text);
            string chastota = Convert.ToString(textBox3.Text);
            string sozdatel = Convert.ToString(textBox4.Text);
            string obiempameti = Convert.ToString(textBox5.Text);
            videocart vd1 = new videocart(cena, GodVblpyska, chastota, sozdatel, obiempameti);
            vd1.Display(listBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cena = Convert.ToString(textBox1.Text);
            string GoDVblpyska = Convert.ToString(textBox2.Text);
            string chastota = Convert.ToString(textBox3.Text);
            string kolvoiader = Convert.ToString(textBox4.Text);
            string kolvopotokov = Convert.ToString(textBox5.Text);
            Cp cp1 = new Cp(cena, GoDVblpyska, chastota, kolvoiader, kolvopotokov);
            cp1.Display(listBox1);
        }
    }
}
