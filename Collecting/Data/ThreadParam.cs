using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collecting.Data
{
    class ThreadParams
    {
        public string keyword;
        public int page;
        public ThreadParams(string k,int p)
        {
            this.keyword = k;
            this.page = p;

        }
    }
}
