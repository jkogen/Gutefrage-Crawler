using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Net;

namespace GuteFrage_Crawler
{
    public partial class Form1 : Form
    {
        private int hits = 0;
        private Stopwatch eventStopper = new Stopwatch();
        private List<ErrorLog> errorLogs = new List<ErrorLog>();
        private Queue<Report> reports = new Queue<Report>();
        private int currentPage = 0;
        private enum Status {  Start, Stop, Update };

        public Form1()
        {
            InitializeComponent();
            setConnectionLabel();
            eventStopper.Start();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            updateControls(Status.Start);

            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();
            errorLogs.Clear();
            timerUpdateControls.Start();

            bgWorkerWebRequests.RunWorkerAsync();
        }

        private void updateControls(Status status)
        {
            switch (status)
            {
                case Status.Start:
                    hits = 0;
                    lblStart.Text = DateTime.Now.ToString("HH:mm:ss");
                    lblEnd.Text = "";
                    lblRequests.Text = (nudEndSite.Value + 1 - nudStartSite.Value).ToString();
                    btnStart.BackColor = Color.OrangeRed;
                    btnStart.Enabled = false;
                    nudStartSite.Enabled = false;
                    nudEndSite.Enabled = false;
                    break;
                case Status.Stop:
                    btnStart.BackColor = Color.MediumAquamarine;
                    Text = "GuteFrage-Crawler";
                    lblEnd.Text = DateTime.Now.ToString("HH:mm:ss");
                    btnStart.Enabled = true;
                    nudStartSite.Enabled = true;
                    nudEndSite.Enabled = true;
                    break;
                case Status.Update:

                    break;
                default:
                    break;
            }

            Text = "Crawlen: Seite " + currentPage + " von " + nudEndSite.Value;
            lblRequests.Text = currentPage + "/" + nudEndSite.Value;
            setConnectionLabel();
            llblExceptions.Text = errorLogs.Count.ToString();
            updateDataGridView();
            lblHits.Text = hits.ToString();
            Update();
        }

        private void updateDataGridView()
        {
            while (reports.Count > 0)
            {
                Report report = reports.Dequeue();
                int rowIndex = dataGridView1.Rows.Add(report.IllegalUrl, report.Page, report.Answer.User, " → ");
                dataGridView1.Rows[rowIndex].Cells[3].ToolTipText = report.Answer.Question;
                hits++;
            }

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[0].Value.ToString().ToLower().Contains(tbSearchUrl.Text.ToLower())
                    && row.Cells[2].Value.ToString().ToLower().Contains(tbSearchUser.Text.ToLower()))
                    row.Visible = true;
                else
                    row.Visible = false;
            }
        }

        private void saveLog(Report report)
        {
            using (StreamWriter sw = File.AppendText("log.csv"))
            {
                try
                {
                    sw.WriteLine(string.Format("Seite {0};{1};{2};http://www.gutefrage.net/frage/{3}", report.Page, report.Answer.User, report.IllegalUrl, report.Answer.Question));
                }
                catch(IOException ioEx)
                {
                    errorLogs.Add(new ErrorLog(ioEx.Message, report.Page));
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (eventStopper.ElapsedMilliseconds < 500)
                return;

            switch (e.ColumnIndex)
            {
                case 1:
                    Process.Start("http://www.gutefrage.net/antworten/neue/" + dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString()); break;
                case 2:
                    Process.Start("http://www.gutefrage.net/nutzer/" + dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString()); break;
                case 3:
                    Process.Start("http://www.gutefrage.net/frage/" + dataGridView1.Rows[e.RowIndex].Cells[3].ToolTipText); break;
                default:
                    return;
            }

            eventStopper.Restart();
        }

        private void textChanged(object sender, EventArgs e)
        {
            updateDataGridView();
        }

        private void setConnectionLabel()
        {
            try
            {
                using (var client = new WebClient())
                {
                    using (var stream = client.OpenRead("http://www.google.com"))
                    {
                        lblConnected.Text = "Verbunden";
                        lblConnected.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
                        lblConnected.ForeColor = Color.Green;
                    }
                }
            }
            catch
            {
                lblConnected.Text = "Nicht verbunden";
                lblConnected.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
                lblConnected.ForeColor = Color.Red;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (llblExceptions.Text == "0")
                return;

            FrmLog logForm = new FrmLog(errorLogs);
            logForm.Show();
        }

        private void nudStartSite_ValueChanged(object sender, EventArgs e)
        {
            if (nudStartSite.Value > nudEndSite.Value)
                nudEndSite.Value = nudStartSite.Value;
        }

        private void nudEndSite_ValueChanged(object sender, EventArgs e)
        {
            if (nudEndSite.Value < nudStartSite.Value)
                nudStartSite.Value = nudEndSite.Value;
        }

        private void bgWorkerWebRequests_RunWorkerCompleted(object sender, System.ComponentModel.RunWorkerCompletedEventArgs e)
        {
            timerUpdateControls.Stop();
            dataGridView1.CellClick += new DataGridViewCellEventHandler(dataGridView1_CellContentClick);
            updateControls(Status.Stop);
        }

        private void bgWorkerWebRequests_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            for (int i = (int)nudStartSite.Value; i <= (int)nudEndSite.Value; i++)
            {
                try
                {
                    foreach (var report in Report.GetReports(i, cboxProxy.Checked))
                    {
                        if (cboxSaveLog.Checked)
                            saveLog(report);

                        currentPage = i;
                        reports.Enqueue(report);
                    }
                }
                catch(WebException webEx)
                {
                    errorLogs.Add(new ErrorLog(webEx.Status + " " + webEx.Message, i));
                }
            }
        }

        private void timerUpdateControls_Tick(object sender, EventArgs e)
        {
            updateControls(Status.Update);
        }
    }
}
