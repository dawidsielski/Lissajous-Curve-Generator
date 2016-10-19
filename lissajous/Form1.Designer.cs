namespace lissajous
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
            this.drawingPlace = new System.Windows.Forms.PictureBox();
            this.drawButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rotate_check_box = new System.Windows.Forms.CheckBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.Button();
            this.header = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.amplitude_x = new System.Windows.Forms.TrackBar();
            this.freq_x = new System.Windows.Forms.TrackBar();
            this.phase_x = new System.Windows.Forms.TrackBar();
            this.phase_y = new System.Windows.Forms.TrackBar();
            this.freq_y = new System.Windows.Forms.TrackBar();
            this.amplitude_y = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.equation_1 = new System.Windows.Forms.Label();
            this.equation_2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.drawingPlace)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amplitude_x)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.freq_x)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phase_x)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phase_y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.freq_y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amplitude_y)).BeginInit();
            this.SuspendLayout();
            // 
            // drawingPlace
            // 
            this.drawingPlace.AccessibleDescription = "Drawing plane";
            this.drawingPlace.BackColor = System.Drawing.Color.White;
            this.drawingPlace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.drawingPlace.ErrorImage = null;
            this.drawingPlace.InitialImage = null;
            this.drawingPlace.Location = new System.Drawing.Point(258, 59);
            this.drawingPlace.Name = "drawingPlace";
            this.drawingPlace.Size = new System.Drawing.Size(734, 604);
            this.drawingPlace.TabIndex = 0;
            this.drawingPlace.TabStop = false;
            // 
            // drawButton
            // 
            this.drawButton.BackColor = System.Drawing.Color.Violet;
            this.drawButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.drawButton.FlatAppearance.BorderSize = 0;
            this.drawButton.Font = new System.Drawing.Font("Century Gothic", 21.75F);
            this.drawButton.Location = new System.Drawing.Point(0, 556);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(258, 47);
            this.drawButton.TabIndex = 1;
            this.drawButton.Text = "Draw";
            this.drawButton.UseVisualStyleBackColor = false;
            this.drawButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.equation_2);
            this.panel1.Controls.Add(this.equation_1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.phase_y);
            this.panel1.Controls.Add(this.freq_y);
            this.panel1.Controls.Add(this.amplitude_y);
            this.panel1.Controls.Add(this.phase_x);
            this.panel1.Controls.Add(this.freq_x);
            this.panel1.Controls.Add(this.amplitude_x);
            this.panel1.Controls.Add(this.drawButton);
            this.panel1.Controls.Add(this.rotate_check_box);
            this.panel1.Location = new System.Drawing.Point(0, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 606);
            this.panel1.TabIndex = 9;
            // 
            // rotate_check_box
            // 
            this.rotate_check_box.AutoSize = true;
            this.rotate_check_box.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rotate_check_box.Location = new System.Drawing.Point(75, 515);
            this.rotate_check_box.Name = "rotate_check_box";
            this.rotate_check_box.Size = new System.Drawing.Size(84, 25);
            this.rotate_check_box.TabIndex = 9;
            this.rotate_check_box.Text = "Rotate";
            this.rotate_check_box.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.AccessibleDescription = "Panel";
            this.panel4.BackColor = System.Drawing.Color.Violet;
            this.panel4.Controls.Add(this.exit);
            this.panel4.Controls.Add(this.header);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(992, 60);
            this.panel4.TabIndex = 10;
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseDown);
            this.panel4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseMove);
            this.panel4.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseUp);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.ForeColor = System.Drawing.Color.Black;
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.Location = new System.Drawing.Point(930, 3);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(50, 51);
            this.exit.TabIndex = 1;
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Century Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.header.Location = new System.Drawing.Point(18, 9);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(357, 36);
            this.header.TabIndex = 0;
            this.header.Text = "Lissaus Curve Generator";
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // amplitude_x
            // 
            this.amplitude_x.Location = new System.Drawing.Point(75, 46);
            this.amplitude_x.Maximum = 300;
            this.amplitude_x.Name = "amplitude_x";
            this.amplitude_x.Size = new System.Drawing.Size(158, 45);
            this.amplitude_x.SmallChange = 10;
            this.amplitude_x.TabIndex = 10;
            this.amplitude_x.Value = 200;
            // 
            // freq_x
            // 
            this.freq_x.Location = new System.Drawing.Point(75, 97);
            this.freq_x.Name = "freq_x";
            this.freq_x.Size = new System.Drawing.Size(158, 45);
            this.freq_x.TabIndex = 11;
            this.freq_x.Value = 3;
            // 
            // phase_x
            // 
            this.phase_x.Location = new System.Drawing.Point(75, 148);
            this.phase_x.Maximum = 360;
            this.phase_x.Name = "phase_x";
            this.phase_x.Size = new System.Drawing.Size(158, 45);
            this.phase_x.TabIndex = 12;
            // 
            // phase_y
            // 
            this.phase_y.Location = new System.Drawing.Point(75, 396);
            this.phase_y.Maximum = 360;
            this.phase_y.Name = "phase_y";
            this.phase_y.Size = new System.Drawing.Size(158, 45);
            this.phase_y.TabIndex = 15;
            // 
            // freq_y
            // 
            this.freq_y.Location = new System.Drawing.Point(75, 345);
            this.freq_y.Name = "freq_y";
            this.freq_y.Size = new System.Drawing.Size(158, 45);
            this.freq_y.TabIndex = 14;
            this.freq_y.Value = 3;
            // 
            // amplitude_y
            // 
            this.amplitude_y.Location = new System.Drawing.Point(75, 294);
            this.amplitude_y.Maximum = 300;
            this.amplitude_y.Name = "amplitude_y";
            this.amplitude_y.Size = new System.Drawing.Size(158, 45);
            this.amplitude_y.SmallChange = 10;
            this.amplitude_y.TabIndex = 13;
            this.amplitude_y.Value = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(61, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 28);
            this.label1.TabIndex = 16;
            this.label1.Text = "Equation 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(61, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(139, 28);
            this.label2.TabIndex = 17;
            this.label2.Text = "Equation 2:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(8, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Amplitude";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.Location = new System.Drawing.Point(8, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Frequency";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(12, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Phase";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(12, 396);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "Phase";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(8, 345);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "Frequency";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(8, 294);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "Amplitude";
            // 
            // equation_1
            // 
            this.equation_1.AutoSize = true;
            this.equation_1.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.equation_1.Location = new System.Drawing.Point(37, 196);
            this.equation_1.Name = "equation_1";
            this.equation_1.Size = new System.Drawing.Size(140, 22);
            this.equation_1.TabIndex = 24;
            this.equation_1.Text = "equation form";
            // 
            // equation_2
            // 
            this.equation_2.AutoSize = true;
            this.equation_2.Font = new System.Drawing.Font("Century Gothic", 14F);
            this.equation_2.Location = new System.Drawing.Point(37, 444);
            this.equation_2.Name = "equation_2";
            this.equation_2.Size = new System.Drawing.Size(140, 22);
            this.equation_2.TabIndex = 25;
            this.equation_2.Text = "equation form";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(992, 665);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.drawingPlace);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Lissayous Curve Generator";
            ((System.ComponentModel.ISupportInitialize)(this.drawingPlace)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.amplitude_x)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.freq_x)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phase_x)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phase_y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.freq_y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amplitude_y)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox drawingPlace;
        private System.Windows.Forms.Button drawButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox rotate_check_box;
        private System.Windows.Forms.TrackBar amplitude_x;
        private System.Windows.Forms.TrackBar phase_x;
        private System.Windows.Forms.TrackBar freq_x;
        private System.Windows.Forms.TrackBar phase_y;
        private System.Windows.Forms.TrackBar freq_y;
        private System.Windows.Forms.TrackBar amplitude_y;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label equation_1;
        private System.Windows.Forms.Label equation_2;
    }
}

