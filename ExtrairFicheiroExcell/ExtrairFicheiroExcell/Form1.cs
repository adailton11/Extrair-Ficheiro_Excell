using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using OfficeOpenXml;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data;

namespace ExtrairFicheiroExcell
{
    public partial class Form1 : Form
    {
        string filePath = string.Empty;
        DataTable dataTable = new DataTable();
        ExcelWorksheet worksheet = null;


        public Form1()
        {
            InitializeComponent();
            //Linkdin: Adaolton Ngunji
            //Email: adailtonadelino100@gmail.com
            //Whatsapp: +244 945 802 697
        }

        private void btnBuscarExcell_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Arquivos Excel|*.xls;*.xlsx|Todos os Arquivos|*.*";
                openFileDialog.Title = "Selecione um arquivo Excel";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = openFileDialog.FileName;

                    txtCaminhoExcell.Text = filePath;

                }
            }

            // Verifica se o arquivo existe
            if (File.Exists(filePath))
            {
                using (ExcelPackage package = new ExcelPackage(new FileInfo(filePath)))
                {
                    ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                    worksheet = package.Workbook.Worksheets[0]; // Assume que os dados estão na primeira planilha

                    int rowCount = worksheet.Dimension.Rows;
                    int columnCount = worksheet.Dimension.Columns;

                    NumeroColunas(columnCount);//Add numeros de colunas igual ao do ficheiro XML

                    // Loop pelas linhas do Excel
                    for (int row = 2; row <= rowCount; row++) // Começando da linha 2 para ignorar o cabeçalho
                    {
                        DataRow dataRow = dataTable.NewRow();
                        for (int Colunas = 1; Colunas <= columnCount; Colunas++) // Começando da linha 2 para ignorar o cabeçalho
                        {
                            dataRow[Colunas -1] = worksheet.Cells[row, Colunas].Value?.ToString();
                        }
                        dataTable.Rows.Add(dataRow);
                    }
                    dataGridView1.DataSource = dataTable;
                }
            }
            else
            {
                MessageBox.Show("O arquivo especificado não existe.");
            }
        }

        void NumeroColunas(int numeroColunas)
        {
            for (int Colunas = 1; Colunas <= numeroColunas; Colunas++) // Começando da linha 2 para ignorar o cabeçalho
            {
                // Lendo os dados de cada coluna
                dataTable.Columns.Add(worksheet.Cells[1, Colunas].Value?.ToString());
            }
        }

    }
}
