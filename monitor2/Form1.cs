using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace monitor2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int numberOfMonitors = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            Directory.CreateDirectory("logs");
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void writeMsg(string msg) { 
        
        }

        private void monitoringControl1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Label lbl = new Label();
            lbl.Text = "Монитор " + (numberOfMonitors + 1);
            lbl.Font = new Font(FontFamily.GenericSansSerif, 10);

            
            monitoringControl mc = new monitoringControl();
            lbl.Location = new Point(0, (numberOfMonitors * mc.Height) + numberOfMonitors * 20 );
            mc.Location = new Point(0, (numberOfMonitors * mc.Height) + numberOfMonitors * 20 + 20);
            splitContainer2.Panel1.Controls.Add(mc);
            splitContainer2.Panel1.Controls.Add(lbl);

            numberOfMonitors++;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            foreach (monitoringControl mc in splitContainer2.Panel1.Controls.OfType<monitoringControl>())
            {
                mc.preClose();

            }
        }

    }
}
/* public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        FileSystemWatcher fsw = new FileSystemWatcher();
        private void button1_Click(object sender, EventArgs e)
        {
            fsw.NotifyFilter = NotifyFilters.Attributes | NotifyFilters.CreationTime | NotifyFilters.DirectoryName | NotifyFilters.FileName | NotifyFilters.LastAccess | NotifyFilters.LastWrite | NotifyFilters.Security | NotifyFilters.Size;
                    
            fsw.Path =@"C:\";
            

            fsw.Renamed += fsw_Changed;
            fsw.Changed += fsw_Changed;
            fsw.Created += fsw_Changed;
            fsw.Deleted += fsw_Changed;

            fsw.IncludeSubdirectories = true;
            fsw.EnableRaisingEvents = true;

            richTextBox1.Text += fsw.Path+"\n";

        }

        void fsw_Changed(object sender, FileSystemEventArgs e)
        {
           writeToTextBox(String.Format("{0} {1}", e.ChangeType, e.FullPath));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fsw.EnableRaisingEvents = false;            
            
        }

        private void writeToTextBox(string text) {
            richTextBox1.Invoke((MethodInvoker)(delegate() { richTextBox1.Text += text+"\n"; }));

        }*/