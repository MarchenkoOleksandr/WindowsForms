using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

//Помимо основного задания было реализовано:
//1. Упаковщик папок в один бинарный файл с возможностью дальнейшего восстановления из него файловой структуры
//2. Добавлены иконки дисков, папок и файлов
//3. Доступна возможность изменения вида папок и файлов
//4. Доступна навигация по папкам в окне содержимого привычным двойным кликом
//5. Добавлена возможность вырезать, вставлять, переименовывать и удалять файлы и папки
//6. Добавлена возможность узнать свойства файла (размер и дату последнего изменения)
//7. Добавлена возможность создавать новые папки

namespace WinForms_homework10_2_browser
{
    public partial class Form1 : Form
    {
        List<string> selectedFolders = new List<string>();
        List<string> selectedFiles = new List<string>();
        string folderForUnpacking = String.Empty;

        public Form1()
        {
            InitializeComponent();
            GetAllDisks();
        }

        private void MenuClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TreeView1_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            e.Node.Nodes.Clear();
            string[] dirs;
            try
            {
                if (Directory.Exists(e.Node.FullPath))
                {
                    dirs = Directory.GetDirectories(e.Node.FullPath);
                    if (dirs.Length != 0)
                    {
                        for (int i = 0; i < dirs.Length; i++)
                        {
                            TreeNode dirNode = new TreeNode(new DirectoryInfo(dirs[i]).Name);
                            FillChildNodes(dirNode, dirs[i]);
                            e.Node.Nodes.Add(dirNode);
                        }
                    }
                }
            }
            catch (Exception) { }
        }

