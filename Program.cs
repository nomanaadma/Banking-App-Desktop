namespace Banking_App
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Initialize();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new banking_app());
        }

        static void Initialize()
        {
            var dataFolderPath = FileSystemCus.dataPath();

            // creating ./data directory to store data
            if (!Directory.Exists(dataFolderPath))
                Directory.CreateDirectory(dataFolderPath);

            // creating user file
            string userPath = FileSystemCus.filePath("users");
            if (!File.Exists(userPath))
                File.WriteAllText(userPath, "id,full_name,email,password,cnic,balance,card_number,expiry,cvc\r\n");

            // creating transactions file
            string transactionPath = FileSystemCus.filePath("transactions");
            if (!File.Exists(transactionPath))
                File.WriteAllText(transactionPath, "id,from,to,amount,date\r\n");
        }

    }
}