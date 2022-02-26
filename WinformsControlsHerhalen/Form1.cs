using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformsControlsHerhalen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //var allPeople = SeedPeople.GetPeople();  var yerine asagida IENUmerable kllandik cunku read only olasini istiyoruz. Baskasinin person eklememesi gerekiyor.
            IEnumerable<Person> allPeople = SeedPeople.GetPeople();

            foreach (var item in allPeople)
            {
                lstAllPeople.Items.Add(item);
            }

            // lstAllPeople.DataSource = allPeople;  Bu ikinci yol, foreqch yerine bu sekildede kullanabiliriz.

            IEnumerable<Country> allCountries = SeedCountry.GetCountries();
            foreach (var item in allCountries)
            {
                lstAllCountries.Items.Add(item);

            }

            IEnumerable<Country> allCountriesForComboBox = SeedCountry.Countries;
            foreach (var item in allCountriesForComboBox)
            {
                cmbCountry.Items.Add(item);

            }
        }

        private void btnFilterByAge_Click(object sender, EventArgs e)
        {
            try
            {
                IEnumerable<Person> listPerAge = SeedPeople.People.Where(x => x.Age == Convert.ToInt32(txtFilter.Text)).ToList();
                lstDemo.DataSource = listPerAge;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            //IEnumerable<Person> allPeople = SeedPeople.GetPeople();
            //foreach (var item in allPeople)
            //{
            //    if (item.Country==Convert.ToInt32(txtFilter.Text))
            //    {
            //        lstDemo.Items.Add(item);
            //    }
            //}
        }

        private void btnFilterByCountry_Click(object sender, EventArgs e)
        {

        }

        private void cmbCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            // With Lamda

            //int selected = cmbCountry.SelectedIndex + 1;
            ////MessageBox.Show(selected.ToString());
            //IEnumerable<Person> list = SeedPeople.People.Where(x => x.Country == selected).ToList();
            //lstDemo.DataSource = list;

            lstDemo.Items.Clear();
            int selected = cmbCountry.SelectedIndex + 1;
            IEnumerable<Person> people = SeedPeople.People;
            foreach (var person in people)
            {
                if (person.Country==selected)
                {
                    lstDemo.Items.Add(person);
                }

            }

        }

        private void btnFindPerson_Click(object sender, EventArgs e)
        {
            var person = SeedPeople.People.Find(x => x.Id == (Convert.ToInt32(txtFilter.Text)));
            lstDemo.Items.Add(person);
        }
    }
}
