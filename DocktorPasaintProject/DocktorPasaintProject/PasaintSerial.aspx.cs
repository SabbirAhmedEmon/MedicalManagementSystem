using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DocktorPasaintProject
{
    public partial class PasaintSerial : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            string id = txtPasaintSerial.Text;
            DataTable dt = GetDataFromTable(id);
            lblPasaintName.Text = Convert.ToString(dt.Rows[0]["name"]);
            lblPasaintGender.Text = Convert.ToString(dt.Rows[0]["gender"]);
            lblPasaintAddress.Text = Convert.ToString(dt.Rows[0]["address"]);
            lblpasaintPhoneNumber.Text = Convert.ToString(dt.Rows[0]["phnnmbr"]);
            lblPasaintSerialNumber.Text = Convert.ToString(dt.Rows[0]["serial"]);
            

        }

        private DataTable GetDataFromTable(string id)
        {
            DataTable dt =new DataTable();
            dt.Columns.Add("name");
            dt.Columns.Add("gender");
            dt.Columns.Add("address");
            dt.Columns.Add("phnnmbr");
            dt.Columns.Add("serial");

            Class_Connection classConnection=new Class_Connection();
            string sqlQuery = @"select * from PasaintDetails where id='" + id + "'";
            SqlCommand command = new SqlCommand(sqlQuery, classConnection.GetConnection());

            try
            {
                using (SqlDataReader dr=command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        DataRow dataRow = dt.NewRow();
                        dataRow["name"] = Convert.ToString(dr["PasaintName"]);
                        dataRow["gender"] = Convert.ToString(dr["PasaintGender"]);
                        dataRow["address"] = Convert.ToString(dr["PasaintAddress"]);
                        dataRow["phnnmbr"] = Convert.ToString(dr["PasaintPhoneNumber"]);
                        dataRow["serial"] = Convert.ToString(dr["PasaintSerial"]);
                        dt.Rows.Add(dataRow);

                    }
                }
            }
            catch (Exception)
            {

                dt = null;
            }
            finally
            {
                classConnection.Close();
            }
            return dt;
        }
    }
}