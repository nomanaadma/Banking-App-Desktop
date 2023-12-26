using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Banking_App
{
    public class FileSystemCus
    {
        public static string extension = ".txt";
        public static void initialize()
        {

            string dataFolderPath = dataPath();

            // creating ./data directory to store data
            if (!Directory.Exists(dataFolderPath))
                Directory.CreateDirectory(dataFolderPath);

            // creating user file
            string userPath = filePath("users");
            if (!File.Exists(userPath))
                File.WriteAllText(userPath, "id,full_name,email,password,cnic,balance,card_number,expiry,cvc\r\n");

            // creating transactions file
            string transactionPath = filePath("transactions");
            if (!File.Exists(transactionPath))
                File.WriteAllText(transactionPath, "id,from,to,amount,date\r\n");

        }

        public static string dataPath()
        {
            return Path.Combine(System.IO.Path.GetFullPath(@"..\..\..\"), "data");
        }

        public static string filePath(string file)
        {

            return Path.Combine(dataPath(), file) + extension;
        }

        


        public static void writeData(string file, string[] data)
        {
            file = filePath(file);

            string dataRow = GlobalCus.generateId() + ",";
            foreach (var item in data)
            {
                dataRow += item + ",";
            }
            dataRow += "\r\n";

            File.AppendAllText(file, dataRow);

        }

        public static string[] readData(string file)
        {
            file = filePath(file);
            string[] lines = File.ReadAllLines(file, Encoding.UTF8);

            return lines;

        }

        public static string[] findRows(string file, string[] conditions)
        {

            string[] data = readData(file);

            string[] foundRows = { };

            foreach (var row in data)
            {

                int matchCount = 0;
                foreach (var cond in conditions)
                {
                    string condtionQoma = cond + ',';
                    if (row.Contains(condtionQoma))
                        matchCount++;

                    if (matchCount == conditions.Length)
                    {
                        Array.Resize(ref foundRows, foundRows.Length + 1);
                        foundRows[foundRows.Length - 1] = row;
                    }

                }

            }

            return foundRows;

        }

        public static void UpdateRow(string file, string[] rowData) {

            string[] fileData = readData(file);
            string newData = "";

            foreach (var row in fileData)
            {
                if( row.Contains(rowData[0]+",") )
                {
                    foreach (var item in rowData)
                    {
                        if(item != "")
                            newData += item + ",";
                    }
                    newData += "\r\n";
                } else
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
