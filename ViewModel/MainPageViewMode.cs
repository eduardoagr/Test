using System.Collections.ObjectModel;

using Test.Model;

namespace Test.ViewModel;

// Is a good practice, to name your viewModel the same as your view, but putting the suffix ViewModel 
public partial class MainPageViewMode : ObservableObject {

    public ObservableCollection<WordItem> WordItems { get; set; } = [];

    [ObservableProperty]
    WordItem? word = new();


    [RelayCommand]
    void ShowWordData() {

        string[] words = Word.Word.Split(' ');
        WordItems.Clear();
        foreach(var item in words) {

            WordItems.Add(new WordItem { Word = item, length = item.Length });
        }

        char[] charArray = Word.Word.ToCharArray();
        Array.Reverse(charArray);
        string reversedWord = new(charArray);
        Word.Word = reversedWord;
    }
}


