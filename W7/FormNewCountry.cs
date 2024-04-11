using CsvHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W7
{
    public partial class FormNewCountry : Form
    {
        public CountryData CountryData;
        public FormNewCountry()
        {
            InitializeComponent();
        }

        private void FormNewCountry_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = CountryData;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

        }
    }
}
