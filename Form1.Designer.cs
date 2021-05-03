namespace WinFormsCalendar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.OldBitmap = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.AddFurnitureBox = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.Kitchen_table = new System.Windows.Forms.CheckBox();
            this.Table = new System.Windows.Forms.CheckBox();
            this.Bed = new System.Windows.Forms.CheckBox();
            this.Sofa = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.CreatedFurnitureBox = new System.Windows.Forms.GroupBox();
            this.CreatedFurnitureList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OldBitmap)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.AddFurnitureBox.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.CreatedFurnitureBox.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer
            // 
            resources.ApplyResources(this.splitContainer, "splitContainer");
            this.splitContainer.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            resources.ApplyResources(this.splitContainer.Panel1, "splitContainer.Panel1");
            this.splitContainer.Panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitContainer.Panel1.Controls.Add(this.OldBitmap);
            this.splitContainer.Panel1.SizeChanged += new System.EventHandler(this.splitContainer_Panel1_SizeChanged);
            this.splitContainer.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer_Panel1_Paint);
            this.splitContainer.Panel1.MouseHover += new System.EventHandler(this.splitContainer_Panel1_MouseHover);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.splitContainer.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer_SplitterMoved);
            // 
            // OldBitmap
            // 
            resources.ApplyResources(this.OldBitmap, "OldBitmap");
            this.OldBitmap.BackColor = System.Drawing.Color.White;
            this.OldBitmap.Name = "OldBitmap";
            this.OldBitmap.TabStop = false;
            this.OldBitmap.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OldBitmap_MouseDown);
            this.OldBitmap.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OldBitmap_MouseMove);
            this.OldBitmap.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OldBitmap_MouseUp);
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.AddFurnitureBox, 0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // AddFurnitureBox
            // 
            this.AddFurnitureBox.Controls.Add(this.flowLayoutPanel2);
            resources.ApplyResources(this.AddFurnitureBox, "AddFurnitureBox");
            this.AddFurnitureBox.Name = "AddFurnitureBox";
            this.AddFurnitureBox.TabStop = false;
            // 
            // flowLayoutPanel2
            // 
            resources.ApplyResources(this.flowLayoutPanel2, "flowLayoutPanel2");
            this.flowLayoutPanel2.Controls.Add(this.Kitchen_table);
            this.flowLayoutPanel2.Controls.Add(this.Table);
            this.flowLayoutPanel2.Controls.Add(this.Bed);
            this.flowLayoutPanel2.Controls.Add(this.Sofa);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            // 
            // Kitchen_table
            // 
            resources.ApplyResources(this.Kitchen_table, "Kitchen_table");
            this.Kitchen_table.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Kitchen_table.BackgroundImage = global::WinFormsCalendar.Properties.Resources.coffee_table;
            this.Kitchen_table.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Kitchen_table.Name = "Kitchen_table";
            this.Kitchen_table.UseVisualStyleBackColor = false;
            this.Kitchen_table.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged_1);
            // 
            // Table
            // 
            resources.ApplyResources(this.Table, "Table");
            this.Table.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Table.BackgroundImage = global::WinFormsCalendar.Properties.Resources.table;
            this.Table.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Table.Name = "Table";
            this.Table.UseVisualStyleBackColor = false;
            this.Table.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged_1);
            // 
            // Bed
            // 
            resources.ApplyResources(this.Bed, "Bed");
            this.Bed.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Bed.BackgroundImage = global::WinFormsCalendar.Properties.Resources.double_bed;
            this.Bed.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Bed.Name = "Bed";
            this.Bed.UseVisualStyleBackColor = false;
            this.Bed.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // Sofa
            // 
            resources.ApplyResources(this.Sofa, "Sofa");
            this.Sofa.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Sofa.BackgroundImage = global::WinFormsCalendar.Properties.Resources.sofa;
            this.Sofa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Sofa.Name = "Sofa";
            this.Sofa.UseVisualStyleBackColor = false;
            this.Sofa.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.CreatedFurnitureBox, 0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // CreatedFurnitureBox
            // 
            this.CreatedFurnitureBox.Controls.Add(this.CreatedFurnitureList);
            resources.ApplyResources(this.CreatedFurnitureBox, "CreatedFurnitureBox");
            this.CreatedFurnitureBox.Name = "CreatedFurnitureBox";
            this.CreatedFurnitureBox.TabStop = false;
            // 
            // CreatedFurnitureList
            // 
            this.CreatedFurnitureList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.CreatedFurnitureList.Cursor = System.Windows.Forms.Cursors.Default;
            resources.ApplyResources(this.CreatedFurnitureList, "CreatedFurnitureList");
            this.CreatedFurnitureList.FullRowSelect = true;
            this.CreatedFurnitureList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.CreatedFurnitureList.HideSelection = false;
            this.CreatedFurnitureList.MultiSelect = false;
            this.CreatedFurnitureList.Name = "CreatedFurnitureList";
            this.CreatedFurnitureList.UseCompatibleStateImageBehavior = false;
            this.CreatedFurnitureList.View = System.Windows.Forms.View.Details;
            this.CreatedFurnitureList.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CreatedFurnitureList_MouseDown);
            // 
            // columnHeader1
            // 
            resources.ApplyResources(this.columnHeader1, "columnHeader1");
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.languageToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            resources.ApplyResources(this.fileToolStripMenuItem, "fileToolStripMenuItem");
            this.fileToolStripMenuItem.Click += new System.EventHandler(this.fileToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            this.toolStripMenuItem1.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            resources.ApplyResources(this.openToolStripMenuItem, "openToolStripMenuItem");
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            resources.ApplyResources(this.saveToolStripMenuItem, "saveToolStripMenuItem");
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.polishToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            resources.ApplyResources(this.languageToolStripMenuItem, "languageToolStripMenuItem");
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            resources.ApplyResources(this.englishToolStripMenuItem, "englishToolStripMenuItem");
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // polishToolStripMenuItem
            // 
            this.polishToolStripMenuItem.Name = "polishToolStripMenuItem";
            resources.ApplyResources(this.polishToolStripMenuItem, "polishToolStripMenuItem");
            this.polishToolStripMenuItem.Click += new System.EventHandler(this.polishToolStripMenuItem_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.splitContainer);
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OldBitmap)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.AddFurnitureBox.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.CreatedFurnitureBox.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.GroupBox AddFurnitureBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.CheckBox Kitchen_table;
        private System.Windows.Forms.CheckBox Table;
        private System.Windows.Forms.CheckBox Sofa;
        private System.Windows.Forms.CheckBox Bed;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox CreatedFurnitureBox;
        private System.Windows.Forms.ListView CreatedFurnitureList;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        public System.Windows.Forms.PictureBox OldBitmap;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polishToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
    }
}

