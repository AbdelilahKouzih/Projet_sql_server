namespace Projet_sql_server
{
    partial class Commande
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblcmd = new System.Windows.Forms.Label();
            this.lbldatecmd = new System.Windows.Forms.Label();
            this.txtcmd = new System.Windows.Forms.TextBox();
            this.txtdatecmd = new System.Windows.Forms.TextBox();
            this.dgcmd = new System.Windows.Forms.DataGridView();
            this.btnajouter = new System.Windows.Forms.Button();
            this.btnmodifier = new System.Windows.Forms.Button();
            this.btnsupprimer = new System.Windows.Forms.Button();
            this.btnafficher = new System.Windows.Forms.Button();
            this.btnvalider = new System.Windows.Forms.Button();
            this.btnannuler = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgcmd)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtdatecmd);
            this.panel1.Controls.Add(this.txtcmd);
            this.panel1.Controls.Add(this.lbldatecmd);
            this.panel1.Controls.Add(this.lblcmd);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(945, 217);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnannuler);
            this.panel2.Controls.Add(this.btnvalider);
            this.panel2.Controls.Add(this.btnafficher);
            this.panel2.Controls.Add(this.btnsupprimer);
            this.panel2.Controls.Add(this.btnmodifier);
            this.panel2.Controls.Add(this.btnajouter);
            this.panel2.Location = new System.Drawing.Point(6, 491);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(945, 97);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dgcmd);
            this.panel3.Location = new System.Drawing.Point(6, 229);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(945, 256);
            this.panel3.TabIndex = 1;
            // 
            // lblcmd
            // 
            this.lblcmd.AutoSize = true;
            this.lblcmd.Location = new System.Drawing.Point(76, 54);
            this.lblcmd.Name = "lblcmd";
            this.lblcmd.Size = new System.Drawing.Size(94, 16);
            this.lblcmd.TabIndex = 0;
            this.lblcmd.Text = "Numéro CMD :";
            // 
            // lbldatecmd
            // 
            this.lbldatecmd.AutoSize = true;
            this.lbldatecmd.Location = new System.Drawing.Point(76, 103);
            this.lbldatecmd.Name = "lbldatecmd";
            this.lbldatecmd.Size = new System.Drawing.Size(75, 16);
            this.lbldatecmd.TabIndex = 1;
            this.lbldatecmd.Text = "Date CMD :";
            // 
            // txtcmd
            // 
            this.txtcmd.Location = new System.Drawing.Point(190, 34);
            this.txtcmd.Multiline = true;
            this.txtcmd.Name = "txtcmd";
            this.txtcmd.Size = new System.Drawing.Size(231, 36);
            this.txtcmd.TabIndex = 2;
            // 
            // txtdatecmd
            // 
            this.txtdatecmd.Location = new System.Drawing.Point(190, 93);
            this.txtdatecmd.Multiline = true;
            this.txtdatecmd.Name = "txtdatecmd";
            this.txtdatecmd.Size = new System.Drawing.Size(231, 36);
            this.txtdatecmd.TabIndex = 3;
            // 
            // dgcmd
            // 
            this.dgcmd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgcmd.Location = new System.Drawing.Point(7, 5);
            this.dgcmd.Name = "dgcmd";
            this.dgcmd.RowHeadersWidth = 51;
            this.dgcmd.RowTemplate.Height = 24;
            this.dgcmd.Size = new System.Drawing.Size(938, 248);
            this.dgcmd.TabIndex = 0;
            // 
            // btnajouter
            // 
            this.btnajouter.Location = new System.Drawing.Point(28, 36);
            this.btnajouter.Name = "btnajouter";
            this.btnajouter.Size = new System.Drawing.Size(123, 39);
            this.btnajouter.TabIndex = 0;
            this.btnajouter.Text = "Ajouter";
            this.btnajouter.UseVisualStyleBackColor = true;
            // 
            // btnmodifier
            // 
            this.btnmodifier.Location = new System.Drawing.Point(176, 36);
            this.btnmodifier.Name = "btnmodifier";
            this.btnmodifier.Size = new System.Drawing.Size(123, 39);
            this.btnmodifier.TabIndex = 1;
            this.btnmodifier.Text = "Modifier";
            this.btnmodifier.UseVisualStyleBackColor = true;
            // 
            // btnsupprimer
            // 
            this.btnsupprimer.Location = new System.Drawing.Point(330, 36);
            this.btnsupprimer.Name = "btnsupprimer";
            this.btnsupprimer.Size = new System.Drawing.Size(123, 39);
            this.btnsupprimer.TabIndex = 2;
            this.btnsupprimer.Text = "Supprimer";
            this.btnsupprimer.UseVisualStyleBackColor = true;
            // 
            // btnafficher
            // 
            this.btnafficher.Location = new System.Drawing.Point(480, 36);
            this.btnafficher.Name = "btnafficher";
            this.btnafficher.Size = new System.Drawing.Size(123, 39);
            this.btnafficher.TabIndex = 3;
            this.btnafficher.Text = "Afficher";
            this.btnafficher.UseVisualStyleBackColor = true;
            // 
            // btnvalider
            // 
            this.btnvalider.Location = new System.Drawing.Point(637, 36);
            this.btnvalider.Name = "btnvalider";
            this.btnvalider.Size = new System.Drawing.Size(123, 39);
            this.btnvalider.TabIndex = 4;
            this.btnvalider.Text = "Valider";
            this.btnvalider.UseVisualStyleBackColor = true;
            // 
            // btnannuler
            // 
            this.btnannuler.Location = new System.Drawing.Point(794, 36);
            this.btnannuler.Name = "btnannuler";
            this.btnannuler.Size = new System.Drawing.Size(123, 39);
            this.btnannuler.TabIndex = 5;
            this.btnannuler.Text = "Annuler";
            this.btnannuler.UseVisualStyleBackColor = true;
            // 
            // Commande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 600);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Commande";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgcmd)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtdatecmd;
        private System.Windows.Forms.TextBox txtcmd;
        private System.Windows.Forms.Label lbldatecmd;
        private System.Windows.Forms.Label lblcmd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnannuler;
        private System.Windows.Forms.Button btnvalider;
        private System.Windows.Forms.Button btnafficher;
        private System.Windows.Forms.Button btnsupprimer;
        private System.Windows.Forms.Button btnmodifier;
        private System.Windows.Forms.Button btnajouter;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DataGridView dgcmd;
    }
}

