using System.Drawing.Drawing2D;

namespace UserMaintenance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Handle focus events
            textBox1.GotFocus += (sender, e) =>
            {
                if (textBox1.Text == "Keresés...")
                {
                    textBox1.Text = "";
                    textBox1.ForeColor = System.Drawing.Color.Black; // Set text color to black
                }
            };

            textBox1.LostFocus += (sender, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    textBox1.Text = "Keresés...";
                    textBox1.ForeColor = System.Drawing.Color.Gray; // Set text color to gray
                }
            };

                //// Create rounded corners for the textbox
                //textBox1.Padding = new Padding(10, 5, 10, 5); // Add padding to the textbox
                //GraphicsPath path = new GraphicsPath();
                //path.AddArc(0, 0, 20, 20, 180, 90);
                //path.AddArc(textBox1.Width - 20, 0, 20, 20, 270, 90);
                //path.AddArc(textBox1.Width - 20, textBox1.Height - 20, 20, 20, 0, 90);
                //path.AddArc(0, textBox1.Height - 20, 20, 20, 90, 90);
                //path.CloseFigure();

                //textBox1.Region = new Region(path);

                //// Create shadow effect
                //Panel shadowPanel = new Panel();
                //shadowPanel.Location = new Point(textBox1.Location.X + 3, textBox1.Location.Y + 3);
                //shadowPanel.Size = textBox1.Size;
                //shadowPanel.BackColor = Color.Gray;
                //shadowPanel.BorderStyle = BorderStyle.None;
                //shadowPanel.Region = new Region(path);

                //panel2.Controls.Add(shadowPanel); // Add shadow panel behind textbox
        }

        
    }
}

        