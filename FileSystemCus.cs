using System.Text;
using System.Windows.Forms.VisualStyles;

namespace Banking_App
{
    public class FileSystemCus
    {
        private static string extension = ".txt";
        
        public static string dataPath()
        {
            return Path.Combine(System.IO.Path.GetFullPath(@"..\..\..\"), "data");
        }

        public static string filePath(string file)
        {
            return Path.Combine(dataPath(), file) + extension;
        }

        public static string ToValueString(Dictionary<string, string> data)
        {
            return string.Join(",", data.Select(v => v.Value) .ToArray());
        }

        public static void WriteDataTemp(string file, Dictionary<string, string> data)
        {
            file = filePath(file);
            string dataRow = GlobalCus.generateId() + "," + ToValueString(data) + ",\r\n";
            File.AppendAllText(file, dataRow);
        }

        public static void writeData(string file, string[] data)
        {
            file = filePath(file);
            string dataRow = GlobalCus.generateId() + "," + string.Join(",", data) + ",\r\n";
            File.AppendAllText(file, dataRow);
        }

        public static string[] readData(string file)
        {
            file = filePath(file);
            return File.ReadAllLines(file, Encoding.UTF8);
        }

        public static string[] findAll(string file, string data, bool single = false)
        {
            string[] rows = readData(file);

            string[] foundRows = [];

            string dataWithQoma = data + ',';

            foreach (var row in rows)
            {
                if (row.Contains(dataWithQoma))
                {
                    if (single == true) return row.Split(',');

                    Array.Resize(ref foundRows, foundRows.Length + 1);
                    foundRows[foundRows.Length - 1] = row;

                }
           
            }

            return foundRows;
        }
        public static List<Dictionary<string, string>> FindAllTemp(string file, string data, bool single = false)
        {
            var rows = readData(file);

            var titles = rows[0].Split(",");

            var foundRows = new List<Dictionary<string, string>>();

            var dataWithQoma = data + ',';

            foreach (var row in rows)
            {
                if (row.Contains(dataWithQoma))
                {
                    var dRow = new Dictionary<string, string>();
                    var dataColumns = row.Split(",");

                    for (var i = 0; i < dataColumns.Length - 1; i++)
                    {
                        dRow[titles[i]] = dataColumns[i];
                    }

                    foundRows.Add(dRow);

                    if (single == true) 
                        return foundRows;

                }

            }

            return foundRows;
        }
        public static Dictionary<string, string> FindOneTemp(string file, string data)
        {
            var result = FindAllTemp(file, data, true);
            return result.Count == 0 ? [] : result[0];
        }

        public static string[] findOne(string file, string data)
        {
            return findAll(file, data, true);
        }

        public static void UpdateRow(string file, string[] rowData) {

            string[] fileData = readData(file);
            string newData = "";

            foreach (var row in fileData)
            {
                if( row.Contains(rowData[0]+",") )
                {
                    string updatedRow = string.Join(",", rowData) + "\r\n";
                    newData += updatedRow;
                }
                else
                {
                    newData += row + "\r\n";
                }
            }

            file = filePath(file);
            File.WriteAllText(file, string.Empty);
            File.AppendAllText(file, newData);

        }

    }
}
