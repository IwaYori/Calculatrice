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
            if (whereAmI == 3)
            {
                double angle = Convert.ToInt32(num_valeur2.Text);

                double b = (angle * (Math.PI)) / 180;
                double cosAngle = Math.Cos(b);

                double result = (valeur1 / cosAngle);
                l_result.Text = "Le résultat est : " + Convert.ToString(result) + "cm";
            }
            if (whereAmI == 4)
            {
                double angle = Convert.ToInt32(num_valeur2.Text);

                double b = (angle * (Math.PI)) / 180;
                double cosAngle = Math.Cos(b);

                double result = (valeur1 * cosAngle);
                l_result.Text = "Le résultat est : " + Convert.ToString(result) + "cm";
            }
            if (whereAmI == 5)
            {
                double angle = Convert.ToInt32(num_valeur2.Text);

                double b = (angle * (Math.PI)) / 180;
                double sinAngle = Math.Sin(b);

                double result = (valeur1 / sinAngle);
                l_result.Text = "Le résultat est : " + Convert.ToString(result) + "cm";
            }
            if (whereAmI == 6)
            {
                double angle = Convert.ToInt32(num_valeur2.Text);

                double b = (angle * (Math.PI)) / 180;
                double sinAngle = Math.Sin(b);

                double result = (valeur1 * sinAngle);
                l_result.Text = "Le résultat est : " + Convert.ToString(result) + "cm";
            }
            if (whereAmI == 7)
            {
                double angle = Convert.ToInt32(num_valeur2.Text);

                double b = (angle * (Math.PI)) / 180;
                double tanAngle = Math.Tan(b);

                double result = (valeur1 / tanAngle);
                l_result.Text = "Le résultat est : " + Convert.ToString(result) + "cm";
            }
            if (whereAmI == 8)
            {
                double angle = Convert.ToInt32(num_valeur2.Text);

                double b = (angle * (Math.PI)) / 180;
                double tanAngle = Math.Tan(b);

                double result = (valeur1 * tanAngle);
                l_result.Text = "Le résultat est : " + Convert.ToString(result) + "cm";
            }
            if (whereAmI == 9)
            {
                double r3 = (valeur1 * valeur1 * valeur1);
                double result = (4 / 3) * (Math.PI) * (r3);
                l_result.Text = "Le résultat est : " + Convert.ToString(result) + " cm3";
            }
            if (whereAmI == 10)
            {
                double result =(1 / 3) * (valeur1 * valeur1) * valeur2;
                l_result.Text = "Le résultat est : " + Convert.ToString(result) + " cm3";
            }
            if (whereAmI == 11)
            {
                double result = (valeur1 * valeur1) * Math.PI * valeur2;
                l_result.Text = "Le résultat est : " + Convert.ToString(result) + " cm3";
            }
            if (whereAmI == 12)
            {
                double result = (valeur1) + (valeur2);
                l_result.Text = "Le résultat est : " + Convert.ToString(result);
            }
            if (whereAmI == 13)
            {
                double result = (valeur1) - (valeur2);
                l_result.Text = "Le résultat est : " + Convert.ToString(result);
            }
            if (whereAmI == 14)
            {
                double result = (valeur1) * (valeur2);
                l_result.Text = "Le résultat est : " + Convert.ToString(result);
            }
            if (whereAmI == 15)
            {
                double result = (valeur1) / (valeur2);
                l_result.Text = "Le résultat est : " + Convert.ToString(result);
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
            cb_cst.Visible = false;

            bu_aq.Visible = true;
            bu_at.Visible = true;
            bu_vb.Visible = true;
            bu_cos.Visible = true;
            bu_sin.Visible = true;
            bu_tan.Visible = true;
            bu_vc.Visible = true;

            cb_cst.Items.Clear();
        }

        private void bu_cos_Click(object sender, EventArgs e)
        {
            cb_cst.Items.Clear();
            l_note.Visible = true;

            num_valeur1.Text = "0";
            num_valeur2.Text = "0";

            bu_aq.Visible = false;
            bu_at.Visible = false;
            bu_cos.Visible = false;
            bu_sin.Visible = false;
            bu_tan.Visible = false;
            bu_vb.Visible = false;
            bu_vc.Visible = false;

            bu_back.Enabled = true;
            l_cst.Visible = true;
            l_cst.Text = "Choisissez la longueur connue.";
            cb_cst.Visible = true;

            cb_cst.Items.Add("CA (cos)");
            cb_cst.Items.Add("HYP (cos)");
            cb_cst.SelectedIndex = 0;

            l_valeur1.Visible = true;
            l_valeur2.Visible = true;
            num_valeur1.Visible = true;
            num_valeur2.Visible = true;
        }

        private void cb_cst_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cb_cst.Text == "CA (cos)")
            {
                whereAmI = 3;

                l_valeur1.Text = "Longeur CA";
                l_valeur2.Text = "Angle";
             
                l_valeur1.Visible = true;
                l_valeur2.Visible = true;
            }

            if (cb_cst.Text == "HYP (cos)")
            {
                whereAmI = 4;

                l_valeur1.Text = "Longueur HYP";
                l_valeur2.Text = "Angle";

                l_valeur1.Visible = true;
                l_valeur2.Visible = true;
            }

            if (cb_cst.Text == "CO (sin)")
            {
                whereAmI = 5;

                l_valeur1.Text = "Longeur CO";
                l_valeur2.Text = "Angle";

                l_valeur1.Visible = true;
                l_valeur2.Visible = true;
            }

            if (cb_cst.Text == "HYP (sin)")
            {
                whereAmI = 6;

                l_valeur1.Text = "Longeur HYP";
                l_valeur2.Text = "Angle";

                l_valeur1.Visible = true;
                l_valeur2.Visible = true;
            }

            if (cb_cst.Text == "CO (tan)")
            {
                whereAmI = 7;

                l_valeur1.Text = "Longueur CO";
                l_valeur2.Text = "Angle";

                l_valeur1.Visible = true;
                l_valeur2.Visible = true;
            }

            if (cb_cst.Text == "CA (tan)")
            {
                whereAmI = 8;

                l_valeur1.Text = "Longueur CA";
                l_valeur2.Text = "Angle";

                l_valeur1.Visible = true;
                l_valeur2.Visible = true;
            }

        }

        private void bu_sin_Click(object sender, EventArgs e)
        {
            cb_cst.Items.Clear();
            l_note.Visible = true;

            num_valeur1.Text = "0";
            num_valeur2.Text = "0";

            bu_aq.Visible = false;
            bu_at.Visible = false;
            bu_cos.Visible = false;
            bu_sin.Visible = false;
            bu_tan.Visible = false;
            bu_vb.Visible = false;
            bu_vc.Visible = false;

            bu_back.Enabled = true;
            l_cst.Visible = true;
            l_cst.Text = "Choisissez la longueur connue.";
            cb_cst.Visible = true;

            cb_cst.Items.Add("CO (sin)");
            cb_cst.Items.Add("HYP (sin)");
            cb_cst.SelectedIndex = 0;

            l_valeur1.Visible = true;
            l_valeur2.Visible = true;
            num_valeur1.Visible = true;
            num_valeur2.Visible = true;
        }

        private void bu_tan_Click(object sender, EventArgs e)
        {
            cb_cst.Items.Clear();
            l_note.Visible = true;

            num_valeur1.Text = "0";
            num_valeur2.Text = "0";

            bu_aq.Visible = false;
            bu_at.Visible = false;
            bu_cos.Visible = false;
            bu_sin.Visible = false;
            bu_tan.Visible = false;
            bu_vb.Visible = false;
            
            bu_vc.Visible = false;

            bu_back.Enabled = true;
            l_cst.Visible = true;
            l_cst.Text = "Choisissez la longueur connue.";
            cb_cst.Visible = true;

            cb_cst.Items.Add("CO (tan)");
            cb_cst.Items.Add("CA (tan)");
            cb_cst.SelectedIndex = 0;

            l_valeur1.Visible = true;
            l_valeur2.Visible = true;
            num_valeur1.Visible = true;
            num_valeur2.Visible = true;
        }

        private void lL_github_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/IwaYori/Calculatrice");
        }

        private void bu_vb_Click(object sender, EventArgs e)
        {
            whereAmI = 9;

            l_valeur1.Text = "Rayon";

            num_valeur1.Text = "0";
            num_valeur2.Text = "1";

            l_valeur1.Visible = true;
            l_valeur2.Visible = false;
            num_valeur1.Visible = true;
            num_valeur2.Visible = false;
            bu_back.Enabled = true;
        }



        private void bu_vc_Click(object sender, EventArgs e)
        {
            whereAmI = 11;

            l_valeur1.Text = "Rayon de la base";
            l_valeur2.Text = "Hauteur";

            num_valeur1.Text = "0";
            num_valeur2.Text = "0";

            l_valeur1.Visible = true;
            l_valeur2.Visible = true;
            num_valeur1.Visible = true;
            num_valeur2.Visible = true;
            bu_back.Enabled = true;
        }

        private void num_valeur1_Leave(object sender, EventArgs e)
        {

        }

        private void bu_somm_Click(object sender, EventArgs e)
        {
            whereAmI = 12;

            l_valeur1.Text = "Valeur 1";
            l_valeur2.Text = "Valeur 2";

            num_valeur1.Text = "0";
            num_valeur2.Text = "0";

            l_valeur1.Visible = true;
            l_valeur2.Visible = true;
            num_valeur1.Visible = true;
            num_valeur2.Visible = true;
            bu_back.Enabled = true;
        }

        private void bu_diff_Click(object sender, EventArgs e)
        {
            whereAmI = 13;

            l_valeur1.Text = "Valeur 1";
            l_valeur2.Text = "Valeur 2";

            num_valeur1.Text = "0";
            num_valeur2.Text = "0";

            l_valeur1.Visible = true;
            l_valeur2.Visible = true;
            num_valeur1.Visible = true;
            num_valeur2.Visible = true;
            bu_back.Enabled = true;
        }

        private void bu_prod_Click(object sender, EventArgs e)
        {
            whereAmI = 14;

            l_valeur1.Text = "Valeur 1";
            l_valeur2.Text = "Valeur 2";

            num_valeur1.Text = "0";
            num_valeur2.Text = "0";

            l_valeur1.Visible = true;
            l_valeur2.Visible = true;
            num_valeur1.Visible = true;
            num_valeur2.Visible = true;
            bu_back.Enabled = true;
        }

        private void bu_quo_Click(object sender, EventArgs e)
        {
            whereAmI = 15;

            l_valeur1.Text = "Valeur 1";
            l_valeur2.Text = "Valeur 2";

            num_valeur1.Text = "0";
            num_valeur2.Text = "0";

            l_valeur1.Visible = true;
            l_valeur2.Visible = true;
            num_valeur1.Visible = true;
            num_valeur2.Visible = true;
            bu_back.Enabled = true;
        }
    }
}
