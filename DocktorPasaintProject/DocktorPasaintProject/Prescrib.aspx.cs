using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DocktorPasaintProject;

namespace DocktorPasaint
{
    public partial class Prescrib : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSubmitt_Click(object sender, EventArgs e)
        {
            string x = txtMedicinName.Text;
            //string y = txtMadisinD.Text;
            //string submitt = Convert.ToString(x) + Convert.ToString(y);
            //lbl1.Text = "Madicin name is:" + x + submitt.ToString();


            //Session["Prescrib"] = submitt;
            //Response.Redirect("Medicin.aspx");

            int submitt = SaveIntoTable(x);
            if (submitt > 0)
                lbl1.Text = "successful";
            else
            {
                lbl1.Text = "Unsuccessful";
            }

        }

        private int SaveIntoTable(string x)
        {
            Class_Connection classConnection = new Class_Connection();
            SqlConnection connection = classConnection.GetConnection();
            string sqlQuery = @"Insert Into MedicinName (MedicinName) Values('" + x + "')";
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