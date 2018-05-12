using System;
using System.IO;
using System.Windows.Forms;

namespace YouTubeDL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /* The visibility of textBox_XFormat */
        private void XFormatBoxVisability()
        {
            if (radioButton_XFormat.Checked)
            {
                textBox_XFormat.Visible = true;
            }
            else
            {
                textBox_XFormat.Visible = false;
            }
        }

        /* good URL? */
        private Boolean ValidURL()
        {
            if (textBox_URL.Text.Length < 8)
            {
                MessageBox.Show("Please Enter valid URL!");
                return false;
            }
            else return true;
        }

        // Two kinds of height of the form
        int noInfoHeight = 150;
        int InfoHeight = 600;

        /* Initial with normal height*/
        private void Form1_Load(object sender, EventArgs e)
        {
            Height = noInfoHeight;
        }

        /* Get URL from Clipboard */
        private void textBox_URL_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox_URL.Text = Clipboard.GetText();
        }

        private void pictureBox_More_Click(object sender, EventArgs e)
        {
            if (Height < 600) Height = InfoHeight;
            else Height = noInfoHeight;
        }

        private void radioButton_Video_CheckedChanged(object sender, EventArgs e)
        {
            XFormatBoxVisability();
        }

        private void radioButton_Audio_CheckedChanged(object sender, EventArgs e)
        {
            XFormatBoxVisability();
        }

        private void radioButton_XFormat_CheckedChanged(object sender, EventArgs e)
        {
            XFormatBoxVisability();
        }

        /* Find Resolution */
        private void button_FindRes_Click(object sender, EventArgs e)
        {
            if (ValidURL())
            {
                button_Download.Enabled = false;
                button_FindRes.Enabled = false;
                pictureBox_Clear.Enabled = false;
                pictureBox_Loading.Visible = true;
                Height = InfoHeight;

                System.IO.File.WriteAllLines("Res.bat", new string[] {
                "youtube-dl.exe --no-playlist -F \""+textBox_URL.Text+"\">Res.part",
                "ren Res.part Res"
                });
                System.Diagnostics.Process p = new System.Diagnostics.Process();
                p.StartInfo.FileName = "Res.bat";
                p.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                p.Start();

                timer_Res.Start();
            }
        }
        private void timer_Res_Tick(object sender, EventArgs e)
        {
            timer_Res.Stop();
            if (File.Exists("Res"))
            {
                // pre-set
                textBox_Info.Text = "";

                // Read the file and display it line by line.
                int counter = 0;
                string line;
                StreamReader file =
                    new StreamReader(@"Res");
                while ((line = file.ReadLine()) != null)
                {
                    // add "Environment.NewLine" as "\n"
                    textBox_Info.Text += line + Environment.NewLine;
                    counter++;
                }
                file.Close();

                // final
                button_Download.Enabled = true;
                button_FindRes.Enabled = true;
                pictureBox_Clear.Enabled = true;
                pictureBox_Loading.Visible = false;
                File.Delete("Res.bat");
                File.Delete("Res");
            }
            else timer_Res.Start();
        }

        /* Download */
        private void button_Download_Click(object sender, EventArgs e)
        {
            if (ValidURL())
            {
                string dlOption;
                // List?
                if (checkBox_List.Checked) dlOption = "--yes-playlist -o \""
                        + Environment.GetEnvironmentVariable("USERPROFILE")
                        + "\\Videos\\%(playlist_index)s-%(title)s%(format)s.%(ext)s\" ";
                else dlOption = "--no-playlist -o \""
                        + Environment.GetEnvironmentVariable("USERPROFILE")
                        + "\\Videos\\%(title)s%(format)s.%(ext)s\" ";
                // Option?
                if (radioButton_Video.Checked)
                {
                    dlOption += "-f \"bestvideo[ext=mp4]+bestaudio[ext=m4a]/best[ext=mp4]/best\" -i \"";
                }
                else if (radioButton_Audio.Checked)
                {
                    dlOption += "-f bestaudio -x --audio-format mp3 --audio-quality 320k -i \"";
                }
                else if (radioButton_XFormat.Checked)
                {
                    dlOption += "-f \"" + textBox_XFormat.Text + "\" -i \"";
                }
                System.Diagnostics.Process p = new System.Diagnostics.Process();
                p.StartInfo.FileName = "youtube-dl.exe";
                p.StartInfo.Arguments = dlOption += textBox_URL.Text + "\"";
                //MessageBox.Show(dlOption);
                p.Start();
            }
        }

        /* Clear */
        private void pictureBox_Clear_Click(object sender, EventArgs e)
        {
            Height = noInfoHeight;
            textBox_URL.Clear();
            textBox_Info.Clear();
        }

        /* Update */
        private void pictureBox_Logo_DoubleClick(object sender, EventArgs e)
        {
            button_Download.Enabled = false;
            button_FindRes.Enabled = false;
            pictureBox_Clear.Enabled = false;
            pictureBox_Loading.Visible = true;
            Height = InfoHeight;

            System.IO.File.WriteAllLines("ytdl.bat", new string[] {
                "youtube-dl.exe -U >ytdl"
            });
            System.Diagnostics.Process p = new System.Diagnostics.Process();
            p.StartInfo.FileName = "ytdl.bat";
            p.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            p.Start();

            timer_Update.Start();
        }
        private void timer_Update_Tick(object sender, EventArgs e)
        {
            timer_Update.Stop();
            try
            {
                // pre-set
                textBox_Info.Text = "";

                // Read the file and display it line by line.
                int counter = 0;
                string line;
                StreamReader file =
                    new StreamReader(@"ytdl");
                while ((line = file.ReadLine()) != null)
                {
                    // add "Environment.NewLine" as "\n"
                    textBox_Info.Text += line + Environment.NewLine;
                    counter++;
                }
                file.Close();

                // final
                button_Download.Enabled = true;
                button_FindRes.Enabled = true;
                pictureBox_Clear.Enabled = true;
                pictureBox_Loading.Visible = false;
                File.Delete("ytdl.bat");
                File.Delete("ytdl");
            }
            catch { timer_Update.Start(); }
        }
    }
}
