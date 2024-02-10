using BottomSheetTest.Controls;

namespace BottomSheetTest;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnCounterClicked(object sender, EventArgs e)
    {
        var bottomSheet = new BottomSheet();

        await bottomSheet.ShowAsync();
    }
}