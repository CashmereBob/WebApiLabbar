using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F03L02___KlientUppgift_2
{
    public partial class Form1 : Form
    {
        const string apiKey = "abdcb6922e0d826d2959df4048276068610126e99ba8";
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string url = $"https://api.thumbnail.ws/api/" + apiKey + "/thumbnail/get?url=" + textBox1.Text + "&width=" + pictureBox1.Width;

            try
            {
                WebRequest request = WebRequest.Create(url);

                label1.Text = "Loading";
                WebResponse response = request.GetResponse();

                label1.Text = ((HttpWebResponse)response).StatusDescription;

                Stream datastream = response.GetResponseStream();

                var image = Image.FromStream(datastream);

                pictureBox1.Image = image;

                response.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
                    
                    
            }
        }
    }
}
