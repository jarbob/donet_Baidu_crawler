using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Collecting.Controller
{
    class Keywords
    {
        private StreamReader _rstream = null;
        public int ReadTxtToLst(System.Windows.Forms.ListBox lst, string spath) //listbox 读取txt文件
        {
            _rstream = new StreamReader(spath, System.Text.Encoding.Default);
            string line;
            int total = 0;
            while ((line = _rstream.ReadLine()) != null)
            {
                lst.Items.Add(line);
                ++total;
            }
            _rstream.Close();
            return total;
        }

    }
}
