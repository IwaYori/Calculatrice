
namespace Calculatrice
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bu_aq = new System.Windows.Forms.Button();
            this.l_valeur1 = new System.Windows.Forms.Label();
            this.l_valeur2 = new System.Windows.Forms.Label();
            this.bu_calc = new System.Windows.Forms.Button();
            this.l_result = new System.Windows.Forms.Label();
            this.num_valeur1 = new System.Windows.Forms.NumericUpDown();
            this.num_valeur2 = new System.Windows.Forms.NumericUpDown();
            this.bu_at = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.bu_cos = new System.Windows.Forms.Button();
            this.bu_sin = new System.Windows.Forms.Button();
            this.bu_tan = new System.Windows.Forms.Button();
            this.bu_back = new System.Windows.Forms.Button();
            this.cb_cst = new System.Windows.Forms.ComboBox();
            this.lL_github = new System.Windows.Forms.LinkLabel();
            this.l_note = new System.Windows.Forms.Label();
            this.l_cst = new System.Windows.Forms.Label();
            this.bu_vb = new System.Windows.Forms.Button();
            this.bu_vpbc = new System.Windows.Forms.Button();
            this.l_valeur3 = new System.Windows.Forms.Label();
            this.num_valeur3 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.num_valeur1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_valeur2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_valeur3)).BeginInit();
            this.SuspendLayout();
            // 
            // bu_aq
            // 
            this.bu_aq.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bu_aq.Location = new System.Drawing.Point(0, 0);
            this.bu_aq.Name = "bu_aq";
            this.bu_aq.Size = new System.Drawing.Size(153, 44);
            this.bu_aq.TabIndex = 0;
            this.bu_aq.Text = "Aire quadrilatère";
            this.toolTip1.SetToolTip(this.bu_aq, "Permet de calculer une aire d\'un quadrilatère");
            this.bu_aq.UseVisualStyleBackColor = true;
            this.bu_aq.Click += new System.EventHandler(this.bu_aq_Click);
            // 
            // l_valeur1
            // 
            this.l_valeur1.AutoSize = true;
            this.l_valeur1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_valeur1.Location = new System.Drawing.Point(64, 153);
            this.l_valeur1.Name = "l_valeur1";
            this.l_valeur1.Size = new System.Drawing.Size(60, 24);
            this.l_valeur1.TabIndex = 1;
            this.l_valeur1.Text = "label1";
            this.l_valeur1.Visible = false;
            // 
            // l_valeur2
            // 
            this.l_valeur2.AutoSize = true;
            this.l_valeur2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_valeur2.Location = new System.Drawing.Point(64, 194);
            this.l_valeur2.Name = "l_valeur2";
            this.l_valeur2.Size = new System.Drawing.Size(60, 24);
            this.l_valeur2.TabIndex = 2;
            this.l_valeur2.Text = "label2";
            this.l_valeur2.Visible = false;
            // 
            // bu_calc
            // 
            this.bu_calc.BackColor = System.Drawing.SystemColors.Info;
            this.bu_calc.Enabled = false;
            this.bu_calc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bu_calc.Location = new System.Drawing.Point(700, 461);
            this.bu_calc.Name = "bu_calc";
            this.bu_calc.Size = new System.Drawing.Size(96, 44);
            this.bu_calc.TabIndex = 5;
            this.bu_calc.Text = "Calc";
            this.toolTip1.SetToolTip(this.bu_calc, "Bouton \"Calculer\"");
            this.bu_calc.UseVisualStyleBackColor = false;
            this.bu_calc.Click += new System.EventHandler(this.bu_calc_Click);
            // 
            // l_result
            // 
            this.l_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_result.Location = new System.Drawing.Point(63, 328);
            this.l_result.Name = "l_result";
            this.l_result.Size = new System.Drawing.Size(473, 52);
            this.l_result.TabIndex = 0;
            this.l_result.Click += new System.EventHandler(this.l_result_Click);
            // 
            // num_valeur1
            // 
            this.num_valeur1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_valeur1.Location = new System.Drawing.Point(272, 151);
            this.num_valeur1.Name = "num_valeur1";
            this.num_valeur1.Size = new System.Drawing.Size(120, 29);
            this.num_valeur1.TabIndex = 6;
            this.toolTip1.SetToolTip(this.num_valeur1, "Entre ton nombre ici");
            this.num_valeur1.Visible = false;
            this.num_valeur1.ValueChanged += new System.EventHandler(this.num_valeur1_ValueChanged);
            // 
            // num_valeur2
            // 
            this.num_valeur2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_valeur2.Location = new System.Drawing.Point(272, 192);
            this.num_valeur2.Name = "num_valeur2";
            this.num_valeur2.Size = new System.Drawing.Size(120, 29);
            this.num_valeur2.TabIndex = 7;
            this.toolTip1.SetToolTip(this.num_valeur2, "Entre ton nombre ici");
            this.num_valeur2.Visible = false;
            this.num_valeur2.ValueChanged += new System.EventHandler(this.num_valeur2_ValueChanged);
            // 
            // bu_at
            // 
            this.bu_at.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bu_at.Location = new System.Drawing.Point(159, 0);
            this.bu_at.Name = "bu_at";
            this.bu_at.Size = new System.Drawing.Size(123, 44);
            this.bu_at.TabIndex = 8;
            this.bu_at.Text = "Aire triangle";
            this.toolTip1.SetToolTip(this.bu_at, "Permet de calculer l\'aire d\'un triangle");
            this.bu_at.UseVisualStyleBackColor = true;
            this.bu_at.Click += new System.EventHandler(this.bu_at_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // bu_cos
            // 
            this.bu_cos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bu_cos.Location = new System.Drawing.Point(640, 0);
            this.bu_cos.Name = "bu_cos";
            this.bu_cos.Size = new System.Drawing.Size(48, 44);
            this.bu_cos.TabIndex = 12;
            this.bu_cos.Text = "cos";
            this.toolTip1.SetToolTip(this.bu_cos, "Permet de calculer avec le cosinus");
            this.bu_cos.UseVisualStyleBackColor = true;
            this.bu_cos.Click += new System.EventHandler(this.bu_cos_Click);
            // 
            // bu_sin
            // 
            this.bu_sin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bu_sin.Location = new System.Drawing.Point(694, 0);
            this.bu_sin.Name = "bu_sin";
            this.bu_sin.Size = new System.Drawing.Size(48, 44);
            this.bu_sin.TabIndex = 13;
            this.bu_sin.Text = "sin";
            this.toolTip1.SetToolTip(this.bu_sin, "Permet de calculer avec le sinus");
            this.bu_sin.UseVisualStyleBackColor = true;
            this.bu_sin.Click += new System.EventHandler(this.bu_sin_Click);
            // 
            // bu_tan
            // 
            this.bu_tan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bu_tan.Location = new System.Drawing.Point(748, 0);
            this.bu_tan.Name = "bu_tan";
            this.bu_tan.Size = new System.Drawing.Size(48, 44);
            this.bu_tan.TabIndex = 14;
            this.bu_tan.Text = "tan";
            this.toolTip1.SetToolTip(this.bu_tan, "Permet de calculer la tangente");
            this.bu_tan.UseVisualStyleBackColor = true;
            this.bu_tan.Click += new System.EventHandler(this.bu_tan_Click);
            // 
            // bu_back
            // 
            this.bu_back.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bu_back.Enabled = false;
            this.bu_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bu_back.Location = new System.Drawing.Point(12, 461);
            this.bu_back.Name = "bu_back";
            this.bu_back.Size = new System.Drawing.Size(96, 44);
            this.bu_back.TabIndex = 9;
            this.bu_back.Text = "Retour";
            this.toolTip1.SetToolTip(this.bu_back, "Permet de revenir au menu de base");
            this.bu_back.UseVisualStyleBackColor = false;
            this.bu_back.Click += new System.EventHandler(this.bu_back_Click);
            // 
            // cb_cst
            // 
            this.cb_cst.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_cst.FormattingEnabled = true;
            this.cb_cst.Location = new System.Drawing.Point(612, 113);
            this.cb_cst.Name = "cb_cst";
            this.cb_cst.Size = new System.Drawing.Size(156, 28);
            this.cb_cst.TabIndex = 19;
            this.toolTip1.SetToolTip(this.cb_cst, "Choisis la longueur connue");
            this.cb_cst.Visible = false;
            this.cb_cst.SelectedIndexChanged += new System.EventHandler(this.cb_cst_SelectedIndexChanged);
            // 
            // lL_github
            // 
            this.lL_github.AutoSize = true;
            this.lL_github.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lL_github.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lL_github.Location = new System.Drawing.Point(645, 478);
            this.lL_github.Name = "lL_github";
            this.lL_github.Size = new System.Drawing.Size(49, 16);
            this.lL_github.TabIndex = 20;
            this.lL_github.TabStop = true;
            this.lL_github.Text = "GitHub";
            this.toolTip1.SetToolTip(this.lL_github, "Lien du GitHub du programme");
            this.lL_github.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lL_github_LinkClicked);
            // 
            // l_note
            // 
            this.l_note.AutoSize = true;
            this.l_note.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_note.ForeColor = System.Drawing.Color.Gray;
            this.l_note.Location = new System.Drawing.Point(560, 360);
            this.l_note.Name = "l_note";
            this.l_note.Size = new System.Drawing.Size(51, 20);
            this.l_note.TabIndex = 15;
            this.l_note.Text = "label1";
            this.l_note.Visible = false;
            // 
            // l_cst
            // 
            this.l_cst.AutoSize = true;
            this.l_cst.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_cst.Location = new System.Drawing.Point(581, 71);
            this.l_cst.Name = "l_cst";
            this.l_cst.Size = new System.Drawing.Size(46, 18);
            this.l_cst.TabIndex = 17;
            this.l_cst.Text = "label1";
            this.l_cst.Visible = false;
            // 
            // bu_vb
            // 
            this.bu_vb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bu_vb.Location = new System.Drawing.Point(288, 0);
            this.bu_vb.Name = "bu_vb";
            this.bu_vb.Size = new System.Drawing.Size(123, 44);
            this.bu_vb.TabIndex = 21;
            this.bu_vb.Text = "Volume boule";
            this.toolTip1.SetToolTip(this.bu_vb, "Permet de calculer le volume d\'une boule");
            this.bu_vb.UseVisualStyleBackColor = true;
            this.bu_vb.Click += new System.EventHandler(this.bu_vb_Click);
            // 
            // bu_vpbc
            // 
            this.bu_vpbc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bu_vpbc.Location = new System.Drawing.Point(417, 0);
            this.bu_vpbc.Name = "bu_vpbc";
            this.bu_vpbc.Size = new System.Drawing.Size(149, 44);
            this.bu_vpbc.TabIndex = 22;
            this.bu_vpbc.Text = "Vol. Py. base carré";
            this.toolTip1.SetToolTip(this.bu_vpbc, "Permet de calculer le volume d\'une pyramide à base carré");
            this.bu_vpbc.UseVisualStyleBackColor = true;
            this.bu_vpbc.Click += new System.EventHandler(this.bu_vpbc_Click);
            // 
            // l_valeur3
            // 
            this.l_valeur3.AutoSize = true;
            this.l_valeur3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_valeur3.Location = new System.Drawing.Point(64, 233);
            this.l_valeur3.Name = "l_valeur3";
            this.l_valeur3.Size = new System.Drawing.Size(60, 24);
            this.l_valeur3.TabIndex = 23;
            this.l_valeur3.Text = "label1";
            this.l_valeur3.Visible = false;
            // 
            // num_valeur3
            // 
            this.num_valeur3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_valeur3.Location = new System.Drawing.Point(272, 233);
            this.num_valeur3.Name = "num_valeur3";
            this.num_valeur3.Size = new System.Drawing.Size(120, 29);
            this.num_valeur3.TabIndex = 24;
            this.toolTip1.SetToolTip(this.num_valeur3, "Entre ton nombre ici");
            this.num_valeur3.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 517);
            this.Controls.Add(this.num_valeur3);
            this.Controls.Add(this.l_valeur3);
            this.Controls.Add(this.bu_vpbc);
            this.Controls.Add(this.bu_vb);
            this.Controls.Add(this.lL_github);
            this.Controls.Add(this.cb_cst);
            this.Controls.Add(this.l_cst);
            this.Controls.Add(this.l_note);
            this.Controls.Add(this.bu_tan);
            this.Controls.Add(this.bu_sin);
            this.Controls.Add(this.bu_cos);
            this.Controls.Add(this.bu_back);
            this.Controls.Add(this.bu_at);
            this.Controls.Add(this.num_valeur2);
            this.Controls.Add(this.num_valeur1);
            this.Controls.Add(this.l_result);
            this.Controls.Add(this.bu_calc);
            this.Controls.Add(this.l_valeur2);
            this.Controls.Add(this.l_valeur1);
            this.Controls.Add(this.bu_aq);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_valeur1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_valeur2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_valeur3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bu_aq;
        private System.Windows.Forms.Label l_valeur1;
        private System.Windows.Forms.Label l_valeur2;
        private System.Windows.Forms.Button bu_calc;
        private System.Windows.Forms.Label l_result;
        private System.Windows.Forms.NumericUpDown num_valeur1;
        private System.Windows.Forms.NumericUpDown num_valeur2;
        private System.Windows.Forms.Button bu_at;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button bu_back;
        private System.Windows.Forms.Button bu_cos;
        private System.Windows.Forms.Button bu_sin;
        private System.Windows.Forms.Button bu_tan;
        private System.Windows.Forms.Label l_note;
        private System.Windows.Forms.Label l_cst;
        private System.Windows.Forms.ComboBox cb_cst;
        private System.Windows.Forms.LinkLabel lL_github;
        private System.Windows.Forms.Button bu_vb;
        private System.Windows.Forms.Button bu_vpbc;
        private System.Windows.Forms.Label l_valeur3;
        private System.Windows.Forms.NumericUpDown num_valeur3;
    }
}

