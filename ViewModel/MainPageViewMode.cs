using System.Collections.ObjectModel;
using System.Text;

using Test.Model;

namespace Test.ViewModel;

// Is a good practice, to name your viewModel the same as your view, but putting the suffix ViewModel 
public partial class MainPageViewMode : ObservableObject {

    public ObservableCollection<WordItem> WordItems { get; set; } = [];

    [ObservableProperty]
    WordItem? word = new();

    [RelayCommand]
    void ShowWordData() {

        if(!string.IsNullOrWhiteSpace(Word?.word)) {

            string[] words = Word.word.Split(' ');
            WordItems.Clear();
            foreach(var item in words) {

                WordItems.Add(new WordItem { word = item, length = item.Length });
            }
        }
    }
}
