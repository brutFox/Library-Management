using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace library_management
{
    public class Borrow_Model
    {
        public string UID { get; set; }
        public int BID { get; set; }
        public DateTime Issued { get; set; }
        public DateTime Returned { get; set; }
        public string IsReturned { get; set; }
        public float Fine { get; set; }

        public int BrID { get; set; }
        public string user_id { get; set; }
    }

 
}