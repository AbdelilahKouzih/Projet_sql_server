﻿namespace Projet_sql_server
{
    partial class Etudiant
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
            this.dglcmd = new System.Windows.Forms.DataGridView();
            this.btnajouter = new System.Windows.Forms.Button();
            this.Commande = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnumcmd = new System.Windows.Forms.TextBox();
            this.txtnumc = new System.Windows.Forms.TextBox();
            this.btnvalider = new System.Windows.Forms.Button();
            this.btnafficher = new System.Windows.Forms.Button();
            this.btnsupprimer = new System.Windows.Forms.Button();
            this.btnmodifier = new System.Windows.Forms.Button();
            this.txtquantite = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnannuler = new System.Windows.Forms.Button();
            this.lbllcmd = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtlcmd = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbldatecmd = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dglcmd)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dglcmd
            // 
            this.dglcmd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dglcmd.Location = new System.Drawing.Point(0, 0);
            this.dglcmd.Name = "dglcmd";
            this.dglcmd.RowHeadersWidth = 51;
            this.dglcmd.RowTemplate.Height = 24;
            this.dglcmd.Size = new System.Drawing.Size(948, 230);
            this.dglcmd.TabIndex = 0;
            // 
            // btnajouter
            // 
            this.btnajouter.Location = new System.Drawing.Point(28, 36);
            this.btnajouter.Name = "btnajouter";
            this.btnajouter.Size = new System.Drawing.Size(123, 39);
            this.btnajouter.TabIndex = 0;
            this.btnajouter.Text = "Ajouter";
            this.btnajouter.UseVisualStyleBackColor = true;
            this.btnajouter.Click += new System.EventHandler(this.btnajouter_Click_1);
            // 
            // Commande
            // 
            this.Commande.Location = new System.Drawing.Point(759, 33);
            this.Commande.Name = "Commande";
            this.Commande.Size = new System.Drawing.Size(174, 37);
            this.Commande.TabIndex = 10;
            this.Commande.Text = "Classe";
            this.Commande.UseVisualStyleBackColor = true;
            this.Commande.Click += new System.EventHandler(this.Commande_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 217);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Age :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(79, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Prénom :";
            // 
            // txtnumcmd
            // 
            this.txtnumcmd.Location = new System.Drawing.Point(200, 203);
            this.txtnumcmd.Multiline = true;
            this.txtnumcmd.Name = "txtnumcmd";
            this.txtnumcmd.Size = new System.Drawing.Size(231, 30);
            this.txtnumcmd.TabIndex = 5;
            // 
            // txtnumc
            // 
            this.txtnumc.Location = new System.Drawing.Point(200, 151);
            this.txtnumc.Multiline = true;
            this.txtnumc.Name = "txtnumc";
            this.txtnumc.Size = new System.Drawing.Size(231, 30);
            this.txtnumc.TabIndex = 4;
            // 
            // btnvalider
            // 
            this.btnvalider.Location = new System.Drawing.Point(637, 36);
            this.btnvalider.Name = "btnvalider";
            this.btnvalider.Size = new System.Drawing.Size(123, 39);
            this.btnvalider.TabIndex = 4;
            this.btnvalider.Text = "Valider";
            this.btnvalider.UseVisualStyleBackColor = true;
            this.btnvalider.Click += new System.EventHandler(this.btnvalider_Click_1);
            // 
            // btnafficher
            // 
            this.btnafficher.Location = new System.Drawing.Point(480, 36);
            this.btnafficher.Name = "btnafficher";
            this.btnafficher.Size = new System.Drawing.Size(123, 39);
            this.btnafficher.TabIndex = 3;
            this.btnafficher.Text = "Afficher";
            this.btnafficher.UseVisualStyleBackColor = true;
            this.btnafficher.Click += new System.EventHandler(this.btnafficher_Click_1);
            // 
            // btnsupprimer
            // 
            this.btnsupprimer.Location = new System.Drawing.Point(330, 36);
            this.btnsupprimer.Name = "btnsupprimer";
            this.btnsupprimer.Size = new System.Drawing.Size(123, 39);
            this.btnsupprimer.TabIndex = 2;
            this.btnsupprimer.Text = "Supprimer";
            this.btnsupprimer.UseVisualStyleBackColor = true;
            this.btnsupprimer.Click += new System.EventHandler(this.btnsupprimer_Click_1);
            // 
            // btnmodifier
            // 
            this.btnmodifier.Location = new System.Drawing.Point(176, 36);
            this.btnmodifier.Name = "btnmodifier";
            this.btnmodifier.Size = new System.Drawing.Size(123, 39);
            this.btnmodifier.TabIndex = 1;
            this.btnmodifier.Text = "Modifier";
            this.btnmodifier.UseVisualStyleBackColor = true;
            this.btnmodifier.Click += new System.EventHandler(this.btnmodifier_Click_1);
            // 
            // txtquantite
            // 
            this.txtquantite.Location = new System.Drawing.Point(200, 96);
            this.txtquantite.Multiline = true;
            this.txtquantite.Name = "txtquantite";
            this.txtquantite.Size = new System.Drawing.Size(231, 33);
            this.txtquantite.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnannuler);
            this.panel2.Controls.Add(this.btnvalider);
            this.panel2.Controls.Add(this.btnafficher);
            this.panel2.Controls.Add(this.btnsupprimer);
            this.panel2.Controls.Add(this.btnmodifier);
            this.panel2.Controls.Add(this.btnajouter);
            this.panel2.Location = new System.Drawing.Point(12, 569);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(936, 97);
            this.panel2.TabIndex = 6;
            // 
            // btnannuler
            // 
            this.btnannuler.Location = new System.Drawing.Point(794, 36);
            this.btnannuler.Name = "btnannuler";
            this.btnannuler.Size = new System.Drawing.Size(123, 39);
            this.btnannuler.TabIndex = 5;
            this.btnannuler.Text = "Annuler";
            this.btnannuler.UseVisualStyleBackColor = true;
            this.btnannuler.Click += new System.EventHandler(this.btnannuler_Click_1);
            // 
            // lbllcmd
            // 
            this.lbllcmd.AutoSize = true;
            this.lbllcmd.Location = new System.Drawing.Point(76, 54);
            this.lbllcmd.Name = "lbllcmd";
            this.lbllcmd.Size = new System.Drawing.Size(77, 16);
            this.lbllcmd.TabIndex = 0;
            this.lbllcmd.Text = "ID Etudiant :";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dglcmd);
            this.panel3.Location = new System.Drawing.Point(0, 318);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(945, 230);
            this.panel3.TabIndex = 7;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.Commande);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtnumcmd);
            this.panel1.Controls.Add(this.txtnumc);
            this.panel1.Controls.Add(this.txtquantite);
            this.panel1.Controls.Add(this.txtlcmd);
            this.panel1.Controls.Add(this.lbldatecmd);
            this.panel1.Controls.Add(this.lbllcmd);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(945, 313);
            this.panel1.TabIndex = 5;
            // 
            // lbldatecmd
            // 
            this.lbldatecmd.AutoSize = true;
            this.lbldatecmd.Location = new System.Drawing.Point(79, 113);
            this.lbldatecmd.Name = "lbldatecmd";
            this.lbldatecmd.Size = new System.Drawing.Size(42, 16);
            this.lbldatecmd.TabIndex = 1;
            this.lbldatecmd.Text = "Nom :";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(759, 76);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 37);
            this.button2.TabIndex = 12;
            this.button2.Text = "Inscription";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Etudiant
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 678);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "Etudiant";
            this.Text = "Etudiant";
            this.Load += new System.EventHandler(this.Etudiant_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dglcmd)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dglcmd;
        private System.Windows.Forms.Button btnajouter;
        private System.Windows.Forms.Button Commande;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnumcmd;
        private System.Windows.Forms.TextBox txtnumc;
        private System.Windows.Forms.Button btnvalider;
        private System.Windows.Forms.Button btnafficher;
        private System.Windows.Forms.Button btnsupprimer;
        private System.Windows.Forms.Button btnmodifier;
        private System.Windows.Forms.TextBox txtquantite;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnannuler;
        private System.Windows.Forms.Label lbllcmd;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtlcmd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbldatecmd;
        private System.Windows.Forms.Button button2;
    }
}