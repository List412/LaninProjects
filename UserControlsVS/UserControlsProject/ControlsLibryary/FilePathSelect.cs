using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlsLibryary
{
    public partial class FilePathSelect : UserControl
    {
        public FilePathSelect()
        {
            InitializeComponent();
        }

        public string FileName
        {
            get => txt_path.Text;
            set => txt_path.Text = value;
        }

        private void btn_pickPath_Click(object sender, EventArgs e)
        {
            var ofd = new OpenFileDialog {FileName = txt_path.Text};
            if (ofd.ShowDialog() == DialogResult.OK)
                txt_path.Text = ofd.FileName;        
        }
    }
}
