using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace PasswordGenerator
{
    public partial class PasswordGenerator : Form
    {
        public PasswordGenerator()
        {
            InitializeComponent();
        }

        private void PasswordGenerator_Load(object sender, EventArgs e)
        {
            // Setting the drop box to 8 by default.
            ListLength.Text = "8";
        }
        // Making it where it'll shuffle the set of characters it's given. 
        static string Shuffle(string input)
        {
            var Q = from C in input.ToCharArray()
                    orderby Guid.NewGuid()
                    select C;
            string S = string.Empty;
            foreach (var R in Q)
                S += R;
            return S;
        }
        private void BtnPasswordGen_Click(object sender, EventArgs e)
        {
            // Make constraint strings containing the characters. 
            const string UpperChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            const string LowerChars = "abcdefghijklmnopqrstuvwxyz";
            const string NumChars = "0123456789";
            const string SpecialChars = @"!#$%&*@\";
            string Password = " ";
            // Checking to see if the check boxes are marked or not.
            int PasswordLength = Int32.Parse(ListLength.Text);

            if (ChkUpper.Checked)
            {
                Password += UpperChars;
            }
            if (ChkLower.Checked)
            {
                Password += LowerChars;
            }
            if (ChkNum.Checked)
            {
                Password += NumChars;
            }
            if (ChkSpecial.Checked)
            {
                Password += SpecialChars;
            }
            // Shuffle the above symbols using shuffle() method then remove extra characters that go pass the selected drop down value.  
            Password = Shuffle(Password); 
            Password = Password.Remove(PasswordLength);  
            TxtPassword.Text = Password.ToString();
        }
    }
}
