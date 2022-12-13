namespace Projet_sql_server
{
    partial class inscription
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.Commande = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnump = new System.Windows.Forms.TextBox();
            this.txtnumcmd = new System.Windows.Forms.TextBox();
            this.txtnumc = new System.Windows.Forms.TextBox();
            this.txtquantite = new System.Windows.Forms.TextBox();
            this.txtlcmd = new System.Windows.Forms.TextBox();
            this.lbldatecmd = new System.Windows.Forms.Label();
            this.lbllcmd = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnannuler = new System.Windows.Forms.Button();
            this.btnvalider = new System.Windows.Forms.Button();
            this.btnafficher = new System.Windows.Forms.Button();
            this.btnsupprimer = new System.Windows.Forms.Button();
            this.btnmodifier = new System.Windows.Forms.Button();
            this.btnajouter = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dglcmd = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dglcmd)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.Commande);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtnump);
            this.panel1.Controls.Add(this.txtnumcmd);
            this.panel1.Controls.Add(this.txtnumc);
            this.panel1.Controls.Add(this.txtquantite);
            this.panel1.Controls.Add(this.txtlcmd);
            this.panel1.Controls.Add(this.lbldatecmd);
            this.panel1.Controls.Add(this.lbllcmd);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(945, 313);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Commande
            // 
            this.Commande.Location = new System.Drawing.Point(759, 33);
            this.Commande.Name = "Commande";
            this.Commande.Size = new System.Drawing.Size(174, 37);
            this.Commande.TabIndex = 10;
            this.Commande.Text = "Classe";
            this.Commande.UseVisualStyleBackColor = true;
            this.Commande.Click += new System.EventHandler(this.Commande_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Durée";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Date :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "ID classe :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtnump
            // 
            this.txtnump.Location = new System.Drawing.Point(200, 256);
            this.txtnump.Multiline = true;
            this.txtnump.Name = "txtnump";
            this.txtnump.Size = new System.Drawing.Size(231, 30);
            this.txtnump.TabIndex = 6;
            this.txtnump.TextChanged += new System.EventHandler(this.txtnump_TextChanged);
            // 
            // txtnumcmd
            // 
            this.txtnumcmd.Location = new System.Drawing.Point(200, 203);
            this.txtnumcmd.Multiline = true;
            this.txtnumcmd.Name = "txtnumcmd";
            this.txtnumcmd.Size = new System.Drawing.Size(231, 30);
            this.txtnumcmd.TabIndex = 5;
            this.txtnumcmd.TextChanged += new System.EventHandler(this.txtnumcmd_TextChanged);
            // 
            // txtnumc
            // 
            this.txtnumc.Location = new System.Drawing.Point(200, 151);
            this.txtnumc.Multiline = true;
            this.txtnumc.Name = "txtnumc";
            this.txtnumc.Size = new System.Drawing.Size(231, 30);
            this.txtnumc.TabIndex = 4;
            this.txtnumc.TextChanged += new System.EventHandler(this.txtnumc_TextChanged);
            // 
            // txtquantite
            // 
            this.txtquantite.Location = new System.Drawing.Point(200, 96);
            this.txtquantite.Multiline = true;
            this.txtquantite.Name = "txtquantite";
            this.txtquantite.Size = new System.Drawing.Size(231, 33);
            this.txtquantite.TabIndex = 3;
            this.txtquantite.TextChanged += new System.EventHandler(this.txtquantite_TextChanged);
            // 
            // txtlcmd
            // 
            this.txtlcmd.Location = new System.Drawing.Point(200, 40);
            this.txtlcmd.Multiline = true;
            this.txtlcmd.Name = "txtlcmd";
            this.txtlcmd.Size = new System.Drawing.Size(231, 30);
            this.txtlcmd.TabIndex = 2;
            this.txtlcmd.TextChanged += new System.EventHandler(this.txtlcmd_TextChanged);
            // 
            // lbldatecmd
            // 
            this.lbldatecmd.AutoSize = true;
            this.lbldatecmd.Location = new System.Drawing.Point(79, 113);
            this.lbldatecmd.Name = "lbldatecmd";
            this.lbldatecmd.Size = new System.Drawing.Size(76, 16);
            this.lbldatecmd.TabIndex = 1;
            this.lbldatecmd.Text = "ID étudiant :";
            this.lbldatecmd.Click += new System.EventHandler(this.lbldatecmd_Click);
            // 
            // lbllcmd
            // 
            this.lbllcmd.AutoSize = true;
            this.lbllcmd.Location = new System.Drawing.Point(76, 54);
            this.lbllcmd.Name = "lbllcmd";
            this.lbllcmd.Size = new System.Drawing.Size(89, 16);
            this.lbllcmd.TabIndex = 0;
            this.lbllcmd.Text = "ID inscription :";
            this.lbllcmd.Click += new System.EventHandler(this.lbllcmd_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnannuler);
            this.panel2.Controls.Add(this.btnvalider);
            this.panel2.Controls.Add(this.btnafficher);
            this.panel2.Controls.Add(this.btnsupprimer);
            this.panel2.Controls.Add(this.btnmodifier);
            this.panel2.Controls.Add(this.btnajouter);
            this.panel2.Location = new System.Drawing.Point(15, 590);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(945, 97);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnannuler
            // 
            this.btnannuler.Location = new System.Drawing.Point(794, 36);
            this.btnannuler.Name = "btnannuler";
            this.btnannuler.Size = new System.Drawing.Size(123, 39);
            this.btnannuler.TabIndex = 5;
            this.btnannuler.Text = "Annuler";
            this.btnannuler.UseVisualStyleBackColor = true;
            this.btnannuler.Click += new System.EventHandler(this.btnannuler_Click);
            // 
            // btnvalider
            // 
            this.btnvalider.Location = new System.Drawing.Point(637, 36);
            this.btnvalider.Name = "btnvalider";
            this.btnvalider.Size = new System.Drawing.Size(123, 39);
            this.btnvalider.TabIndex = 4;
            this.btnvalider.Text = "Valider";
            this.btnvalider.UseVisualStyleBackColor = true;
            this.btnvalider.Click += new System.EventHandler(this.btnvalider_Click);
            // 
            // btnafficher
            // 
            this.btnafficher.Location = new System.Drawing.Point(480, 36);
            this.btnafficher.Name = "btnafficher";
            this.btnafficher.Size = new System.Drawing.Size(123, 39);
            this.btnafficher.TabIndex = 3;
            this.btnafficher.Text = "Afficher";
            this.btnafficher.UseVisualStyleBackColor = true;
            this.btnafficher.Click += new System.EventHandler(this.btnafficher_Click);
            // 
            // btnsupprimer
            // 
            this.btnsupprimer.Location = new System.Drawing.Point(330, 36);
            this.btnsupprimer.Name = "btnsupprimer";
            this.btnsupprimer.Size = new System.Drawing.Size(123, 39);
            this.btnsupprimer.TabIndex = 2;
            this.btnsupprimer.Text = "Supprimer";
            this.btnsupprimer.UseVisualStyleBackColor = true;
            this.btnsupprimer.Click += new System.EventHandler(this.btnsupprimer_Click);
            // 
            // btnmodifier
            // 
            this.btnmodifier.Location = new System.Drawing.Point(176, 36);
            this.btnmodifier.Name = "btnmodifier";
            this.btnmodifier.Size = new System.Drawing.Size(123, 39);
            this.btnmodifier.TabIndex = 1;
            this.btnmodifier.Text = "Modifier";
            this.btnmodifier.UseVisualStyleBackColor = true;
            this.btnmodifier.Click += new System.EventHandler(this.btnmodifier_Click);
            // 
            // btnajouter
            // 
            this.btnajouter.Location = new System.Drawing.Point(28, 36);
            this.btnajouter.Name = "btnajouter";
            this.btnajouter.Size = new System.Drawing.Size(123, 39);
            this.btnajouter.TabIndex = 0;
            this.btnajouter.Text = "Ajouter";
            this.btnajouter.UseVisualStyleBackColor = true;
            this.btnajouter.Click += new System.EventHandler(this.btnajouter_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dglcmd);
            this.panel3.Location = new System.Drawing.Point(12, 328);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(945, 256);
            this.panel3.TabIndex = 4;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // dglcmd
            // 
            this.dglcmd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dglcmd.Location = new System.Drawing.Point(3, 3);
            this.dglcmd.Name = "dglcmd";
            this.dglcmd.RowHeadersWidth = 51;
            this.dglcmd.RowTemplate.Height = 24;
            this.dglcmd.Size = new System.Drawing.Size(945, 245);
            this.dglcmd.TabIndex = 0;
            this.dglcmd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dglcmd_CellContentClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(759, 76);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 37);
            this.button1.TabIndex = 11;
            this.button1.Text = "Etudiant";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // inscription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(985, 688);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Name = "inscription";
            this.Text = "LigneCommande";
            this.Load += new System.EventHandler(this.LigneCommande_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dglcmd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnump;
        private System.Windows.Forms.TextBox txtnumcmd;
        private System.Windows.Forms.TextBox txtnumc;
        private System.Windows.Forms.TextBox txtquantite;
        private System.Windows.Forms.TextBox txtlcmd;
        private System.Windows.Forms.Label lbldatecmd;
        private System.Windows.Forms.Label lbllcmd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnannuler;
        private System.Windows.Forms.Button btnvalider;
        private System.Windows.Forms.Button btnafficher;
        private System.Windows.Forms.Button btnsupprimer;
        private System.Windows.Forms.Button btnmodifier;
        private System.Windows.Forms.Button btnajouter;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dglcmd;
        private System.Windows.Forms.Button Commande;
        private System.Windows.Forms.Button button1;
    }
}