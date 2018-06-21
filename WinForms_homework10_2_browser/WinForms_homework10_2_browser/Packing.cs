using System;
using System.IO;
using System.Collections.Generic;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace WinForms_homework10_2_browser
{
    [Serializable]
    class Packing
    {
        public string path;
        public byte[] content;

        public Packing(string p, string pathToFolder)
        {
            if (File.Exists(p))
            {
                int count = pathToFolder.Length + 1;
                path = p.Remove(0, count);
                try
                {
                    using (BinaryReader binreader = new BinaryReader(File.Open(p, FileMode.Open)))
                    {
                        content = binreader.ReadBytes((int)binreader.BaseStream.Length);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
                MessageBox.Show($"\nОшибка! Файл \"{p}\" не найден!\n", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public void Unpacking(string newFolder)
        {
            try
            {
                Directory.CreateDirectory(Path.GetDirectoryName($"{newFolder}" + "\\" + $"{path}"));
                using (BinaryWriter binwriter = new BinaryWriter(File.Create($"{newFolder}" + "\\" + $"{path}")))
                {
                    binwriter.Write(content);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public static void Serialization(string pathToFolder)
        {
            BinaryFormatter format = new BinaryFormatter();
            if (Directory.Exists(pathToFolder))
            {
                string[] files = Directory.GetFiles(pathToFolder, "*.*", SearchOption.AllDirectories);
                string[] directories = Directory.GetDirectories(pathToFolder, "*", SearchOption.AllDirectories);
                List<Packing> packingList = new List<Packing>(files.Length);
                try
                {
                    foreach (string str in files)
                        packingList.Add(new Packing(str, pathToFolder));
                    try
                    {
                        using (Stream fstream = File.Create($"{Directory.GetParent(pathToFolder + "\\")}" + ".bin"))
                        {
                            format.Serialize(fstream, packingList);
                            MessageBox.Show($"\n{files.Length} файлов и {directories.Length} папок упаковано в файл \nпо адресу \"{$"{Directory.GetParent(pathToFolder + "\\")}" + ".bin"}\"", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
                MessageBox.Show($"\nОшибка! Папка не найдена по адресу \"{pathToFolder}\"!\n", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        public static void Deserialization(string savedFilePath, string destinationFolder)
        {
            try
            {
                if (File.Exists(savedFilePath))
                {
                    using (FileStream fs = new FileStream(savedFilePath, FileMode.Open))
                    {
                        BinaryFormatter format = new BinaryFormatter();
                        List<Packing> UnpackingList = new List<Packing>((List<Packing>)format.Deserialize(fs));
                        Directory.CreateDirectory(destinationFolder);
                        foreach (Packing np in UnpackingList)
                            np.Unpacking(destinationFolder);
                        MessageBox.Show($"{UnpackingList.Count} файлов распаковано по адресу \"{destinationFolder}\"", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                    MessageBox.Show($"\nОшибка! Файл не найден по адресу \"{savedFilePath}\"!\n", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}