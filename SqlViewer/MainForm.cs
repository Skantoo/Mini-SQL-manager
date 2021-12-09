using SqlViewer.Dal;
using SqlViewer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlViewer
{
    public partial class MainForm : Form
    {
        private const string FileFilter = "XML files(*.xml)|*.xml|All files(*.*)|*.*";
        private const string FileName = "{0}.xml";

        private string selectedDatabase;

        public MainForm()
        {
            InitializeComponent();
            Init();
        }

        private void Init() => LoadDatabases();

        private void LoadDatabases()
        => CbDatabases.DataSource = new List<Database>(RepositoryFactory.GetRepository().GetDatabases());

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e) => Application.Exit();

        
        private void BtnExecute_Click(object sender, EventArgs e)
        {
            FlpQueryTables.Controls.Clear();
            string[] commands = TbQuery.Text.Split('\n');
            foreach (var command in commands)
            {
                try
                {
                    if (command.ToLower().Contains("select"))
                    {
                        DataSet ds = RepositoryFactory.GetRepository().ExecuteSQLCommand(command, selectedDatabase);
                        lblMsg.Text = "Select initiated";
                        foreach (var table in ds.Tables)
                        {
                            DataTable dataTable = (DataTable)table;
                            DataGrid dataGrid = new DataGrid();
                            dataGrid.DataSource = dataTable;
                            dataGrid.Size = new Size(300, FlpQueryTables.Height);
                            dataGrid.ReadOnly = true;
                            FlpQueryTables.Controls.Add(dataGrid);
                        }
                    }
                    else
                    {
                        int rows = RepositoryFactory.GetRepository().ExecuteNonQueryCommand(command);
                        lblMsg.Text = $"{rows} row/s affected";
                    }
                }
                catch (Exception)
                {

                    MessageError();
                }

            }
            
        }

        private void MessageError()
        {
            
            lblMsg.Text = "Error";
        }
    }
}
