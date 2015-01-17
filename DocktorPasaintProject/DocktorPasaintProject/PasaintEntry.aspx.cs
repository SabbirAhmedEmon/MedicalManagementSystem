using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DocktorPasaintProject
{
    public partial class PasaintEntry : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmitt_Click(object sender, EventArgs e)
        {
            string name = txtPName.Text;
            string gender = txtPGender.Text;
            string address = txtPAddress.Text;
            string phnnmbr = txtPPhnNmbr.Text;
            string serial = txtPSerial.Text;

            int save = SaveIntoTable(name, gender, address, phnnmbr, serial);

            if (save > 0)
                lblSucesMsg.Text = "successful";
            else
            {
                lblSucesMsg.Text = "Unsuccessful";
            }

        }

        private int SaveIntoTable(string name, string gender, string address, string phnnmbr, string serial)
        {
         
            Class_Connection classConnection=new Class_Connection();
            SqlConnection connection = classConnection.GetConnection();
            //string sqlQuery = @"insert into PasaintDetails (PasaintName,PasaintGender,PasaintAddress,PasaintPhoneNumber,PasaintSerial) values('" + name + "','" + gender + "','" + address + "','" + phnnmbr + "','" + serial + "',)";
            string sqlQuery = @"Insert Into PasaintDetails (PasaintName,PasaintGender,PasaintAddress,PasaintPhoneNumber,PasaintSerial) Values('" + name + "','" + gender + "','" + address + "','" + phnnmbr + "','" + serial + "')";
            try
            {
                SqlCommand cmd = new SqlCommand(sqlQuery, connection);
                cmd.ExecuteNonQuery();
                return 1;
            }
            catch (Exception)
            {

                return 0;
            }
            finally
            {
                classConnection.Close();
            }

        }
    }
}