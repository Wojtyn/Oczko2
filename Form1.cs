using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oczko2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MessageBoxManager.Yes = "Trudny";
            MessageBoxManager.No = "Łatwy";
            MessageBoxManager.Register();
            DialogResult DifficultyLevel = MessageBox.Show("Wybierz poziom trudności", "Poziom trudności", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void QuitBtn_Click(object sender, EventArgs e) //Zamykanie programu
        {
            this.Close();
        }

        private void PlayerHitBtn_Click(object sender, EventArgs e)
        {
            //string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            //path += "\\Cards\\1-1.png";
            //BotPointsLabel.Text = path;
            //PlayerCard2.Image =
            //    Image.FromFile(path);
        }

        private void PlayerStandBtn_Click(object sender, EventArgs e)
        {
            PlayerCard2.Image = null;
        }

        private void HelpBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Zamknij - zamyka program \nHit - dobierz kartę \nStand - pasowanie \nDouble Down - podwojenie zakładu, dobranie karty i spasowanie \n" +
                "Split - rozdzielenie ręki na 2 - możliwe tylko, gdy masz 2 karty na ręce \nCelem gry jest zdobycie liczby punktow jak najblizszej 21, ale nie więcej.\n" +
                "Wartości kart: 2-10 - 2-10\n" +
                "Walet (J), Królowa (Q), Król(K) - 10" +
                "As (A) - 1 lub 11 w zależności co jest lepsze dla gracza.", "Pomoc", MessageBoxButtons.OK);
        }
        
    }
}
