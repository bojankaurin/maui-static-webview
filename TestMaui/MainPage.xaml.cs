namespace TestMaui;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void OnNextPageBtnClicked(object sender, EventArgs e)
    {
        Dispatcher.Dispatch(() => Navigation.PushAsync(new MainPage2()));
    }

    protected override void OnAppearing()
    {
        Dispatcher.Dispatch(() =>
        {
            //When navigating back to the page, I don't know why I have to clear it to null first, but if I don't for some reason it won't set the content to WebView
            viewContainer.Content = null;
            //This works on iOS but on Android every time I update the content, it refreshes the page in WebView
            viewContainer.Content = WebViewStaticFactory.Instance;
        });
        base.OnAppearing();
    }
}