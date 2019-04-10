namespace Ushanka
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.singlePage = new System.Windows.Forms.TabPage();
            this.single_randomText = new System.Windows.Forms.Label();
            this.single_saveAllButton = new System.Windows.Forms.Button();
            this.single_saveButton = new System.Windows.Forms.Button();
            this.single_nextButton = new System.Windows.Forms.Button();
            this.single_prevButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.single_loadButton = new System.Windows.Forms.Button();
            this.single_textBox = new System.Windows.Forms.TextBox();
            this.single_pictureBox = new System.Windows.Forms.PictureBox();
            this.multiplePage = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.progressHelp = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_log_username = new System.Windows.Forms.Label();
            this.label_log_filename = new System.Windows.Forms.Label();
            this.multiple_progressBar = new System.Windows.Forms.ProgressBar();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.multiple_logBox = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.helpLog = new System.Windows.Forms.Label();
            this.goHelp = new System.Windows.Forms.Label();
            this.helpUsernames = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.multiple_usernameBox = new System.Windows.Forms.RichTextBox();
            this.multiple_goButton = new System.Windows.Forms.Button();
            this.settingsPage = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.settings_buttonSave = new System.Windows.Forms.Button();
            this.button_logLocation = new System.Windows.Forms.Button();
            this.settings_logTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button_downloadLocation = new System.Windows.Forms.Button();
            this.settings_downloadTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.logPage = new System.Windows.Forms.TabPage();
            this.logBox = new System.Windows.Forms.RichTextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControl1.SuspendLayout();
            this.singlePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.single_pictureBox)).BeginInit();
            this.multiplePage.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.settingsPage.SuspendLayout();
            this.logPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.singlePage);
            this.tabControl1.Controls.Add(this.multiplePage);
            this.tabControl1.Controls.Add(this.settingsPage);
            this.tabControl1.Controls.Add(this.logPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(384, 485);
            this.tabControl1.TabIndex = 0;
            // 
            // singlePage
            // 
            this.singlePage.Controls.Add(this.single_randomText);
            this.singlePage.Controls.Add(this.single_saveAllButton);
            this.singlePage.Controls.Add(this.single_saveButton);
            this.singlePage.Controls.Add(this.single_nextButton);
            this.singlePage.Controls.Add(this.single_prevButton);
            this.singlePage.Controls.Add(this.label1);
            this.singlePage.Controls.Add(this.single_loadButton);
            this.singlePage.Controls.Add(this.single_textBox);
            this.singlePage.Controls.Add(this.single_pictureBox);
            this.singlePage.Location = new System.Drawing.Point(4, 22);
            this.singlePage.Name = "singlePage";
            this.singlePage.Padding = new System.Windows.Forms.Padding(3);
            this.singlePage.Size = new System.Drawing.Size(376, 459);
            this.singlePage.TabIndex = 1;
            this.singlePage.Text = "Single";
            this.singlePage.UseVisualStyleBackColor = true;
            // 
            // single_randomText
            // 
            this.single_randomText.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.single_randomText.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.single_randomText.Location = new System.Drawing.Point(3, 443);
            this.single_randomText.Name = "single_randomText";
            this.single_randomText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.single_randomText.Size = new System.Drawing.Size(370, 13);
            this.single_randomText.TabIndex = 8;
            this.single_randomText.Text = "...";
            this.single_randomText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // single_saveAllButton
            // 
            this.single_saveAllButton.Enabled = false;
            this.single_saveAllButton.Location = new System.Drawing.Point(61, 399);
            this.single_saveAllButton.Name = "single_saveAllButton";
            this.single_saveAllButton.Size = new System.Drawing.Size(250, 23);
            this.single_saveAllButton.TabIndex = 7;
            this.single_saveAllButton.Text = "Save All!";
            this.single_saveAllButton.UseVisualStyleBackColor = true;
            this.single_saveAllButton.Click += new System.EventHandler(this.single_saveAllButton_Click);
            // 
            // single_saveButton
            // 
            this.single_saveButton.Enabled = false;
            this.single_saveButton.Location = new System.Drawing.Point(61, 370);
            this.single_saveButton.Name = "single_saveButton";
            this.single_saveButton.Size = new System.Drawing.Size(250, 23);
            this.single_saveButton.TabIndex = 6;
            this.single_saveButton.Text = "Save!";
            this.single_saveButton.UseVisualStyleBackColor = true;
            this.single_saveButton.Click += new System.EventHandler(this.single_saveButton_Click);
            // 
            // single_nextButton
            // 
            this.single_nextButton.Enabled = false;
            this.single_nextButton.Location = new System.Drawing.Point(216, 319);
            this.single_nextButton.Name = "single_nextButton";
            this.single_nextButton.Size = new System.Drawing.Size(95, 23);
            this.single_nextButton.TabIndex = 5;
            this.single_nextButton.Text = "Next";
            this.single_nextButton.UseVisualStyleBackColor = true;
            this.single_nextButton.Click += new System.EventHandler(this.single_nextButton_Click);
            // 
            // single_prevButton
            // 
            this.single_prevButton.Enabled = false;
            this.single_prevButton.Location = new System.Drawing.Point(61, 319);
            this.single_prevButton.Name = "single_prevButton";
            this.single_prevButton.Size = new System.Drawing.Size(89, 23);
            this.single_prevButton.TabIndex = 4;
            this.single_prevButton.Text = "Previous";
            this.single_prevButton.UseVisualStyleBackColor = true;
            this.single_prevButton.Click += new System.EventHandler(this.single_prevButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "URL: ";
            // 
            // single_loadButton
            // 
            this.single_loadButton.Location = new System.Drawing.Point(293, 22);
            this.single_loadButton.Name = "single_loadButton";
            this.single_loadButton.Size = new System.Drawing.Size(75, 23);
            this.single_loadButton.TabIndex = 2;
            this.single_loadButton.Text = "Load";
            this.single_loadButton.UseVisualStyleBackColor = true;
            this.single_loadButton.Click += new System.EventHandler(this.single_loadButton_Click);
            // 
            // single_textBox
            // 
            this.single_textBox.Location = new System.Drawing.Point(47, 24);
            this.single_textBox.Name = "single_textBox";
            this.single_textBox.Size = new System.Drawing.Size(240, 20);
            this.single_textBox.TabIndex = 1;
            this.single_textBox.Text = "Bttnh-EBv89";
            // 
            // single_pictureBox
            // 
            this.single_pictureBox.Location = new System.Drawing.Point(61, 63);
            this.single_pictureBox.Name = "single_pictureBox";
            this.single_pictureBox.Size = new System.Drawing.Size(250, 250);
            this.single_pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.single_pictureBox.TabIndex = 0;
            this.single_pictureBox.TabStop = false;
            // 
            // multiplePage
            // 
            this.multiplePage.Controls.Add(this.tabControl2);
            this.multiplePage.Controls.Add(this.goHelp);
            this.multiplePage.Controls.Add(this.helpUsernames);
            this.multiplePage.Controls.Add(this.label3);
            this.multiplePage.Controls.Add(this.multiple_usernameBox);
            this.multiplePage.Controls.Add(this.multiple_goButton);
            this.multiplePage.Location = new System.Drawing.Point(4, 22);
            this.multiplePage.Name = "multiplePage";
            this.multiplePage.Padding = new System.Windows.Forms.Padding(3);
            this.multiplePage.Size = new System.Drawing.Size(376, 459);
            this.multiplePage.TabIndex = 0;
            this.multiplePage.Text = "Multiple";
            this.multiplePage.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Location = new System.Drawing.Point(9, 149);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(354, 261);
            this.tabControl2.TabIndex = 9;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.progressHelp);
            this.tabPage2.Controls.Add(this.panel1);
            this.tabPage2.Controls.Add(this.multiple_progressBar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(346, 235);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Simple";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // progressHelp
            // 
            this.progressHelp.AutoSize = true;
            this.progressHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progressHelp.Location = new System.Drawing.Point(166, 167);
            this.progressHelp.Name = "progressHelp";
            this.progressHelp.Size = new System.Drawing.Size(15, 16);
            this.progressHelp.TabIndex = 9;
            this.progressHelp.Text = "?";
            this.toolTip1.SetToolTip(this.progressHelp, "This shows the download progress.");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_log_username);
            this.panel1.Controls.Add(this.label_log_filename);
            this.panel1.Location = new System.Drawing.Point(6, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 25);
            this.panel1.TabIndex = 3;
            // 
            // label_log_username
            // 
            this.label_log_username.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label_log_username.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_log_username.Location = new System.Drawing.Point(0, -1);
            this.label_log_username.Name = "label_log_username";
            this.label_log_username.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_log_username.Size = new System.Drawing.Size(334, 13);
            this.label_log_username.TabIndex = 11;
            this.label_log_username.Text = "...";
            this.label_log_username.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_log_filename
            // 
            this.label_log_filename.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label_log_filename.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_log_filename.Location = new System.Drawing.Point(0, 12);
            this.label_log_filename.Name = "label_log_filename";
            this.label_log_filename.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_log_filename.Size = new System.Drawing.Size(334, 13);
            this.label_log_filename.TabIndex = 10;
            this.label_log_filename.Text = "...";
            this.label_log_filename.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // multiple_progressBar
            // 
            this.multiple_progressBar.Location = new System.Drawing.Point(6, 141);
            this.multiple_progressBar.Name = "multiple_progressBar";
            this.multiple_progressBar.Size = new System.Drawing.Size(334, 23);
            this.multiple_progressBar.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.multiple_logBox);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.helpLog);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(346, 235);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Advanced";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // multiple_logBox
            // 
            this.multiple_logBox.Location = new System.Drawing.Point(6, 29);
            this.multiple_logBox.Name = "multiple_logBox";
            this.multiple_logBox.ReadOnly = true;
            this.multiple_logBox.Size = new System.Drawing.Size(334, 200);
            this.multiple_logBox.TabIndex = 4;
            this.multiple_logBox.Text = "";
            this.multiple_logBox.WordWrap = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(166, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Log";
            // 
            // helpLog
            // 
            this.helpLog.AutoSize = true;
            this.helpLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpLog.Location = new System.Drawing.Point(307, 3);
            this.helpLog.Name = "helpLog";
            this.helpLog.Size = new System.Drawing.Size(15, 16);
            this.helpLog.TabIndex = 7;
            this.helpLog.Text = "?";
            this.toolTip1.SetToolTip(this.helpLog, "This is just a log that the software writes to show you what it\r\nis doing.");
            // 
            // goHelp
            // 
            this.goHelp.AutoSize = true;
            this.goHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.goHelp.Location = new System.Drawing.Point(320, 413);
            this.goHelp.Name = "goHelp";
            this.goHelp.Size = new System.Drawing.Size(15, 16);
            this.goHelp.TabIndex = 8;
            this.goHelp.Text = "?";
            this.toolTip1.SetToolTip(this.goHelp, "Start a new background worker that tries to download\r\nevery possible image/video " +
        "of the usernames that you have\r\nselected.\r\n\r\n(Note: This will also save your set" +
        "tings)");
            // 
            // helpUsernames
            // 
            this.helpUsernames.AutoSize = true;
            this.helpUsernames.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.helpUsernames.Location = new System.Drawing.Point(320, 8);
            this.helpUsernames.Name = "helpUsernames";
            this.helpUsernames.Size = new System.Drawing.Size(15, 16);
            this.helpUsernames.TabIndex = 6;
            this.helpUsernames.Text = "?";
            this.toolTip1.SetToolTip(this.helpUsernames, "Write usernames here seperated by new line\r\n\r\nExample:\r\ncoolestinstagramuser123\r\n" +
        "memepage420\r\ncuteinstagramgirl\r\n");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(182, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Usernames (Seperate with a newline)";
            // 
            // multiple_usernameBox
            // 
            this.multiple_usernameBox.Location = new System.Drawing.Point(6, 27);
            this.multiple_usernameBox.Name = "multiple_usernameBox";
            this.multiple_usernameBox.Size = new System.Drawing.Size(360, 116);
            this.multiple_usernameBox.TabIndex = 2;
            this.multiple_usernameBox.Text = "";
            this.multiple_usernameBox.WordWrap = false;
            // 
            // multiple_goButton
            // 
            this.multiple_goButton.Location = new System.Drawing.Point(6, 428);
            this.multiple_goButton.Name = "multiple_goButton";
            this.multiple_goButton.Size = new System.Drawing.Size(357, 23);
            this.multiple_goButton.TabIndex = 1;
            this.multiple_goButton.Text = "Go!";
            this.multiple_goButton.UseVisualStyleBackColor = true;
            this.multiple_goButton.Click += new System.EventHandler(this.multiple_goButton_Click);
            // 
            // settingsPage
            // 
            this.settingsPage.Controls.Add(this.button1);
            this.settingsPage.Controls.Add(this.label8);
            this.settingsPage.Controls.Add(this.label7);
            this.settingsPage.Controls.Add(this.label6);
            this.settingsPage.Controls.Add(this.settings_buttonSave);
            this.settingsPage.Controls.Add(this.button_logLocation);
            this.settingsPage.Controls.Add(this.settings_logTextBox);
            this.settingsPage.Controls.Add(this.label5);
            this.settingsPage.Controls.Add(this.button_downloadLocation);
            this.settingsPage.Controls.Add(this.settings_downloadTextBox);
            this.settingsPage.Controls.Add(this.label2);
            this.settingsPage.Location = new System.Drawing.Point(4, 22);
            this.settingsPage.Name = "settingsPage";
            this.settingsPage.Padding = new System.Windows.Forms.Padding(3);
            this.settingsPage.Size = new System.Drawing.Size(376, 459);
            this.settingsPage.TabIndex = 2;
            this.settingsPage.Text = "Settings";
            this.settingsPage.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(8, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "About Ushanka";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(328, 409);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "?";
            this.toolTip1.SetToolTip(this.label8, "Saves the values above to a seperate file.\r\n\r\n(Note: Includes the usernames on th" +
        "e \'Multiple\' page)\r\n");
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(328, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "?";
            this.toolTip1.SetToolTip(this.label7, "The folder location that you want the program to write the logs to.\r\n");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(328, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "?";
            this.toolTip1.SetToolTip(this.label6, "The folder location that you want to download all of the images and videos to.\r\n");
            // 
            // settings_buttonSave
            // 
            this.settings_buttonSave.Location = new System.Drawing.Point(8, 428);
            this.settings_buttonSave.Name = "settings_buttonSave";
            this.settings_buttonSave.Size = new System.Drawing.Size(365, 23);
            this.settings_buttonSave.TabIndex = 6;
            this.settings_buttonSave.Text = "Save";
            this.settings_buttonSave.UseVisualStyleBackColor = true;
            this.settings_buttonSave.Click += new System.EventHandler(this.button_save_Click);
            // 
            // button_logLocation
            // 
            this.button_logLocation.Location = new System.Drawing.Point(297, 119);
            this.button_logLocation.Name = "button_logLocation";
            this.button_logLocation.Size = new System.Drawing.Size(76, 23);
            this.button_logLocation.TabIndex = 5;
            this.button_logLocation.Text = "Browse..";
            this.button_logLocation.UseVisualStyleBackColor = true;
            this.button_logLocation.Click += new System.EventHandler(this.button_logLocation_Click);
            // 
            // settings_logTextBox
            // 
            this.settings_logTextBox.Location = new System.Drawing.Point(8, 121);
            this.settings_logTextBox.Name = "settings_logTextBox";
            this.settings_logTextBox.Size = new System.Drawing.Size(286, 20);
            this.settings_logTextBox.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(143, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Log Location:";
            // 
            // button_downloadLocation
            // 
            this.button_downloadLocation.Location = new System.Drawing.Point(297, 59);
            this.button_downloadLocation.Name = "button_downloadLocation";
            this.button_downloadLocation.Size = new System.Drawing.Size(76, 23);
            this.button_downloadLocation.TabIndex = 2;
            this.button_downloadLocation.Text = "Browse..";
            this.button_downloadLocation.UseVisualStyleBackColor = true;
            this.button_downloadLocation.Click += new System.EventHandler(this.button_downloadLocation_Click);
            // 
            // settings_downloadTextBox
            // 
            this.settings_downloadTextBox.Location = new System.Drawing.Point(8, 61);
            this.settings_downloadTextBox.Name = "settings_downloadTextBox";
            this.settings_downloadTextBox.Size = new System.Drawing.Size(286, 20);
            this.settings_downloadTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Download Location:";
            // 
            // logPage
            // 
            this.logPage.Controls.Add(this.logBox);
            this.logPage.Location = new System.Drawing.Point(4, 22);
            this.logPage.Name = "logPage";
            this.logPage.Padding = new System.Windows.Forms.Padding(3);
            this.logPage.Size = new System.Drawing.Size(376, 459);
            this.logPage.TabIndex = 3;
            this.logPage.Text = "Debug Log";
            this.logPage.UseVisualStyleBackColor = true;
            // 
            // logBox
            // 
            this.logBox.Font = new System.Drawing.Font("Segoe UI Emoji", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logBox.Location = new System.Drawing.Point(8, 6);
            this.logBox.Name = "logBox";
            this.logBox.ReadOnly = true;
            this.logBox.Size = new System.Drawing.Size(360, 445);
            this.logBox.TabIndex = 0;
            this.logBox.Text = "";
            this.logBox.WordWrap = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(384, 485);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ushanka  - Alpha 1.2";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.singlePage.ResumeLayout(false);
            this.singlePage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.single_pictureBox)).EndInit();
            this.multiplePage.ResumeLayout(false);
            this.multiplePage.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.settingsPage.ResumeLayout(false);
            this.settingsPage.PerformLayout();
            this.logPage.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage multiplePage;
        private System.Windows.Forms.TabPage singlePage;
        private System.Windows.Forms.TabPage settingsPage;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button single_loadButton;
        private System.Windows.Forms.TextBox single_textBox;
        private System.Windows.Forms.PictureBox single_pictureBox;
        private System.Windows.Forms.Button single_nextButton;
        private System.Windows.Forms.Button single_prevButton;
        private System.Windows.Forms.Button single_saveButton;
        private System.Windows.Forms.Button single_saveAllButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label single_randomText;
        private System.Windows.Forms.Button multiple_goButton;
        private System.Windows.Forms.Button button_downloadLocation;
        private System.Windows.Forms.TextBox settings_downloadTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox multiple_logBox;
        private System.Windows.Forms.Button button_logLocation;
        private System.Windows.Forms.TextBox settings_logTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label helpLog;
        private System.Windows.Forms.Button settings_buttonSave;
        private System.Windows.Forms.Label helpUsernames;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox multiple_usernameBox;
        private System.Windows.Forms.Label goHelp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ProgressBar multiple_progressBar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_log_username;
        private System.Windows.Forms.Label label_log_filename;
        private System.Windows.Forms.Label progressHelp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage logPage;
        private System.Windows.Forms.RichTextBox logBox;
    }
}

