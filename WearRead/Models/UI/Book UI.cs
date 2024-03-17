using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WearRead.Models.UI;

public class BookUI : INotifyPropertyChanged
{
    public Guid ID { get; set; }

    private string title = string.Empty;
    public string Title
    {
        get => this.title;
        set { this.title = value; OnPropertyChanged(); }
    }

    private ImageSource? cover = null;
    public ImageSource? Cover
    {
        get => this.cover;
        set { this.cover = value; OnPropertyChanged(); }
    }

    private int current_page;
    public int CurrentPage
    {
        get => this.current_page;
        set { this.current_page = value; OnPropertyChanged(); }
    }

    private int total_pages;
    public int TotalPages
    {
        get => this.total_pages;
        set { this.total_pages = value; OnPropertyChanged(); }
    }

    public event PropertyChangedEventHandler? PropertyChanged;
    private void OnPropertyChanged([CallerMemberName] string property_name = "") => this.PropertyChanged?.Invoke(this, new(property_name));
}