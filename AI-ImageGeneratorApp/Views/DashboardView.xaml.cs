using AI_ImageGeneratorApp.Models;
using System.Collections.ObjectModel;

namespace AI_ImageGeneratorApp.Views;

public partial class DashboardView : ContentPage
{
    public ObservableCollection<Profile> Profiles { get; set; }
    public ObservableCollection<GeneratedImage> GeneratedImages { get; set; }

    public DashboardView()
    {
        InitializeComponent();
        LoadData();
        BindingContext = this;

    }

    private void LoadData()
    {
        Profiles = new ObservableCollection<Profile>
        {
            new Profile
            {
                Name = "Javohir",
                ProfileImage = "dotnet_bot.png",
                NoPhotos = 2
            },
            new Profile
            {
                Name = "Islom",
                ProfileImage = "profile.jpg",
                NoPhotos = 4
            },
            new Profile
            {
                Name = "Javlon",
                ProfileImage = "dotnet_bot.png",
                NoPhotos = 7
            },
            new Profile
            {
                Name = "Akobir",
                ProfileImage = "profile.jpg",
                NoPhotos = 9
            },
        };

        GeneratedImages = new ObservableCollection<GeneratedImage>
        {
            new GeneratedImage
            {
                ImagePath = "first.jpg",
                MainKeyword = "Joker",
                Keywords = new List<string>{"joker","man","red"}
            },
            new GeneratedImage
            {
                ImagePath = "two.jpeg",
                MainKeyword = "KingLion",
                Keywords = new List<string>{"king","lion","mountine"}
            },
            new GeneratedImage
            {
                ImagePath = "three.jpeg",
                MainKeyword = "Scrooge McDuck",
                Keywords = new List<string>{"scrooge","duck","rich"}
            },
            new GeneratedImage
            {
                ImagePath = "four.jpeg",
                MainKeyword = "Monnalisa",
                Keywords = new List<string>{ "monnalisa", "image", "LeonardoDaVinci" }
            },
        };
    }
}