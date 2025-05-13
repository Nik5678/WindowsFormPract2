using System.Xml.Linq;

namespace _2_задание
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGreat_Click(object sender, EventArgs e)
        {
            string greeting = "Привет, " + textBoxName.Text + "!";
            labelGreeting.Text = greeting;
        }
    }
}
