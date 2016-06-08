using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Structure_Helper
{
    public partial class DisplayConnections : Form
    {
        public DisplayConnections()
        {
            InitializeComponent();
            lst_Connections.DataSource = Program.Connections;
            lst_Connections.DisplayMember = "Name";
        }
    }
}
