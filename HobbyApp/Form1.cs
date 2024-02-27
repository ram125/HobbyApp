namespace HobbyApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] contents = { "hobbyroman", "hobbytoshko" };
            checkedListBox1.DataSource = contents;
        }
    }
}