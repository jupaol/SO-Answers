using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.Caching;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForms_1.Topics.Caching
{
    public partial class Caching_SettingAnAbsoluteAndSlidingExpirationPolicy : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var @object = this.GetObject("o");

            this.lbl.Text = @object.ToString();
        }

        private DateTime GetObject(string key)
        {
            var objectFromCache = (DateTime?)this.Cache["o"];

            if (!objectFromCache.HasValue)
            {
                var newObject = this.GetExpensiveObject();

                this.SaveObjectInCache(15, 5, key, newObject);

                objectFromCache = newObject;
            }

            return objectFromCache.Value;
        }

        private void SaveObjectInCache(int absoluteExpiration, int slidingExpiration, string key, DateTime @object)
        {
            // setting the absolute expiration
            this.Cache.Insert("trigger", DateTime.Now, null, DateTime.Now.AddSeconds(absoluteExpiration), System.Web.Caching.Cache.NoSlidingExpiration);

            var cd = new CacheDependency(null, new[] { "trigger" });

            this.Cache.Insert(key, @object, cd, System.Web.Caching.Cache.NoAbsoluteExpiration, TimeSpan.FromSeconds(slidingExpiration));
        }

        private DateTime GetExpensiveObject()
        {
            // simulating this object takes too long to be created
            Thread.Sleep(2500);
            return DateTime.Now;
        }
    }
}