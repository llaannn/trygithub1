using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinsForm0718
{
    public partial class 閏年測試 : Form
    {
        public 閏年測試()
        {
            InitializeComponent();
        }

        //DateTime dateTime = DateTime.Now;
        //DateTime startDate = new DateTime;

        bool isLeapYear = DateTime.IsLeapYear(DateTime.Now.Year);
        
    }
}
