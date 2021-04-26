using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZadanieDomowe1_Farma

{
    public partial class FormShop : Form
    {
        FormMain formMain;
        /// <summary>
        /// ustawienie setera z FormMain
        /// </summary>
        /// <param name="formMain"></param>
        public void setformMain(FormMain formMain)
        {
            this.formMain = formMain;
        }
        public FormShop()
        {
            InitializeComponent();
        }


        /// <summary>
        /// funkcja pozwalająca kupić nawóz do Marchewek
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShopBuyJuice1_Click(object sender, EventArgs e)
        {
            if (formMain.Form_Main_LvlCheck(5) == true)
            {
                formMain.FormMain_LvlDown(5);
                MessageBox.Show("Kupiłeś Nawoz do Marchewek. Kosztowało Cię to 5 poziomów. ");
                formMain.carotJuice++;
            }
            else
                MessageBox.Show("Nie masz tylu pozimów! ");
            
        }
        /// <summary>
        /// funkcja pozwalająca kupić nawóz do ziemniaków
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShopBuyJuice2_Click(object sender, EventArgs e)
        {
            if (formMain.Form_Main_LvlCheck(10) == true)
            {
                //obnizenie poziomu o cene nawozu
                formMain.FormMain_LvlDown(10);
                //wypisanie informacji o zakupie
                MessageBox.Show("Kupiłeś Nawoz do Ziemniaków. Kosztowało Cię to 10 poziomów. ");
                //dodanie nawozu do zmiennej globalnej
                formMain.potatoesJuice++;
            }
            else
                //wypisanie informacji o braku poziomow
                MessageBox.Show("Nie masz tylu pozimów! ");
        }
        /// <summary>
        /// funkcja pozwalająca kupić nawóz dla truskawek 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShopJuice3_Click(object sender, EventArgs e)
        {
            if (formMain.Form_Main_LvlCheck(25) == true)
            {
                //obnizenie poziomu o cene nawozu
                formMain.FormMain_LvlDown(25);
                //wypisanie informacji o zakupie
                MessageBox.Show("Kupiłeś Nawoz do Trsukawek. Kosztowało Cię to 25 poziomów. ");
                //dodanie nawozu do zmiennej globalnej
                formMain.strawberiesJuice++;
            }
            else
                //wypisanie informacji o braku poziomow
                MessageBox.Show("Nie masz tylu pozimów! ");
        }
        /// <summary>
        /// informacje o nawozie Marchewek
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxShopJuice1_Click(object sender, EventArgs e)
        {
            //wyświetlenie wiadomości o nawozie 
            MessageBox.Show("Nawóz do marchewek!\nKosztuje 5 poziomów. Po kupieniu kolejne zbiory marchewek będą dawać o 3 poziomy więcej  ");
        }
        /// <summary>
        /// informacje o nawozie dla ziemniaków
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxShopJuice2_Click(object sender, EventArgs e)
        {
            //wyświetlenie wiadomości o nawozie 
            MessageBox.Show("Nawóz do Ziemniaków!\nKosztuje 10 poziomów. Po kupieniu kolejne zbiory ziemniaków będą dawać o 15 poziomów więcej  ");
        }
        /// <summary>
        /// infomacje o nawozie dla truskawek
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxShopJuice3_Click(object sender, EventArgs e)
        {
            //wyświetlenie wiadomości o nawozie 
            MessageBox.Show("Nawóz do Truskawek!\n Kosztuje 10 poziomów. Po kupieniu kolejne zbiory truskawek będą dawać o 25 poziomów więcej  ");
        }

       
        /// <summary>
        /// informacje o środku przeciwko mszycom
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxShopAntidotum_Click(object sender, EventArgs e)
        {
            //wyświetlenie wiadomości o nawozie 
            MessageBox.Show("Środek przeciwko Mszcycom!\n Kosztuje 15 poziomów. Po kupieniu możesz bronić się przeciwko atakowi szkodników  ");
        }

        private void buttonShopAntidotum_Click(object sender, EventArgs e)
        {
            if (formMain.Form_Main_LvlCheck(10) == true)
            {
                //obnizenie poziomu o cene nawozu
                formMain.FormMain_LvlDown(10);
                //wypisanie informacji o zakupie
                MessageBox.Show("Kupiłeś Środek przeciwko mszycom Kosztowało Cię to 10 poziomów. Jesteś bezpieczny przeciwko atakowi mszyc ");
                //dodanie nawozu do zmiennej globalnej
                formMain.antidotum++;
            }
            else
                //wypisanie informacji o braku poziomow
                MessageBox.Show("Nie masz tylu pozimów! ");
        }
    }
}
