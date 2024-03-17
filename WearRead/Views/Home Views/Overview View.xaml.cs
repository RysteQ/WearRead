using WearRead.View_Models.Home_Views;

namespace WearRead.Views.Home_Views;

public partial class OverviewView : ContentPage
{
	public OverviewView()
	{
		InitializeComponent();

        this.view_model = new();
        BindingContext = this.view_model;
	}

    protected override void OnAppearing()
    {
        base.OnAppearing();

        this.view_model.LoadCurrentBook();

        GridMainOverview.HeightRequest = DeviceDisplay.Current.MainDisplayInfo.Height / DeviceDisplay.Current.MainDisplayInfo.Density;
        GridActionsOverview.HeightRequest = DeviceDisplay.Current.MainDisplayInfo.Height / DeviceDisplay.Current.MainDisplayInfo.Density;
    }

    private OverviewVM view_model;
}