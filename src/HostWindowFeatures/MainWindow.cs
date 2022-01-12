namespace HostWindowFeatures;
internal class MainWindow : Formium
{
#if DEBUG
    public override string StartUrl { get; } = "http://localhost:9001/"; // 如果在 Debug 模式，那么请自行使用静态服务器来运行页面。
                                                                         // 我使用的live-server，启动方法：
                                                                         // live-server --port=9001
#else
    public override string StartUrl { get; } = "http://res.app.local/"; // 如果是 Release 那么就自动把页面作为内嵌资源打包进程序集。
                                                                        // 打包进程序集的资源不需要起 http 服务。
#endif

    public override HostWindowType WindowType { get; } = HostWindowType.Borderless;

    public MainWindow()
    {
        StartPosition = FormStartPosition.CenterScreen;

        // 获取 Borderless 样式的扩展属性，可以在扩展属性里对 Borderless 专用属性进行设置
        // 泛型需要对应 WindowType 的值，如果使用 Layered 样式，那么泛型 T 的类型就是 LayeredWindowStyle
        var styles = UseExtendedStyles<BorderlessWindowStyle>();
        styles.CornerStyle = CornerStyle.Small;
        styles.ShadowEffect = ShadowEffect.DropShadow;
        styles.ShadowColor = ColorTranslator.FromHtml("#fa3a3a3a");

        // 修改启动界面
        SplashScreen.BackColor = ColorTranslator.FromHtml("#fafafa");
        SplashScreen.Image = Properties.Resources.SplashLogo;

    }

    protected override void OnReady()
    {

    }
}
