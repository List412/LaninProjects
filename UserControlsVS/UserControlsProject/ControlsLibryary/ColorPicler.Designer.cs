namespace ControlsLibryary
{
    partial class ColorPicler
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_color = new System.Windows.Forms.Panel();
            this.panel_left = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt_Blue = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Red = new System.Windows.Forms.TextBox();
            this.txt_Green = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radio_hex = new System.Windows.Forms.RadioButton();
            this.radio_dec = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel_left.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel_color);
            this.panel1.Controls.Add(this.panel_left);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 195);
            this.panel1.TabIndex = 0;
            // 
            // panel_color
            // 
            this.panel_color.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_color.Location = new System.Drawing.Point(187, 0);
            this.panel_color.Name = "panel_color";
            this.panel_color.Size = new System.Drawing.Size(248, 195);
            this.panel_color.TabIndex = 2;
            // 
            // panel_left
            // 
            this.panel_left.Controls.Add(this.panel4);
            this.panel_left.Controls.Add(this.panel3);
            this.panel_left.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_left.Location = new System.Drawing.Point(0, 0);
            this.panel_left.Name = "panel_left";
            this.panel_left.Size = new System.Drawing.Size(187, 195);
            this.panel_left.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txt_Blue);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.txt_Red);
            this.panel4.Controls.Add(this.txt_Green);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(187, 146);
            this.panel4.TabIndex = 7;
            // 
            // txt_Blue
            // 
            this.txt_Blue.Location = new System.Drawing.Point(69, 102);
            this.txt_Blue.Name = "txt_Blue";
            this.txt_Blue.Size = new System.Drawing.Size(96, 22);
            this.txt_Blue.TabIndex = 6;
            this.txt_Blue.TextChanged += new System.EventHandler(this.txt_Blue_TextChanged);
            this.txt_Blue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Red";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Blue";
            // 
            // txt_Red
            // 
            this.txt_Red.Location = new System.Drawing.Point(69, 17);
            this.txt_Red.Name = "txt_Red";
            this.txt_Red.Size = new System.Drawing.Size(96, 22);
            this.txt_Red.TabIndex = 2;
            this.txt_Red.TextChanged += new System.EventHandler(this.txt_Red_TextChanged);
            this.txt_Red.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // txt_Green
            // 
            this.txt_Green.Location = new System.Drawing.Point(69, 60);
            this.txt_Green.Name = "txt_Green";
            this.txt_Green.Size = new System.Drawing.Size(96, 22);
            this.txt_Green.TabIndex = 4;
            this.txt_Green.TextChanged += new System.EventHandler(this.txt_Green_TextChanged);
            this.txt_Green.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Green";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.radio_hex);
            this.panel3.Controls.Add(this.radio_dec);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 146);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(187, 49);
            this.panel3.TabIndex = 0;
            // 
            // radio_hex
            // 
            this.radio_hex.AutoSize = true;
            this.radio_hex.Location = new System.Drawing.Point(111, 6);
            this.radio_hex.Name = "radio_hex";
            this.radio_hex.Size = new System.Drawing.Size(54, 21);
            this.radio_hex.TabIndex = 1;
            this.radio_hex.Text = "Hec";
            this.radio_hex.UseVisualStyleBackColor = true;
            // 
            // radio_dec
            // 
            this.radio_dec.AutoSize = true;
            this.radio_dec.Checked = true;
            this.radio_dec.Location = new System.Drawing.Point(16, 6);
            this.radio_dec.Name = "radio_dec";
            this.radio_dec.Size = new System.Drawing.Size(54, 21);
            this.radio_dec.TabIndex = 0;
            this.radio_dec.TabStop = true;
            this.radio_dec.Text = "Dec";
            this.radio_dec.UseVisualStyleBackColor = true;
            this.radio_dec.CheckedChanged += new System.EventHandler(this.radio_dec_CheckedChanged);
            // 
            // ColorPicler
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panel1);
            this.Name = "ColorPicler";
            this.Size = new System.Drawing.Size(435, 195);
            this.panel1.ResumeLayout(false);
            this.panel_left.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_left;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton radio_hex;
        private System.Windows.Forms.RadioButton radio_dec;
        private System.Windows.Forms.TextBox txt_Blue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Green;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Red;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel_color;
    }
}
