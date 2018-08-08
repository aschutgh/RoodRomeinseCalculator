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
            //FIXME: recursief formuleren
            RomGet = RomGet.ToUpper();

            Dictionary<string, int> RomInvDig = new Dictionary<string, int>();
            RomInvDig.Add("CM", 900);
            RomInvDig.Add("CD", 400);
            RomInvDig.Add("XC", 90);
            RomInvDig.Add("XL", 40);
            RomInvDig.Add("IX", 9);
            RomInvDig.Add("IV", 4);

            Dictionary<string, int> RomNums = new Dictionary<string, int>();
            RomNums.Add("M", 1000);
            RomNums.Add("D", 500);
            RomNums.Add("C", 100);
            RomNums.Add("L", 50);
            RomNums.Add("X", 10);
            RomNums.Add("V", 5);
            RomNums.Add("I", 1);

            int ToInt = 0;

            foreach (string invdig in RomInvDig.Keys)
            {
                if (RomGet.Contains(invdig) == true)
                {
                    ToInt += RomInvDig[invdig];
                    string[] RomSplit;
                    string[] sep = new string[] { invdig };
                    RomSplit = RomGet.Split(sep, StringSplitOptions.None);
                    RomGet = String.Join("", RomSplit);
                }
            }

            foreach (char c in RomGet)
            {
                string cs = c.ToString();
                ToInt += RomNums[cs];
            }

            return ToInt;

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
