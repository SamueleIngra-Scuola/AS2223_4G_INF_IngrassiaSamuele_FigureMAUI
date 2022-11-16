using Microsoft.Maui.ApplicationModel.Communication;

namespace FigureMAUI;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }
    void OnPickerSelectedIndexChanged(object sender, EventArgs e)
    {
        switch (cmbShapes.SelectedItem)
        {
            case "Quadrato":
                lblBase.IsVisible = true;
                txtBase.IsVisible = true;
                break;
            case "Rettangolo":
                lblBase.IsVisible = true;
                txtBase.IsVisible = true;

                lblHeight.IsVisible = true;
                txtHeight.IsVisible = true;
                break;
            case "Cerchio":
                lblRadius.IsVisible = true;
                txtBase.IsVisible = true;
                break;
            default:
                break; 
        }
    }

    private void Calculate_Clicked(object sender, EventArgs e)
    {
        int n = 0;
    }
}

