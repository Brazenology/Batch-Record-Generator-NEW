namespace BatchRecordGenerator
{
    partial class HomePanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePanel));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fIleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.createButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.incLabel = new System.Windows.Forms.Label();
            this.verLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.createBox = new System.Windows.Forms.GroupBox();
            this.viewBox = new System.Windows.Forms.GroupBox();
            this.editBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.createBox.SuspendLayout();
            this.viewBox.SuspendLayout();
            this.editBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fIleToolStripMenuItem,
            this.editToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1099, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fIleToolStripMenuItem
            // 
            this.fIleToolStripMenuItem.Name = "fIleToolStripMenuItem";
            this.fIleToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fIleToolStripMenuItem.Text = "File";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.exitToolStripMenuItem.Text = "Help";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // createButton
            // 
            this.createButton.BackColor = System.Drawing.Color.CadetBlue;
            this.createButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.createButton.Font = new System.Drawing.Font("Eras Bold ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createButton.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.createButton.Location = new System.Drawing.Point(16, 19);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(302, 144);
            this.createButton.TabIndex = 0;
            this.createButton.Text = "Create New Batch Record";
            this.createButton.UseVisualStyleBackColor = false;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // editButton
            // 
            this.editButton.BackColor = System.Drawing.Color.CadetBlue;
            this.editButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.editButton.Font = new System.Drawing.Font("Eras Bold ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editButton.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.editButton.Location = new System.Drawing.Point(17, 19);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(301, 144);
            this.editButton.TabIndex = 0;
            this.editButton.Text = "Edit Existing Batch Record";
            this.editButton.UseVisualStyleBackColor = false;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.CadetBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Eras Bold ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.button2.Location = new System.Drawing.Point(15, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(303, 144);
            this.button2.TabIndex = 0;
            this.button2.Text = "View/Print Batch Record";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // incLabel
            // 
            this.incLabel.AutoSize = true;
            this.incLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incLabel.Location = new System.Drawing.Point(928, 742);
            this.incLabel.Name = "incLabel";
            this.incLabel.Size = new System.Drawing.Size(144, 17);
            this.incLabel.TabIndex = 6;
            this.incLabel.Text = "Southmedic Inc. 2016";
            // 
            // verLabel
            // 
            this.verLabel.AutoSize = true;
            this.verLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verLabel.Location = new System.Drawing.Point(20, 742);
            this.verLabel.Name = "verLabel";
            this.verLabel.Size = new System.Drawing.Size(106, 17);
            this.verLabel.TabIndex = 7;
            this.verLabel.Text = "Version No. 1.0";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(23, 256);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1049, 177);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel3.BackgroundImage")));
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Location = new System.Drawing.Point(26, 48);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1045, 202);
            this.panel3.TabIndex = 10;
            // 
            // createBox
            // 
            this.createBox.Controls.Add(this.createButton);
            this.createBox.Location = new System.Drawing.Point(23, 439);
            this.createBox.Name = "createBox";
            this.createBox.Size = new System.Drawing.Size(335, 265);
            this.createBox.TabIndex = 11;
            this.createBox.TabStop = false;
            // 
            // viewBox
            // 
            this.viewBox.Controls.Add(this.button2);
            this.viewBox.Location = new System.Drawing.Point(737, 439);
            this.viewBox.Name = "viewBox";
            this.viewBox.Size = new System.Drawing.Size(335, 265);
            this.viewBox.TabIndex = 12;
            this.viewBox.TabStop = false;
            // 
            // editBox
            // 
            this.editBox.Controls.Add(this.editButton);
            this.editBox.Location = new System.Drawing.Point(380, 439);
            this.editBox.Name = "editBox";
            this.editBox.Size = new System.Drawing.Size(335, 265);
            this.editBox.TabIndex = 12;
            this.editBox.TabStop = false;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(23, 731);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1048, 2);
            this.label1.TabIndex = 13;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // HomePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 768);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.editBox);
            this.Controls.Add(this.viewBox);
            this.Controls.Add(this.createBox);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.verLabel);
            this.Controls.Add(this.incLabel);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "HomePanel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Batch Record Generator";
            this.Load += new System.EventHandler(this.HomePanel_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.createBox.ResumeLayout(false);
            this.viewBox.ResumeLayout(false);
            this.editBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fIleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label verLabel;
        private System.Windows.Forms.Label incLabel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox editBox;
        private System.Windows.Forms.GroupBox viewBox;
        private System.Windows.Forms.GroupBox createBox;
        private System.Windows.Forms.Label label1;
    }
}

