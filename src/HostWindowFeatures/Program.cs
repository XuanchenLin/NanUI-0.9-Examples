using NetDimension.NanUI;

namespace HostWindowFeatures;

internal static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.SetHighDpiMode(HighDpiMode.PerMonitorV2);

        var runtime = WinFormium.CreateRuntimeBuilder(app => {
#if DEBUG
            app.UseDebuggingMode();
#else
            app.UseEmbeddedFileResource("http", "res.app.local", "Web");
#endif
            app.UseMainWindow(_ => new MainWindow());

        }).Build();

        runtime.Run();

    }
}
