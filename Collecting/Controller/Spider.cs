using HtmlAgilityPack;
using System;
using System.Collections;
using System.Text;

namespace Collecting.Controller
{
    class Spider
    {
        public static string UrlEncode(string str)
        {
            StringBuilder sb = new StringBuilder();
            byte[] byStr = System.Text.Encoding.UTF8.GetBytes(str); //默认是System.Text.Encoding.Default.GetBytes(str)
            for (int i = 0; i < byStr.Length; i++)
            {
                sb.Append(@"%" + Convert.ToString(byStr[i], 16));
            }

            return (sb.ToString());
        }
        public static Hashtable MainProc(string keyword, int page)
        {
            //string s = Spider.GetResponseHtml("http://www.baidu.com");
            HtmlWeb hw = new HtmlWeb();
            string url = @"https://www.baidu.com/s?wd={0}&pn={1}&tn=baiduhome_pg&ie=utf-8&usm=4&rsv_idx=2&rsv_pq=d0ae91a100016dc4&rsv_t=cf77fDsHQo3QeQI2%2B2s4Eh3ammVV0GnDRj%2BsSQ4zgyqk4MBS6nPqzAoCKYx6bHFcFZ5V";
            url = string.Format(url, UrlEncode(keyword), (page - 1) * 10);//20代表第3页
            HtmlDocument doc = hw.Load(url);

            DocumentWithLinks bd = new DocumentWithLinks(doc);

            //TODO：完成哈希表的读取
            return bd.LinksTable;
        }
    }


    public class DocumentWithLinks
    {
        private Hashtable _linksTable;

        public Hashtable LinksTable
        {
            get { return _linksTable; }
            set { _linksTable = value; }
        }
        private string _title;
        private string _href;




        private HtmlDocument _doc;
        private HtmlDocument _tmpDoc;


        public DocumentWithLinks(HtmlDocument doc)
        {
            this._title = this._href = "";
            _tmpDoc = new HtmlDocument();
            _linksTable = new Hashtable();
            if (doc == null)
            {
                throw new ArgumentNullException("doc");
            }
            _doc = doc;
            GetLinksAndTitles();

        }

        private void GetLinksAndTitles()
        {

            HtmlNodeCollection atts = _doc.DocumentNode.SelectNodes("//h3[@class='t']/a");
            if (atts == null)
                return;
            int i = 0;

            foreach (HtmlNode node in atts)
            {
                this._title = node.InnerText;
                this._href = GetHrefLink(node.OuterHtml);
                this._href = Uri.GetLocation(this._href);
                this._linksTable.Add(this._title + (i++).ToString(), this._href);
            }
        }

        private string GetHrefLink(string name)
        {

            HtmlDocument doc = this._tmpDoc;
            doc.LoadHtml(name);
            HtmlNode hrefNode = doc.DocumentNode.SelectSingleNode(".//a[@href]");

            if (hrefNode != null)
            {
                return hrefNode.Attributes["href"].Value;

            }
            return "";
        }
    }
}
