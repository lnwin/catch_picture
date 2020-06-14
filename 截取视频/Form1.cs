using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace 截取视频
{
    public partial class 视频逐帧截图 : Form
    {
        public 视频逐帧截图()
        {
            InitializeComponent();
        }
        public void GetImage(string vedioPath, int start, int end, double frame, string saveImgSize)
        {
            int k = 0;
            string catchTime = "";
            string ffmpeg = string.Format("{0}ffmpeg.exe", AppDomain.CurrentDomain.BaseDirectory);


            for (double i = start; i < end; i += frame)
            {
                try
                {
                    //开始截图
                    catchTime = i.ToString();
                    string saveImgPath = System.IO.Path.ChangeExtension(vedioPath, "(" + k++.ToString() + ").jpg");
                    ProcessStartInfo startInfo = new ProcessStartInfo(ffmpeg);
                    startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                    //ffmpeg指令
                    startInfo.Arguments = string.Format(" -i \"{0}\" -y -f image2 -ss {1} -s \"{2}\" \"{3}\"", vedioPath, catchTime, saveImgSize, saveImgPath);                 
                    System.Diagnostics.Process.Start(startInfo).Close();
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                    return;
                }
            }
            
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                this.txtPath.Text = dlg.SelectedPath;
                var files = System.IO.Directory.GetFiles(dlg.SelectedPath);
                int end = Convert.ToInt32(txtEnd.Text);
                int start = Convert.ToInt32(txtStart.Text);
                double frame = 1 / Convert.ToDouble(txtFrame.Text);
                string size = txtWidth.Text + "x" + txtHigh.Text;
                foreach (var f in files)
                {
                    try
                    {
                        GetImage(f, start, end, frame, size);
                    }
                    catch { }
                }
                MessageBox.Show("后台正在截图，请等待");
            }
        }

        private void txtStart_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtStart.Text == "输入第几秒")
            {
                txtStart.Text = "";
                txtStart.ForeColor = Color.Black;
            }
            if (txtEnd.Text == "")
            {
                txtEnd.Text = "输入第几秒";
                txtEnd.ForeColor = Color.Gray;
            }
            if (txtFrame.Text == "")
            {
                txtFrame.Text = "输入帧数";
                txtFrame.ForeColor = Color.Gray;
            }

        }

        private void txtEnd_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtEnd.Text == "输入第几秒")
            {
                txtEnd.Text = "";
                txtEnd.ForeColor = Color.Black;
            }
            if (txtStart.Text == "")
            {
                txtStart.Text = "输入第几秒";
                txtStart.ForeColor = Color.Gray;
            }
            if (txtFrame.Text == "")
            {
                txtFrame.Text = "输入帧数";
                txtFrame.ForeColor = Color.Gray;
            }
        }

        private void txtFrame_MouseClick(object sender, MouseEventArgs e)
        {
            if (txtFrame.Text == "输入帧数")
            {
                txtFrame.Text = "";
                txtFrame.ForeColor = Color.Black;
            }
            if (txtEnd.Text == "")
            {
                txtEnd.Text = "输入第几秒";
                txtEnd.ForeColor = Color.Gray;
            }
            if (txtStart.Text == "")
            {
                txtStart.Text = "输入第几秒";
                txtStart.ForeColor = Color.Gray;
            }
        }
    }
}
