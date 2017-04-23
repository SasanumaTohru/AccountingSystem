using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 会計システム.Domain.PrimitiveObject;

namespace 会計システム
{
    public partial class frmスタート画面 : Form
    {
        public frmスタート画面()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime foo = new DateTime(2017, 1, 1);
            MessageBox.Show(foo.ToShortDateString());
            
        }
    }
}
