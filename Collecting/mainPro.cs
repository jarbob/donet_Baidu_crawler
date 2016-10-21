using System;
using System.Windows.Forms;
using Collecting.Controller;
using System.Collections;
using System.Threading;
using Collecting.Data;
using System.IO;


namespace Collecting
{
    public partial class MainForm : Form
    {
        private int total = 0;
        private bool isStop = false;
        private Queue urlQueue;
        private bool isClicked = false;
        


        public MainForm()
        {
            InitializeComponent();
            //this.startBtn.Enabled = true;
        }


        private void insertBtn_Click(object sender, EventArgs e)
        {
            DialogResult res = this.openFileDialog.ShowDialog();
            if (res == DialogResult.OK)
            {
                //this.openFileDialog.FileName
                Keywords kws = new Keywords();
                total = kws.ReadTxtToLst(this.keywordsListBox, this.openFileDialog.FileName);
                this.Log("共导入" + total.ToString() + "个关键字");
                this.startBtn.Enabled = true;

            }

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.openFileDialog.InitialDirectory = System.Environment.CurrentDirectory;
            this.openComboBox.SelectedIndex = 2;

            //this.urlListView.Columns.Add("标题", 120, HorizontalAlignment.Center); 

        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            outputBtn.Enabled = true;
            stopBtn.Enabled = true;
            insertBtn.Enabled = false;
            startBtn.Enabled = false;
            Control.CheckForIllegalCrossThreadCalls = false;
            Thread s = new Thread(new ThreadStart(CreateThreadPool));
            s.IsBackground = true;
            s.Start();
            


        }

        private void CreateThreadPool()
        {

            for (int i = 0; i < keywordsListBox.Items.Count; i++)
            {
                int num = Convert.ToInt32(this.pageTextBox.Text);
                string s = keywordsListBox.Items[i].ToString();
                for (int n = 1; n <= num; n++)
                {
                    if (!this.isStop)
                    {
                        ThreadParams tp = new ThreadParams(s, num);

                        ThreadPool.QueueUserWorkItem(new WaitCallback(ThreadInvoke), tp);

                        this.Log("正在采集第" + (i + 1).ToString() + "个关键字第" + n.ToString() + "页");

                        //将当前线程挂起200毫秒

                        Thread.Sleep(Convert.ToInt32(this.timeOutTextBox.Text));
                    }
                }
                Thread.Sleep(100);
                if (this.total == i + 1)
                    this.Log("采集完成");
            }

        }

        void ThreadInvoke(Object tps)
        {
            ThreadParams tp = tps as ThreadParams;
            Hashtable tb = Spider.MainProc(tp.keyword, tp.page);
            //this.urlListView.BeginUpdate();
            foreach (System.Collections.DictionaryEntry objDE in tb)
            {
                //Console.WriteLine(objDE.Key.ToString());
                //Console.WriteLine(objDE.Value.ToString());
               
                ListViewItem lvi = new ListViewItem();
                
                lvi.Text = objDE.Key.ToString();
                lvi.SubItems.Add(objDE.Value.ToString());
                this.urlListView.Items.Add(lvi);

            }
            //this.urlListView.EndUpdate();
        }
        private void Log(string detail)
        {
            this.logBox.AppendText(DateTime.Now.ToString("HH:mm:ss ") + detail + "\r\n");
        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            this.isStop = true;
            this.Log("停止采集");
            startBtn.Enabled = true;
            stopBtn.Enabled = false;
        }

        private void outputBtn_Click(object sender, EventArgs e)
        {
            this.Log("开始导出，请耐心等待");
            System.Windows.Forms.SaveFileDialog objSave = new System.Windows.Forms.SaveFileDialog();
            objSave.Filter = "(*.txt)|*.txt|" + "(*.*)|*.*";

            objSave.FileName = "网址" + DateTime.Now.ToString("yyyyMMddHHmm") + ".txt";

            if (objSave.ShowDialog() == DialogResult.OK)
            {
                StreamWriter FileWriter = new StreamWriter(objSave.FileName, true); //写文件

                foreach (ListViewItem item in this.urlListView.Items)
                {
                    FileWriter.WriteLine(item.SubItems[1].Text);//将字符串写入
                }
                MessageBox.Show("导出完成");
                this.Log("导出成功");

                FileWriter.Close(); //关闭StreamWriter对象
            }

            
        }

        private void openBtn_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(this.openComboBox.SelectedItem.ToString());
            if (!isClicked)
            {
                
                this.urlQueue = new Queue();
                foreach (ListViewItem item in this.urlListView.Items)
                {
                    this.urlQueue.Enqueue(item.SubItems[1].Text);
                }
                isClicked = true;
                this.Log("共" + this.urlQueue.Count + "个链接");
            }
            
            if (n > this.urlQueue.Count)
            {
                n = this.urlQueue.Count;
            }
                 
            while (--n >= 0)
            {
                //浏览器打开
                System.Diagnostics.Process.Start(this.urlQueue.Dequeue().ToString());  
                
            }
            this.Log("还剩" + this.urlQueue.Count + "个链接");
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill(); 
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            DeleteDuplicate(this.urlListView);
        }

        public void DeleteDuplicate(ListView lv)
        {
            for (int i = 0; i < lv.Items.Count; i++)
            {
                for (int j = i + 1; j < lv.Items.Count; j++)
                {
                    if (lv.Items[i].SubItems[1].Text == lv.Items[j].SubItems[1].Text)
                    {
                        lv.Items[j].Remove();
                        j--;//执行删除操作后j--,中和掉j++，让j的索引保持在原位，进行下一次比较，以免删除不干净
                    }
                }
            }
            MessageBox.Show("去重完成！");

        }

    }
}
