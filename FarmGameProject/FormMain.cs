using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmGame
{ 
    public partial class FormMain : Form
    {
        //zmienna globalna przechowujaca poziom
        int lvl = 0;
       
        public int carotJuice = 0;
        //zmienna globalna przechowujaca ilosc nazowu do Ziemniaków
        public int potatoesJuice = 0;
        //zmienna globalna przechowujaca ilosc nazowu do truskawek
        public int strawberiesJuice = 0;
        public int antidotum = 0;


        /// <summary>
        /// zmienna przechowujaca referencje do pola Pole
        /// </summary>
        /// <returns></returns>
        FormPole formPole;
        /// <summary>
        /// zmienna przechowujaca referencje do pola Sklep
        /// </summary>
        FormShop formShop;
        public FormMain()
        {
            InitializeComponent();
        }
        /// <summary>
        /// funkcja tworzaca okno Pole
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPole_Click(object sender, EventArgs e)
        {

            //utowrzenie nowego obiektu okna FormPole
            formPole = new FormPole();
            //deklaracja settera formPole
            formPole.setformMain(this);
            formPole.Show();
            MessageBox.Show("Witamy na Polu! \nNaciśnij na nazwy ważyw aby dowiedzieć się więcej!");
        }
        /// <summary>
        /// funkcja tworzaca okno Sklep
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSklep_Click(object sender, EventArgs e)
        {
            //utowrzenie nowego obiektu okna FormPole
            formShop = new FormShop();
            //deklaracja settera formPole
            formShop.setformMain(this);
            //Otworzenie okna obiektu formShop
            formShop.Show();
            MessageBox.Show("Witamy w Sklepie! \nNaciśnij na nawóz aby dowiedzieć się więcej!");
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// funkcja podnoszaca poziom 
        /// </summary>
        /// <param name="n"></param>
        public void FormMain_LvlUp(int n)
        {
            lvl+=n;
            textBoxLvl.Text = lvl.ToString();
        }
        /// <summary>
        /// funkcja odejmujaca poziom
        /// </summary>
        /// <param name="n"></param>
        public void FormMain_LvlDown(int n)
        {
            //zapisanie do zmiennej lvl wartość textBoxLvl za pomocą inta
            lvl = int.Parse(textBoxLvl.Text);
            lvl -= n;
            textBoxLvl.Text = lvl.ToString();
        }
        /// <summary>
        /// funkcja globalna sprawdzająca poziom 
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public bool Form_Main_LvlCheck(int n)
        {
            //zmiana stringa na int
            int i = int.Parse(textBoxLvl.Text);
            if (i < n)
                return false;
            else 
                return true;
        }
      
    }
}
