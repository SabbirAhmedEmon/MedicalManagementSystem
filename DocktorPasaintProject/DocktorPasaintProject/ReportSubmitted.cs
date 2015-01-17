using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CrystalDecisions.CrystalReports.Engine;

namespace DocktorPasaintProject
{
    public class ReportSubmitted
    {
        static ReportDocument rpt;

        public static ReportDocument Rpt
        {
            get { return ReportSubmitted.rpt; }
            set { ReportSubmitted.rpt = value; }
        }
    }
}