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
    public partial class PasaintFullList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
                LoadDataGrideview();
        }

        private void LoadDataGrideview()
        {
            DataTable dt = GetDataFromTable();
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        private DataTable GetDataFromTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("Name");
            dt.Columns.Add("Gender");
            dt.Columns.Add("Address");
            dt.Columns.Add("Phnnmbr");
            dt.Columns.Add("Serial");
            Class_Connection classConnection=new Class_Connection();
            string sqlQuery = @"select * from PasaintDetails";
            try
            {
                SqlCommand command = new SqlCommand(sqlQuery, classConnection.GetConnection());
                using (SqlDataReader dr =command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        DataRow dataRow = dt.NewRow();
                        dataRow["Id"] = Convert.ToString(dr["id"]);
                        dataRow["Name"] = Convert.ToString(dr["PasaintName"]);
                        dataRow["Gender"] = Convert.ToString(dr["PasaintGender"]);
                        dataRow["Address"] = Convert.ToString(dr["PasaintAddress"]);
                        dataRow["Phnnmbr"] = Convert.ToString(dr["PasaintPhoneNumber"]);
                        dataRow["Serial"] = Convert.ToString(dr["PasaintSerial"]);
                        dt.Rows.Add(dataRow);
                    }
                }
            }
            catch (Exception)
            {


            }

            return dt;


        }
    }
}