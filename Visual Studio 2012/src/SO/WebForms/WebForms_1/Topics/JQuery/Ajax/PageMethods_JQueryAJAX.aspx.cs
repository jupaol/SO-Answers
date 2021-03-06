﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebForms_1.DataAccess;
using WebForms_1.ViewModel;

namespace WebForms_1.Topics.JQuery
{
    public partial class PageMethods_JQueryAJAX : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        [WebMethod]
        public static List<JobModel> GetJobs()
        {
            var ctx = new PubsDataContext();

            return (from j in ctx.jobs
                    orderby j.job_desc
                    select new JobModel
                    {
                        JobID = j.job_id,
                        Description = j.job_desc
                    }).ToList();
        }

        [WebMethod]
        public static List<EmployeeModel> GetEmployees(int jobID)
        {
            var ctx = new PubsDataContext();

            return (from e in ctx.employee
                    where e.job_id == jobID
                    orderby e.fname
                    select new EmployeeModel
                    {
                        EmployeeID = e.emp_id,
                        FirstName = e.fname
                    }).ToList();
        }
    }
}