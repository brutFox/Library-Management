using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace library_management
{
    public class Book_Tab_Model
    {
        public string BName { get; set; }
        public string Authors { get; set; }
        public int CID { get; set; }
        public int PID { get; set; }
        public int Total_Copies { get; set; }
        public string Info { get; set; }
        public int available = 0;
    }
}