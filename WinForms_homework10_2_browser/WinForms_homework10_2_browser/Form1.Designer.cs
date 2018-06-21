namespace WinForms_homework10_2_browser
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.StripMenuUp = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemCut = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemRename = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuFileView = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemList = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemTile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemLargeIcon = new System.Windows.Forms.ToolStripMenuItem();
            this.StripMenuPacker = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemPacking = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemUnpacking = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItemHowToUse = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageListSmall = new System.Windows.Forms.ImageList(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuCut = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuPaste = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuRename = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.contextMenuRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuCreateFolder = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuCheckUnpack = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.contextMenuProperties = new System.Windows.Forms.ToolStripMenuItem();
            this.imageListLarge = new System.Windows.Forms.ImageList(this.components);
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StripMenuUp,
            this.StripMenuFile,
            this.StripMenuFileView,
            this.StripMenuPacker});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // StripMenuUp
            // 
            this.StripMenuUp.Name = "StripMenuUp";
            this.StripMenuUp.Size = new System.Drawing.Size(50, 29);
            this.StripMenuUp.Text = "<--";
            this.StripMenuUp.Click += new System.EventHandler(this.StripMenuUp_Click);
            // 
            // StripMenuFile
            // 
            this.StripMenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemCut,
            this.MenuItemPaste,
            this.MenuItemRename,
            this.MenuItemDelete,
            this.toolStripSeparator1,
            this.MenuClose});
            this.StripMenuFile.Name = "StripMenuFile";
            this.StripMenuFile.Size = new System.Drawing.Size(65, 29);
            this.StripMenuFile.Text = "Файл";
            this.StripMenuFile.DropDownOpening += new System.EventHandler(this.StripMenuFile_DropDownOpening);
            // 
            // MenuItemCut
            // 
            this.MenuItemCut.Name = "MenuItemCut";
            this.MenuItemCut.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.MenuItemCut.Size = new System.Drawing.Size(288, 30);
            this.MenuItemCut.Text = "Вырезать";
            this.MenuItemCut.Click += new System.EventHandler(this.MenuItemCut_Click);
            // 
            // MenuItemPaste
            // 
            this.MenuItemPaste.Name = "MenuItemPaste";
            this.MenuItemPaste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.MenuItemPaste.Size = new System.Drawing.Size(288, 30);
            this.MenuItemPaste.Text = "Вставить";
            this.MenuItemPaste.Click += new System.EventHandler(this.MenuItemPaste_Click);
            // 
            // MenuItemRename
            // 
            this.MenuItemRename.Name = "MenuItemRename";
            this.MenuItemRename.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.MenuItemRename.Size = new System.Drawing.Size(288, 30);
            this.MenuItemRename.Text = "Переименовать";
            this.MenuItemRename.Click += new System.EventHandler(this.MenuItemRename_Click);
            // 
            // MenuItemDelete
            // 
            this.MenuItemDelete.Name = "MenuItemDelete";
            this.MenuItemDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.MenuItemDelete.Size = new System.Drawing.Size(288, 30);
            this.MenuItemDelete.Text = "Удалить";
            this.MenuItemDelete.Click += new System.EventHandler(this.MenuItemDelete_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(285, 6);
            // 
            // MenuClose
            // 
            this.MenuClose.Name = "MenuClose";
            this.MenuClose.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.MenuClose.Size = new System.Drawing.Size(288, 30);
            this.MenuClose.Text = "Закрыть";
            this.MenuClose.Click += new System.EventHandler(this.MenuClose_Click);
            // 
            // StripMenuFileView
            // 
            this.StripMenuFileView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemList,
            this.MenuItemTile,
            this.MenuItemLargeIcon});
            this.StripMenuFileView.Name = "StripMenuFileView";
            this.StripMenuFileView.Size = new System.Drawing.Size(54, 29);
            this.StripMenuFileView.Text = "Вид";
            // 
            // MenuItemList
            // 
            this.MenuItemList.Name = "MenuItemList";
            this.MenuItemList.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.MenuItemList.Size = new System.Drawing.Size(267, 30);
            this.MenuItemList.Text = "Список";
            this.MenuItemList.Click += new System.EventHandler(this.MenuItemList_Click);
            // 
            // MenuItemTile
            // 
            this.MenuItemTile.Name = "MenuItemTile";
            this.MenuItemTile.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.MenuItemTile.Size = new System.Drawing.Size(267, 30);
            this.MenuItemTile.Text = "Обычные значки";
            this.MenuItemTile.Click += new System.EventHandler(this.MenuItemTile_Click);
            // 
            // MenuItemLargeIcon
            // 
            this.MenuItemLargeIcon.Name = "MenuItemLargeIcon";
            this.MenuItemLargeIcon.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.MenuItemLargeIcon.Size = new System.Drawing.Size(267, 30);
            this.MenuItemLargeIcon.Text = "Крупные значки";
            this.MenuItemLargeIcon.Click += new System.EventHandler(this.MenuItemLargeIcon_Click);
            // 
            // StripMenuPacker
            // 
            this.StripMenuPacker.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemPacking,
            this.MenuItemUnpacking,
            this.toolStripSeparator4,
            this.MenuItemHowToUse});
            this.StripMenuPacker.Name = "StripMenuPacker";
            this.StripMenuPacker.Size = new System.Drawing.Size(117, 29);
            this.StripMenuPacker.Text = "Упаковщик";
            this.StripMenuPacker.DropDownOpening += new System.EventHandler(this.StripMenuPacker_DropDownOpening);
            // 
            // MenuItemPacking
            // 
            this.MenuItemPacking.Name = "MenuItemPacking";
            this.MenuItemPacking.Size = new System.Drawing.Size(264, 30);
            this.MenuItemPacking.Text = "Упаковать объект";
            this.MenuItemPacking.Click += new System.EventHandler(this.MenuItemPacking_Click);
            // 
            // MenuItemUnpacking
            // 
            this.MenuItemUnpacking.Name = "MenuItemUnpacking";
            this.MenuItemUnpacking.Size = new System.Drawing.Size(264, 30);
            this.MenuItemUnpacking.Text = "Распаковать  объект";
            this.MenuItemUnpacking.Click += new System.EventHandler(this.MenuItemUnpacking_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(261, 6);
            // 
            // MenuItemHowToUse
            // 
            this.MenuItemHowToUse.Name = "MenuItemHowToUse";
            this.MenuItemHowToUse.Size = new System.Drawing.Size(264, 30);
            this.MenuItemHowToUse.Text = "Как использовать";
            this.MenuItemHowToUse.Click += new System.EventHandler(this.MenuItemHowToUse_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 65);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listView1);
            this.splitContainer1.Size = new System.Drawing.Size(800, 385);
            this.splitContainer1.SplitterDistance = 255;
            this.splitContainer1.TabIndex = 1;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.ImageKey = "folder.jpg";
            this.treeView1.ImageList = this.imageListSmall;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.SelectedImageIndex = 1;
            this.treeView1.Size = new System.Drawing.Size(255, 385);
            this.treeView1.TabIndex = 0;
            this.treeView1.BeforeExpand += new System.Windows.Forms.TreeViewCancelEventHandler(this.TreeView1_BeforeExpand);
            this.treeView1.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.TreeView1_BeforeExpand);
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView1_AfterSelect);
            // 
            // imageListSmall
            // 
            this.imageListSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListSmall.ImageStream")));
            this.imageListSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListSmall.Images.SetKeyName(0, "disk.jpg");
            this.imageListSmall.Images.SetKeyName(1, "folder.jpg");
            this.imageListSmall.Images.SetKeyName(2, "file.jpg");
            // 
            // listView1
            // 
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.LargeImageList = this.imageListLarge;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(541, 385);
            this.listView1.SmallImageList = this.imageListSmall;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListView1_MouseDoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextMenuCut,
            this.contextMenuPaste,
            this.contextMenuRename,
            this.contextMenuDelete,
            this.toolStripSeparator3,
            this.contextMenuRefresh,
            this.contextMenuCreateFolder,
            this.contextMenuCheckUnpack,
            this.toolStripSeparator2,
            this.contextMenuProperties});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(343, 256);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.ContextMenuStrip1_Opening);
            // 
            // contextMenuCut
            // 
            this.contextMenuCut.Name = "contextMenuCut";
            this.contextMenuCut.Size = new System.Drawing.Size(342, 30);
            this.contextMenuCut.Text = "Вырезать";
            this.contextMenuCut.Click += new System.EventHandler(this.MenuItemCut_Click);
            // 
            // contextMenuPaste
            // 
            this.contextMenuPaste.Name = "contextMenuPaste";
            this.contextMenuPaste.Size = new System.Drawing.Size(342, 30);
            this.contextMenuPaste.Text = "Вставить";
            this.contextMenuPaste.Click += new System.EventHandler(this.MenuItemPaste_Click);
            // 
            // contextMenuRename
            // 
            this.contextMenuRename.Name = "contextMenuRename";
            this.contextMenuRename.Size = new System.Drawing.Size(342, 30);
            this.contextMenuRename.Text = "Переименовать";
            this.contextMenuRename.Click += new System.EventHandler(this.MenuItemRename_Click);
            // 
            // contextMenuDelete
            // 
            this.contextMenuDelete.Name = "contextMenuDelete";
            this.contextMenuDelete.Size = new System.Drawing.Size(342, 30);
            this.contextMenuDelete.Text = "Удалить";
            this.contextMenuDelete.Click += new System.EventHandler(this.MenuItemDelete_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(339, 6);
            // 
            // contextMenuRefresh
            // 
            this.contextMenuRefresh.Name = "contextMenuRefresh";
            this.contextMenuRefresh.Size = new System.Drawing.Size(342, 30);
            this.contextMenuRefresh.Text = "Обновить";
            this.contextMenuRefresh.Click += new System.EventHandler(this.ContextMenuRefresh_Click);
            // 
            // contextMenuCreateFolder
            // 
            this.contextMenuCreateFolder.Name = "contextMenuCreateFolder";
            this.contextMenuCreateFolder.Size = new System.Drawing.Size(342, 30);
            this.contextMenuCreateFolder.Text = "Создать папку";
            this.contextMenuCreateFolder.Click += new System.EventHandler(this.ContextMenuCreateFolder_Click);
            // 
            // contextMenuCheckUnpack
            // 
            this.contextMenuCheckUnpack.Name = "contextMenuCheckUnpack";
            this.contextMenuCheckUnpack.Size = new System.Drawing.Size(342, 30);
            this.contextMenuCheckUnpack.Text = "Пометить файл для распаковки";
            this.contextMenuCheckUnpack.Click += new System.EventHandler(this.ContextMenuCheckUnpack_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(339, 6);
            // 
            // contextMenuProperties
            // 
            this.contextMenuProperties.Name = "contextMenuProperties";
            this.contextMenuProperties.Size = new System.Drawing.Size(342, 30);
            this.contextMenuProperties.Text = "Свойства";
            this.contextMenuProperties.Click += new System.EventHandler(this.ContextMenuProperties_Click);
            // 
            // imageListLarge
            // 
            this.imageListLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListLarge.ImageStream")));
            this.imageListLarge.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListLarge.Images.SetKeyName(0, "disk.jpg");
            this.imageListLarge.Images.SetKeyName(1, "folder.jpg");
            this.imageListLarge.Images.SetKeyName(2, "file.jpg");
            // 
            // textBoxPath
            // 
            this.textBoxPath.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBoxPath.Location = new System.Drawing.Point(0, 33);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(800, 26);
            this.textBoxPath.TabIndex = 2;
            this.textBoxPath.WordWrap = false;
            this.textBoxPath.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxPath_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(400, 300);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Browser";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ToolStripMenuItem StripMenuFile;
        private System.Windows.Forms.ToolStripMenuItem MenuClose;
        private System.Windows.Forms.ImageList imageListSmall;
        private System.Windows.Forms.ImageList imageListLarge;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.ToolStripMenuItem MenuItemCut;
        private System.Windows.Forms.ToolStripMenuItem MenuItemPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemRename;
        private System.Windows.Forms.ToolStripMenuItem StripMenuFileView;
        private System.Windows.Forms.ToolStripMenuItem MenuItemLargeIcon;
        private System.Windows.Forms.ToolStripMenuItem MenuItemList;
        private System.Windows.Forms.ToolStripMenuItem MenuItemTile;
        private System.Windows.Forms.ToolStripMenuItem StripMenuPacker;
        private System.Windows.Forms.ToolStripMenuItem MenuItemPacking;
        private System.Windows.Forms.ToolStripMenuItem MenuItemUnpacking;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem contextMenuCut;
        private System.Windows.Forms.ToolStripMenuItem contextMenuPaste;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem contextMenuProperties;
        private System.Windows.Forms.ToolStripMenuItem MenuItemDelete;
        private System.Windows.Forms.ToolStripMenuItem contextMenuRename;
        private System.Windows.Forms.ToolStripMenuItem contextMenuDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem contextMenuRefresh;
        private System.Windows.Forms.ToolStripMenuItem contextMenuCreateFolder;
        private System.Windows.Forms.ToolStripMenuItem contextMenuCheckUnpack;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem MenuItemHowToUse;
        private System.Windows.Forms.ToolStripMenuItem StripMenuUp;
    }
}

