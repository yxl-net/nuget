using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yxl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DataTable dt = new DataTable();
            dt.Columns.Add("title");
            dt.Columns.Add("version");
            dt.Columns.Add("authors");
            dt.Columns.Add("license");
            dt.Columns.Add("projectUrl");
            dt.Columns.Add("description");
            dt.Columns.Add("tags");
            dt.Columns.Add("dir");
            dt.Columns.Add("key");

            dt.Rows.Add("Yxl.ORM","0.0.3", "yxl-net(996986842@qq.com)", "Apache-2.0", "https://github.com/yxl-net/orm", "最简单的SQL Server对象关系库", "SQL_Server,O/RM,最简单", @"G:\yxl\Yxl\Yxl.ORM", "oy2ajlmen5frpu5gfklacqdejigp6fjerckx7c6stlpkai");
            /*
             nuget.exe pack
             nuget.exe push Yxl.ORM.0.0.2.nupkg oy2ajlmen5frpu5gfklacqdejigp6fjerckx7c6stlpkai -Source https://api.nuget.org/v3/index.json
             */
            dgv.DataSource = dt;
        }
    }
}
