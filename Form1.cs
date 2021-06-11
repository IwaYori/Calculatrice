using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculatrice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int whereAmI = 0;
        int fraction = 0;


        private void Form1_Load(object sender, EventArgs e)
        {
            l_note.Text = "Note, utilisez :\n-cos Pour calculer le CA ou l'HYP\n-sin Pour calculer le CO ou l'HYP\n-tan Pour calculer le CO ou le CA\nCAH SOH TOA";
        }

        private void bu_aq_Click(object sender, EventArgs e)
        {
            whereAmI = 1;

            l_valeur1.Text = "Longueur";
            l_valeur2.Text = "Largeur";

            num_valeur1.Text = "0";
            num_valeur2.Text = "0";

            l_valeur1.Visible = true;
            l_valeur2.Visible = true;
            num_valeur1.Visible = true;
            num_valeur2.Visible = true;
            bu_back.Enabled = true;
        }

        private void bu_calc_Click(object sender, EventArgs e)
        {
            double valeur1;
            double valeur2;

            valeur1 = Convert.ToDouble(num_valeur1.Text);
            valeur2 = Convert.ToDouble(num_valeur2.Text);

            if (whereAmI == 1) 
            {
                double result = valeur1 * valeur2;
                l_result.Text = "Le résultat est : " + Convert.ToString(result) + " cm²";
            }
            if (whereAmI == 2)
            {
                double result = (valeur1 * valeur2) / 2;
                l_result.Text = "Le résultat est : " + Convert.ToString(result) + " cm²";
            }

            l_result.Visible = true;
        }

        private void num_valeur1_ValueChanged(object sender, EventArgs e)
        {
            double valeur1 = 0;
            double valeur2 = 0;

            if (num_valeur1.Text != "")
            {
                valeur1 = Convert.ToDouble(num_valeur1.Text);
            }

            if (num_valeur2.Text != "")
            {
                valeur2 = Convert.ToDouble(num_valeur2.Text);
            }

            if (valeur1 == 0 || valeur2 == 0)
            {

                bu_calc.Enabled = false;

            }
            else
            {
                bu_calc.Enabled = true;
            }
        }

        private void num_valeur2_ValueChanged(object sender, EventArgs e)
        {
            double valeur1 = 0;
            double valeur2 = 0;

            if (num_valeur1.Text != "")
            {
                valeur1 = Convert.ToDouble(num_valeur1.Text);
            }

            if (num_valeur2.Text != "")
            {
                valeur2 = Convert.ToDouble(num_valeur2.Text);
            }

            if (valeur1 == 0 || valeur2 == 0)
            {

                bu_calc.Enabled = false;

            }
            else
            {
                bu_calc.Enabled = true;
            }
        }

        private void bu_at_Click(object sender, EventArgs e)
        {
            whereAmI = 2;

            l_valeur1.Text = "Base";
            l_valeur2.Text = "Hauteur";

            num_valeur1.Text = "0";
            num_valeur2.Text = "0";

            l_valeur1.Visible = true;
            l_valeur2.Visible = true;
            num_valeur1.Visible = true;
            num_valeur2.Visible = true;
        }

        private void l_result_Click(object sender, EventArgs e)
        {

        }

        private void bu_back_Click(object sender, EventArgs e)
        {
            num_valeur1.Text = "0";
            num_valeur2.Text = "0";

            l_valeur1.Visible = false;
            l_valeur2.Visible = false;
            num_valeur1.Visible = false;
            num_valeur2.Visible = false;

            l_result.Visible = false;
            l_note.Visible = false;
            l_cst.Visible = false;

            bu_aq.Visible = true;
            bu_at.Visible = true;
            bu_cos.Visible = true;
            bu_sin.Visible = true;
            bu_tan.Visible = true;
        }

        private void bu_cos_Click(object sender, EventArgs e)
        {
            l_note.Visible = true;

            bu_aq.Visible = false;
            bu_at.Visible = false;
            bu_cos.Visible = false;
            bu_sin.Visible = false;
            bu_tan.Visible = false;

            bu_back.Enabled = true;
            l_cst.Visible = true;
            du_cst.Visible = true;
        }
    }
}
