using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlsLibryary
{
    public partial class NumberBox : TextBox
    {
        public NumberBox()
        {
            InitializeComponent();
        }

        public NumberBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        protected override void OnTextChanged(EventArgs e)
        {
            double number;
             ForeColor = !double.TryParse(Text, out number) ? Color.Red : Color.Black;

            base.OnTextChanged(e);
        }
    }
}
