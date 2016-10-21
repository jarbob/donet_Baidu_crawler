using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Collecting.Controller
{
    class Uri
    {
        public static string GetLocation(string u)
        {
            HttpWebRequest myHttpWebRequest = (HttpWebRequest)HttpWebRequest.Create(u);
            myHttpWebRequest.AllowAutoRedirect = false;
            HttpWebResponse myHttpWebResponse = (HttpWebResponse)myHttpWebRequest.GetResponse();
            StreamReader streamReader = new StreamReader(myHttpWebResponse.GetResponseStream());
            string responseContent = streamReader.ReadToEnd();
            responseContent = Between(responseContent, ";URL='", "'");
            //Console.WriteLine(responseContent);
            if (responseContent == "")
                return u;
            return responseContent;
        }

        /// <summary>
        /// 取文本中间内容
        /// </summary>
        /// <param name="str">原文本</param>
        /// <param name="leftstr">左边文本</param>
        /// <param name="rightstr">右边文本</param>
        /// <returns>返回中间文本内容</returns>
        public static string Between(string str, string leftstr, string rightstr)
        {

            int i = str.IndexOf(leftstr) + leftstr.Length;
            string temp = str.Substring(i, str.IndexOf(rightstr, i) - i);
            if (temp == "")
            {
                return str;
            }
            return temp;
        }

    }
}