        private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            UpdateListView((sender as TreeView).SelectedNode.FullPath);
        }

        private void MenuItemLargeIcon_Click(object sender, EventArgs e)
        {
            listView1.View = View.LargeIcon;
        }

        private void MenuItemList_Click(object sender, EventArgs e)
        {
            listView1.View = View.List;
        }

        private void MenuItemTile_Click(object sender, EventArgs e)
        {
            listView1.View = View.Tile;
        }

        private void MenuItemCut_Click(object sender, EventArgs e)
        {
            GetSelectedObjects();
        }

        private void MenuItemPaste_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < selectedFolders.Count; i++)
            {
                string destDirName = textBoxPath.Text + "\\" + selectedFolders[i].Remove(0, selectedFolders[i].LastIndexOf("\\") + 1);
                if (!Directory.Exists(destDirName))
                    Directory.Move(selectedFolders[i], destDirName);
            }
            for (int i = 0; i < selectedFiles.Count; i++)
            {
                string destFileName = textBoxPath.Text + "\\" + selectedFiles[i].Remove(0, selectedFiles[i].LastIndexOf("\\") + 1);
                if (!File.Exists(destFileName))
                    File.Move(selectedFiles[i], destFileName);
            }
            UpdateListView(textBoxPath.Text);
        }

        private void MenuItemDelete_Click(object sender, EventArgs e)
        {
            GetSelectedObjects();
            foreach (string item in selectedFolders)
                Directory.Delete(item, true);
            foreach (string item in selectedFiles)
                File.Delete(item);
            UpdateListView(textBoxPath.Text);
        }

        private void MenuItemRename_Click(object sender, EventArgs e)
        {
            GetSelectedObjects();
            
            if (selectedFolders.Count == 1 && selectedFiles.Count == 0)
            {
                DirectoryInfo dirInfo = new DirectoryInfo(selectedFolders[0]);
                if (dirInfo.Exists)
                {
                    string newName = dirInfo.Name;
                    using (FormRename formRename = new FormRename(newName))
                    {
                        if (formRename.ShowDialog() == DialogResult.OK)
                        {
                            newName = formRename.textBoxRenameField.Text;
                            Directory.Move(dirInfo.FullName, textBoxPath.Text + "\\" + newName);
                        }
                    }
                }
            }
            else if (selectedFolders.Count == 0 && selectedFiles.Count == 1)
            {
                FileInfo fileInfo = new FileInfo(selectedFiles[0]);
                if (fileInfo.Exists)
                {
                    string newName = fileInfo.Name;
                    using (FormRename formRename = new FormRename(newName))
                    {
                        if (formRename.ShowDialog() == DialogResult.OK)
                        {
                            newName = formRename.textBoxRenameField.Text;
                            Directory.Move(fileInfo.FullName, textBoxPath.Text + "\\" + newName);
                        }
                    }
                }
            }
            UpdateListView(textBoxPath.Text);
        }

        private void ContextMenuRefresh_Click(object sender, EventArgs e)
        {
            UpdateListView(textBoxPath.Text);
        }

        private void ContextMenuProperties_Click(object sender, EventArgs e)
        {
            GetSelectedObjects();
            if (selectedFolders.Count == 1 && selectedFiles.Count == 0)
            {
                DirectoryInfo dirInfo = new DirectoryInfo(selectedFolders[0]);
                if (dirInfo.Exists)
                    MessageBox.Show($"Имя папки: \"{dirInfo.Name}\"\nВремя создания: { dirInfo.CreationTime}");
            }
            else if (selectedFolders.Count == 0 && selectedFiles.Count == 1)
            {
                FileInfo fileInfo = new FileInfo(selectedFiles[0]);
                if (fileInfo.Exists)
                    MessageBox.Show($"Имя файла: \"{fileInfo.Name}\"\nВремя создания: { fileInfo.CreationTime}\nРазмер файла: {fileInfo.Length} байт");
            }
            else
                MessageBox.Show($"Выделено папок: {selectedFolders.Count}\nВыделено файлов: {selectedFiles.Count}");
        }

        private void ContextMenuCreateFolder_Click(object sender, EventArgs e)
        {
            using (FormRename formRename = new FormRename("Новая папка"))
            {
                if (formRename.ShowDialog() == DialogResult.OK)
                {
                    DirectoryInfo dirInfo = new DirectoryInfo(textBoxPath.Text + "\\" + formRename.textBoxRenameField.Text);
                    if (!dirInfo.Exists)
                        dirInfo.Create();
                    else
                        MessageBox.Show("Папка с таким именем уже существует");
                }
            }
            UpdateListView(textBoxPath.Text);
        }

        private void ListView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
                UpdateListView(textBoxPath.Text + "\\" + listView1.SelectedItems[0].Text);
        }

        private void TextBoxPath_KeyPress(object sender, KeyPressEventArgs e)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(textBoxPath.Text);
            if (e.KeyChar == 13 && dirInfo.Exists)
                UpdateListView(textBoxPath.Text);
        }

        private void StripMenuFile_DropDownOpening(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                MenuItemCut.Enabled = false;
                MenuItemRename.Enabled = false;
                MenuItemDelete.Enabled = false;
            }
            else
            {
                MenuItemCut.Enabled = true;
                MenuItemRename.Enabled = true;
                MenuItemDelete.Enabled = true;
            }

            if (selectedFolders.Count == 0 && selectedFiles.Count == 0)
                MenuItemPaste.Enabled = false;
            else
                MenuItemPaste.Enabled = true;
        }

        private void ContextMenuStrip1_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (listView1.SelectedItems.Count == 0)
            {
                contextMenuCut.Enabled = false;
                contextMenuRename.Enabled = false;
                contextMenuDelete.Enabled = false;
            }
            else
            {
                contextMenuCut.Enabled = true;
                contextMenuRename.Enabled = true;
                contextMenuDelete.Enabled = true;
            }

            if (selectedFolders.Count == 0 && selectedFiles.Count == 0)
                contextMenuPaste.Enabled = false;
            else
                contextMenuPaste.Enabled = true;
        }

        private void StripMenuPacker_DropDownOpening(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
                MenuItemPacking.Enabled = true;
            else
                MenuItemPacking.Enabled = false;

            if (String.IsNullOrEmpty(folderForUnpacking))
                MenuItemUnpacking.Enabled = false;
            else
                MenuItemUnpacking.Enabled = true;
        }

        private void MenuItemPacking_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1 && listView1.SelectedItems[0].ImageIndex == 1)
            {
                listView1.Enabled = false;
                listView1.Update();
                Packing.Serialization(textBoxPath.Text + "\\" + listView1.SelectedItems[0].Text);
                listView1.Enabled = true;
                UpdateListView(textBoxPath.Text);
            }
            else
                MessageBox.Show($"\nВыберете одну папку для упаковки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void ContextMenuCheckUnpack_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
                folderForUnpacking = textBoxPath.Text + "\\" + listView1.SelectedItems[0].Text;
        }

        private void MenuItemUnpacking_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(folderForUnpacking))
            {
                listView1.Enabled = false;
                listView1.Update();
                Packing.Deserialization(folderForUnpacking, textBoxPath.Text);
                listView1.Enabled = true;
                UpdateListView(textBoxPath.Text);
                folderForUnpacking = String.Empty;
            }
            else
                MessageBox.Show($"\nВыберете одну папку для упаковки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void MenuItemHowToUse_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. Чтобы упаковать - выберите одну папку и нажмите \"Упаковать объект\"\n" +
                "2. Чтобы распаковать: \n- пометьте правой клавишей созданый файл *.bin\n- перейдите в любую папку\n" +
                "- выберите пункт \"Распаковать  объект\"", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void StripMenuUp_Click(object sender, EventArgs e)
        {
            try
            {
                UpdateListView(Directory.GetParent(textBoxPath.Text).ToString());
            }
            catch (Exception) { }
        }

        private void GetAllDisks()
        {
            try
            {
                foreach (DriveInfo drive in DriveInfo.GetDrives())
                {
                    TreeNode driveNode = new TreeNode { Text = drive.Name };
                    FillChildNodes(driveNode, drive.Name);
                    driveNode.ImageIndex = 0;
                    driveNode.SelectedImageIndex = 0;
                    treeView1.Nodes.Add(driveNode);
                }
            }
            catch (Exception) { }
        }

        private void FillChildNodes(TreeNode driveNode, string path)
        {
            try
            {
                string[] directories = Directory.GetDirectories(path);
                foreach (string dir in directories)
                {
                    TreeNode dirNode = new TreeNode();
                    dirNode.Text = dir.Remove(0, dir.LastIndexOf("\\") + 1);
                    driveNode.ImageIndex = 1;
                    driveNode.SelectedImageIndex = 1;
                    driveNode.Nodes.Add(dirNode);
                }
            }
            catch (Exception) { }
        }

        private void GetSelectedObjects()
        {
            selectedFolders.Clear();
            selectedFiles.Clear();
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                if (item.ImageIndex == 1)
                    selectedFolders.Add(textBoxPath.Text + "\\" + item.Text);
                else if (item.ImageIndex == 2)
                    selectedFiles.Add(textBoxPath.Text + "\\" + item.Text);
            }
        }

        private void UpdateListView(string path)
        {
            try
            {
                path = path.Replace("\\\\", "\\");
                textBoxPath.Text = path;
                listView1.Clear();
                string[] directories = Directory.GetDirectories(path);
                foreach (string dir in directories)
                {
                    ListViewItem item = new ListViewItem(dir.Remove(0, dir.LastIndexOf("\\") + 1));
                    item.ImageIndex = 1;
                    listView1.Items.Add(item);
                }
                string[] files = Directory.GetFiles(path);
                foreach (string file in files)
                {
                    ListViewItem item = new ListViewItem(file.Remove(0, file.LastIndexOf("\\") + 1));
                    item.ImageIndex = 2;
                    listView1.Items.Add(item);
                }
            }
            catch (Exception) { }
        }
    }
}