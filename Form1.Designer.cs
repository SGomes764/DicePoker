using System;

namespace DicePoker
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.pbDado1 = new System.Windows.Forms.PictureBox();
            this.pbDado2 = new System.Windows.Forms.PictureBox();
            this.pbDado3 = new System.Windows.Forms.PictureBox();
            this.pbDado4 = new System.Windows.Forms.PictureBox();
            this.pbDado5 = new System.Windows.Forms.PictureBox();
            this.chkDado1 = new System.Windows.Forms.CheckBox();
            this.chkDado2 = new System.Windows.Forms.CheckBox();
            this.chkDado3 = new System.Windows.Forms.CheckBox();
            this.chkDado4 = new System.Windows.Forms.CheckBox();
            this.chkDado5 = new System.Windows.Forms.CheckBox();
            this.chkDados = new System.Windows.Forms.CheckBox();
            this.btnRolar = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblLegenda = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.imgDados = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbDado1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDado2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDado3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDado4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDado5)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pbDado1
            // 
            this.pbDado1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbDado1.Location = new System.Drawing.Point(12, 64);
            this.pbDado1.Name = "pbDado1";
            this.pbDado1.Size = new System.Drawing.Size(124, 144);
            this.pbDado1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDado1.TabIndex = 1;
            this.pbDado1.TabStop = false;
            // 
            // pbDado2
            // 
            this.pbDado2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbDado2.Location = new System.Drawing.Point(174, 64);
            this.pbDado2.Name = "pbDado2";
            this.pbDado2.Size = new System.Drawing.Size(124, 144);
            this.pbDado2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDado2.TabIndex = 2;
            this.pbDado2.TabStop = false;
            // 
            // pbDado3
            // 
            this.pbDado3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbDado3.Location = new System.Drawing.Point(340, 64);
            this.pbDado3.Name = "pbDado3";
            this.pbDado3.Size = new System.Drawing.Size(124, 144);
            this.pbDado3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDado3.TabIndex = 3;
            this.pbDado3.TabStop = false;
            // 
            // pbDado4
            // 
            this.pbDado4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbDado4.Location = new System.Drawing.Point(510, 64);
            this.pbDado4.Name = "pbDado4";
            this.pbDado4.Size = new System.Drawing.Size(124, 144);
            this.pbDado4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDado4.TabIndex = 4;
            this.pbDado4.TabStop = false;
            // 
            // pbDado5
            // 
            this.pbDado5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbDado5.Location = new System.Drawing.Point(678, 64);
            this.pbDado5.Name = "pbDado5";
            this.pbDado5.Size = new System.Drawing.Size(124, 144);
            this.pbDado5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDado5.TabIndex = 5;
            this.pbDado5.TabStop = false;
            // 
            // chkDado1
            // 
            this.chkDado1.AutoSize = true;
            this.chkDado1.Location = new System.Drawing.Point(12, 225);
            this.chkDado1.Name = "chkDado1";
            this.chkDado1.Size = new System.Drawing.Size(59, 17);
            this.chkDado1.TabIndex = 6;
            this.chkDado1.Text = "Manter";
            this.chkDado1.UseVisualStyleBackColor = true;
            this.chkDado1.Visible = false;
            // 
            // chkDado2
            // 
            this.chkDado2.AutoSize = true;
            this.chkDado2.Location = new System.Drawing.Point(174, 225);
            this.chkDado2.Name = "chkDado2";
            this.chkDado2.Size = new System.Drawing.Size(59, 17);
            this.chkDado2.TabIndex = 7;
            this.chkDado2.Text = "Manter";
            this.chkDado2.UseVisualStyleBackColor = true;
            this.chkDado2.Visible = false;
            // 
            // chkDado3
            // 
            this.chkDado3.AutoSize = true;
            this.chkDado3.Location = new System.Drawing.Point(340, 225);
            this.chkDado3.Name = "chkDado3";
            this.chkDado3.Size = new System.Drawing.Size(59, 17);
            this.chkDado3.TabIndex = 8;
            this.chkDado3.Text = "Manter";
            this.chkDado3.UseVisualStyleBackColor = true;
            this.chkDado3.Visible = false;
            // 
            // chkDado4
            // 
            this.chkDado4.AutoSize = true;
            this.chkDado4.Location = new System.Drawing.Point(510, 225);
            this.chkDado4.Name = "chkDado4";
            this.chkDado4.Size = new System.Drawing.Size(59, 17);
            this.chkDado4.TabIndex = 9;
            this.chkDado4.Text = "Manter";
            this.chkDado4.UseVisualStyleBackColor = true;
            this.chkDado4.Visible = false;
            // 
            // chkDado5
            // 
            this.chkDado5.AutoSize = true;
            this.chkDado5.Location = new System.Drawing.Point(678, 225);
            this.chkDado5.Name = "chkDado5";
            this.chkDado5.Size = new System.Drawing.Size(59, 17);
            this.chkDado5.TabIndex = 10;
            this.chkDado5.Text = "Manter";
            this.chkDado5.UseVisualStyleBackColor = true;
            this.chkDado5.Visible = false;
            // 
            // chkDados
            // 
            this.chkDados.AutoSize = true;
            this.chkDados.Location = new System.Drawing.Point(352, 282);
            this.chkDados.Name = "chkDados";
            this.chkDados.Size = new System.Drawing.Size(83, 17);
            this.chkDados.TabIndex = 11;
            this.chkDados.Text = "Manter tudo";
            this.chkDados.UseVisualStyleBackColor = true;
            this.chkDados.Visible = false;
            this.chkDados.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // btnRolar
            // 
            this.btnRolar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRolar.Location = new System.Drawing.Point(174, 276);
            this.btnRolar.Name = "btnRolar";
            this.btnRolar.Size = new System.Drawing.Size(105, 23);
            this.btnRolar.TabIndex = 12;
            this.btnRolar.Text = "Rolar os dados";
            this.btnRolar.UseVisualStyleBackColor = true;
            this.btnRolar.Click += new System.EventHandler(this.btnRolar_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(510, 278);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Sair";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblLegenda);
            this.groupBox1.Location = new System.Drawing.Point(12, 374);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 100);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // lblLegenda
            // 
            this.lblLegenda.AutoSize = true;
            this.lblLegenda.Location = new System.Drawing.Point(25, 32);
            this.lblLegenda.Name = "lblLegenda";
            this.lblLegenda.Size = new System.Drawing.Size(169, 39);
            this.lblLegenda.TabIndex = 0;
            this.lblLegenda.Text = "5 of a kind = $4 Full House = $2\r\n4 of a kind = $3 High Straight = $3\r\n3 of a kin" +
    "d = $1 Low Straight = $3\r\n";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtOutput);
            this.groupBox2.Location = new System.Drawing.Point(428, 374);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(379, 100);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(22, 32);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(319, 20);
            this.txtOutput.TabIndex = 0;
            this.txtOutput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // imgDados
            // 
            this.imgDados.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgDados.ImageStream")));
            this.imgDados.TransparentColor = System.Drawing.Color.Transparent;
            this.imgDados.Images.SetKeyName(0, "0.png");
            this.imgDados.Images.SetKeyName(1, "1.png");
            this.imgDados.Images.SetKeyName(2, "2.png");
            this.imgDados.Images.SetKeyName(3, "3.png");
            this.imgDados.Images.SetKeyName(4, "4.png");
            this.imgDados.Images.SetKeyName(5, "5.png");
            this.imgDados.Images.SetKeyName(6, "6.png");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 498);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnRolar);
            this.Controls.Add(this.chkDados);
            this.Controls.Add(this.chkDado5);
            this.Controls.Add(this.chkDado4);
            this.Controls.Add(this.chkDado3);
            this.Controls.Add(this.chkDado2);
            this.Controls.Add(this.chkDado1);
            this.Controls.Add(this.pbDado5);
            this.Controls.Add(this.pbDado4);
            this.Controls.Add(this.pbDado3);
            this.Controls.Add(this.pbDado2);
            this.Controls.Add(this.pbDado1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Dice Poker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbDado1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDado2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDado3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDado4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDado5)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbDado1;
        private System.Windows.Forms.PictureBox pbDado2;
        private System.Windows.Forms.PictureBox pbDado3;
        private System.Windows.Forms.PictureBox pbDado4;
        private System.Windows.Forms.PictureBox pbDado5;
        private System.Windows.Forms.CheckBox chkDado1;
        private System.Windows.Forms.CheckBox chkDado2;
        private System.Windows.Forms.CheckBox chkDado3;
        private System.Windows.Forms.CheckBox chkDado4;
        private System.Windows.Forms.CheckBox chkDado5;
        private System.Windows.Forms.CheckBox chkDados;
        private System.Windows.Forms.Button btnRolar;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblLegenda;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ImageList imgDados;
    }
}

