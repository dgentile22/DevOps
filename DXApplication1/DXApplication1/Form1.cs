using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
//Class
using MyTestApplication.Class;


namespace MyTestApplication
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        public Form1()
        {
            InitializeComponent();


            string fPath1 = Path.Combine(FilePaths.GetFolderPath("Accounting"), "test.txt");
            string fPath2 = Path.Combine(FilePaths.GetFolderPath("IT"), "test.txt");
            string fPath3 = Path.Combine(FilePaths.GetFolderPath("Service_Logs"), "test.txt");
            string fPath4 = Path.Combine(FilePaths.GetFolderPath("_Customers"), "Testing" + "\\" + "test.txt");

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            dxValidationProvider1.Validate();
        }
    }
}
