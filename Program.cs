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
            Application.Run(new BankingApp());
        }

        static void Initialize()
        {
            var dataFolderPath = FileSystemCus.DataPath();

            // creating ./data directory to store data
            if (!Directory.Exists(dataFolderPath))
                Directory.CreateDirectory(dataFolderPath);

            // creating user file
            var userPath = FileSystemCus.FilePath("users");
            if (!File.Exists(userPath))
                File.WriteAllText(userPath, "id,full_name,email,password,cnic,balance,card_number,expiry,cvc,\r\n");

            // creating transactions file
            var transactionPath = FileSystemCus.FilePath("transactions");
            if (!File.Exists(transactionPath))
                File.WriteAllText(transactionPath, "id,from,to,amount,date,\r\n");
        }

    }
}