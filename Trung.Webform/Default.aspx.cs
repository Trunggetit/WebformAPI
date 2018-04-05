using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Trung.Webform
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string apiEndPoint = @"https://jsonplaceholder.typicode.com/posts";

            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(apiEndPoint);
            request.Method = "GET";
            request.ContentType = "application/json; charset=utf-8";

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            StreamReader streamReader = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding(0));

            string result = streamReader.ReadToEnd();
            Response.Write(result);
        }
    }
}