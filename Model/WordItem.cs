namespace Test.Model;
public partial class WordItem : ObservableObject {

    [ObservableProperty]
    public string word;

    [ObservableProperty]
    public int length;


}
