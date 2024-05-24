using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBLearn
{
    public partial class UniversityMenu : Form
    {
        private string university_name;
        private string university_address;
        public UniversityMenu(string university_name, string university_address)
        {
            InitializeComponent();

            this.university_name = university_name;
            this.university_address = university_address;
        }

        private void UniversityMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
