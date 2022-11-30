using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public string Insert(InsertTenant tenant)
        {
            string message;
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=tenant;Integrated Security=True");
            con.Open();     
            SqlCommand cmd = new SqlCommand("Insert into tenant (Name, Rent, Email) values(@Name, @Rent, @Email)", con);
            cmd.Parameters.AddWithValue("@Name", tenant.Name);
            cmd.Parameters.AddWithValue("@Rent", tenant.Rent);
            cmd.Parameters.AddWithValue("@Email", tenant.Email);

            int tent = cmd.ExecuteNonQuery();
            if(tent == 1)
            {
                message = "Successfully Inserted";
            }
            else
            {
                message = "Failed to Insert";
            }

            return message;
        }

        public getTenantData GetInfo()
        {
            getTenantData test = new getTenantData();
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=tenant;Integrated Security=True");
            con.Open();
            SqlCommand conNewSql = new SqlCommand("Select * from tenant", con);

            SqlDataAdapter dataAdapter = new SqlDataAdapter(conNewSql);
            DataTable dt = new DataTable("tenant");
            dataAdapter.Fill(dt);
            test.tenant1 = dt;
            return test;
        }

        public string Update(UpdateTenant t)
        {
            string message1="";
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=tenant;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update tenant set Name=@Name, Rent=@Rent, Email=@Email where tenantID=@tenantID", con);
            cmd.Parameters.AddWithValue("@tenantID", t.TenantId);
            cmd.Parameters.AddWithValue("@Name", t.TenantName);
            cmd.Parameters.AddWithValue("@Rent", t.TenantRent);
            cmd.Parameters.AddWithValue("@Email", t.TenantEmail);

            int resultTenant = cmd.ExecuteNonQuery();

            if (resultTenant == 1)
            {
                message1 = "Successfully Updated";
            }
            else
            {
                message1 = "Failed to Update";
            }
            return message1;
        }

        public string Delete(DeleteTenant deletetenant)
        {
            string message2 = "";
            SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=tenant;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("delete tenant where tenantID=@tenantID", con);
            cmd.Parameters.AddWithValue("@tenantID", deletetenant.TENANTID);
            int result2Tenant = cmd.ExecuteNonQuery();
            if (result2Tenant == 1)
            {
                message2 = "Successfully Deleted";
            }
            else
            {
                message2 = "Failed to delete";
            }
            return message2;

        }
    }
}
