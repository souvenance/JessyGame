namespace game1
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
            this.pbcanvas = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblscord = new System.Windows.Forms.Label();
            this.gametimer = new System.Windows.Forms.Timer(this.components);
            this.lblgameOver = new System.Windows.Forms.Label();
            this.pickbad = new System.Windows.Forms.PictureBox();
            this.pickcool = new System.Windows.Forms.PictureBox();
            this.pickhappy = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbcanvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pickbad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pickcool)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pickhappy)).BeginInit();
            this.SuspendLayout();
            // 
            // pbcanvas
            // 
            this.pbcanvas.BackColor = System.Drawing.Color.Silver;
            this.pbcanvas.Location = new System.Drawing.Point(2, 30);
            this.pbcanvas.Name = "pbcanvas";
            this.pbcanvas.Size = new System.Drawing.Size(495, 329);
            this.pbcanvas.TabIndex = 0;
            this.pbcanvas.TabStop = false;
            this.pbcanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pbcanvas_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 362);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Score:";
            // 
            // lblscord
            // 
            this.lblscord.AutoSize = true;
            this.lblscord.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblscord.Location = new System.Drawing.Point(87, 369);
            this.lblscord.Name = "lblscord";
            this.lblscord.Size = new System.Drawing.Size(47, 17);
            this.lblscord.TabIndex = 2;
            this.lblscord.Text = "label2";
            // 
            // lblgameOver
            // 
            this.lblgameOver.AutoSize = true;
            this.lblgameOver.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgameOver.Location = new System.Drawing.Point(71, 178);
            this.lblgameOver.Name = "lblgameOver";
            this.lblgameOver.Size = new System.Drawing.Size(112, 39);
            this.lblgameOver.TabIndex = 3;
            this.lblgameOver.Text = "label2";
            this.lblgameOver.Visible = false;
           // this.lblgameOver.Click += new System.EventHandler(this.lblgameOver_Click);
            // 
            // pickbad
            // 
            this.pickbad.BackColor = System.Drawing.Color.Silver;
            this.pickbad.Image = ((System.Drawing.Image)(resources.GetObject("pickbad.Image")));
            this.pickbad.Location = new System.Drawing.Point(188, 41);
            this.pickbad.Name = "pickbad";
            this.pickbad.Size = new System.Drawing.Size(97, 81);
            this.pickbad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pickbad.TabIndex = 4;
            this.pickbad.TabStop = false;
            this.pickbad.Visible = false;
            // 
            // pickcool
            // 
            this.pickcool.BackColor = System.Drawing.Color.Silver;
            this.pickcool.Image = ((System.Drawing.Image)(resources.GetObject("pickcool.Image")));
            this.pickcool.Location = new System.Drawing.Point(185, 41);
            this.pickcool.Name = "pickcool";
            this.pickcool.Size = new System.Drawing.Size(100, 81);
            this.pickcool.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pickcool.TabIndex = 5;
            this.pickcool.TabStop = false;
            this.pickcool.Visible = false;
            // 
            // pickhappy
            // 
            this.pickhappy.BackColor = System.Drawing.Color.Silver;
            this.pickhappy.Image = ((System.Drawing.Image)(resources.GetObject("pickhappy.Image")));
            this.pickhappy.Location = new System.Drawing.Point(185, 41);
            this.pickhappy.Name = "pickhappy";
            this.pickhappy.Size = new System.Drawing.Size(100, 88);
            this.pickhappy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pickhappy.TabIndex = 6;
            this.pickhappy.TabStop = false;
            this.pickhappy.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 395);
            this.Controls.Add(this.pickhappy);
            this.Controls.Add(this.pickcool);
            this.Controls.Add(this.pickbad);
            this.Controls.Add(this.lblgameOver);
            this.Controls.Add(this.lblscord);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbcanvas);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pbcanvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pickbad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pickcool)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pickhappy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbcanvas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblscord;
        private System.Windows.Forms.Timer gametimer;
        private System.Windows.Forms.Label lblgameOver;
        private System.Windows.Forms.PictureBox pickbad;
        private System.Windows.Forms.PictureBox pickcool;
        private System.Windows.Forms.PictureBox pickhappy;
    }
}

