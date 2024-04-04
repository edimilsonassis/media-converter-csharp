using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (var file in openFileDialog1.FileNames)
                {
                    listViewFiles.Items.Add(new ListViewItem(new string[]
                    {
                        System.IO.Path.GetFileName(file),
                        getFormatedSizeNumber(file),
                        file,
                    }));
                }
            }
        }

        private string getFormatedSizeNumber(string path)
        {
            string[] sizes = { "B", "KB", "MB", "GB", "TB" };
            double len = new System.IO.FileInfo(path).Length;
            int order = 0;
            while (len >= 1024 && order < sizes.Length - 1)
            {
                order++;
                len = len / 1024;
            }
            return $"{len:0.##} {sizes[order]}";
        }

        private void abrirLocalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewFiles.SelectedItems.Count > 0)
            {
                string path = listViewFiles.SelectedItems[0].SubItems[2].Text;
                System.Diagnostics.Process.Start("explorer.exe", "/select, " + path);
            }
        }

        private void removerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewFiles.SelectedItems.Count > 0)
            {
                foreach (ListViewItem item in listViewFiles.SelectedItems)
                {
                    listViewFiles.Items.Remove(item);
                }
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string folder = folderBrowserDialog1.SelectedPath;
                string extension = textFormat.Text;

                buttonStart.Enabled = false;
                toolStripStatusLabel1.Text = "Convertendo para " + extension + "...";
                toolStripProgressBar1.Value = 0;
                toolStripProgressBar1.Visible = true;

                foreach (ListViewItem item in listViewFiles.Items)
                {
                    string file = item.SubItems[2].Text;
                    string name = System.IO.Path.GetFileNameWithoutExtension(file);
                    string output = folder + "\\" + name + "." + extension;
                    string command = $"-i \"{file}\" \"{output}\" -y";

                    System.Diagnostics.ProcessStartInfo processStartInfo = new System.Diagnostics.ProcessStartInfo("ffmpeg", command)
                    {
                        CreateNoWindow = true,
                        UseShellExecute = false,
                        WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden
                    };

                    toolStripProgressBar1.Value += 100 / listViewFiles.Items.Count;
                    System.Diagnostics.Process.Start(processStartInfo).WaitForExit();
                }

                buttonStart.Enabled = true;
                toolStripStatusLabel1.Text = "Conversão concluída!";
                toolStripProgressBar1.Value = 100;
                toolStripProgressBar1.Visible = false;

                System.Media.SystemSounds.Asterisk.Play();

                System.Diagnostics.Process.Start("explorer.exe", folder);
            }
        }
    }
}
