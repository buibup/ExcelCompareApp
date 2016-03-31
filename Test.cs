using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using ExcelCompareApp.App_Code;
using LinqToExcel;

namespace ExcelCompareApp
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void compare_btn_Click(object sender, EventArgs e)
        {
            string firstFile = firstExcel_txt.Text;
            ExcelInfo file1 = ReadExcel(openFileDialog1);

            string secondFile = secondExcel_txt.Text;
            ExcelInfo file2 = ReadExcel(openFileDialog2);

            CompareExcels(file1, file2);
        }
        public void CompareExcels(ExcelInfo fileA, ExcelInfo fileB)
        {
            foreach (ExcelRow rowA in fileA.excelRows)
            {
                //If the current hash of a row of fileA does not exists in fileB then it was removed 
                if (!fileB.ContainsHash(rowA.hash))
                {
                    Console.WriteLine("Row removed" + rowA.ToString());
                }
            }

            foreach (ExcelRow rowB in fileB.excelRows)
            {
                //If the current hash of a row of fileB does not exists in fileA then it was added 
                if (!fileA.ContainsHash(rowB.hash))
                {
                    Console.WriteLine("Row added" + rowB.ToString());
                }
            }
        }
        public ExcelInfo ReadExcel(OpenFileDialog openFileDialog)
        {
            var _excelFile = new ExcelQueryFactory(openFileDialog.FileName);
            var _info = from c in _excelFile.WorksheetNoHeader() select c;

            ExcelRow excelRow;
            ExcelInfo resp;

            resp = new ExcelInfo();

            foreach (var item in _info)
            {
                excelRow = new ExcelRow();

                //Add all the cells (with a for each)
                excelRow.lstCells.Add(item.ElementAt(0));
                excelRow.lstCells.Add(item.ElementAt(1));

                //Add the last cell of the row
                //excelRow.lstCells.Add(item.ElementAt(N));

                //Calculate the hash of the row
                excelRow.CalculateHash();

                //Add the row to the ExcelInfo object
                resp.excelRows.Add(excelRow);
            }
            return resp;
        }
    }
}
