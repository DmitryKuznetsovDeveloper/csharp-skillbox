using System.Collections.ObjectModel;

namespace PracticalWork009
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Splite_Click(object sender, EventArgs e)
        {
            string[] array = textBox1.Text.Split();
            for (int i = 0; i < array.Length; i++)
            {
                listBox1.Items.Add(array[i]);
            }
        }

        private void MyReverse_Click(object sender, EventArgs e)
        {
            string[] array = textBox2.Text.Split();
            Array.Reverse(array);
            label2.Text = string.Join(" ", array);
        }


        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}