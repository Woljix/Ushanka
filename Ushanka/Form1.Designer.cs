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
            this.button1 = new System.Windows.Forms.Button();
            this.settingsPage = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.singlePage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.single_pictureBox)).BeginInit();
            this.multiplePage.SuspendLayout();
            this.settingsPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.singlePage);
            this.tabControl1.Controls.Add(this.multiplePage);
            this.tabControl1.Controls.Add(this.settingsPage);
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
            this.multiplePage.Controls.Add(this.label4);
            this.multiplePage.Controls.Add(this.richTextBox2);
            this.multiplePage.Controls.Add(this.label3);
            this.multiplePage.Controls.Add(this.richTextBox1);
            this.multiplePage.Controls.Add(this.button1);
            this.multiplePage.Location = new System.Drawing.Point(4, 22);
            this.multiplePage.Name = "multiplePage";
            this.multiplePage.Padding = new System.Windows.Forms.Padding(3);
            this.multiplePage.Size = new System.Drawing.Size(376, 459);
            this.multiplePage.TabIndex = 0;
            this.multiplePage.Text = "Multiple";
            this.multiplePage.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(6, 416);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(357, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Go!";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // settingsPage
            // 
            this.settingsPage.Controls.Add(this.button3);
            this.settingsPage.Controls.Add(this.textBox2);
            this.settingsPage.Controls.Add(this.label5);
            this.settingsPage.Controls.Add(this.button2);
            this.settingsPage.Controls.Add(this.textBox1);
            this.settingsPage.Controls.Add(this.label2);
            this.settingsPage.Location = new System.Drawing.Point(4, 22);
            this.settingsPage.Name = "settingsPage";
            this.settingsPage.Padding = new System.Windows.Forms.Padding(3);
            this.settingsPage.Size = new System.Drawing.Size(376, 459);
            this.settingsPage.TabIndex = 2;
            this.settingsPage.Text = "Settings";
            this.settingsPage.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(297, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(76, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Browse..";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(286, 20);
            this.textBox1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Download Location:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(6, 27);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(360, 116);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
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
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(9, 171);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(354, 239);
            this.richTextBox2.TabIndex = 4;
            this.richTextBox2.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(172, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Log";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(297, 90);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(76, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Browse..";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(8, 92);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(286, 20);
            this.textBox2.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(143, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Log Location:";
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
            this.Text = "Ushanka  - Alpha";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.singlePage.ResumeLayout(false);
            this.singlePage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.single_pictureBox)).EndInit();
            this.multiplePage.ResumeLayout(false);
            this.multiplePage.PerformLayout();
            this.settingsPage.ResumeLayout(false);
            this.settingsPage.PerformLayout();
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
    }
}

