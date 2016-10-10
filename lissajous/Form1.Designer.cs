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
            this.y_amplitude = new System.Windows.Forms.NumericUpDown();
            this.x_phase = new System.Windows.Forms.NumericUpDown();
            this.x_frequency = new System.Windows.Forms.NumericUpDown();
            this.drawingPlace = new System.Windows.Forms.PictureBox();
            this.y_frequency = new System.Windows.Forms.NumericUpDown();
            this.x_amplitude = new System.Windows.Forms.NumericUpDown();
            this.drawButton = new System.Windows.Forms.Button();
            this.y_phase = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.y_amplitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x_phase)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x_frequency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawingPlace)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.y_frequency)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x_amplitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.y_phase)).BeginInit();
            this.SuspendLayout();
            // 
            // y_amplitude
            // 
            this.y_amplitude.Location = new System.Drawing.Point(195, 502);
            this.y_amplitude.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.y_amplitude.Name = "y_amplitude";
            this.y_amplitude.Size = new System.Drawing.Size(55, 20);
            this.y_amplitude.TabIndex = 6;
            this.y_amplitude.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // x_phase
            // 
            this.x_phase.Location = new System.Drawing.Point(134, 502);
            this.x_phase.Name = "x_phase";
            this.x_phase.Size = new System.Drawing.Size(55, 20);
            this.x_phase.TabIndex = 5;
            this.x_phase.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // x_frequency
            // 
            this.x_frequency.Location = new System.Drawing.Point(73, 502);
            this.x_frequency.Name = "x_frequency";
            this.x_frequency.Size = new System.Drawing.Size(55, 20);
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
            this.drawingPlace.Location = new System.Drawing.Point(2, 10);
            this.drawingPlace.Name = "drawingPlace";
            this.drawingPlace.Size = new System.Drawing.Size(602, 470);
            this.drawingPlace.TabIndex = 0;
            this.drawingPlace.TabStop = false;
            // 
            // y_frequency
            // 
            this.y_frequency.Location = new System.Drawing.Point(256, 502);
            this.y_frequency.Name = "y_frequency";
            this.y_frequency.Size = new System.Drawing.Size(55, 20);
            this.y_frequency.TabIndex = 7;
            this.y_frequency.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // x_amplitude
            // 
            this.x_amplitude.Location = new System.Drawing.Point(12, 502);
            this.x_amplitude.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.x_amplitude.Name = "x_amplitude";
            this.x_amplitude.Size = new System.Drawing.Size(55, 20);
            this.x_amplitude.TabIndex = 3;
            this.x_amplitude.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // drawButton
            // 
            this.drawButton.Location = new System.Drawing.Point(427, 486);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(99, 36);
            this.drawButton.TabIndex = 1;
            this.drawButton.Text = "Draw";
            this.drawButton.UseVisualStyleBackColor = true;
            this.drawButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // y_phase
            // 
            this.y_phase.Location = new System.Drawing.Point(317, 502);
            this.y_phase.Name = "y_phase";
            this.y_phase.Size = new System.Drawing.Size(55, 20);
            this.y_phase.TabIndex = 8;
            this.y_phase.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(607, 534);
            this.Controls.Add(this.y_phase);
            this.Controls.Add(this.x_amplitude);
            this.Controls.Add(this.drawButton);
            this.Controls.Add(this.y_frequency);
            this.Controls.Add(this.drawingPlace);
            this.Controls.Add(this.x_frequency);
            this.Controls.Add(this.x_phase);
            this.Controls.Add(this.y_amplitude);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Lissayous Curve Generator";
            ((System.ComponentModel.ISupportInitialize)(this.y_amplitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x_phase)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x_frequency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawingPlace)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.y_frequency)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x_amplitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.y_phase)).EndInit();
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
    }
}

