using AS2223_4G_INF_IngrassiaSamuele_Figure;
using Microsoft.Maui.ApplicationModel.Communication;

namespace FigureMAUI;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    int n = 0;
    string chosenShape;
    string[] lastCalculationsList = new string[10];

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
        
        lblCalculate.IsVisible = true;
        btnCalculate.IsVisible = true;
        
        chosenShape = cmbShapes.SelectedItem.ToString();

        switch (chosenShape)
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



        lblCalculate.Text = $"Calcolerò area e perimetro di un {chosenShape}";
    }

    private void Calculate_Clicked(object sender, EventArgs e)
    {
        string shapeInfo = "";

        switch (chosenShape)
        {
            case "Quadrato":
                Square sq = new Square(Double.Parse(txtBase.Text));
                shapeInfo = $"Area: {sq.Area}";
                break;
            case "Rettangolo":
                Rectangle rect = new Rectangle(Double.Parse(txtBase.Text), Double.Parse(txtHeight.Text));
                shapeInfo = $"Area: {rect.Area} | Perimetro: {rect.Perimeter}";
                break;
            case "Cerchio":
                Circle circ = new Circle(Double.Parse(txtBase.Text));
                shapeInfo = $"Area: {circ.Area} | Diametro: {circ.Perimeter}";
                break;
        }

        if (n == 10)
            n = 0;

        lastCalculationsList[n] = $"{chosenShape} | {shapeInfo}";
        n++;

        Array.Resize<string>(ref lastCalculationsList, n + 1);

        lstLastCalculations.ItemsSource = lastCalculationsList;

    }
}

