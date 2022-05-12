namespace Juego_Submarino
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
            this.ObstaculoArriba = new System.Windows.Forms.PictureBox();
            this.ObstaculoAbajo = new System.Windows.Forms.PictureBox();
            this.Player = new System.Windows.Forms.PictureBox();
            this.Obstaculo = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.Puntaje = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ObstaculoArriba)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ObstaculoAbajo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Obstaculo)).BeginInit();
            this.SuspendLayout();
            // 
            // ObstaculoArriba
            // 
            this.ObstaculoArriba.BackColor = System.Drawing.Color.Transparent;
            this.ObstaculoArriba.Image = global::Juego_Submarino.Properties.Resources.piedraTop;
            this.ObstaculoArriba.Location = new System.Drawing.Point(147, -173);
            this.ObstaculoArriba.Name = "ObstaculoArriba";
            this.ObstaculoArriba.Size = new System.Drawing.Size(163, 362);
            this.ObstaculoArriba.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ObstaculoArriba.TabIndex = 0;
            this.ObstaculoArriba.TabStop = false;
            this.ObstaculoArriba.Click += new System.EventHandler(this.ObtaculoArriba_Click);
            // 
            // ObstaculoAbajo
            // 
            this.ObstaculoAbajo.BackColor = System.Drawing.Color.Transparent;
            this.ObstaculoAbajo.Image = global::Juego_Submarino.Properties.Resources.piedra;
            this.ObstaculoAbajo.Location = new System.Drawing.Point(147, 319);
            this.ObstaculoAbajo.Name = "ObstaculoAbajo";
            this.ObstaculoAbajo.Size = new System.Drawing.Size(163, 316);
            this.ObstaculoAbajo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ObstaculoAbajo.TabIndex = 1;
            this.ObstaculoAbajo.TabStop = false;
            this.ObstaculoAbajo.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.Image = global::Juego_Submarino.Properties.Resources.submarino;
            this.Player.Location = new System.Drawing.Point(3, 225);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(119, 59);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player.TabIndex = 2;
            this.Player.TabStop = false;
            this.Player.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // Obstaculo
            // 
            this.Obstaculo.BackColor = System.Drawing.Color.Transparent;
            this.Obstaculo.Image = global::Juego_Submarino.Properties.Resources.Piso;
            this.Obstaculo.Location = new System.Drawing.Point(-8, 438);
            this.Obstaculo.Name = "Obstaculo";
            this.Obstaculo.Size = new System.Drawing.Size(938, 33);
            this.Obstaculo.TabIndex = 3;
            this.Obstaculo.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 10;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 1;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // Puntaje
            // 
            this.Puntaje.AutoSize = true;
            this.Puntaje.BackColor = System.Drawing.Color.Transparent;
            this.Puntaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Puntaje.Location = new System.Drawing.Point(50, 209);
            this.Puntaje.Name = "Puntaje";
            this.Puntaje.Size = new System.Drawing.Size(21, 24);
            this.Puntaje.TabIndex = 4;
            this.Puntaje.Text = "0";
            this.Puntaje.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Juego_Submarino.Properties.Resources.fondo1;
            this.ClientSize = new System.Drawing.Size(292, 464);
            this.Controls.Add(this.Puntaje);
            this.Controls.Add(this.Obstaculo);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.ObstaculoAbajo);
            this.Controls.Add(this.ObstaculoArriba);
            this.Name = "Form1";
            this.Text = "Juego Submarino";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.ObstaculoArriba)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ObstaculoAbajo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Obstaculo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ObstaculoArriba;
        private System.Windows.Forms.PictureBox ObstaculoAbajo;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.PictureBox Obstaculo;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Label Puntaje;
    }
}

