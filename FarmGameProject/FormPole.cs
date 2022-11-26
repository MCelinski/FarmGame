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
    public partial class FormPole : Form
    {
        //nowy obiekt klasy FormMain
       FormMain formMain;
        /// <summary>
        /// deklaracja settera
        /// </summary>
        /// <param name="formMain"></param>
        public void setformMain(FormMain formMain)
        {
            this.formMain = formMain;
        }
        public FormPole()
        {
            InitializeComponent();
        }
        /// <summary>
        /// funkcja rozpoczynajaća liczenie timeraCarots
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPoleZbierzMarchewki_Click(object sender, EventArgs e)
        {
            timerCarots.Start();
        }
        /// <summary>
        /// funkcja zbierania marchewek z nawozem i bez
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerMarchewki_Tick(object sender, EventArgs e)
        {
            //zapełnienie progresssBaruCArots
            progressBarCarots.Increment(1);

            if (progressBarCarots.Value == progressBarCarots.Maximum)
            {
                timerCarots.Stop();
                if (formMain.carotJuice > 0)
                {
                    MessageBox.Show("Zebrałeś Marchewki z nawozem i Awansowałeś o 3 poziomy");
                    formMain.FormMain_LvlUp(3);
                    progressBarCarots.Value = 0;
                    formMain.carotJuice--;
                }
                else
                {
                    MessageBox.Show("Zebrałeś Marchewki Awansowałeś o 1 poziom");
                    formMain.FormMain_LvlUp(1);
                    progressBarCarots.Value = 0;
                }
            }
        }
        /// <summary>
        /// funkcja uruchamiajaca timerPotatoes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPoleZbierzZiemniaki_Click(object sender, EventArgs e)
        {
            timerPotatoes.Start();
        }
        /// <summary>
        /// funkcja umożliwiająca zbieranie ziemniaków z naowem lub bez
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerZiemniaki_Tick(object sender, EventArgs e)
        {
            progressBarPotatoes.Increment(1);
            if (progressBarPotatoes.Value == progressBarPotatoes.Maximum)
            {
                timerPotatoes.Stop();
                if (formMain.potatoesJuice > 0)
                {
                    MessageBox.Show("Zebrałeś Ziemniaki z nawozem i Awansowałeś o 20 poziomów");
                    formMain.FormMain_LvlUp(20);
                    progressBarPotatoes.Value = 0;
                    formMain.potatoesJuice--;
                }
                else
                {
                    MessageBox.Show("Zebrałeś Ziemniaki  Awansowałeś o 5 poziomów");
                    formMain.FormMain_LvlUp(5);
                    progressBarPotatoes.Value = 0;
                }
            }
        }
        /// <summary>
        /// funkcja uruchamaiająca timerStrowberies
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPoleZbierzTruskawki_Click(object sender, EventArgs e)
        {
            timerStrawberies.Start();
        }
        /// <summary>
        /// funkcja umożliwiająca zbieranie truskawek z nawozem lub bez 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerStrawberies_Tick(object sender, EventArgs e)
        {
            progressBarStrawberies.Increment(1);
            if (progressBarStrawberies.Value == progressBarStrawberies.Maximum)
            {
                timerStrawberies.Stop();
                if (formMain.strawberiesJuice > 0)
                {
                    MessageBox.Show("Zebrałeś Truskawki z nawozem i Awansowałeś o 40 poziomów");
                    formMain.FormMain_LvlUp(40);
                    progressBarStrawberies.Value = 0;
                    formMain.strawberiesJuice--;
                }

                else
                {
                    MessageBox.Show("Zebrałeś Ziemniaki Awansowałeś o 15 poziomów!!!");
                    formMain.FormMain_LvlUp(15);
                    progressBarStrawberies.Value = 0;
                }
            }
        }




        /// <summary>
        /// informacje o zbiorze marchewek
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelPoleCarots_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Zbiór Marchewek.\nZbiory dają 1 poziom i trwają 10s");
        }
        /// <summary>
        /// inforamcje o zbiorze truskawek
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelPoleStrawberies_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Zbiór Truskawek.\nZbiory dają 15 poziomów i trwają 5min ");
        }

        /// <summary>
        /// informacje o zbiorze ziemniaków
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void labelPolePotatoes_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Zbiór Ziemniaków.\nZbiory dają 5 poziomów i trwają 30s");
        }
    }
}




    