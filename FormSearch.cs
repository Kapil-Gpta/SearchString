using System;
using System.Windows.Forms;

namespace SearchString
{
    public partial class FormSearch : Form
    {
        public ISearch _search;  
        public FormSearch()
        {
            _search = new Search();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string delimiter = ",";
            if (string.IsNullOrEmpty(txtString.Text.Trim()) || String.IsNullOrEmpty(txtSubString.Text.Trim()))
            {
                MessageBox.Show("Please enter valid value for Main Text/SubText.");
                return; 
            }
            var results = _search.FindOccurencesOfString(txtString.Text.Trim(), txtSubString.Text.Trim());
            if (results != null && results.Count > 0)
                lblResults.Text = String.Join(delimiter, results);

        }

        
    }
}
