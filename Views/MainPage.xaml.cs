namespace Test;
public partial class MainPage : ContentPage {

    public MainPage(MainPageViewMode mainPageViewMode) {
        InitializeComponent();
        BindingContext = mainPageViewMode;

    }
}
