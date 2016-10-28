namespace TicTacToe
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.A1 = new System.Windows.Forms.Button();
            this.C2 = new System.Windows.Forms.Button();
            this.B3 = new System.Windows.Forms.Button();
            this.C3 = new System.Windows.Forms.Button();
            this.C1 = new System.Windows.Forms.Button();
            this.B2 = new System.Windows.Forms.Button();
            this.B1 = new System.Windows.Forms.Button();
            this.A2 = new System.Windows.Forms.Button();
            this.A3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(679, 546);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // A1
            // 
            this.A1.Font = new System.Drawing.Font("OCR A Extended", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.A1.ForeColor = System.Drawing.Color.Red;
            this.A1.Location = new System.Drawing.Point(98, 112);
            this.A1.Name = "A1";
            this.A1.Size = new System.Drawing.Size(100, 85);
            this.A1.TabIndex = 1;
            this.A1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.A1.UseVisualStyleBackColor = true;
            this.A1.TextChanged += new System.EventHandler(this.Form3_Load);
            this.A1.Click += new System.EventHandler(this.button_click);
            this.A1.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.A1.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // C2
            // 
            this.C2.Font = new System.Drawing.Font("OCR A Extended", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.C2.Location = new System.Drawing.Point(267, 378);
            this.C2.Name = "C2";
            this.C2.Size = new System.Drawing.Size(98, 113);
            this.C2.TabIndex = 2;
            this.C2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.C2.UseVisualStyleBackColor = true;
            this.C2.Click += new System.EventHandler(this.button_click);
            this.C2.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.C2.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // B3
            // 
            this.B3.Font = new System.Drawing.Font("OCR A Extended", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.B3.Location = new System.Drawing.Point(427, 239);
            this.B3.Name = "B3";
            this.B3.Size = new System.Drawing.Size(112, 111);
            this.B3.TabIndex = 3;
            this.B3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.B3.UseVisualStyleBackColor = true;
            this.B3.Click += new System.EventHandler(this.button_click);
            this.B3.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.B3.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // C3
            // 
            this.C3.Font = new System.Drawing.Font("OCR A Extended", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.C3.ForeColor = System.Drawing.Color.Red;
            this.C3.Location = new System.Drawing.Point(418, 388);
            this.C3.Name = "C3";
            this.C3.Size = new System.Drawing.Size(106, 93);
            this.C3.TabIndex = 4;
            this.C3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.C3.UseVisualStyleBackColor = true;
            this.C3.Click += new System.EventHandler(this.button_click);
            this.C3.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.C3.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // C1
            // 
            this.C1.Font = new System.Drawing.Font("OCR A Extended", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.C1.ForeColor = System.Drawing.Color.Red;
            this.C1.Location = new System.Drawing.Point(118, 363);
            this.C1.Name = "C1";
            this.C1.Size = new System.Drawing.Size(101, 95);
            this.C1.TabIndex = 5;
            this.C1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.C1.UseVisualStyleBackColor = true;
            this.C1.Click += new System.EventHandler(this.button_click);
            this.C1.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.C1.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // B2
            // 
            this.B2.Font = new System.Drawing.Font("OCR A Extended", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.B2.ForeColor = System.Drawing.Color.Red;
            this.B2.Location = new System.Drawing.Point(260, 229);
            this.B2.Name = "B2";
            this.B2.Size = new System.Drawing.Size(123, 95);
            this.B2.TabIndex = 6;
            this.B2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.B2.UseVisualStyleBackColor = true;
            this.B2.Click += new System.EventHandler(this.button_click);
            this.B2.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.B2.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // B1
            // 
            this.B1.Font = new System.Drawing.Font("OCR A Extended", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.B1.Location = new System.Drawing.Point(118, 239);
            this.B1.Name = "B1";
            this.B1.Size = new System.Drawing.Size(100, 95);
            this.B1.TabIndex = 7;
            this.B1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.B1.UseVisualStyleBackColor = true;
            this.B1.Click += new System.EventHandler(this.button_click);
            this.B1.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.B1.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // A2
            // 
            this.A2.Font = new System.Drawing.Font("OCR A Extended", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.A2.Location = new System.Drawing.Point(267, 99);
            this.A2.Name = "A2";
            this.A2.Size = new System.Drawing.Size(116, 84);
            this.A2.TabIndex = 8;
            this.A2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.A2.UseVisualStyleBackColor = true;
            this.A2.Click += new System.EventHandler(this.button_click);
            this.A2.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.A2.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // A3
            // 
            this.A3.Font = new System.Drawing.Font("OCR A Extended", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.A3.ForeColor = System.Drawing.Color.Red;
            this.A3.Location = new System.Drawing.Point(439, 99);
            this.A3.Name = "A3";
            this.A3.Size = new System.Drawing.Size(113, 69);
            this.A3.TabIndex = 9;
            this.A3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.A3.UseVisualStyleBackColor = true;
            this.A3.Click += new System.EventHandler(this.button_click);
            this.A3.MouseEnter += new System.EventHandler(this.MouseEnter);
            this.A3.MouseLeave += new System.EventHandler(this.MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 519);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 26);
            this.label1.TabIndex = 10;
            this.label1.Text = "Now it\'s";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(167, 519);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 26);
            this.label2.TabIndex = 11;
            this.label2.Text = "turn !";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(114, 494);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(47, 51);
            this.textBox1.TabIndex = 12;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(26, 310);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(0, 0);
            this.progressBar1.TabIndex = 16;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(44, 13);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(0, 0);
            this.progressBar2.TabIndex = 17;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Poplar Std", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.button2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button2.Location = new System.Drawing.Point(205, 293);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(241, 153);
            this.button2.TabIndex = 14;
            this.button2.Text = "Quit!";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Font = new System.Drawing.Font("Poplar Std", 28F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button1.Location = new System.Drawing.Point(205, 99);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(241, 153);
            this.button1.TabIndex = 13;
            this.button1.Text = "PlayAgain!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(118, 76);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(424, 392);
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 544);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.A3);
            this.Controls.Add(this.A2);
            this.Controls.Add(this.B1);
            this.Controls.Add(this.B2);
            this.Controls.Add(this.C1);
            this.Controls.Add(this.C3);
            this.Controls.Add(this.B3);
            this.Controls.Add(this.C2);
            this.Controls.Add(this.A1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TicTacToe";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button A1;
        private System.Windows.Forms.Button C2;
        private System.Windows.Forms.Button B3;
        private System.Windows.Forms.Button C3;
        private System.Windows.Forms.Button C1;
        private System.Windows.Forms.Button B2;
        private System.Windows.Forms.Button B1;
        private System.Windows.Forms.Button A2;
        private System.Windows.Forms.Button A3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}