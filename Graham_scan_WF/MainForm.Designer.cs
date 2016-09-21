namespace Graham_scan_WF
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem_File = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Create = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItem_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Save = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_SaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolStripMenuItem_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Activity = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_AddPoint = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_RemovePoint = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_View = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_ToolsPanel = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_StandartPanel = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Activitys = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.toolStripPanel_Top = new System.Windows.Forms.ToolStripPanel();
            this.toolStrip_Standart = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_Create = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Open = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_Save = new System.Windows.Forms.ToolStripButton();
            this.toolStrip_Activitys = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_AddPoint = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton_RemovePoint = new System.Windows.Forms.ToolStripButton();
            this.toolStripPanel_Bottom = new System.Windows.Forms.ToolStripPanel();
            this.toolStripPanel_Right = new System.Windows.Forms.ToolStripPanel();
            this.toolStripPanel_Left = new System.Windows.Forms.ToolStripPanel();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.toolStripPanel_Top.SuspendLayout();
            this.toolStrip_Standart.SuspendLayout();
            this.toolStrip_Activitys.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_File,
            this.ToolStripMenuItem_Activity,
            this.ToolStripMenuItem_View});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(736, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // ToolStripMenuItem_File
            // 
            this.ToolStripMenuItem_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_Create,
            this.toolStripSeparator2,
            this.ToolStripMenuItem_Open,
            this.ToolStripMenuItem_Save,
            this.ToolStripMenuItem_SaveAs,
            this.toolStripSeparator1,
            this.ToolStripMenuItem_Exit});
            this.ToolStripMenuItem_File.Name = "ToolStripMenuItem_File";
            this.ToolStripMenuItem_File.Size = new System.Drawing.Size(48, 20);
            this.ToolStripMenuItem_File.Text = "Файл";
            // 
            // ToolStripMenuItem_Create
            // 
            this.ToolStripMenuItem_Create.Name = "ToolStripMenuItem_Create";
            this.ToolStripMenuItem_Create.Size = new System.Drawing.Size(151, 22);
            this.ToolStripMenuItem_Create.Text = "Створити";
            this.ToolStripMenuItem_Create.Click += new System.EventHandler(this.ToolStripMenuItem_Create_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(148, 6);
            // 
            // ToolStripMenuItem_Open
            // 
            this.ToolStripMenuItem_Open.Name = "ToolStripMenuItem_Open";
            this.ToolStripMenuItem_Open.Size = new System.Drawing.Size(151, 22);
            this.ToolStripMenuItem_Open.Text = "Відкрити";
            this.ToolStripMenuItem_Open.Click += new System.EventHandler(this.ToolStripMenuItem_Open_Click);
            // 
            // ToolStripMenuItem_Save
            // 
            this.ToolStripMenuItem_Save.Name = "ToolStripMenuItem_Save";
            this.ToolStripMenuItem_Save.Size = new System.Drawing.Size(151, 22);
            this.ToolStripMenuItem_Save.Text = "Зберегти";
            this.ToolStripMenuItem_Save.Click += new System.EventHandler(this.ToolStripMenuItem_Save_Click);
            // 
            // ToolStripMenuItem_SaveAs
            // 
            this.ToolStripMenuItem_SaveAs.Name = "ToolStripMenuItem_SaveAs";
            this.ToolStripMenuItem_SaveAs.Size = new System.Drawing.Size(151, 22);
            this.ToolStripMenuItem_SaveAs.Text = "Зберегти як ...";
            this.ToolStripMenuItem_SaveAs.Click += new System.EventHandler(this.ToolStripMenuItem_SaveAs_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(148, 6);
            // 
            // ToolStripMenuItem_Exit
            // 
            this.ToolStripMenuItem_Exit.Name = "ToolStripMenuItem_Exit";
            this.ToolStripMenuItem_Exit.Size = new System.Drawing.Size(151, 22);
            this.ToolStripMenuItem_Exit.Text = "Вихід";
            this.ToolStripMenuItem_Exit.Click += new System.EventHandler(this.ToolStripMenuItem_Exit_Click);
            // 
            // ToolStripMenuItem_Activity
            // 
            this.ToolStripMenuItem_Activity.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_AddPoint,
            this.ToolStripMenuItem_RemovePoint});
            this.ToolStripMenuItem_Activity.Name = "ToolStripMenuItem_Activity";
            this.ToolStripMenuItem_Activity.Size = new System.Drawing.Size(33, 20);
            this.ToolStripMenuItem_Activity.Text = "Дії";
            // 
            // ToolStripMenuItem_AddPoint
            // 
            this.ToolStripMenuItem_AddPoint.Name = "ToolStripMenuItem_AddPoint";
            this.ToolStripMenuItem_AddPoint.Size = new System.Drawing.Size(160, 22);
            this.ToolStripMenuItem_AddPoint.Text = "Додати точку";
            this.ToolStripMenuItem_AddPoint.Click += new System.EventHandler(this.ToolStripMenuItem_AddPoint_Click);
            // 
            // ToolStripMenuItem_RemovePoint
            // 
            this.ToolStripMenuItem_RemovePoint.Name = "ToolStripMenuItem_RemovePoint";
            this.ToolStripMenuItem_RemovePoint.Size = new System.Drawing.Size(160, 22);
            this.ToolStripMenuItem_RemovePoint.Text = "Видалити точку";
            this.ToolStripMenuItem_RemovePoint.Click += new System.EventHandler(this.ToolStripMenuItem_RemovePoint_Click);
            // 
            // ToolStripMenuItem_View
            // 
            this.ToolStripMenuItem_View.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_ToolsPanel});
            this.ToolStripMenuItem_View.Name = "ToolStripMenuItem_View";
            this.ToolStripMenuItem_View.Size = new System.Drawing.Size(57, 20);
            this.ToolStripMenuItem_View.Text = "Вигляд";
            // 
            // ToolStripMenuItem_ToolsPanel
            // 
            this.ToolStripMenuItem_ToolsPanel.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_StandartPanel,
            this.ToolStripMenuItem_Activitys});
            this.ToolStripMenuItem_ToolsPanel.Name = "ToolStripMenuItem_ToolsPanel";
            this.ToolStripMenuItem_ToolsPanel.Size = new System.Drawing.Size(188, 22);
            this.ToolStripMenuItem_ToolsPanel.Text = "Панель інструментів";
            // 
            // ToolStripMenuItem_StandartPanel
            // 
            this.ToolStripMenuItem_StandartPanel.Checked = true;
            this.ToolStripMenuItem_StandartPanel.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ToolStripMenuItem_StandartPanel.Name = "ToolStripMenuItem_StandartPanel";
            this.ToolStripMenuItem_StandartPanel.Size = new System.Drawing.Size(179, 22);
            this.ToolStripMenuItem_StandartPanel.Text = "Стандартна панель";
            this.ToolStripMenuItem_StandartPanel.Click += new System.EventHandler(this.ToolStripMenuItem_StandartPanel_Click);
            // 
            // ToolStripMenuItem_Activitys
            // 
            this.ToolStripMenuItem_Activitys.Checked = true;
            this.ToolStripMenuItem_Activitys.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ToolStripMenuItem_Activitys.Name = "ToolStripMenuItem_Activitys";
            this.ToolStripMenuItem_Activitys.Size = new System.Drawing.Size(179, 22);
            this.ToolStripMenuItem_Activitys.Text = "Дії";
            this.ToolStripMenuItem_Activitys.Click += new System.EventHandler(this.ToolStripMenuItem_Activitys_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.White;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 24);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(736, 507);
            this.pictureBox.TabIndex = 2;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseUp);
            // 
            // toolStripPanel_Top
            // 
            this.toolStripPanel_Top.Controls.Add(this.toolStrip_Standart);
            this.toolStripPanel_Top.Controls.Add(this.toolStrip_Activitys);
            this.toolStripPanel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.toolStripPanel_Top.Location = new System.Drawing.Point(0, 24);
            this.toolStripPanel_Top.Name = "toolStripPanel_Top";
            this.toolStripPanel_Top.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.toolStripPanel_Top.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.toolStripPanel_Top.Size = new System.Drawing.Size(736, 27);
            // 
            // toolStrip_Standart
            // 
            this.toolStrip_Standart.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip_Standart.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip_Standart.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_Create,
            this.toolStripButton_Open,
            this.toolStripButton_Save});
            this.toolStrip_Standart.Location = new System.Drawing.Point(3, 0);
            this.toolStrip_Standart.Name = "toolStrip_Standart";
            this.toolStrip_Standart.Size = new System.Drawing.Size(84, 27);
            this.toolStrip_Standart.TabIndex = 6;
            this.toolStrip_Standart.Text = "toolStrip1";
            this.toolStrip_Standart.EndDrag += new System.EventHandler(this.ToolStrip_Standart_EndDrag);
            // 
            // toolStripButton_Create
            // 
            this.toolStripButton_Create.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Create.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Create.Image")));
            this.toolStripButton_Create.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Create.Name = "toolStripButton_Create";
            this.toolStripButton_Create.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton_Create.Text = "Створити";
            // 
            // toolStripButton_Open
            // 
            this.toolStripButton_Open.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Open.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Open.Image")));
            this.toolStripButton_Open.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Open.Name = "toolStripButton_Open";
            this.toolStripButton_Open.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton_Open.Text = "Відкрити";
            // 
            // toolStripButton_Save
            // 
            this.toolStripButton_Save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_Save.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_Save.Image")));
            this.toolStripButton_Save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_Save.Name = "toolStripButton_Save";
            this.toolStripButton_Save.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton_Save.Text = "Зберегти";
            // 
            // toolStrip_Activitys
            // 
            this.toolStrip_Activitys.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip_Activitys.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip_Activitys.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_AddPoint,
            this.toolStripButton_RemovePoint});
            this.toolStrip_Activitys.Location = new System.Drawing.Point(88, 0);
            this.toolStrip_Activitys.Name = "toolStrip_Activitys";
            this.toolStrip_Activitys.Size = new System.Drawing.Size(60, 27);
            this.toolStrip_Activitys.TabIndex = 6;
            this.toolStrip_Activitys.Text = "toolStrip1";
            // 
            // toolStripButton_AddPoint
            // 
            this.toolStripButton_AddPoint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_AddPoint.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_AddPoint.Image")));
            this.toolStripButton_AddPoint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_AddPoint.Name = "toolStripButton_AddPoint";
            this.toolStripButton_AddPoint.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton_AddPoint.Text = "Додати точку";
            // 
            // toolStripButton_RemovePoint
            // 
            this.toolStripButton_RemovePoint.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton_RemovePoint.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_RemovePoint.Image")));
            this.toolStripButton_RemovePoint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_RemovePoint.Name = "toolStripButton_RemovePoint";
            this.toolStripButton_RemovePoint.Size = new System.Drawing.Size(24, 24);
            this.toolStripButton_RemovePoint.Text = "Видалити точку";
            // 
            // toolStripPanel_Bottom
            // 
            this.toolStripPanel_Bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStripPanel_Bottom.Location = new System.Drawing.Point(0, 531);
            this.toolStripPanel_Bottom.Name = "toolStripPanel_Bottom";
            this.toolStripPanel_Bottom.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.toolStripPanel_Bottom.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.toolStripPanel_Bottom.Size = new System.Drawing.Size(736, 0);
            // 
            // toolStripPanel_Right
            // 
            this.toolStripPanel_Right.Dock = System.Windows.Forms.DockStyle.Right;
            this.toolStripPanel_Right.Location = new System.Drawing.Point(736, 51);
            this.toolStripPanel_Right.Name = "toolStripPanel_Right";
            this.toolStripPanel_Right.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.toolStripPanel_Right.RowMargin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.toolStripPanel_Right.Size = new System.Drawing.Size(0, 480);
            // 
            // toolStripPanel_Left
            // 
            this.toolStripPanel_Left.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStripPanel_Left.Location = new System.Drawing.Point(0, 51);
            this.toolStripPanel_Left.Name = "toolStripPanel_Left";
            this.toolStripPanel_Left.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.toolStripPanel_Left.RowMargin = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.toolStripPanel_Left.Size = new System.Drawing.Size(0, 480);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(736, 531);
            this.Controls.Add(this.toolStripPanel_Left);
            this.Controls.Add(this.toolStripPanel_Right);
            this.Controls.Add(this.toolStripPanel_Bottom);
            this.Controls.Add(this.toolStripPanel_Top);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MainForm";
            this.Text = "Graham Algorithm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainForm_KeyPress);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.toolStripPanel_Top.ResumeLayout(false);
            this.toolStripPanel_Top.PerformLayout();
            this.toolStrip_Standart.ResumeLayout(false);
            this.toolStrip_Standart.PerformLayout();
            this.toolStrip_Activitys.ResumeLayout(false);
            this.toolStrip_Activitys.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_File;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Open;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Save;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_SaveAs;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Exit;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Activity;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_AddPoint;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Create;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_RemovePoint;
        private System.Windows.Forms.ToolStripPanel toolStripPanel_Top;
        private System.Windows.Forms.ToolStripPanel toolStripPanel_Bottom;
        private System.Windows.Forms.ToolStripPanel toolStripPanel_Right;
        private System.Windows.Forms.ToolStripPanel toolStripPanel_Left;
        private System.Windows.Forms.ToolStrip toolStrip_Standart;
        private System.Windows.Forms.ToolStripButton toolStripButton_Create;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_View;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_ToolsPanel;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_StandartPanel;
        private System.Windows.Forms.ToolStripButton toolStripButton_Open;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Activitys;
        private System.Windows.Forms.ToolStrip toolStrip_Activitys;
        private System.Windows.Forms.ToolStripButton toolStripButton_Save;
        private System.Windows.Forms.ToolStripButton toolStripButton_AddPoint;
        private System.Windows.Forms.ToolStripButton toolStripButton_RemovePoint;
        public System.Windows.Forms.PictureBox pictureBox;
    }
}

