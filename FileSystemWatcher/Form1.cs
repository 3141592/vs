using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Data;

namespace FileSystemWatcher
{
    //  Stop lights
    enum Signal {Red, Yellow, Green};

	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
        //  Global file name for log file
        private string g_LogFile;
        private StreamWriter g_SR;
        private Boolean g_Logging = false;
        private long g_ChangeCounter = 0;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Button cmdBrowse;
        private System.Windows.Forms.ListBox lstFileList;
        private System.Windows.Forms.Button cmdStart;
        private System.Windows.Forms.Button cmdStop;
        private System.Windows.Forms.Button cmdExit;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label lblRed;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdBrowseLog;
        private System.Windows.Forms.TextBox txtLogFile;
        private System.Windows.Forms.Button cmdClear;
        private System.Windows.Forms.CheckBox cbIncludeSubDir;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cbChanged;
        private System.Windows.Forms.CheckBox cbCreated;
        private System.Windows.Forms.CheckBox cbDeleted;
        private System.Windows.Forms.CheckBox cbRenamed;
        private System.Windows.Forms.CheckBox cbListUpdates;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox cbAlwaysOnTop;
        private System.ComponentModel.IContainer components;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//

            //  Initial stop light image
            ChangeLight((int)Signal.Red);
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.cmdBrowse = new System.Windows.Forms.Button();
            this.lstFileList = new System.Windows.Forms.ListBox();
            this.cmdStart = new System.Windows.Forms.Button();
            this.cmdStop = new System.Windows.Forms.Button();
            this.cmdExit = new System.Windows.Forms.Button();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblRed = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.cmdBrowseLog = new System.Windows.Forms.Button();
            this.txtLogFile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdClear = new System.Windows.Forms.Button();
            this.cbIncludeSubDir = new System.Windows.Forms.CheckBox();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbChanged = new System.Windows.Forms.CheckBox();
            this.cbCreated = new System.Windows.Forms.CheckBox();
            this.cbDeleted = new System.Windows.Forms.CheckBox();
            this.cbRenamed = new System.Windows.Forms.CheckBox();
            this.cbListUpdates = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.cbAlwaysOnTop = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select folders to watch:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(136, 12);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(380, 20);
            this.txtFileName.TabIndex = 1;
            this.txtFileName.Text = "c:\\";
            // 
            // cmdBrowse
            // 
            this.cmdBrowse.Location = new System.Drawing.Point(524, 12);
            this.cmdBrowse.Name = "cmdBrowse";
            this.cmdBrowse.TabIndex = 2;
            this.cmdBrowse.Text = "Browse";
            this.cmdBrowse.Click += new System.EventHandler(this.cmdBrowse_Click);
            // 
            // lstFileList
            // 
            this.lstFileList.HorizontalScrollbar = true;
            this.lstFileList.Location = new System.Drawing.Point(12, 132);
            this.lstFileList.Name = "lstFileList";
            this.lstFileList.ScrollAlwaysVisible = true;
            this.lstFileList.Size = new System.Drawing.Size(588, 251);
            this.lstFileList.TabIndex = 5;
            // 
            // cmdStart
            // 
            this.cmdStart.Location = new System.Drawing.Point(364, 404);
            this.cmdStart.Name = "cmdStart";
            this.cmdStart.TabIndex = 6;
            this.cmdStart.Text = "Start";
            this.cmdStart.Click += new System.EventHandler(this.cmdStart_Click);
            // 
            // cmdStop
            // 
            this.cmdStop.Location = new System.Drawing.Point(444, 404);
            this.cmdStop.Name = "cmdStop";
            this.cmdStop.TabIndex = 7;
            this.cmdStop.Text = "Stop";
            this.cmdStop.Click += new System.EventHandler(this.cmdStop_Click);
            // 
            // cmdExit
            // 
            this.cmdExit.Location = new System.Drawing.Point(524, 404);
            this.cmdExit.Name = "cmdExit";
            this.cmdExit.TabIndex = 8;
            this.cmdExit.Text = "Exit";
            this.cmdExit.Click += new System.EventHandler(this.cmdExit_Click);
            // 
            // lblGreen
            // 
            this.lblGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGreen.Location = new System.Drawing.Point(300, 404);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(23, 23);
            this.lblGreen.TabIndex = 8;
            // 
            // lblRed
            // 
            this.lblRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRed.Location = new System.Drawing.Point(328, 404);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(23, 23);
            this.lblRed.TabIndex = 10;
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // cmdBrowseLog
            // 
            this.cmdBrowseLog.Location = new System.Drawing.Point(523, 100);
            this.cmdBrowseLog.Name = "cmdBrowseLog";
            this.cmdBrowseLog.TabIndex = 4;
            this.cmdBrowseLog.Text = "Browse";
            this.cmdBrowseLog.Click += new System.EventHandler(this.cmdBrowseLog_Click);
            // 
            // txtLogFile
            // 
            this.txtLogFile.Location = new System.Drawing.Point(135, 100);
            this.txtLogFile.Name = "txtLogFile";
            this.txtLogFile.Size = new System.Drawing.Size(380, 20);
            this.txtLogFile.TabIndex = 3;
            this.txtLogFile.Text = "c:\\";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Save the log file here:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmdClear
            // 
            this.cmdClear.Location = new System.Drawing.Point(216, 404);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.TabIndex = 9;
            this.cmdClear.Text = "Clear List";
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // cbIncludeSubDir
            // 
            this.cbIncludeSubDir.Checked = true;
            this.cbIncludeSubDir.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbIncludeSubDir.Location = new System.Drawing.Point(140, 36);
            this.cbIncludeSubDir.Name = "cbIncludeSubDir";
            this.cbIncludeSubDir.Size = new System.Drawing.Size(140, 24);
            this.cbIncludeSubDir.TabIndex = 12;
            this.cbIncludeSubDir.Text = "Include subdirectories?";
            // 
            // txtFilter
            // 
            this.txtFilter.Location = new System.Drawing.Point(424, 36);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(176, 20);
            this.txtFilter.TabIndex = 13;
            this.txtFilter.Text = "*.*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(288, 40);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "All or part of files named:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Events to monitor:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbChanged
            // 
            this.cbChanged.Checked = true;
            this.cbChanged.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbChanged.Location = new System.Drawing.Point(140, 64);
            this.cbChanged.Name = "cbChanged";
            this.cbChanged.Size = new System.Drawing.Size(72, 24);
            this.cbChanged.TabIndex = 16;
            this.cbChanged.Text = "Changed";
            // 
            // cbCreated
            // 
            this.cbCreated.Checked = true;
            this.cbCreated.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCreated.Location = new System.Drawing.Point(216, 64);
            this.cbCreated.Name = "cbCreated";
            this.cbCreated.Size = new System.Drawing.Size(72, 24);
            this.cbCreated.TabIndex = 17;
            this.cbCreated.Text = "Created";
            // 
            // cbDeleted
            // 
            this.cbDeleted.Checked = true;
            this.cbDeleted.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDeleted.Location = new System.Drawing.Point(292, 64);
            this.cbDeleted.Name = "cbDeleted";
            this.cbDeleted.Size = new System.Drawing.Size(72, 24);
            this.cbDeleted.TabIndex = 18;
            this.cbDeleted.Text = "Deleted";
            // 
            // cbRenamed
            // 
            this.cbRenamed.Checked = true;
            this.cbRenamed.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbRenamed.Location = new System.Drawing.Point(368, 64);
            this.cbRenamed.Name = "cbRenamed";
            this.cbRenamed.Size = new System.Drawing.Size(72, 24);
            this.cbRenamed.TabIndex = 19;
            this.cbRenamed.Text = "Renamed";
            // 
            // cbListUpdates
            // 
            this.cbListUpdates.Checked = true;
            this.cbListUpdates.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbListUpdates.Location = new System.Drawing.Point(12, 388);
            this.cbListUpdates.Name = "cbListUpdates";
            this.cbListUpdates.Size = new System.Drawing.Size(176, 24);
            this.cbListUpdates.TabIndex = 20;
            this.cbListUpdates.Text = "Show immediate list updates";
            // 
            // checkBox1
            // 
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(292, 60);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(72, 24);
            this.checkBox1.TabIndex = 18;
            this.checkBox1.Text = "Deleted";
            // 
            // checkBox2
            // 
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(216, 60);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(72, 24);
            this.checkBox2.TabIndex = 17;
            this.checkBox2.Text = "Created";
            // 
            // checkBox3
            // 
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Location = new System.Drawing.Point(140, 60);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(72, 24);
            this.checkBox3.TabIndex = 16;
            this.checkBox3.Text = "Changed";
            // 
            // cbAlwaysOnTop
            // 
            this.cbAlwaysOnTop.Location = new System.Drawing.Point(12, 412);
            this.cbAlwaysOnTop.Name = "cbAlwaysOnTop";
            this.cbAlwaysOnTop.Size = new System.Drawing.Size(176, 24);
            this.cbAlwaysOnTop.TabIndex = 21;
            this.cbAlwaysOnTop.Text = "This window always on top";
            this.cbAlwaysOnTop.CheckedChanged += new System.EventHandler(this.cbAlwaysOnTop_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(618, 443);
            this.Controls.Add(this.cbAlwaysOnTop);
            this.Controls.Add(this.cbListUpdates);
            this.Controls.Add(this.cbRenamed);
            this.Controls.Add(this.cbDeleted);
            this.Controls.Add(this.cbCreated);
            this.Controls.Add(this.cbChanged);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.cbIncludeSubDir);
            this.Controls.Add(this.cmdClear);
            this.Controls.Add(this.cmdBrowseLog);
            this.Controls.Add(this.txtLogFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblRed);
            this.Controls.Add(this.lblGreen);
            this.Controls.Add(this.cmdExit);
            this.Controls.Add(this.cmdStop);
            this.Controls.Add(this.cmdStart);
            this.Controls.Add(this.lstFileList);
            this.Controls.Add(this.cmdBrowse);
            this.Controls.Add(this.txtFileName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "File System Watcher";
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

        private void cmdExit_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void ChangeLight(int w_color)
        {
            switch(w_color)
            {

                case (int)Signal.Red:
                    this.lblRed.BackColor= Color.Red;
                    this.lblGreen.BackColor= Color.Gray;
                    //this.lblYellow.BackColor= Color.Gray;
                    break;

                case (int)Signal.Yellow:
                    this.lblRed.BackColor= Color.Gray;
                    this.lblGreen.BackColor= Color.Gray;
                    //this.lblYellow.BackColor= Color.Yellow;
                    break;
                
                case (int)Signal.Green:
                    this.lblRed.BackColor= Color.Gray;
                    this.lblGreen.BackColor= Color.Green;
                    //this.lblYellow.BackColor= Color.Gray;
                    break;
            }
        }

        private void cmdStart_Click(object sender, System.EventArgs e)
        {
            ChangeLight((int) Signal.Green);

            if(!this.cbListUpdates.Checked)
            {
                this.lstFileList.BeginUpdate();
            }

            if(!this.txtLogFile.Equals(""))
            {
                //  Start logging in the log file
                OpenLogFile();
                g_Logging = true;
            }
            
            //this.fileSystemWatcher1.NotifyFilter = NotifyFilters.
            this.fileSystemWatcher1.Path = this.txtFileName.Text;
            this.fileSystemWatcher1.Filter = this.txtFilter.Text;

            if(this.cbIncludeSubDir.Checked)
            {
                this.fileSystemWatcher1.IncludeSubdirectories = true;
            }
            else
            {
                this.fileSystemWatcher1.IncludeSubdirectories = false;
            }

            // Add event handlers.
            if(this.cbChanged.Checked)
                this.fileSystemWatcher1.Changed += new FileSystemEventHandler(OnChanged);
            if(this.cbCreated.Checked)
                this.fileSystemWatcher1.Created += new FileSystemEventHandler(OnChanged);
            if(this.cbDeleted.Checked)
                this.fileSystemWatcher1.Deleted += new FileSystemEventHandler(OnChanged);
            if(this.cbRenamed.Checked)
                this.fileSystemWatcher1.Renamed += new RenamedEventHandler(OnRenamed);

            this.fileSystemWatcher1.EnableRaisingEvents = true;
        }

        private void OpenLogFile()
        {
            string tempLogName = "FileSystemLog " + DateTime.Now.Year 
                + DateTime.Now.Month + DateTime.Now.Day + DateTime.Now.Hour 
                + DateTime.Now.Minute + DateTime.Now.Second   +  ".txt";
            //  name a log file
            g_LogFile = this.txtLogFile.Text + "\\" + tempLogName;
            
            //  change the name if the file already exists
            while (File.Exists(this.txtLogFile.Text)) 
            {
                tempLogName = "FileSystemLog " + DateTime.Now.Year 
                    + DateTime.Now.Month + DateTime.Now.Day + DateTime.Now.Hour 
                    + DateTime.Now.Minute + DateTime.Now.Second   +  ".txt";
                g_LogFile = this.txtLogFile.Text + "\\" + tempLogName;
            }

            //open it - finally!
            g_SR = File.CreateText(g_LogFile);
        }

        // Define the event handlers.
        private void OnChanged(object source, FileSystemEventArgs e)
        {
            g_ChangeCounter++;
            // Specify what is done when a file is changed, created, or deleted.
            this.lstFileList.Items.Add(g_ChangeCounter + ": " + DateTime.Now + " " + e.ChangeType + ": " + e.FullPath);
            this.lstFileList.SelectedIndex = this.lstFileList.Items.Count - 1;
            //this.lstFileList.Refresh();
            if(g_Logging)
                g_SR.WriteLine(g_ChangeCounter + "," + DateTime.Now + "," + e.ChangeType + "," + e.FullPath);
        }
        
        private  void OnRenamed(object source, RenamedEventArgs e)
        {
            g_ChangeCounter++;
            // Specify what is done when a file is renamed.
            this.lstFileList.Items.Add(g_ChangeCounter + ": " + DateTime.Now + " " + e.ChangeType + ": " + e.FullPath);
            this.lstFileList.SelectedIndex = this.lstFileList.Items.Count -1;
            //this.lstFileList.Refresh();
            if(g_Logging)
                g_SR.WriteLine(g_ChangeCounter + "," + DateTime.Now + "," + e.ChangeType + "," + e.FullPath);
        }

        private void cmdStop_Click(object sender, System.EventArgs e)
        {   
            this.fileSystemWatcher1.EnableRaisingEvents = false;
            ChangeLight((int) Signal.Yellow);
            Thread.Sleep(50);  
            if(g_Logging)g_SR.Close();
            ChangeLight((int) Signal.Red);
            g_ChangeCounter = 0;

            if(!this.cbListUpdates.Checked)
            {
                this.lstFileList.EndUpdate();
            }
        }

        private void cmdBrowse_Click(object sender, System.EventArgs e)
        {   
            if(!this.txtFileName.Text.Equals(""))
            {
                this.folderBrowserDialog1.SelectedPath = this.txtFileName.Text;
            }
                this.folderBrowserDialog1.ShowNewFolderButton = false;
                this.folderBrowserDialog1.ShowDialog();
                this.txtFileName.Text = folderBrowserDialog1.SelectedPath;
        }

        private void cmdBrowseLog_Click(object sender, System.EventArgs e)
        {
            if(!this.txtLogFile.Text.Equals(""))
            {
                this.folderBrowserDialog1.SelectedPath = this.txtLogFile.Text;
            }
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            this.folderBrowserDialog1.ShowDialog();
            this.txtLogFile.Text = folderBrowserDialog1.SelectedPath;
            g_LogFile = this.txtLogFile.Text + "\\" + "FileSystemLog " + DateTime.Now + ".txt";
        }

        private void cmdClear_Click(object sender, System.EventArgs e)
        {
            this.lstFileList.Items.Clear();
        }

        private void cbAlwaysOnTop_CheckedChanged(object sender, System.EventArgs e)
        {
            if(this.cbAlwaysOnTop.Checked)
            {
                this.TopMost = true;
            }
            else 
            {
                this.TopMost = false;
            }
        }

	}
}
