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
            var toleranceValues = new Dictionary<string, double>
            {
                { "BROWN", 1 },
                { "RED", 2 },
                { "ORANGE", 3 },
                { "YELLOW", 4 },
                { "GREEN", 0.5 },
                { "BLUE", 0.25 },
                { "VIOLET", 0.1 },
                { "GREY", 0.005 },
                { "GOLD", 5 },
                { "SILVER", 10 }
            };
            return toleranceValues.TryGetValue(color.ToUpper(), out double result) ? result : 0;
        }

        private string color_to_num(string color)
        {
            var colorToNumMappings = new Dictionary<string, string>
            {
                { "BLACK", "0" },
                { "BROWN", "1" },
                { "RED", "2" },
                { "ORANGE", "3" },
                { "YELLOW", "4" },
                { "GREEN", "5" },
                { "BLUE", "6" },
                { "VIOLET", "7" },
                { "GREY", "8" },
                { "WHITE", "9" }
            };
            return colorToNumMappings.TryGetValue(color.ToUpper(), out string result) ? result : "0";
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
