
using EO.WebBrowser.DOM;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Open_TestWindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            EO.WebBrowser.Runtime.AddLicense("mZvLn1mXwAAd457pzf8R7lnb5QUQvFuotcDcr2iptMPboVnq+fPw96ng9vYe" + "wK20psLcrmqns8PbsWqZpAcQ8azg8//ooWunprHavUaBpLHLn3Xq7fgZ4K3s" + "9vbpx23h9cXewI+/uNrsrnzm1QH++ajm+87ou2jq7fgZ4K3s9vbpjEOzs/0U" + "4p7l9/bpjEN14+30EO2s3MKetZ9Zl6TNF+ic3PIEEMidtbjD3rNtqrvJ47Vs" + "s7P9FOKe5ff29ON3hI6xy59Zs/D6DuSn6un26bto4+30EO2s3OnPuIlZl6Sx" + "5+Cl4/MI6YxDl6Sxy59Zl6TNDOOdl/gKG+R2mcng2cKh6fP+EKFZ7ekDHuio" + "5cGz3a9np6ax2r1GgaSxy591puX9F+6wtZE=");

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FileInfo projectDllURL = new FileInfo(Assembly.GetExecutingAssembly().CodeBase.Replace("file:///", ""));
            //取得html 相對路徑
            string htmlRelativeURL = Path.Combine(projectDllURL.DirectoryName, "Redactor\\index.html");

            webControl1.WebView = webView1;
            webControl1.WebView.LoadUrl(htmlRelativeURL);

        }

        TaskScheduler ts { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {



        }
        
    }
}
