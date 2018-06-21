using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace WinForms_homework9_wordpad
{
    public partial class Form1 : Form
    {
        int tempIndex = 0;
        string path = String.Empty;

        public Form1()
        {
            InitializeComponent();

            richTextBox1.AllowDrop = true;
            richTextBox1.DragEnter += new DragEventHandler(RichTextBox1_DragEnter);
            richTextBox1.DragDrop += new DragEventHandler(RichTextBox1_DragDrop);
        }

        private void RichTextBox1_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent("Text"))
                e.Effect = DragDropEffects.Copy;
        }

        private void RichTextBox1_DragDrop(object sender, DragEventArgs e)
        {
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            RichTextBox tempRichTextBox = new RichTextBox();

            foreach (string file in files)
            {
                if (Path.GetExtension(file) == ".txt")
                {
                    tempRichTextBox.LoadFile(file, RichTextBoxStreamType.PlainText);
                    richTextBox1.Text = richTextBox1.Text.Insert(richTextBox1.SelectionStart, tempRichTextBox.Text);
                    ToolStripMenuDeveloper.Checked = false;
                }
                else if (Path.GetExtension(file) == ".cs")
                {
                    tempRichTextBox.LoadFile(file, RichTextBoxStreamType.PlainText);
                    richTextBox1.Text = richTextBox1.Text.Insert(richTextBox1.SelectionStart, tempRichTextBox.Text);
                    ToolStripMenuDeveloper.Checked = true;
                    CheckKeyWords(0, richTextBox1.Text.Length);
                }
                else if (Path.GetExtension(file) == ".rtf")
                {
                    richTextBox1.LoadFile(file, RichTextBoxStreamType.RichText);
                    ToolStripMenuDeveloper.Checked = false;
                }
            }

        }

        private void ToolMenuExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ToolMenuCreate_Click(object sender, EventArgs e)
        {
            if (IsChanded())
            {
                tempIndex = 0;
                path = String.Empty;
            }
        }

        private void ToolMenuOpen_Click(object sender, EventArgs e)
        {
            if (IsChanded())
                OpenFile();
        }

        private void ToolStripSave_Click(object sender, EventArgs e)
        {
            SaveFile();
        }

        private void ToolMenuSaveAs_Click(object sender, EventArgs e)
        {
            SaveAsFile();
        }

        private void ToolMenuCut_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText.Length > 0)
                richTextBox1.Cut();
        }

        private void ToolMenuCopy_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void ToolMenuPaste_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void ToolStripCut_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText.Length > 0)
            {
                richTextBox1.Cut();
                ToolMenuPaste.Enabled = true;
            }
        }

        private void ToolStripCopy_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText.Length > 0)
            {
                richTextBox1.Copy();
                ToolMenuPaste.Enabled = true;
            }
        }

        private void ToolStripDelete_Click(object sender, EventArgs e)
        {
            DeleteSelectedFragment();
        }

        private void ToolStripPaste_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void ToolStripFont_Click(object sender, EventArgs e)
        {
            SetFont();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!IsChanded())
                e.Cancel = true;
            else
                e.Cancel = false;
        }

        private void ToolStripUndo_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void ToolStripRedo_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }

        private void ToolStripZoom_SelectedIndexChanged(object sender, EventArgs e)
        {
            toolStripMinus.Enabled = true;
            toolStripPlus.Enabled = true;

            richTextBox1.ZoomFactor = (toolStripZoom.SelectedIndex + 1) * 0.5f;
            if (toolStripZoom.SelectedIndex == 0)
                toolStripMinus.Enabled = false;
            else if (toolStripZoom.SelectedIndex == toolStripZoom.Items.Count - 1)
                toolStripPlus.Enabled = false;
        }

        private void ToolStripMinus_Click(object sender, EventArgs e)
        {
            if (richTextBox1.ZoomFactor > 0.5f)
            {
                richTextBox1.ZoomFactor -= 0.5f;
                toolStripZoom.SelectedIndex--;
            }
        }

        private void ToolStripPlus_Click(object sender, EventArgs e)
        {
            if (richTextBox1.ZoomFactor < 4.0f)
            {
                richTextBox1.ZoomFactor += 0.5f;
                toolStripZoom.SelectedIndex++;
            }
        }

        private void RichTextBox1_SelectionChanged(object sender, EventArgs e)
        {
            if (richTextBox1.CanUndo)
            {
                ToolStripUndo.Enabled = true;
                toolStripUndo1.Enabled = true;
            }
            else
            {
                ToolStripUndo.Enabled = false;
                toolStripUndo1.Enabled = false;
            }

            if (richTextBox1.CanRedo)
            {
                ToolStripRedo.Enabled = true;
                toolStripRedo1.Enabled = true;
            }
            else
            {
                ToolStripRedo.Enabled = false;
                toolStripRedo1.Enabled = false;
            }

            if (richTextBox1.SelectedText.Length > 0)
            {
                ToolMenuCut.Enabled = true;
                ToolMenuCopy.Enabled = true;
                toolStripCut1.Enabled = true;
                ToolStripCut.Enabled = true;
                ToolStripCopy.Enabled = true;
                toolStripCopy1.Enabled = true;
                ToolStripDelete.Enabled = true;
            }
            else
            {
                ToolMenuCut.Enabled = false;
                ToolMenuCopy.Enabled = false;
                toolStripCut1.Enabled = false;
                ToolStripCut.Enabled = false;
                ToolStripCopy.Enabled = false;
                toolStripCopy1.Enabled = false;
                ToolStripDelete.Enabled = false;
            }
        }

        private void ToolStripSelectAll_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }

        private void ToolStripTimeDate_Click(object sender, EventArgs e)
        {
            int cursorPosition = richTextBox1.SelectionStart;
            richTextBox1.Text = richTextBox1.Text.Insert(richTextBox1.SelectionStart, DateTime.Now.ToShortDateString().ToString() + " "+ DateTime.Now.ToShortTimeString().ToString());
            richTextBox1.SelectionStart = cursorPosition + 16;
        }

        private void ToolStripMenuFont_Click(object sender, EventArgs e)
        {
            SetFont();
        }

        private void ToolStripMenuBackground_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            color.FullOpen = true;
            color.ShowDialog();
            richTextBox1.BackColor = color.Color;
        }

        private void ToolStripMenuAbout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Программа разработана студентом \nКомпьютерной академии \"ШАГ\"\nАлександром Марченко", "О программе");
        }

        private void RichTextBox1_KeyUp(object sender, KeyEventArgs e)
        {
            StatusStripLanguage();
            if (ToolStripMenuDeveloper.Checked && e.KeyCode == Keys.Space)
                CheckKeyWords(richTextBox1.GetFirstCharIndexOfCurrentLine(), richTextBox1.SelectionStart);
        }

        private void RichTextBox1_MouseDown(object sender, MouseEventArgs e)
        {
            StatusStripLanguage();
        }

        private void ToolStripMenuColorScheme_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            color.FullOpen = true;
            color.ShowDialog();
            menuStrip1.BackColor = color.Color;
            toolStrip1.BackColor = color.Color;
            statusStrip1.BackColor = color.Color;
            contextMenuStrip1.BackColor = color.Color;
        }

        private void ToolStripMenuRus_Click(object sender, EventArgs e)
        {
            ToolStripMenuRus.Checked = true;
            ToolStripMenuUkr.Checked = false;
            ToolStripMenuEng.Checked = false;
            ToolStripMenuFile.Text = "Файл";
            ToolMenuCreate.Text = "Создать";
            ToolMenuOpen.Text = "Открыть";
            ToolStripSave.Text = "Сохранить";
            ToolMenuSaveAs.Text = "Сохранить как";
            ToolMenuExit.Text = "Выход";
            ToolStripMenuEdit.Text = "Правка";
            ToolStripUndo.Text = "Назад";
            ToolStripRedo.Text = "Вперёд";
            ToolMenuCut.Text = "Вырезать";
            ToolMenuCopy.Text = "Копировать";
            ToolMenuPaste.Text = "Вставить";
            ToolStripDelete.Text = "Удалить";
            ToolStripSelectAll.Text = "Виделить все";
            ToolStripTimeDate.Text = "Дата и время";
            ToolStripMenuView.Text = "Вид";
            ToolStripMenuFont.Text = "Шрифт";
            ToolStripMenuBackground.Text = "Фон";
            ToolStripMenuColorScheme.Text = "Цветовая схема";
            ToolStripMenuLanguage.Text = "Язык";
            ToolStripMenuRus.Text = "Русский";
            ToolStripMenuUkr.Text = "Украинский";
            ToolStripMenuEng.Text = "Английский";
            ToolStripMenuInfo.Text = "Справка";
            ToolStripMenuAbout.Text = "О программе";
            toolStripUndo1.Text = "Назад";
            toolStripRedo1.Text = "Вперёд";
            toolStripCreate.Text = "Создать новый документ";
            toolStripOpen.Text = "Открыть";
            toolStripSave1.Text = "Сохранить";
            toolStripSaveAs.Text = "Сохранить как";
            toolStripMinus.Text = "Уменьшить масштаб";
            toolStripPlus.Text = "Увеличить масштаб";
            toolStripCut1.Text = "Вырезать";
            toolStripCopy1.Text = "Копировать";
            toolStripPaste1.Text = "Вставить";
            ToolStripCut.Text = "Вырезать";
            ToolStripCopy.Text = "Копировать";
            ToolStripPaste.Text = "Вставить";
            ToolStripFont.Text = "Шрифт";
            toolStripButtonFind.Text = "Найти";
            toolStripButtonReplace.Text = "Заменить";
        }

        private void ToolStripMenuUkr_Click(object sender, EventArgs e)
        {
            ToolStripMenuRus.Checked = false;
            ToolStripMenuUkr.Checked = true;
            ToolStripMenuEng.Checked = false;
            ToolStripMenuFile.Text = "Файл";
            ToolMenuCreate.Text = "Створити";
            ToolMenuOpen.Text = "Відкрити";
            ToolStripSave.Text = "Зберегти";
            ToolMenuSaveAs.Text = "Зберегти як";
            ToolMenuExit.Text = "Вихід";
            ToolStripMenuEdit.Text = "Редагувати";
            ToolStripUndo.Text = "Назад";
            ToolStripRedo.Text = "Вперед";
            ToolMenuCut.Text = "Вирізати";
            ToolMenuCopy.Text = "Копіювати";
            ToolMenuPaste.Text = "Вставити";
            ToolStripDelete.Text = "Видалити";
            ToolStripSelectAll.Text = "Виділити все";
            ToolStripTimeDate.Text = "Дата та час";
            ToolStripMenuView.Text = "Вигляд";
            ToolStripMenuFont.Text = "Шрифт";
            ToolStripMenuBackground.Text = "Фон";
            ToolStripMenuColorScheme.Text = "Кольорова схема";
            ToolStripMenuLanguage.Text = "Мова";
            ToolStripMenuRus.Text = "Російська";
            ToolStripMenuUkr.Text = "Українська";
            ToolStripMenuEng.Text = "Англійська";
            ToolStripMenuInfo.Text = "Iнформація";
            ToolStripMenuAbout.Text = "Про програму";
            toolStripUndo1.Text = "Назад";
            toolStripRedo1.Text = "Вперед";
            toolStripCreate.Text = "Строрити новий документ";
            toolStripOpen.Text = "Відкрити";
            toolStripSave1.Text = "Зберегти";
            toolStripSaveAs.Text = "Зберегти як";
            toolStripMinus.Text = "Зненшити";
            toolStripPlus.Text = "Збільшити";
            toolStripCut1.Text = "Вирізати";
            toolStripCopy1.Text = "Копіювати";
            toolStripPaste1.Text = "Вставити";
            ToolStripCut.Text = "Вирізати";
            ToolStripCopy.Text = "Копіювати";
            ToolStripPaste.Text = "Вставити";
            ToolStripFont.Text = "Шрифт";
            toolStripButtonFind.Text = "Знайти";
            toolStripButtonReplace.Text = "Замінити";
        }

        private void ToolStripMenuEng_Click(object sender, EventArgs e)
        {
            ToolStripMenuRus.Checked = false;
            ToolStripMenuUkr.Checked = false;
            ToolStripMenuEng.Checked = true;
            ToolStripMenuFile.Text = "File";
            ToolMenuCreate.Text = "Create new";
            ToolMenuOpen.Text = "Open";
            ToolStripSave.Text = "Save";
            ToolMenuSaveAs.Text = "Save as";
            ToolMenuExit.Text = "Exit";
            ToolStripMenuEdit.Text = "Edit";
            ToolStripUndo.Text = "Undo";
            ToolStripRedo.Text = "Redo";
            ToolMenuCut.Text = "Cut";
            ToolMenuCopy.Text = "Copy";
            ToolMenuPaste.Text = "Paste";
            ToolStripDelete.Text = "Delete";
            ToolStripSelectAll.Text = "Select all";
            ToolStripTimeDate.Text = "Time & Date";
            ToolStripMenuView.Text = "View";
            ToolStripMenuFont.Text = "Font";
            ToolStripMenuBackground.Text = "Background";
            ToolStripMenuColorScheme.Text = "Color scheme";
            ToolStripMenuLanguage.Text = "Language";
            ToolStripMenuRus.Text = "Russian";
            ToolStripMenuUkr.Text = "Ukrainian";
            ToolStripMenuEng.Text = "English";
            ToolStripMenuInfo.Text = "Info";
            ToolStripMenuAbout.Text = "About";
            toolStripUndo1.Text = "Undo";
            toolStripRedo1.Text = "Redo";
            toolStripCreate.Text = "Create new";
            toolStripOpen.Text = "Open";
            toolStripSave1.Text = "Save";
            toolStripSaveAs.Text = "Save as";
            toolStripMinus.Text = "Zoom -";
            toolStripPlus.Text = "Zoom +";
            toolStripCut1.Text = "Cut";
            toolStripCopy1.Text = "Copy";
            toolStripPaste1.Text = "Paste";
            ToolStripCut.Text = "Cut";
            ToolStripCopy.Text = "Copy";
            ToolStripPaste.Text = "Paste";
            ToolStripFont.Text = "Font";
            toolStripButtonFind.Text = "Find";
            toolStripButtonReplace.Text = "Replace";
        }

        private void ToolStripButtonFind_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.Find(toolStripTextBoxFind.Text, richTextBox1.SelectionStart + 1, RichTextBoxFinds.None);
            }
            catch (Exception) { }
        }

        private void ToolStripButtonReplace_Click(object sender, EventArgs e)
        {
            DeleteSelectedFragment();
            int cursorPosition = richTextBox1.SelectionStart;
            richTextBox1.Text = richTextBox1.Text.Insert(cursorPosition, toolStripTextBoxReplace.Text);
            richTextBox1.SelectionStart = cursorPosition + toolStripTextBoxReplace.Text.Length;
        }

        private void ToolStripMenuDeveloper_Click(object sender, EventArgs e)
        {
            if (ToolStripMenuDeveloper.Checked)
                ToolStripMenuDeveloper.Checked = false;
            else
            {
                ToolStripMenuDeveloper.Checked = true;
                CheckKeyWords(0, richTextBox1.Text.Length);
            }
        }

        private void CheckKeyWords(int start, int end)
        {
            int cursorPosition = richTextBox1.SelectionStart;
            List<string> keyWords = new List<string> { "using", "while", "for", "if", "else", "switch",
                "namespace", "public", "private", "class", "int", "string", "void", "break", "continue", "string",
                "object", "double", "struct", "foreach", "try", "catch", "default", "case", "char", "static" };
            int tempStart;
            
            foreach (string item in keyWords)
            {
                tempStart = start;
                while (richTextBox1.Find(item, tempStart, end, RichTextBoxFinds.MatchCase) != -1)
                {
                    richTextBox1.SelectionColor = Color.Blue;
                    tempStart = richTextBox1.SelectionStart + richTextBox1.SelectedText.Length;
                }
            }
            richTextBox1.SelectionStart = cursorPosition;
        }

        private void SetFont()
        {
            using (FontDialog fontDialog = new FontDialog())
            {
                fontDialog.ShowColor = true;
                if (fontDialog.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.SelectionFont = fontDialog.Font;
                    richTextBox1.SelectionColor = fontDialog.Color;
                }
            }
        }

        private void OpenFile()
        {
            try
            {
                OpenFileDialog openFile1 = new OpenFileDialog();
                openFile1.Filter = "RTF files|*.rtf|Text files|*.txt|C-sharp files|*.cs|All files|*.*";
                openFile1.FilterIndex = 1;

                if (openFile1.ShowDialog() == DialogResult.OK && openFile1.FileName.Length > 0)
                {
                    if (openFile1.FilterIndex == 1)
                    {
                        richTextBox1.LoadFile(openFile1.FileName, RichTextBoxStreamType.RichText);
                        tempIndex = 1;
                        ToolStripMenuDeveloper.Checked = false;
                    }
                    else if (openFile1.FilterIndex == 2)
                    {
                        richTextBox1.LoadFile(openFile1.FileName, RichTextBoxStreamType.PlainText);
                        tempIndex = 2;
                        ToolStripMenuDeveloper.Checked = false;
                    }
                    else if (openFile1.FilterIndex == 3)
                    {
                        richTextBox1.LoadFile(openFile1.FileName, RichTextBoxStreamType.PlainText);
                        tempIndex = 3;
                        ToolStripMenuDeveloper.Checked = true;
                        CheckKeyWords(0, richTextBox1.Text.Length);
                    }
                    FileInfo fileInfo = new FileInfo(openFile1.FileName);
                    path = fileInfo.FullName;
                    Text += fileInfo.Name;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SaveFile()
        {
            try
            {
                if (File.Exists(path) && tempIndex == 1)
                    richTextBox1.SaveFile(path, RichTextBoxStreamType.RichText);
                else if (File.Exists(path) && tempIndex == 2)
                    richTextBox1.SaveFile(path, RichTextBoxStreamType.PlainText);
                else if (File.Exists(path) && tempIndex == 3)
                    richTextBox1.SaveFile(path, RichTextBoxStreamType.PlainText);
                else
                    SaveAsFile();
                richTextBox1.ClearUndo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SaveAsFile()
        {
            try
            {
                SaveFileDialog saveFile1 = new SaveFileDialog();
                saveFile1.DefaultExt = "*.rtf";
                saveFile1.Filter = "RTF files|*.rtf|Text files|*.txt|C-sharp files|*.cs";
                saveFile1.FilterIndex = tempIndex;

                if (saveFile1.ShowDialog() == DialogResult.OK)
                {
                    if (saveFile1.FilterIndex == 1)
                        richTextBox1.SaveFile(saveFile1.FileName, RichTextBoxStreamType.RichText);
                    else if (saveFile1.FilterIndex == 2 || saveFile1.FilterIndex == 3)
                        richTextBox1.SaveFile(saveFile1.FileName, RichTextBoxStreamType.PlainText);
                }
                richTextBox1.ClearUndo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool IsChanded()
        {
            if (!richTextBox1.CanUndo || MessageBox.Show("Последние изменения будут потеряны!\nХотите продолжить?", "Внимание", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.OK)
            {
                richTextBox1.Clear();
                Text = "NotePad-- ";
                return true;
            }
            else
                return false;
        }

        private void DeleteSelectedFragment()
        {
            int cursorPosition = richTextBox1.SelectionStart;
            if (richTextBox1.SelectedText.Length > 0)
                richTextBox1.Text = richTextBox1.Text.Remove(richTextBox1.SelectionStart, richTextBox1.SelectionLength);
            richTextBox1.SelectionStart = cursorPosition;
        }

        private void StatusStripLanguage()
        {
            if (ToolStripMenuRus.Checked)
                toolStripStatusLabel1.Text = $"Строк: {richTextBox1.Lines.Length}   символов: {richTextBox1.Text.Length - richTextBox1.Lines.Length + 1}    " +
                $"Курсор в строке {richTextBox1.GetLineFromCharIndex(richTextBox1.SelectionStart) + 1}  на символе {richTextBox1.SelectionStart - richTextBox1.GetFirstCharIndexOfCurrentLine()}";
            else if (ToolStripMenuUkr.Checked)
                toolStripStatusLabel1.Text = $"Рядків: {richTextBox1.Lines.Length}   символів: {richTextBox1.Text.Length - richTextBox1.Lines.Length + 1}    " +
                $"Курсор у рядку {richTextBox1.GetLineFromCharIndex(richTextBox1.SelectionStart) + 1}  на символі {richTextBox1.SelectionStart - richTextBox1.GetFirstCharIndexOfCurrentLine()}";
            else if (ToolStripMenuEng.Checked)
                toolStripStatusLabel1.Text = $"Lines: {richTextBox1.Lines.Length}   symbols: {richTextBox1.Text.Length - richTextBox1.Lines.Length + 1}    " +
                $"Cursor is in the line {richTextBox1.GetLineFromCharIndex(richTextBox1.SelectionStart) + 1}  near symbol {richTextBox1.SelectionStart - richTextBox1.GetFirstCharIndexOfCurrentLine()}";
        }
    }
}