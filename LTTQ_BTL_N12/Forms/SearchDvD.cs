using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LTTQ_BTL_N12.Forms
{
    public partial class SearchDvD : DevExpress.XtraEditors.XtraUserControl
    {
        public SearchDvD()
        {
            InitializeComponent();
        }

        private void rbtnCategory_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnCategory.Checked == true)
            {
                txtCategory.ReadOnly = false;
            }
            else
            {
                txtCategory.ReadOnly = true;
            }
        }

        private void rbtnProducer_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnProducer.Checked == true)
            {
                txtProducer.ReadOnly = false;
            }
            else
            {
                txtProducer.ReadOnly = true;
            }
        }
    }
}
