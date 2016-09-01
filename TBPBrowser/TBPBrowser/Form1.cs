using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TBPBrowser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) // ie go
        { // lets see what type of text i have
            
            if (URLBox.Text.Contains("http") || URLBox.Text.Contains("https"))
            {
                // we have the html so it sould be fine...
            }else
            {
                URLBox.Text = "http://" + URLBox.Text;  // adds the https://!
            }
            // lets look for common websites...
            Uri url = new Uri(URLBox.Text);
            webBrowser1.Url = url;
        }

        private void UrlBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            URLBox.Text = webBrowser1.Url.ToString();
        }
    }
}
