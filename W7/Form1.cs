using CsvHelper;
using System.ComponentModel;
using System.Globalization;

namespace W7
{
    public partial class Form1 : Form
    {
        BindingList<CountryData> countryList = new BindingList<CountryData>();
        public Form1()
        {
            InitializeComponent();
            countryDataBindingSource.DataSource = countryList;
            dataGridView1.DataSource = countryDataBindingSource;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("european_countries.csv");
            var csv = new CsvReader(sr, CultureInfo.InvariantCulture);
            var arr = csv.GetRecords<CountryData>();
            foreach (var row in arr)
            {
                countryList.Add(row);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            countryDataBindingSource.RemoveCurrent();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            FormNewCountry fnc = new FormNewCountry();
            fnc.CountryData = countryDataBindingSource.Current as CountryData;
            fnc.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var writer = new StreamWriter("countries.csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(countryList);
            }
        }
    }
}