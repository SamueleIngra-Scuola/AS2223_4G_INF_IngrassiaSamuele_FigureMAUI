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
        
    }

    private void ShowGeometry_Clicked(object sender, EventArgs e)
    {
        //Make everything invisible and delete every text box
        lblBase.IsVisible = false;
        txtBase.IsVisible = false;
        lblHeight.IsVisible = false;
        txtHeight.IsVisible = false;
        lblRadius.IsVisible = false;
        txtHeight.Text = "";
        txtBase.Text = "";

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
        }
    }

    private void Calculate_Clicked(object sender, EventArgs e)
    {
        
    }
}

