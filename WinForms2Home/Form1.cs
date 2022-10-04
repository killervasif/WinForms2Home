using System.Text.Json;
using System.Text.RegularExpressions;

namespace WinForms2Home
{
    public partial class Form1 : Form
    {
        bool isSaved = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            if (isSaved)
            {
                foreach (var control in AnketGb.Controls)
                {
                    if (control is TextBox)
                        (control as TextBox).Text = "";
                }
                isSaved = false;
                Savebtn.Text = "Save";
                return;
            }
            bool isChecked = false;
            string? phonePattern = @"^[+]?[(]?[0-9]{3}[)]?[-\s.]?[0-9]{3}[-\s.]?[0-9]{4,6}$";
            Regex regex = new(phonePattern);
            foreach (var control in AnketGb.Controls)
            {
                if (control is TextBox && string.IsNullOrEmpty((control as TextBox).Text))
                {
                    MessageBox.Show($"{(control as TextBox).PlaceholderText} should be written");
                    return;
                }
                else if (control is RadioButton)
                    if ((control as RadioButton).Checked)
                        isChecked = true;
            }
            if (!regex.IsMatch(Phonetxt.Text))
            {
                MessageBox.Show("Invalid phone number");
                return;
            }
            if (isChecked)
            {
                string gender = Malerb.Checked ? "Male" : "Female";
                Anket a = new(Surnametxt.Text, Nametxt.Text, Fathertxt.Text, Countrytxt.Text, Citytxt.Text, Phonetxt.Text, gender, Birthdatedp.Value);
                string serializer = JsonSerializer.Serialize(a);
                File.WriteAllText($"{a.Name}.json", serializer);
                isSaved = true;
                Savebtn.Text = "Clear";
                MessageBox.Show("Saved");
                return;
            }
            else
            {
                MessageBox.Show("You must identify your gender");
                return;
            }
        }

        private void Loadbtn_Click(object sender, EventArgs e)
        {
            Anket a=null;
            DirectoryInfo directoryInfo = new(Directory.GetCurrentDirectory());
            foreach (var file in directoryInfo.GetFiles())
            {
                if (file.Name.Contains(Loadtxt.Text))
                    a = JsonSerializer.Deserialize<Anket>(File.ReadAllText(file.FullName));
                if (a != null)
                {
                    Surnametxt.Text = a.Surname;
                    Nametxt.Text = a.Name;
                    Fathertxt.Text = a.FatherName;
                    Countrytxt.Text = a.Country;
                    Citytxt.Text = a.City;
                    Phonetxt.Text = a.Phone;
                    if (a.Gender == "Male")
                        Malerb.Checked = true;
                    else
                        Femalerb.Checked = true;
                    return;
                }                
            }
            MessageBox.Show("File Doesn't Exist");
            return;
        }
    }
}