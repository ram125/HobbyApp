namespace HobbyApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                listBox1.Items.Add(checkBox1.Text);
            }
            else
            {
                listBox1.Items.Remove(checkBox1.Text);
            }
        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                listBox1.Items.Add(checkBox2.Text);
            }
            else
            {
                listBox1.Items.Remove(checkBox2.Text);
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                listBox1.Items.Add(checkBox3.Text);
            }
            else
            {
                listBox1.Items.Remove(checkBox3.Text);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 0)
            {
                listBox2.Items.Add(listBox1.Items[0].ToString());
                listBox1.Items.RemoveAt(0);
            }
            else if (listBox1.SelectedIndex == 1)
            {
                listBox2.Items.Add(listBox1.Items[1].ToString());
                listBox1.Items.RemoveAt(1);
            }
            else if (listBox1.SelectedIndex == 2)
            {
                listBox2.Items.Add(listBox1.Items[2].ToString());
                listBox1.Items.RemoveAt(2);
            }
            else if (listBox1.SelectedIndex == 3)
            {
                listBox2.Items.Add(listBox1.Items[3].ToString());
                listBox1.Items.RemoveAt(3);
            }
            else if (listBox1.SelectedIndex == 4)
            {
                listBox2.Items.Add(listBox1.Items[4].ToString());
                listBox1.Items.RemoveAt(4);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex == 0)
            {
                listBox1.Items.Add(listBox2.Items[0].ToString());
                listBox2.Items.RemoveAt(0);
            }
            else if (listBox2.SelectedIndex == 1)
            {
                listBox1.Items.Add(listBox2.Items[1].ToString());
                listBox2.Items.RemoveAt(1);
            }
            else if (listBox1.SelectedIndex == 2)
            {
                listBox1.Items.Add(listBox2.Items[2].ToString());
                listBox2.Items.RemoveAt(2);
            }
            else if (listBox1.SelectedIndex == 3)
            {
                listBox1.Items.Add(listBox2.Items[3].ToString());
                listBox2.Items.RemoveAt(3);
            }
            else if (listBox1.SelectedIndex == 4)
            {
                listBox1.Items.Add(listBox2.Items[4].ToString());
                listBox2.Items.RemoveAt(4);
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            if (comboBox1.SelectedIndex == 0)
            {
                comboBox2.Items.Add("Sofia");
                comboBox2.Items.Add("Plovdiv");
                comboBox2.Items.Add("Burgas");
                comboBox2.Items.Add("Varna");
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                comboBox2.Items.Add("Milan");
                comboBox2.Items.Add("Rome");
                comboBox2.Items.Add("Bari");
                comboBox2.Items.Add("Venice");
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                comboBox2.Items.Add("New York City");
                comboBox2.Items.Add("Los Angeles");
                comboBox2.Items.Add("Washington DC");
                comboBox2.Items.Add("Philadelphia");
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                comboBox2.Items.Add("Amsterdam");
                comboBox2.Items.Add("Rotterdam");
                comboBox2.Items.Add("Leeuwarden");
                comboBox2.Items.Add("Hague");
            }
        }
        public string Time()
        {
            if (radioButton1.Checked)
            {
                return radioButton1.Text;
            }
            else
            {
                return radioButton2.Text;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string selectedHobbies = string.Join(", ", listBox2.Items.OfType<object>().Select(item => item.ToString()));
            string selectedTime = Time();

            MessageBox.Show($"Your chosen country is {comboBox1.SelectedItem.ToString()} and your chosen city is " +
                $"{comboBox2.SelectedItem.ToString()}. Your chosen hobbies are {selectedHobbies}, and you prefer to do them in the {selectedTime}.");
            Environment.Exit(0);
        }
    }
}