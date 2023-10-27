namespace Szorzotabla_trener
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CreateButtons();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonKilep_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void CreateButtons()
        {
            int t = 0;
            int buttons = 10;
            for (int i = 0; i < buttons; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Button button = new Button();
                    button.Size = new Size(30, 30);
                    button.Location = new Point(j * 30, i * 30);
                    panel2.Controls.Add(button);
                    for (int k = 0; k < 101; k++)
                    {
                        t++;
                    }
                    button.Text = t.ToString();
                }
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            
            Random rnd1 = new Random();
            int x = rnd1.Next(10);
            Random rnd2 = new Random();
            int y = rnd1.Next(10);

            rnd2.Next(10);
            labelKerdes.Text = $"1. kérdés: {x.ToString()}*{y.ToString()}";
        }
    }
}