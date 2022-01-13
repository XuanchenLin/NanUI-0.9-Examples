using NetDimension.NanUI;

namespace UsingSplashScreen;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();

        WinFormium.CreateRuntimeBuilder(app => {

            app.UseDebuggingMode();

            app.UseMainWindow(_ => new MainWindow());

            app.UseEmbeddedFileResource("http", "res.app.local", "Web");
        }).Build().Run();
    }
}
