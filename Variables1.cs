using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.IO;
using System.Collections;

namespace MIS_SCREENS
{
    class Variables
    {
        public static bool fstatus { get; set; }
        public string test { get; set; }
        public static string name { get; set; }
        public static int flg { get; set; }
        public static ArrayList a { get; set; }
        public static DataSet ds { get; set; }        
        public static DataTable dt { get; set; }
        public static DataTable dt1 { get; set; }
        public static byte[] b = new byte[0];
        public static bool bl { get; set; }
        public static int rptid { get; set; }
        public static int invid { get; set; }
        public static string rptparam { get; set; }
        public static string rpttype { get; set; }
        public static string urole { get; set; }
        public static AutoCompleteStringCollection cs = new AutoCompleteStringCollection();
       
    }
}
