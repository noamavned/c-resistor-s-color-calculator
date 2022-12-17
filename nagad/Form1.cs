namespace nagad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double tolerance(string color)
        {
            switch (color)
            {
                case "BROWN": return 1;
                case "RED": return 2;
                case "ORANGE": return 3;
                case "YELLOW": return 4;
                case "GREEN": return 0.5;
                case "BLUE": return 0.25;
                case "VIOLET": return 0.1;
                case "GREY": return 0.005;
                case "GOLD": return 5;
                case "SILVER": return 10;
            }
            return 0;
        }

        private string color_to_num(string color)
        {
            switch(color)
            {
                case "BLACK": return "0";
                case "BROWN": return "1";
                case "RED": return "2";
                case "ORANGE": return "3";
                case "YELLOW": return "4";
                case "GREEN": return "5";
                case "BLUE": return "6";
                case "VIOLET": return "7";
                case "GREY": return "8";
                case "WHITE": return "9";
            }
            return "0";
        }

        private void calc_btn_Click(object sender, EventArgs e)
        {
            string[] options = { "BLACK", "BROWN", "RED", "ORANGE", "YELLOW", "GREEN", "BLUE", "VIOLET", "GREY", "WHITE", "GOLD", "SILVER" };
            if(Array.Exists(options, element => element == t1.Text) && Array.Exists(options, element => element == t2.Text) && Array.Exists(options, element => element == t3.Text) && Array.Exists(options, element => element == t4.Text))
            {
                double num, min, max;

                switch (t3.Text)
                {
                    case "GOLD": num = double.Parse(color_to_num(t1.Text) + color_to_num(t2.Text)) / 10; break;
                    case "SILVER": num = double.Parse(color_to_num(t1.Text) + color_to_num(t2.Text)) / 100; break;
                    default: num = double.Parse(color_to_num(t1.Text) + color_to_num(t2.Text) + new string('0', int.Parse(color_to_num(t3.Text)))); break;
                }
                min = (num / 100) * (100 - tolerance(t4.Text));
                max = (num / 100) * (100 + tolerance(t4.Text));
                System.Windows.Forms.MessageBox.Show($"Calculation: {num} Ω\nTolerance: {tolerance(t4.Text)}%\nRange: {min}Ω-{max}Ω");
            }
        }
    }
}