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
            this.y_amplitude = new System.Windows.Forms.NumericUpDown();
            this.x_phase = new System.Windows.Forms.NumericUpDown();
            this.x_frequency = new System.Windows.Forms.NumericUpDown();
            this.drawingPlace = new System.Windows.Forms.PictureBox();
            this.y_frequency = new System.Windows.Forms.NumericUpDown();
            this.x_amplitude = new System.Windows.Forms.NumericUpDown();
            this.drawButton = new System.Windows.Forms.Button();
            this.y_phase = new System.Windows.Forms.NumericUpDown();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rotate_check_box = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.exit = new System.Windows.Forms.Button();
            this.header = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.y_amplitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x_phase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x_frequency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawingPlace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.y_frequency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x_amplitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.y_phase)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // y_amplitude
            // 
            this.y_amplitude.Location = new System.Drawing.Point(98, 167);
            this.y_amplitude.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.y_amplitude.Name = "y_amplitude";
            this.y_amplitude.Size = new System.Drawing.Size(58, 20);
            this.y_amplitude.TabIndex = 6;
            this.y_amplitude.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // x_phase
            // 
            this.x_phase.Location = new System.Drawing.Point(98, 141);
            this.x_phase.Name = "x_phase";
            this.x_phase.Size = new System.Drawing.Size(58, 20);
            this.x_phase.TabIndex = 5;
            this.x_phase.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // x_frequency
            // 
            this.x_frequency.Location = new System.Drawing.Point(98, 115);
            this.x_frequency.Name = "x_frequency";
            this.x_frequency.Size = new System.Drawing.Size(58, 20);
            this.x_frequency.TabIndex = 4;
            this.x_frequency.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // drawingPlace
            // 
            this.drawingPlace.AccessibleDescription = "Drawing plane";
            this.drawingPlace.BackColor = System.Drawing.Color.White;
            this.drawingPlace.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.drawingPlace.Location = new System.Drawing.Point(258, 59);
            this.drawingPlace.Name = "drawingPlace";
            this.drawingPlace.Size = new System.Drawing.Size(734, 604);
            this.drawingPlace.TabIndex = 0;
            this.drawingPlace.TabStop = false;
            // 
            // y_frequency
            // 
            this.y_frequency.Location = new System.Drawing.Point(98, 193);
            this.y_frequency.Name = "y_frequency";
            this.y_frequency.Size = new System.Drawing.Size(58, 20);
            this.y_frequency.TabIndex = 7;
            this.y_frequency.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // x_amplitude
            // 
            this.x_amplitude.Location = new System.Drawing.Point(98, 89);
            this.x_amplitude.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.x_amplitude.Name = "x_amplitude";
            this.x_amplitude.Size = new System.Drawing.Size(58, 20);
            this.x_amplitude.TabIndex = 3;
            this.x_amplitude.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // drawButton
            // 
            this.drawButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drawButton.Location = new System.Drawing.Point(0, 0);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(258, 78);
            this.drawButton.TabIndex = 1;
            this.drawButton.Text = "Draw";
            this.drawButton.UseVisualStyleBackColor = true;
            this.drawButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // y_phase
            // 
            this.y_phase.Location = new System.Drawing.Point(98, 219);
            this.y_phase.Name = "y_phase";
            this.y_phase.Size = new System.Drawing.Size(58, 20);
            this.y_phase.TabIndex = 8;
            this.y_phase.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rotate_check_box);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.y_phase);
            this.panel1.Controls.Add(this.x_amplitude);
            this.panel1.Controls.Add(this.x_frequency);
            this.panel1.Controls.Add(this.y_frequency);
            this.panel1.Controls.Add(this.x_phase);
            this.panel1.Controls.Add(this.y_amplitude);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(258, 665);
            this.panel1.TabIndex = 9;
            // 
            // rotate_check_box
            // 
            this.rotate_check_box.AutoSize = true;
            this.rotate_check_box.Location = new System.Drawing.Point(98, 245);
            this.rotate_check_box.Name = "rotate_check_box";
            this.rotate_check_box.Size = new System.Drawing.Size(58, 17);
            this.rotate_check_box.TabIndex = 9;
            this.rotate_check_box.Text = "Rotate";
            this.rotate_check_box.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.drawButton);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 587);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(258, 78);
            this.panel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.AccessibleDescription = "Name & Logo";
            this.panel2.BackColor = System.Drawing.Color.MediumVioletRed;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(258, 60);
            this.panel2.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.AccessibleDescription = "Panel";
            this.panel4.BackColor = System.Drawing.Color.HotPink;
            this.panel4.Controls.Add(this.exit);
            this.panel4.Controls.Add(this.header);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(258, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(734, 60);
            this.panel4.TabIndex = 10;
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.ForeColor = System.Drawing.Color.Black;
            this.exit.Image = ((System.Drawing.Image)(resources.GetObject("exit.Image")));
            this.exit.Location = new System.Drawing.Point(672, 3);
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
            ((System.ComponentModel.ISupportInitialize)(this.y_amplitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x_phase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x_frequency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawingPlace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.y_frequency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x_amplitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.y_phase)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown y_amplitude;
        private System.Windows.Forms.NumericUpDown x_phase;
        private System.Windows.Forms.NumericUpDown x_frequency;
        private System.Windows.Forms.PictureBox drawingPlace;
        private System.Windows.Forms.NumericUpDown y_frequency;
        private System.Windows.Forms.NumericUpDown x_amplitude;
        private System.Windows.Forms.Button drawButton;
        private System.Windows.Forms.NumericUpDown y_phase;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.CheckBox rotate_check_box;
    }
}

