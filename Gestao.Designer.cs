﻿namespace TelasDesktopPIM
{
    partial class Gestao
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
            this.buttonSair = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonVendas = new System.Windows.Forms.Button();
            this.buttonGestão = new System.Windows.Forms.Button();
            this.labelGestao = new System.Windows.Forms.Label();
            this.buttonGerClient = new System.Windows.Forms.Button();
            this.buttonGerProdut = new System.Windows.Forms.Button();
            this.buttonGerProducao = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGreen;
            this.panel1.Controls.Add(this.buttonSair);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.buttonVendas);
            this.panel1.Controls.Add(this.buttonGestão);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 63);
            this.panel1.TabIndex = 3;
            // 
            // buttonSair
            // 
            this.buttonSair.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonSair.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSair.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonSair.Location = new System.Drawing.Point(759, 22);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(39, 26);
            this.buttonSair.TabIndex = 5;
            this.buttonSair.Text = "Sair";
            this.buttonSair.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TelasDesktopPIM.Properties.Resources.LogoHorizontal_250;
            this.pictureBox1.Location = new System.Drawing.Point(18, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(232, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // buttonVendas
            // 
            this.buttonVendas.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonVendas.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVendas.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonVendas.Location = new System.Drawing.Point(438, 17);
            this.buttonVendas.Name = "buttonVendas";
            this.buttonVendas.Size = new System.Drawing.Size(121, 31);
            this.buttonVendas.TabIndex = 3;
            this.buttonVendas.Text = "Vendas";
            this.buttonVendas.UseVisualStyleBackColor = false;
            this.buttonVendas.Click += new System.EventHandler(this.buttonVendas_Click);
            // 
            // buttonGestão
            // 
            this.buttonGestão.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonGestão.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGestão.ForeColor = System.Drawing.SystemColors.Control;
            this.buttonGestão.Location = new System.Drawing.Point(269, 17);
            this.buttonGestão.Name = "buttonGestão";
            this.buttonGestão.Size = new System.Drawing.Size(121, 31);
            this.buttonGestão.TabIndex = 1;
            this.buttonGestão.Text = "Gestão";
            this.buttonGestão.UseVisualStyleBackColor = false;
            this.buttonGestão.Click += new System.EventHandler(this.buttonGestão_Click);
            // 
            // labelGestao
            // 
            this.labelGestao.AutoSize = true;
            this.labelGestao.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGestao.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelGestao.Location = new System.Drawing.Point(313, 100);
            this.labelGestao.Name = "labelGestao";
            this.labelGestao.Size = new System.Drawing.Size(96, 28);
            this.labelGestao.TabIndex = 4;
            this.labelGestao.Text = "Gestão";
            // 
            // buttonGerClient
            // 
            this.buttonGerClient.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonGerClient.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGerClient.ForeColor = System.Drawing.Color.Snow;
            this.buttonGerClient.Location = new System.Drawing.Point(283, 178);
            this.buttonGerClient.Name = "buttonGerClient";
            this.buttonGerClient.Size = new System.Drawing.Size(159, 23);
            this.buttonGerClient.TabIndex = 6;
            this.buttonGerClient.Text = "Gerenciar Clientes";
            this.buttonGerClient.UseVisualStyleBackColor = false;
            this.buttonGerClient.Click += new System.EventHandler(this.buttonGerClient_Click);
            // 
            // buttonGerProdut
            // 
            this.buttonGerProdut.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonGerProdut.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGerProdut.ForeColor = System.Drawing.Color.Snow;
            this.buttonGerProdut.Location = new System.Drawing.Point(283, 231);
            this.buttonGerProdut.Name = "buttonGerProdut";
            this.buttonGerProdut.Size = new System.Drawing.Size(159, 23);
            this.buttonGerProdut.TabIndex = 7;
            this.buttonGerProdut.Text = "Gerenciar Produtos";
            this.buttonGerProdut.UseVisualStyleBackColor = false;
            this.buttonGerProdut.Click += new System.EventHandler(this.buttonGerProdut_Click);
            // 
            // buttonGerProducao
            // 
            this.buttonGerProducao.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonGerProducao.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGerProducao.ForeColor = System.Drawing.Color.Snow;
            this.buttonGerProducao.Location = new System.Drawing.Point(283, 283);
            this.buttonGerProducao.Name = "buttonGerProducao";
            this.buttonGerProducao.Size = new System.Drawing.Size(159, 23);
            this.buttonGerProducao.TabIndex = 8;
            this.buttonGerProducao.Text = "Gerenciar Produção";
            this.buttonGerProducao.UseVisualStyleBackColor = false;
            this.buttonGerProducao.Click += new System.EventHandler(this.buttonGerProducao_Click);
            // 
            // Gestao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonGerProducao);
            this.Controls.Add(this.buttonGerProdut);
            this.Controls.Add(this.buttonGerClient);
            this.Controls.Add(this.labelGestao);
            this.Controls.Add(this.panel1);
            this.Name = "Gestao";
            this.Text = "Gestao";
            this.Load += new System.EventHandler(this.Gestao_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonVendas;
        private System.Windows.Forms.Button buttonGestão;
        private System.Windows.Forms.Label labelGestao;
        private System.Windows.Forms.Button buttonGerClient;
        private System.Windows.Forms.Button buttonGerProdut;
        private System.Windows.Forms.Button buttonGerProducao;
    }
}