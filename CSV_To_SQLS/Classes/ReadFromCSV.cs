using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV_To_SQLS.Classes
{
    public class ReadFromCSV
    {
        public DataTable ReadFromCSVFile(string sFilePath)
        {
            DataTable dataTable = new DataTable();

            try
            {
                using (StreamReader reader = new StreamReader(sFilePath))
                {
                    string[] headers = reader.ReadLine().Split(';');
                    foreach (string header in headers)
                    {
                        dataTable.Columns.Add(header);
                    }

                    while (!reader.EndOfStream)
                    {
                        string[] rows = reader.ReadLine().Split(';');
                        DataRow dataRow = dataTable.NewRow();
                        for (int i = 0; i < headers.Length; i++)
                        {
                            dataRow[i] = rows[i];
                        }
                        dataTable.Rows.Add(dataRow);
                    }
                }
                return dataTable;

            } catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return dataTable;
        }
    }
}
