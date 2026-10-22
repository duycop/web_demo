using System;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace web_demo
{
    public partial class api : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            string action = this.Request["action"];
            if (action == "sensor")
            {
                get_sensor();
            }
        }

        void get_sensor()
        {
            string path = this.Server.MapPath("/data.txt");
            string json = System.IO.File.ReadAllText(path);
            Response.ContentType = "application/json";
            Response.Write(json);
        }
    }
}