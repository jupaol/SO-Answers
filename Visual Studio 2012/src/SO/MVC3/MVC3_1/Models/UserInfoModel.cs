using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVC3_1.Models
{
    public class UserInfoModel
    {
        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IEnumerable<CategoryModel> Categories { get; set; }
        public string SelectedCategory { get; set; }
    }
}