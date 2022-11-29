using System;
using System.Collections.Generic;
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
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-5H6RLHG;Initial Catalog=tenant;Persist Security Info=True;User ID=sa;Password=***********");
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


        
    }
}
