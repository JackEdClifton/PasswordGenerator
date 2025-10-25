using System;
using System.Windows.Forms;

namespace PasswordGenerator
{
	public partial class Form1 : Form
	{		
		private static Random random = new Random();
		
		public Form1()
		{
			InitializeComponent();
		}
		
		private void GeneratePassword_Click(object sender, EventArgs e)
		{
			// characters the password can contain
			string validPasswordCharacters = "";

			if (LowerCase.Checked)
				validPasswordCharacters += "abcdefghijklmnopqrstuvwxyz";
			if (UpperCase.Checked) {
				validPasswordCharacters += "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
			}
			if (Numbers.Checked)
				validPasswordCharacters += "0123456789";
			if (Symbols.Checked)
				validPasswordCharacters += "!@#$%^&*";

			// generate password
			int length = Convert.ToInt32(PasswordLength.Value);
			string passwordOut = "";
			for (int i = 0; i < length; i++)
				passwordOut += validPasswordCharacters[random.Next(0, validPasswordCharacters.Length - 1)];

			// output password
			PasswordOut.Text = passwordOut;
		}

        private void button1_Click(object sender, EventArgs e)
        {
			System.Windows.Forms.Clipboard.SetText(PasswordOut.Text);
        }

    }
}
