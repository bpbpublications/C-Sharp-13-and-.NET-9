// ObservableCollection<T> (generic)
using System.Collections.ObjectModel;

ObservableCollection<string> observableCollection = new ObservableCollection<string>()
{
    "Apple"
};
observableCollection.Add("Banana");
Console.WriteLine($"ObservableCollection: {string.Join(", ", observableCollection)}");