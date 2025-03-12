namespace WinFormsApp1
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SideA.Text = Properties.Settings.Default.a.ToString();
            SideB.Text = Properties.Settings.Default.b.ToString();
            SideC.Text = Properties.Settings.Default.c.ToString();
            SideA.KeyDown += new KeyEventHandler(TextBox_KeyDown);
            SideB.KeyDown += new KeyEventHandler(TextBox_KeyDown);
            SideC.KeyDown += new KeyEventHandler(TextBox_KeyDown);
            button1.KeyDown += new KeyEventHandler(TextBox_KeyDown);
            button2.KeyDown += new KeyEventHandler(TextBox_KeyDown);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float a, b, c;
            try
            {
                a = float.Parse(this.SideA.Text);
                b = float.Parse(this.SideB.Text);
                c = float.Parse(this.SideC.Text);
                Properties.Settings.Default.a = a;
                Properties.Settings.Default.b = b;
                Properties.Settings.Default.c = c;
                Properties.Settings.Default.Save();
            }
            catch (FormatException)
            {
                return;
            }
            var message = Logic.Check(a, b, c);
            label4.Text = message;
            label4.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SideA.Text = null;
            SideB.Text = null;
            SideC.Text = null;
            label4.Text = null;
        }
        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                this.SelectNextControl((Control)sender, true, true, true, true);
                e.SuppressKeyPress = true;
            }
            else if (e.KeyCode==Keys.Up)
            {
                this.SelectNextControl((Control)sender, false, true, true, true);
                e.SuppressKeyPress = true;
            }
        }
    }
    public class Logic
    {
        public static string Check(float a, float b, float c)
        {
            if (a + b > c && a + c > b && c + b > a)
            {
                if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2) || Math.Pow(a, 2) + Math.Pow(c, 2) == Math.Pow(b, 2) || Math.Pow(b, 2) + Math.Pow(c, 2) == Math.Pow(a, 2))
                {
                    return "Треугольник прямоугольный";
                }
                else
                {
                    return "Треугольник непрямоугольный";
                }
            }
            else
            {
                return "Треугольника с такими сторонами не существует";
            }
        }
    }
}
