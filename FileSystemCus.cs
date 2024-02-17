﻿using System.Text;
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

        public static void writeDataTemp(string file, Dictionary<string, string> data)
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
        public static List<string> findAllTemp(string file, string data, bool single = false)
        {
            var rows = readData(file);

            var foundRows = new List<string>();

            string dataWithQoma = data + ',';

            foreach (var row in rows)
            {
                if (row.Contains(dataWithQoma))
                {
                    if (single == true) return [.. row.Split(',')];

                    foundRows.Add(row);

                }

            }

            return foundRows;
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

        public static List<string> findOneTemp(string file, string data)
        {
            return findAllTemp(file, data, true);
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
