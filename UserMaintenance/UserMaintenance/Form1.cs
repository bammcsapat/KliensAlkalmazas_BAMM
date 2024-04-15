using System.Drawing.Drawing2D;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System;
//using Hotcakes.CommerceDTO.v1.Client;

namespace UserMaintenance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            var url = string.Empty;
            var key = string.Empty;

            if (url == string.Empty) url = "http://20.234.113.211:8088";
            if (key == string.Empty) key = "1-4ce1a804-7cba-4a55-9a83-3ef3104c2908";

            //var proxy = new Api(url, key);

            //var snaps = proxy.CategoriesFindAll();
            //var s = proxy.ProductsFindAll();


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

            //1-4ce1a804-7cba-4a55-9a83-3ef3104c2908
        }
        //public async Task<List<Product>> GetProducts(string apiKey, string searchTerm = "")
        //{
        //    using (HttpClient client = new HttpClient())
        //    {
        //        client.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

        //        string url = $"http://20.234.113.211:8088/api/products";

        //        if (!string.IsNullOrEmpty(searchTerm))
        //        {
        //            url += $"?searchTerm={searchTerm}";
        //        }

        //        HttpResponseMessage response = await client.GetAsync(url);

        //        if (response.IsSuccessStatusCode)
        //        {
        //            string jsonResponse = await response.Content.ReadAsStringAsync();
        //            JArray productsArray = JArray.Parse(jsonResponse);

        //            List<Product> products = productsArray.ToObject<List<Product>>();

        //            return products;
        //        }
        //        else
        //        {
        //            // Handle error
        //            return null;
        //        }
        //    }
        //}
        //private async void BindProductsToGrid(string searchTerm = "")
        //{
        //    string apiKey = "1-4ce1a804-7cba-4a55-9a83-3ef3104c2908";

        //    List<Product> products = await GetProducts(apiKey, searchTerm);

        //    if (products != null)
        //    {
        //        //dataGridView1.DataSource = products;
        //        productBindingSource.DataSource = products;
        //    }
        //}

        //private void textBox1_TextChanged(object sender, EventArgs e)
        //{
        //    BindProductsToGrid(textBox1.Text);
        //}



    }
}

        