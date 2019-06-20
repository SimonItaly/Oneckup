using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using Microsoft.Win32;

namespace Oneckup
{
    public partial class MainForm : Form
    {
        private bool IsUNCPath;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            StartupBox.Checked = Properties.Settings.Default.Startup;

            Bidirectional.Checked = Properties.Settings.Default.Bidir;

            TimerBox.Checked = Properties.Settings.Default.Timer;
            comboBox1.SelectedIndex = Properties.Settings.Default.TimeType;
            timeBox.Value = Properties.Settings.Default.TimeAmount;

            numDayHour.Value = Properties.Settings.Default.DayHour;
            numDayMinute.Value = Properties.Settings.Default.DayMinute;

            SyncTimer.Interval = (1000) * Convert.ToInt32(timeBox.Value) * Convert.ToInt32(Math.Pow(60, comboBox1.SelectedIndex));

            if (TimerBox.Checked)
            {
                SyncTimer.Start();
                timeBox.Enabled = true;
                comboBox1.Enabled = true;
            }
            else
            {
                SyncTimer.Stop();
                timeBox.Enabled = false;
                comboBox1.Enabled = false;
            }

            destBox.Text = Properties.Settings.Default.Destination;
            if (destBox.Text[0] == '\\' && destBox.Text[1] == '\\') IsUNCPath = true;
            destBox.SelectionLength = 0;
            destBox.SelectionStart = destBox.Text.Length;

            richTextBox1.Text = Properties.Settings.Default.Folders;

            FixTimer();
            DayCheck.Checked = Properties.Settings.Default.DayTimer;
            if (DayCheck.Checked)
            {
                DailyTimer.Start();
                numDayHour.Enabled = true;
                numDayMinute.Enabled = true;
            }
            else
            {
                DailyTimer.Stop();
                numDayHour.Enabled = false;
                numDayMinute.Enabled = false;
            }

            SyncTimer.Tick += new EventHandler(SyncButton_Click);
            DailyTimer.Tick += new EventHandler(SyncDailyTimer);
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void MainForm_Resize(object sender, System.EventArgs e)
        {
            if (FormWindowState.Minimized == WindowState)
            {
                Hide();
            }
        }

        /////////////////////////////////////////////////////////////////////////////////////////////////////////

        private void TimerBox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Timer = SyncTimer.Enabled = TimerBox.Checked;
            if (TimerBox.Checked)
            {
                SyncTimer.Start();
                timeBox.Enabled = true;
                comboBox1.Enabled = true;
            }
            else
            {
                SyncTimer.Stop();
                timeBox.Enabled = false;
                comboBox1.Enabled = false;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.TimeType = comboBox1.SelectedIndex;
            SyncTimer.Interval = (1000) * Convert.ToInt32(timeBox.Value) * Convert.ToInt32(Math.Pow(60, comboBox1.SelectedIndex));
            SyncTimer.Stop();
            if (TimerBox.Checked) SyncTimer.Start();
        }

