namespace Generic_Code_Editor {
    internal static class Program {
        [STAThread]
        static void Main() {
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}