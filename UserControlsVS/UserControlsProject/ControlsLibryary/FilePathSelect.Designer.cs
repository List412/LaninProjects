namespace ControlsLibryary
{
    partial class FilePathSelect
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
            this.txt_path = new System.Windows.Forms.TextBox();
            this.btn_pickPath = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_pickPath);
            this.panel1.Controls.Add(this.txt_path);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 35);
            this.panel1.TabIndex = 0;
            // 
            // txt_path
            // 
            this.txt_path.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_path.Location = new System.Drawing.Point(0, 6);
            this.txt_path.Name = "txt_path";
            this.txt_path.Size = new System.Drawing.Size(332, 22);
            this.txt_path.TabIndex = 0;
            // 
            // btn_pickPath
            // 
            this.btn_pickPath.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_pickPath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pickPath.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_pickPath.Location = new System.Drawing.Point(341, 5);
            this.btn_pickPath.Name = "btn_pickPath";
            this.btn_pickPath.Size = new System.Drawing.Size(35, 25);
            this.btn_pickPath.TabIndex = 1;
            this.btn_pickPath.Text = "...";
            this.btn_pickPath.UseVisualStyleBackColor = true;
            this.btn_pickPath.Click += new System.EventHandler(this.btn_pickPath_Click);
            // 
            // FilePathSelect
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(187)))), ((int)(((byte)(187)))));
            this.Name = "FilePathSelect";
            this.Size = new System.Drawing.Size(376, 35);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_pickPath;
        private System.Windows.Forms.TextBox txt_path;
    }
}
