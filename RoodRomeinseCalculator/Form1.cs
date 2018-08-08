using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// Opdrachtenreeks rood
// Romeinse rekenmachine
// Voer romeinse getallen in in hoofdletters


namespace RoodRomeinseCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int RomNum1 = 0;
        int RomNum2 = 0;
        int Resultaat = 0;

        private string NaarRomGet(int getal)
        {
            //if ((getal < 0) || (getal > 9000)) throw new ArgumentOutOfRangeException("Getal moet tussen 0 en 3000 liggen.");
            if (getal < 1) return string.Empty;
            if (getal >= 1000) return "M" + NaarRomGet(getal - 1000);
            if (getal >= 900) return "CM" + NaarRomGet(getal - 900);
            if (getal >= 500) return "D" + NaarRomGet(getal - 500);
            if (getal >= 400) return "CD" + NaarRomGet(getal - 400);
            if (getal >= 100) return "C" + NaarRomGet(getal - 100);
            if (getal >= 90) return "XC" + NaarRomGet(getal - 90);
            if (getal >= 50) return "L" + NaarRomGet(getal - 50);
            if (getal >= 40) return "XL" + NaarRomGet(getal - 40);
            if (getal >= 10) return "X" + NaarRomGet(getal - 10);
            if (getal >= 9) return "IX" + NaarRomGet(getal - 9);
            if (getal >= 5) return "V" + NaarRomGet(getal - 5);
            if (getal >= 4) return "IV" + NaarRomGet(getal - 4);
            if (getal >= 1) return "I" + NaarRomGet(getal - 1);

            return ("");
        }
        
        private int NaarIntGet(string RomGet)
        {
            RomGet = RomGet.ToUpper(); //FIXME: ergens anders neerzetten
            bool CheckInvDig = false;
            if (RomGet.Length == 0) return 0;
            if (RomGet.Length >= 2)
            {
                if (RomGet.Substring(0, 2) == "CM") return 900 + NaarIntGet(RomGet.Substring(2));
                if (RomGet.Substring(0, 2) == "CD") return 400 + NaarIntGet(RomGet.Substring(2));
                if (RomGet.Substring(0, 2) == "XC") return 90 + NaarIntGet(RomGet.Substring(2));
                if (RomGet.Substring(0, 2) == "XL") return 40 + NaarIntGet(RomGet.Substring(2));
                if (RomGet.Substring(0, 2) == "IX") return 9 + NaarIntGet(RomGet.Substring(2));
                if (RomGet.Substring(0, 2) == "IV") return 4 + NaarIntGet(RomGet.Substring(2));
            }

            if (RomGet.Substring(0, 1) == "M") return 1000 + NaarIntGet(RomGet.Substring(1));
            if (RomGet.Substring(0, 1) == "D") return 500 + NaarIntGet(RomGet.Substring(1));
            if (RomGet.Substring(0, 1) == "C") return 100 + NaarIntGet(RomGet.Substring(1));
            if (RomGet.Substring(0, 1) == "L") return 50 + NaarIntGet(RomGet.Substring(1));
            if (RomGet.Substring(0, 1) == "X") return 10 + NaarIntGet(RomGet.Substring(1));
            if (RomGet.Substring(0, 1) == "V") return 5 + NaarIntGet(RomGet.Substring(1));
            if (RomGet.Substring(0, 1) == "I") return 1 + NaarIntGet(RomGet.Substring(1));

            return 0;
        }


        private void UpdateView()
        {
            labelResultaat.Text = NaarRomGet(Resultaat);
            //RomNum1 = 0;
            //RomNum2 = 0;
            //Resultaat = 0; // hoeft niet
            //romeinsGetal1.Text = "";
            //romeinsGetal2.Text = "";
        }

        private void romeinsGetal2_TextChanged(object sender, EventArgs e)
        {
            RomNum2 = NaarIntGet(romeinsGetal2.Text);
        }

        private void romeinsGetal1_TextChanged(object sender, EventArgs e)
        {
            RomNum1 = NaarIntGet(romeinsGetal1.Text);
        }

        private void OperatorClick(object sender, EventArgs e)
        {
            string operation = "";
            Button button = (Button)sender;
            operation = button.Text;
            //int temp = 0;
            switch(operation)
            {
                case "+":
                    Resultaat = RomNum1 + RomNum2;
                    UpdateView();
                    break;
                case "-":
                    Resultaat = RomNum1 - RomNum2;
                    UpdateView();
                    break;
                case "*":
                    Resultaat = RomNum1 * RomNum2;
                    UpdateView();
                    break;
                case "/":
                    Resultaat = RomNum1 / RomNum2;
                    UpdateView();
                    break;
                default:
                    break;
            }

        }

        private void ClearClick(object sender, EventArgs e)
        {
            RomNum1 = 0;
            RomNum2 = 0;
            Resultaat = 0;
            labelResultaat.Text = "Resultaat";
            romeinsGetal1.Clear();
            romeinsGetal2.Clear();
        }
    }
}
