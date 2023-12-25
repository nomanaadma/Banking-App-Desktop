using System.Runtime.CompilerServices;
using System.Text;

namespace Banking_App
{
    public class FileSystemCus
    {
        public static string extension = ".csv";
        public static void initialize()
        {

            string dataFolderPath = dataPath();

            if (!Directory.Exists(dataFolderPath))
                Directory.CreateDirectory(dataFolderPath);

            string userPath = filePath("users");
            if (!File.Exists(userPath))
                File.WriteAllText(userPath, "id,full_name,email,password,cnic,\r\n");

        }

        public static string dataPath()
        {
            return Path.Combine(System.IO.Path.GetFullPath(@"..\..\..\"), "data");
        }

        public static string filePath(string file) 
        {
            return Path.Combine(dataPath(), file) + extension;
        }

        public static string generateId()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            Random random = new Random();

            string shortId = new string(Enumerable.Repeat(chars, 6)
              .Select(s => s[random.Next(s.Length)]).ToArray());

            return shortId;
        }


        public static void writeData(string file, string[] data)
        {
            file = filePath(file);

            string dataRow = generateId() + ",";
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



    }
}
