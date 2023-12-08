﻿namespace ItemDisappearingBug;

public partial class MainPage : ContentPage
{
    public IList<string> Items => new List<string>()
    {
        "Item 01",
        "Item 02",
        "Item 03",
        "Item 04",
        "Item 05",
        "Item 06",
        "Item 07",
        "Item 08",
        "Item 09",
        "Item 10",
        "Item 11",
        "Item 12",
        "Item 13",
        "Item 14",
        "Item 15",
        "Item 16",
        "Item 17",
        "Item 18",
        "Item 19",
        "Item 20",
        "Item 21",
        "Item 22",
        "Item 23",
        "Item 24",
        "Item 25",
        "Item 26",
        "Item 27",
        "Item 28",
        "Item 29",
        "Item 30",
        "Item 31",
        "Item 32",
        "Item 33",
        "Item 34",
        "Item 35",
        "Item 36",
        "Item 37",
        "Item 38",
        "Item 39",
        "Item 40",
        "Item 41",
        "Item 42",
        "Item 43",
        "Item 44",
        "Item 45",
        "Item 46",
        "Item 47",
        "Item 48",
        "Item 49",
        "Item 50",
    };

    public MainPage()
    {
        InitializeComponent();

        ListView.ItemAppearing += ListViewOnItemAppearing;
        ListView.ItemDisappearing += ListViewOnItemDisappearing;
    }

    ~MainPage()
    {
        ListView.ItemAppearing -= ListViewOnItemAppearing;
        ListView.ItemDisappearing -= ListViewOnItemDisappearing;
    }

    private void ListViewOnItemAppearing(object? sender, ItemVisibilityEventArgs args)
    {
        AppearingLabel.Text = "Appeared item: " + args.Item as string;
    }

    private void ListViewOnItemDisappearing(object? sender, ItemVisibilityEventArgs args)
    {
        DisappearingLabel.Text = "Disappeared item: " + args.Item as string;
    }
}