namespace TestMaui;

public class WebViewStaticFactory
{
    private static WebView _instance;
    public static WebView Instance => _instance ??= new WebView { Source = "https://github.com/" };
}