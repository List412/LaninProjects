using System.Drawing;

namespace TestUserControls
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
            this.top_panel = new System.Windows.Forms.Panel();
            this.btn_closeWindow = new System.Windows.Forms.Button();
            this.left_panel = new System.Windows.Forms.Panel();
            this.filePathSelect2 = new ControlsLibryary.FilePathSelect();
            this.filePathSelect1 = new ControlsLibryary.FilePathSelect();
            this.label1 = new System.Windows.Forms.Label();
            this.numberBox1 = new ControlsLibryary.NumberBox(this.components);
            this.center_panel = new System.Windows.Forms.Panel();
            this.colorPicler1 = new ControlsLibryary.ColorPicler();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.clock1 = new ControlsLibryary.Clock();
            this.top_panel.SuspendLayout();
            this.left_panel.SuspendLayout();
            this.center_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // top_panel
            // 
            this.top_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.top_panel.Controls.Add(this.btn_closeWindow);
            this.top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_panel.Location = new System.Drawing.Point(0, 0);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(1059, 56);
            this.top_panel.TabIndex = 0;
            this.top_panel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.top_panel_MouseDown);
            // 
            // btn_closeWindow
            // 
            this.btn_closeWindow.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_closeWindow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_closeWindow.Location = new System.Drawing.Point(1008, 4);
            this.btn_closeWindow.Name = "btn_closeWindow";
            this.btn_closeWindow.Size = new System.Drawing.Size(48, 48);
            this.btn_closeWindow.TabIndex = 0;
            this.btn_closeWindow.TabStop = false;
            this.btn_closeWindow.UseVisualStyleBackColor = true;
            this.btn_closeWindow.Click += new System.EventHandler(this.btn_closeWindow_Click);
            // 
            // left_panel
            // 
            this.left_panel.Controls.Add(this.colorPicler1);
            this.left_panel.Controls.Add(this.filePathSelect2);
            this.left_panel.Controls.Add(this.filePathSelect1);
            this.left_panel.Controls.Add(this.label1);
            this.left_panel.Controls.Add(this.numberBox1);
            this.left_panel.Dock = System.Windows.Forms.DockStyle.Left;
            this.left_panel.Location = new System.Drawing.Point(0, 56);
            this.left_panel.Name = "left_panel";
            this.left_panel.Size = new System.Drawing.Size(410, 570);
            this.left_panel.TabIndex = 1;
            // 
            // filePathSelect2
            // 
            this.filePathSelect2.FileName = "";
            this.filePathSelect2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.filePathSelect2.Location = new System.Drawing.Point(12, 167);
            this.filePathSelect2.Margin = new System.Windows.Forms.Padding(4);
            this.filePathSelect2.Name = "filePathSelect2";
            this.filePathSelect2.Size = new System.Drawing.Size(319, 35);
            this.filePathSelect2.TabIndex = 3;
            // 
            // filePathSelect1
            // 
            this.filePathSelect1.FileName = "Имя файла хахаха";
            this.filePathSelect1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.filePathSelect1.Location = new System.Drawing.Point(12, 114);
            this.filePathSelect1.Margin = new System.Windows.Forms.Padding(4);
            this.filePathSelect1.Name = "filePathSelect1";
            this.filePathSelect1.Size = new System.Drawing.Size(368, 35);
            this.filePathSelect1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numeric text box";
            // 
            // numberBox1
            // 
            this.numberBox1.ForeColor = System.Drawing.Color.Red;
            this.numberBox1.Location = new System.Drawing.Point(12, 43);
            this.numberBox1.Name = "numberBox1";
            this.numberBox1.Size = new System.Drawing.Size(368, 28);
            this.numberBox1.TabIndex = 0;
            // 
            // center_panel
            // 
            this.center_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(77)))), ((int)(((byte)(109)))));
            this.center_panel.Controls.Add(this.elementHost1);
            this.center_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.center_panel.Location = new System.Drawing.Point(410, 56);
            this.center_panel.Name = "center_panel";
            this.center_panel.Size = new System.Drawing.Size(649, 570);
            this.center_panel.TabIndex = 2;
            // 
            // colorPicler1
            // 
            this.colorPicler1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.colorPicler1.Location = new System.Drawing.Point(0, 375);
            this.colorPicler1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.colorPicler1.Name = "colorPicler1";
            this.colorPicler1.Size = new System.Drawing.Size(410, 195);
            this.colorPicler1.TabIndex = 4;
            // 
            // elementHost1
            // 
            this.elementHost1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.elementHost1.Location = new System.Drawing.Point(0, 0);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(649, 570);
            this.elementHost1.TabIndex = 0;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = this.clock1;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(41)))), ((int)(((byte)(58)))));
            this.ClientSize = new System.Drawing.Size(1059, 626);
            this.ControlBox = false;
            this.Controls.Add(this.center_panel);
            this.Controls.Add(this.left_panel);
            this.Controls.Add(this.top_panel);
            this.Font = new System.Drawing.Font("Georgia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(186)))), ((int)(((byte)(186)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.top_panel.ResumeLayout(false);
            this.left_panel.ResumeLayout(false);
            this.left_panel.PerformLayout();
            this.center_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel top_panel;
        private System.Windows.Forms.Panel left_panel;
        private System.Windows.Forms.Panel center_panel;
        private System.Windows.Forms.Label label1;
        private ControlsLibryary.NumberBox numberBox1;
        private System.Windows.Forms.Button btn_closeWindow;
        private ControlsLibryary.FilePathSelect filePathSelect2;
        private ControlsLibryary.FilePathSelect filePathSelect1;
        private ControlsLibryary.ColorPicler colorPicler1;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private ControlsLibryary.Clock clock1;
    }
}

