using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Magasin
{
    public partial class CustomControl1 : Panel
    {
        public CustomControl1()
        {
            InitializeComponent();
        }

        string text;
        public CustomControl1(string _text)
        {
            text = _text;
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }
    }
}
