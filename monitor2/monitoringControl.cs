using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace monitor2
{
    public partial class monitoringControl : UserControl
    {

       
 

        public monitoringControl()
        {
            InitializeComponent();
        }

        public string Path { get; set; }
        private string curDir;
        public string logFilePath="logs\\";

        private bool isWorking = false;
        public bool includeFolders { get; set; }
        public bool checkForChanges { get; set; }
        public bool checkForRename { get; set; }
        public bool checkForCreate { get; set; }
        public bool checkForDelete { get; set; }
        public bool checkForError { get; set; }


        private void startBtn_Click(object sender, EventArgs e)
        {
            //Form1.writeMsg("QQQQQQQQQQ");
            if (isWorking)
            {
                try
                {

                    watcher.EnableRaisingEvents = false;
                    startBtn.Text = "Start";
                    groupBox1.Enabled = true;
                    groupBox2.Enabled = true;
                    isWorking = false;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }

            else if (currentFolderTxt.Text != string.Empty)
            {

                try
                {

                    setNewmonitorFolder();
                    watcher.EnableRaisingEvents = true;

                    startBtn.Text = "Stop";
                    groupBox1.Enabled = false;
                    groupBox2.Enabled = false;
                    isWorking = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }



            }
            else
            {
                MessageBox.Show("Выберите путь для мониторинга");
            }
            
        }

        FileSystemWatcher watcher = new FileSystemWatcher();

        private void setNewmonitorFolder()
        {

            watcher.NotifyFilter = NotifyFilters.Attributes | NotifyFilters.CreationTime | NotifyFilters.DirectoryName | NotifyFilters.FileName | NotifyFilters.LastAccess | NotifyFilters.LastWrite | NotifyFilters.Security | NotifyFilters.Size ;

            watcher.Path = Path;

            watcher.IncludeSubdirectories = includeFolders;

            if (checkForRename || checkForError || checkForDelete || checkForCreate || checkForChanges) { }
            else
            {
                throw new Exception("Выберите хотя бы один тип событий для мониторинга");
            }
            


            if (checkForError) watcher.Error += watcher_Error;
            else watcher.Error -= watcher_Error;

            if (checkForChanges) watcher.Changed += watcher_Changed;
            else watcher.Changed -= watcher_Changed;

            if (checkForCreate) watcher.Created += watcher_Changed;
            else watcher.Created -= watcher_Changed;

            if (checkForDelete) watcher.Deleted += watcher_Changed;
            else watcher.Deleted -= watcher_Changed;

            if (checkForRename) watcher.Renamed += watcher_Changed;
            else watcher.Renamed -= watcher_Changed;





        }

        void watcher_Changed(object sender, FileSystemEventArgs e)
        {
            
            using (StreamWriter w = File.AppendText(String.Format("{1}log_{0}.txt", curDir.Replace(":\\",""),logFilePath)))
            {
                
                w.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(),DateTime.Now.ToLongDateString());
                w.WriteLine("{0} : {1}",e.ChangeType,e.FullPath);
                w.WriteLine("-------------------------------");
            }

        }


        void watcher_Error(object sender, ErrorEventArgs e)
        {
            using (StreamWriter w = File.AppendText(String.Format("log_{0}.txt", curDir.Replace(":\\", ""))))
            {

                w.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
                w.WriteLine("ERROR");
                w.WriteLine("-------------------------------");
            }
        }

        private void selectPathBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.RootFolder = System.Environment.SpecialFolder.MyComputer;

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                Path = fbd.SelectedPath;
                currentFolderTxt.Text = Path;
                curDir = new DirectoryInfo(Path).Name;
            }
        }

        private void internalCheck_CheckedChanged(object sender, EventArgs e)
        {
            includeFolders = internalCheck.Checked;
        }

        private void changeCheck_CheckedChanged(object sender, EventArgs e)
        {
            checkForChanges = changeCheck.Checked;
        }

        private void createCheck_CheckedChanged(object sender, EventArgs e)
        {
            checkForCreate = createCheck.Checked;
        }

        private void renameCheck_CheckedChanged(object sender, EventArgs e)
        {
            checkForRename = renameCheck.Checked;
        }

        private void deleteCheck_CheckedChanged(object sender, EventArgs e)
        {
            checkForDelete = deleteCheck.Checked;
        }

        private void errorCheck_CheckedChanged(object sender, EventArgs e)
        {
            checkForError = errorCheck.Checked;
        }

        private void changeLogFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.RootFolder = System.Environment.SpecialFolder.MyComputer;
            fbd.SelectedPath = logFilePath;

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                logFilePath=fbd.SelectedPath+"\\";
            }
        }

        public void preClose() {
            watcher.EnableRaisingEvents = false;
            watcher.Dispose();
        }
    }
}
