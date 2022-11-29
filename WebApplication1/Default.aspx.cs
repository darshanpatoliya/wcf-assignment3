using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication1.ServiceReference1;

namespace WebApplication1
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
        protected void Button1_Click(object sender, EventArgs e)
        {
            InsertTenant T = new InsertTenant();
            T.Name = TextBox1.Text;
            T.Rent = TextBox2.Text;
            T.Email = TextBox3.Text;

            string insertT = client.Insert(T);

            Label5.Text = insertT.ToString();

        }
    }
}