using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
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

        protected void Button2_Click(object sender, EventArgs e)
        {
            ServiceReference1.getTenantData tenantData = new ServiceReference1.getTenantData();
            tenantData = client.GetInfo();

            DataTable dt = new DataTable();
            dt = tenantData.tenant1;
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            UpdateTenant up = new UpdateTenant();
            up.TenantId = int.Parse(TextBox4.Text);
            up.TenantName = TextBox1.Text;
            up.TenantRent = TextBox2.Text;
            up.TenantEmail = TextBox3.Text;

            string resultTenant = client.Update(up);
            Label5.Text = resultTenant.ToString();

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            DeleteTenant deletetenant = new DeleteTenant();
            deletetenant.TENANTID = int.Parse(TextBox4.Text);
            

            string result2Tenant = client.Delete(deletetenant);
            Label5.Text = result2Tenant.ToString();
        }
    }
}