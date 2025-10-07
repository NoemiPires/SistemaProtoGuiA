namespace SistemaProtoGuiA
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application
        [STAThread]

        static void Main()
        {
            Repository repository = new Repository();

            ApplicationConfiguration.Initialize();
            //Application.Run(new pnlPricipal());
            //Application.Run(new ValidacaoServidor());
            //Application.Run(new Form3());
            Application.Run(new Form5());
        }
    }
}