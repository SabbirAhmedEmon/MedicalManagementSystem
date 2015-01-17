using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CrystalDecisions.CrystalReports.Engine;

namespace DocktorPasaintProject
{
    public partial class ReportUI : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnReport_Click(object sender, EventArgs e)
        {
            DataTable dt = GetDataFromDataTable();
            if (dt.Rows.Count > 0)
            {
                ReportDocument oReportDocument = new ReportDocument();

                oReportDocument.Load(Server.MapPath("\\CrystalReport1.rpt"));
                oReportDocument.SetDataSource(dt);

                ReportSubmitted.Rpt = oReportDocument;
                //Response.Write("<script>window.open('../ReportViewer.aspx','_blank');</script>");
                Response.Redirect("ReportViewer.aspx");
            }
        }

        private DataTable GetDataFromDataTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("ID");
            dt.Columns.Add("Name");
            //dt.Columns.Add("Roll");
            //dt.Columns.Add("Grade");
            Class_Connection conn = new Class_Connection();
            string sqlQuery = @"select * from MedicinNAme";
            SqlCommand cmd = new SqlCommand(sqlQuery,conn.GetConnection());
            using (SqlDataReader dr = cmd.ExecuteReader())
            {
                while (dr.Read())
                {
                    DataRow datarow = dt.NewRow();
                    datarow["ID"] = Convert.ToString(dr["id"]);
                    datarow["Name"] = Convert.ToString(dr["MedicinName"]);
                    //datarow["Roll"] = Convert.ToString(dr["Roll"]);
                    //datarow["Grade"] = Convert.ToString(dr["Grade"]);
                    dt.Rows.Add(datarow);
                }
                return dt;
            }

        }
    }
}