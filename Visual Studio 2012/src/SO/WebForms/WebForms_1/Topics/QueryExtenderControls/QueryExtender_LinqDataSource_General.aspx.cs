using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.Expressions;
using WebForms_1.DataAccess;

namespace WebForms_1.Topics.QueryExtenderControls
{
    public partial class QueryExtender_LinqDataSource_General : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void resetJobIdFilter_Click(object sender, EventArgs e)
        {
            this.minJobIDFilter.Text = string.Empty;
            this.maxJobIDFilter.Text = string.Empty;
            this.availableJobIds.SelectedIndex = 0;
        }

        protected void resetJobDescriptionFilter_Click(object sender, EventArgs e)
        {
            this.jobDescriptionFilter.Text = string.Empty;
        }

        protected void minLevelShowEvenValuesOnly_Querying(object sender, CustomExpressionEventArgs e)
        {
            var query = from j in e.Query.OfType<jobs>()
                        select j;

            if (Convert.ToBoolean(e.Values["applyFilter"]))
            {
                query = query.Where(x => (x.min_lvl % 2) == 0);
            }

            e.Query = query;
        }

        protected void resetMinLevelFilter_Click(object sender, EventArgs e)
        {
            this.showOnlyEvenValuesForMinValue.Checked = false;
        }

        protected void resetMaxLevelFilter_Click(object sender, EventArgs e)
        {
            this.showOnlyOddValuesForMinValue.Checked = false;
        }

        public static IQueryable<jobs> ApplyFilterByMethod(IQueryable<jobs> query, bool applyFilterToMaxLevel)
        {
            if (applyFilterToMaxLevel)
            {
                query = from j in query
                        where (j.max_lvl % 2) != 0
                        select j;
            }

            return query;
        }
    }
}