using Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ExcelCompareApp
{
    public partial class ExcelCompare : Form
    {
        System.Windows.Forms.OpenFileDialog oFileDialog = new System.Windows.Forms.OpenFileDialog();
        DataTable dtOne = new DataTable();
        DataTable dtTwo = new DataTable();
        DataTable dtResult = new DataTable();
        DataSet ds1 = new DataSet();
        public ExcelCompare()
        {
            InitializeComponent();
        }

        private void btnChooseFil1_Click(object sender, EventArgs e)
        {
            var result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName;
                dtOne = ReadSheet(textBox1, cbSheetFile1);
                lblMsgFile1.Text = dtOne.Rows.Count.ToString();
            }
        }

        private void btnChooseFil2_Click(object sender, EventArgs e)
        {
            var result = openFileDialog2.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBox2.Text = openFileDialog2.FileName;
                dtTwo = ReadSheet(textBox2, cbSheetFile2);
                lblMsgFile2.Text = dtTwo.Rows.Count.ToString();
            }
        }
        private DataTable ReadSheet(TextBox textBox,ComboBox comboBox)
        {
            DataTable dt = new DataTable();
            var file = new FileInfo(textBox.Text);
            using (var stream = new FileStream(textBox.Text, FileMode.Open))
            {
                IExcelDataReader reader = null;
                if (file.Extension == ".xls")
                {
                    reader = ExcelReaderFactory.CreateBinaryReader(stream);

                }
                else if (file.Extension == ".xlsx")
                {
                    reader = ExcelReaderFactory.CreateOpenXmlReader(stream);
                }

                if (reader == null)
                    return dt = null;
                reader.IsFirstRowAsColumnNames = true;
                ds1 = reader.AsDataSet();

                var tablenames = GetTablenames(ds1.Tables);
                comboBox.DataSource = tablenames;

                if (tablenames.Count > 0)
                {
                    comboBox.SelectedIndex = 0;
                    dt = ds1.Tables[0];
                }
                //dataGridView1.DataSource = ds;
                //dataGridView1.DataMember
                
                return dt;
            }
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            if (dtOne.Rows.Count > 0 && dtTwo.Rows.Count > 0)
            {
                dtResult = getDifferentRecords(dtOne, dtTwo);
                dataGridView1.DataSource = dtResult;
                lblMsgResult.Text = "Data not equal is " + dtResult.Rows.Count.ToString() + " row";
            }
            else
            {
                MessageBox.Show("Please choose excel file");
                return;
            }
        }
        private void clsValue()
        {
            lblMsgFile1.Text = "";
            lblMsgFile2.Text = "";
            lblMsgResult.Text = "";
            dataGridView1.DataSource = null;
            dtOne.Clear();
            dtTwo.Clear();
            dtResult.Clear();
        }

        private IList<string> GetTablenames(DataTableCollection tables)
        {
            var tableList = new List<string>();
            foreach (var table in tables)
            {
                tableList.Add(table.ToString());
            }

            return tableList;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clsValue();
        }
        private void ToCsV(DataGridView dGV, string filename)
        {
            string stOutput = "";
            // Export titles:
            string sHeaders = "";

            for (int j = 0; j < dGV.Columns.Count; j++)
                sHeaders = sHeaders.ToString() + Convert.ToString(dGV.Columns[j].HeaderText) + "\t";
            stOutput += sHeaders + "\r\n";
            // Export data.
            for (int i = 0; i < dGV.RowCount - 1; i++)
            {
                string stLine = "";
                for (int j = 0; j < dGV.Rows[i].Cells.Count; j++)
                    stLine = stLine.ToString() + Convert.ToString(dGV.Rows[i].Cells[j].Value) + "\t";
                stOutput += stLine + "\r\n";
            }
            Encoding utf16 = Encoding.GetEncoding(1254);
            byte[] output = utf16.GetBytes(stOutput);
            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryWriter bw = new BinaryWriter(fs);
            bw.Write(output, 0, output.Length); //write the encoded file
            bw.Flush();
            bw.Close();
            fs.Close();
        }
        private void btnExportToExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Document (*.xls)|*.xls";
            sfd.FileName = "export.xls";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                ToCsV(dataGridView1, sfd.FileName);
                MessageBox.Show("Save completed");
            }
        }

        private void ExcelCompare_Load(object sender, EventArgs e)
        {
            clsValue();
        }
        #region Compare two DataTables and return a DataTable with DifferentRecords
        public DataTable getDifferentRecords(DataTable FirstDataTable, DataTable SecondDataTable)
        {
            //Create Empty Table   
            DataTable ResultDataTable = new DataTable("ResultDataTable");

            //use a Dataset to make use of a DataRelation object   
            using (DataSet ds = new DataSet())
            {
                //Add tables   
                ds.Tables.AddRange(new DataTable[] { FirstDataTable.Copy(), SecondDataTable.Copy() });

                //Get Columns for DataRelation   
                DataColumn[] firstColumns = new DataColumn[ds.Tables[0].Columns.Count];
                for (int i = 0; i < firstColumns.Length; i++)
                {
                    firstColumns[i] = ds.Tables[0].Columns[i];
                }

                DataColumn[] secondColumns = new DataColumn[ds.Tables[1].Columns.Count];
                for (int i = 0; i < secondColumns.Length; i++)
                {
                    secondColumns[i] = ds.Tables[1].Columns[i];
                }

                //Create DataRelation   
                DataRelation r1 = new DataRelation(string.Empty, firstColumns, secondColumns, false);
                ds.Relations.Add(r1);

                DataRelation r2 = new DataRelation(string.Empty, secondColumns, firstColumns, false);
                ds.Relations.Add(r2);

                //Create columns for return table   
                for (int i = 0; i < FirstDataTable.Columns.Count; i++)
                {
                    ResultDataTable.Columns.Add(FirstDataTable.Columns[i].ColumnName, FirstDataTable.Columns[i].DataType);
                    if (i == FirstDataTable.Columns.Count - 1)
                    {
                        ResultDataTable.Columns.Add("FromFile", typeof(String));
                    }
                }

                //If FirstDataTable Row not in SecondDataTable, Add to ResultDataTable.   
                ResultDataTable.BeginLoadData();
                foreach (DataRow parentrow in ds.Tables[0].Rows)
                {
                    int index = ds.Tables[0].Rows.IndexOf(parentrow); //get current row index
                    DataRow[] childrows = parentrow.GetChildRows(r1);


                    if (childrows == null || childrows.Length == 0)
                    {
                        ResultDataTable.LoadDataRow(parentrow.ItemArray, true);
                        ResultDataTable.Rows[ResultDataTable.Rows.Count - 1]["FromFile"] = "1";
                    }
                }

                //If SecondDataTable Row not in FirstDataTable, Add to ResultDataTable.   
                foreach (DataRow parentrow in ds.Tables[1].Rows)
                {
                    int index = ds.Tables[1].Rows.IndexOf(parentrow); //get current row index
                    DataRow[] childrows = parentrow.GetChildRows(r2);
                    if (childrows == null || childrows.Length == 0)
                    {
                        ResultDataTable.LoadDataRow(parentrow.ItemArray, true);
                        ResultDataTable.Rows[ResultDataTable.Rows.Count - 1]["FromFile"] = "2";
                    }

                }
                ResultDataTable.EndLoadData();
            }

            return ResultDataTable;
        }
        #endregion

        private void cbSheetFile1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectTable(cbSheetFile1, dtOne);
        }

        private void cbSheetFile2_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectTable(cbSheetFile2, dtTwo);
        }
        private void SelectTable(ComboBox comboBox,DataTable dt)
        {
            var tablename = comboBox.SelectedItem.ToString();
            
            dt = ds1.Tables[tablename];

            //GetValues(ds, tablename);
        }
    }
}