        private void StartupBox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Startup = StartupBox.Checked;
            RegisterInStartup(StartupBox.Checked);
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && FormWindowState.Minimized == WindowState)
            {
                Show();
                toolOpen.Enabled = false;
                WindowState = FormWindowState.Normal;
            }
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                toolOpen.Enabled = (WindowState == FormWindowState.Minimized);
                contextMenuStrip1.Show();
            }
        }

        //

        private void destBox_Leave(object sender, EventArgs e)
        {
            IsUNCPath = false;
            if (destBox.Text != "" && Directory.Exists(destBox.Text))
            {
                Properties.Settings.Default.Destination = destBox.Text;
            }
            else
            {
                destBox.Focus();
                MessageBox.Show("La cartella di destinazione \"" + destBox.Text + "\" non è una directory valida.", "Destinazione non valida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SyncButton_Click(object sender, EventArgs e)
        {
            SyncFolders();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Folders = richTextBox1.Text;
        }

        private void richTextBox1_DoubleClick(object sender, EventArgs e)
        {
            addButton_Click(null, null);
        }

        private void SyncFolders()
        {
            if (richTextBox1.Text != "")
            {
                toolStripStatusLabel1.Text = "Oneckup © - Sincronizzando...";
                string[] folderList = richTextBox1.Text.Split('\n');
                string subFolder; int slashIdx;
                char separator = '/';
                foreach (string folder in folderList)
                {
                    if (folder != "")
                    {
                        if (folder != destBox.Text)
                        {
                            slashIdx = folder.LastIndexOf('/');
                            separator = '/';
                            if (slashIdx == -1)
                            {
                                slashIdx = folder.LastIndexOf('\\');
                                separator = '\\';
                            }
                            if (IsUNCPath) separator = '\\';
                            if (slashIdx > -1)
                            {
                                subFolder = folder.Substring(slashIdx + 1);
                            }
                            else subFolder = folder;
                            toolStripStatusLabel1.Text = "Oneckup © - Sincronizzando \"" + subFolder + "\"...";
                            //MessageBox.Show(toolStripStatusLabel1.Text);
                            Directory.CreateDirectory(destBox.Text + separator + subFolder);
                            CopyDirectory(folder, destBox.Text + separator + subFolder);
                        }
                    }
                }
            }
            toolStripStatusLabel1.Text = notifyIcon1.Text = "Oneckup © - Ultima sincronizzazione avvenuta alle " + DateTime.Now.ToString("HH:mm:ss tt") + "...";
        }

        public void CopyDirectory(string source, string target)
        {
            var stack = new Stack<Folders>();
            stack.Push(new Folders(source, target));

            while (stack.Count > 0)
            {
                var folders = stack.Pop();
                try
                {
                    Directory.CreateDirectory(folders.Target);
                }
                catch (Exception)
                {
                }
                if (Directory.Exists(folders.Source))
                {
                    foreach (var file in Directory.GetFiles(folders.Source, "*.*"))
                    {
                        string targetFile = Path.Combine(folders.Target, Path.GetFileName(file));
                        if (File.Exists(targetFile))
                        {
                            //MessageBox.Show(Convert.ToString(source + "\n" + file + "\n\n" + target + "\n" + file + "\n\n" + targetFile + "\n\n" + File.GetLastWriteTime(source)) + "\n" + Convert.ToString(File.GetLastWriteTime(targetFile)));
                            if (File.GetLastWriteTime(source) > File.GetLastWriteTime(targetFile))
                            {
                                File.Delete(targetFile);
                                File.Copy(file, targetFile);
                            }
                            else if (Bidirectional.Checked && File.GetLastWriteTime(source) < File.GetLastWriteTime(targetFile))
                            {
                                File.Delete(file);
                                File.Copy(targetFile, file);
                            }
                        }
                        else
                        {
                            try
                            {
                                File.Copy(file, targetFile);
                            }
                            catch (Exception)
                            {
                            }
                        }
                    }

                    foreach (var folder in Directory.GetDirectories(folders.Source))
                    {
                        stack.Push(new Folders(folder, Path.Combine(folders.Target, Path.GetFileName(folder))));
                    }
                }
            }
        }

        private void timeBox_ValueChanged(object sender, EventArgs e)
        {
            if (timeBox.Value == 0)
            {
                timeBox.Value = 59;
            }
            else if (timeBox.Value == 60)
            {
                timeBox.Value = 1;
            }
            Properties.Settings.Default.TimeAmount = Convert.ToInt32(timeBox.Value);
            SyncTimer.Interval = (1000) * Convert.ToInt32(timeBox.Value) * Convert.ToInt32(Math.Pow(60, comboBox1.SelectedIndex));
            SyncTimer.Stop();
            if (TimerBox.Checked) SyncTimer.Start();
        }

        private void informazioniSuDckupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form parent = this;
            Form2 form = new Form2();
            form.Location = new Point(this.Left + (this.Width / 2 - form.Width / 2), this.Top + (this.Height / 2 - form.Height / 2));
            form.StartPosition = FormStartPosition.Manual;
            form.Show();
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            Application.Exit();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            Properties.Settings.Default.TimeAmount = Convert.ToInt32(timeBox.Value);
            Properties.Settings.Default.DayHour = Convert.ToInt32(numDayHour.Value);
            Properties.Settings.Default.DayMinute = Convert.ToInt32(numDayMinute.Value);
            toolStripStatusLabel1.Text = notifyIcon1.Text = "Oneckup © - Impostazioni personali salvate";
        }

        private void DayCheck_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.DayTimer = DayCheck.Checked;
            ProcessCheckChanged();
        }

        private void numDayHour_ValueChanged(object sender, EventArgs e)
        {
            if (numDayHour.Value == 24)            {
                if (numDayHour.Value < 23) numDayHour.Value++;
                else numDayHour.Value = 0;
            }
            else if (numDayHour.Value == -1)
            {
                if (numDayHour.Value > 0) numDayHour.Value--;
                else numDayHour.Value = 23;
            }
            Properties.Settings.Default.DayHour = Convert.ToInt32(numDayHour.Value);
            ProcessCheckChanged();
        }

        private void numDayMinute_ValueChanged(object sender, EventArgs e)
        {
            if (numDayMinute.Value == 60)
            {
                numDayMinute.Value = 0;
                if (numDayHour.Value < 23) numDayHour.Value++;
                else numDayHour.Value = 0;
            }
            else if (numDayMinute.Value == -1)
            {
                numDayMinute.Value = 59;
                if (numDayHour.Value > 0) numDayHour.Value--;
                else numDayHour.Value = 23;
            }
            Properties.Settings.Default.DayMinute = Convert.ToInt32(numDayMinute.Value);
            ProcessCheckChanged();
        }

        private void SyncDailyTimer(object sender, EventArgs e)
        {
            FixTimer();
            SyncFolders();
        }

        private void ProcessCheckChanged()
        {
            if (DayCheck.Checked)
            {
                FixTimer();
                numDayHour.Enabled = true;
                numDayMinute.Enabled = true;
            }
            else
            {
                DailyTimer.Stop();
                numDayHour.Enabled = false;
                numDayMinute.Enabled = false;
            }
        }

        private void FixTimer()
        {
            int delay = Convert.ToInt32(1000 * (numDayHour.Value * 3600 + numDayMinute.Value * 60)) -
                                    Convert.ToInt32(1000 * (DateTime.Now.Hour * 3600 + DateTime.Now.Minute * 60)
                                    );

            if (delay > 1000) DailyTimer.Interval = delay;
            else DailyTimer.Interval = 86400000 - delay;

            /*MessageBox.Show(
                Convert.ToString(DateTime.Now.Hour) + ":" + Convert.ToString(DateTime.Now.Minute) + ":" + Convert.ToString(DateTime.Now.Second) + "\n" +
                Convert.ToString(DailyTimer.Interval) + " millisecondi, " +
                Convert.ToString(DailyTimer.Interval/1000) + " secondi, " +
                Convert.ToString(DailyTimer.Interval/1000/60) + " minuti, " +
                Convert.ToString(DailyTimer.Interval/1000/60/60) + " ore"
            );*/
        }

        private void destBox_MouseDoubleClick(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dlg = new FolderBrowserDialog())
            {
                dlg.Description = "Selezionare la cartella di destinazione dei backup";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    destBox.Text = dlg.SelectedPath;
                    destBox.SelectionLength = 0;
                    destBox.SelectionStart = destBox.Text.Length;
                    Properties.Settings.Default.Destination = destBox.Text;
                }
            }
        }

        private void searchDest_Click(object sender, EventArgs e)
        {
            destBox_MouseDoubleClick(null, null);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dlg = new FolderBrowserDialog())
            {
                dlg.Description = "Selezionare una cartella di cui effettuare il backup";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    richTextBox1.Text += dlg.SelectedPath + "\n";
                }
            }
        }

        private void remButton_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dlg = new FolderBrowserDialog())
            {
                dlg.Description = "Selezionare la cartella da rimuovere dall'elenco dei backup";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    int index = richTextBox1.Text.IndexOf(dlg.SelectedPath + "\n");
                    if (index >= 0)
                    {
                        richTextBox1.Text = (richTextBox1.Text.Remove(index, dlg.SelectedPath.Length));
                        richTextBox1.Text = richTextBox1.Text.Replace("\n", ","); ;
                        richTextBox1.Text = richTextBox1.Text.Replace(",,", ""); ;
                        richTextBox1.Text = richTextBox1.Text.Replace(",", Environment.NewLine);
                        richTextBox1.Text += Environment.NewLine;
                    }
                }
            }
        }

        private void toolExit_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            Application.Exit();
        }

        private void toolOpen_Click(object sender, EventArgs e)
        {
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void toolSync_Click(object sender, EventArgs e)
        {
            SyncFolders();
        }

        private void Bidirectional_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.Bidir = Bidirectional.Checked;
            if(Bidirectional.Checked)
            {
                toolSync.Text = SyncButton.Text = "Sync";
            }
            else
            {
                toolSync.Text = SyncButton.Text = "Backup";
            }
        }

        private void RegisterInStartup(bool isChecked)
        {
            RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (isChecked)
            {
                registryKey.SetValue("ApplicationName", Application.ExecutablePath);
            }
            else
            {
                registryKey.DeleteValue("ApplicationName");
            }
        }
    }

    public class Folders
    {
        public string Source { get; private set; }
        public string Target { get; private set; }

        public Folders(string source, string target)
        {
            Source = source;
            Target = target;
        }
    }
}
