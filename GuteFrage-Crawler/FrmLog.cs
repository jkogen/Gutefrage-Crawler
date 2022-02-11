using System.Collections.Generic;
using System.Windows.Forms;

namespace GuteFrage_Crawler
{
    public partial class FrmLog : Form
    {
        public FrmLog(List<ErrorLog> errorLogs)
        {
            InitializeComponent();

            foreach (var log in errorLogs)
                richTextBox1.Text += string.Format("Seite {0}: {1}\n", log.Page, log.Error);
        }
    }
}
