﻿namespace Sagrado
{
    partial class MenuAdm
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnComanda = new System.Windows.Forms.Button();
            this.btnControle = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pnControle = new Sagrado.Controle();
            this.pnComanda = new Sagrado.Comanda();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnComanda);
            this.panel1.Location = new System.Drawing.Point(26, 180);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(179, 166);
            this.panel1.TabIndex = 10;
            // 
            // btnComanda
            // 
            this.btnComanda.BackColor = System.Drawing.Color.White;
            this.btnComanda.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComanda.ForeColor = System.Drawing.Color.Black;
            this.btnComanda.Location = new System.Drawing.Point(0, 0);
            this.btnComanda.Name = "btnComanda";
            this.btnComanda.Size = new System.Drawing.Size(179, 80);
            this.btnComanda.TabIndex = 2;
            this.btnComanda.Text = "Comanda";
            this.btnComanda.UseVisualStyleBackColor = false;
            this.btnComanda.Click += new System.EventHandler(this.btnComanda_Click);
            // 
            // btnControle
            // 
            this.btnControle.BackColor = System.Drawing.Color.White;
            this.btnControle.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnControle.ForeColor = System.Drawing.Color.Black;
            this.btnControle.Location = new System.Drawing.Point(26, 266);
            this.btnControle.Name = "btnControle";
            this.btnControle.Size = new System.Drawing.Size(179, 80);
            this.btnControle.TabIndex = 3;
            this.btnControle.Text = "Controle";
            this.btnControle.UseVisualStyleBackColor = false;
            this.btnControle.Click += new System.EventHandler(this.btnControle_Click);
            // 
            // pnControle
            // 
            this.pnControle.BackColor = System.Drawing.Color.White;
            this.pnControle.Location = new System.Drawing.Point(262, 12);
            this.pnControle.Name = "pnControle";
            this.pnControle.Size = new System.Drawing.Size(498, 461);
            this.pnControle.TabIndex = 12;
            this.pnControle.Load += new System.EventHandler(this.pnControle_Load);
            // 
            // pnComanda
            // 
            this.pnComanda.BackColor = System.Drawing.Color.White;
            this.pnComanda.Location = new System.Drawing.Point(249, 132);
            this.pnComanda.Name = "pnComanda";
            this.pnComanda.Size = new System.Drawing.Size(498, 299);
            this.pnComanda.TabIndex = 11;
            this.pnComanda.Load += new System.EventHandler(this.pnComanda_Load);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Colonna MT", 32.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 46);
            this.label2.TabIndex = 13;
            this.label2.Text = "Restaurante";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Colonna MT", 32.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(64, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 46);
            this.label3.TabIndex = 14;
            this.label3.Text = "Sagrado";
            // 
            // MenuAdm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnControle);
            this.Controls.Add(this.pnComanda);
            this.Controls.Add(this.btnControle);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.HelpButton = true;
            this.Name = "MenuAdm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MenuAdm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnControle;
        private System.Windows.Forms.Button btnComanda;
        private Comanda pnComanda;
        private Controle pnControle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}