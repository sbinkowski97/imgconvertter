
namespace ImgConverter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.light = new System.Windows.Forms.Label();
            this.renderButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lightValue = new System.Windows.Forms.NumericUpDown();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.rgbValue = new System.Windows.Forms.TextBox();
            this.blurValue = new System.Windows.Forms.NumericUpDown();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lightValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.blurValue)).BeginInit();
            this.SuspendLayout();
            // 
            // light
            // 
            this.light.AutoSize = true;
            this.light.Location = new System.Drawing.Point(12, 9);
            this.light.Name = "light";
            this.light.Size = new System.Drawing.Size(106, 15);
            this.light.TabIndex = 2;
            this.light.Text = "Światło -255 to 255";
            // 
            // renderButton
            // 
            this.renderButton.Location = new System.Drawing.Point(12, 213);
            this.renderButton.Name = "renderButton";
            this.renderButton.Size = new System.Drawing.Size(125, 25);
            this.renderButton.TabIndex = 6;
            this.renderButton.Text = "Rozmycie";
            this.renderButton.UseVisualStyleBackColor = true;
            this.renderButton.Click += new System.EventHandler(this.renderButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1, 321);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(533, 23);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lightValue
            // 
            this.lightValue.Location = new System.Drawing.Point(12, 27);
            this.lightValue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.lightValue.Minimum = new decimal(new int[] {
            255,
            0,
            0,
            -2147483648});
            this.lightValue.Name = "lightValue";
            this.lightValue.Size = new System.Drawing.Size(125, 23);
            this.lightValue.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 56);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 25);
            this.button2.TabIndex = 12;
            this.button2.Text = "Jasność";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Kolor Filter R G B";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 142);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 27);
            this.button3.TabIndex = 14;
            this.button3.Text = "Filtr koloru";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // rgbValue
            // 
            this.rgbValue.Location = new System.Drawing.Point(12, 113);
            this.rgbValue.Name = "rgbValue";
            this.rgbValue.Size = new System.Drawing.Size(125, 23);
            this.rgbValue.TabIndex = 15;
            // 
            // blurValue
            // 
            this.blurValue.Location = new System.Drawing.Point(12, 184);
            this.blurValue.Name = "blurValue";
            this.blurValue.Size = new System.Drawing.Size(125, 23);
            this.blurValue.TabIndex = 16;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(175, 27);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(126, 23);
            this.button4.TabIndex = 17;
            this.button4.Text = "Wyszarzenie";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(175, 56);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(126, 25);
            this.button5.TabIndex = 18;
            this.button5.Text = "Negatyw";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 360);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.blurValue);
            this.Controls.Add(this.rgbValue);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lightValue);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.renderButton);
            this.Controls.Add(this.light);
            this.Name = "Form1";
            this.Text = "Light Render";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            ((System.ComponentModel.ISupportInitialize)(this.lightValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.blurValue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label light;
        private System.Windows.Forms.Button renderButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown lightValue;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox rgbValue;
        private System.Windows.Forms.NumericUpDown blurValue;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

