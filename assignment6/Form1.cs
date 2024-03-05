namespace assignment6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculateTime_Click(object sender, EventArgs e)
        {
            string input = txtbxInput.Text;
            int numberOfSeconds = int.Parse(input);

            int hours = numberOfSeconds / 3600;
            numberOfSeconds = numberOfSeconds - hours * 3600;

            int minutes = numberOfSeconds / 60;
            numberOfSeconds = numberOfSeconds - minutes * 60;

            txtTimeOutput.Text = ($"{hours:00}:{minutes:00}:{numberOfSeconds:00}");
        }
    }
}