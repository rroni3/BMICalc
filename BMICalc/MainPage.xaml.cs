using System.Runtime.CompilerServices;

namespace BMICalc;

public partial class MainPage : ContentPage
{

	double height;
	double weight;
	double result;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		
		
	}

	private void Button_Clicked(object sender, EventArgs e)
	{
		this.weight=Weight.Value;
		this.height=Height.Value;

		int h = (int)(height * height);
		result = weight / h;

		if (result < 18.5)
		{
            Result.Text = result.ToString()+"Be careful youre underweight!";
        }
		if (result < 25 && result>18.5)
		{
            Result.Text = result.ToString() + "youre BMI is normal";
        }
		if (result < 30 && result >25)
		{
            Result.Text = result.ToString() + "Be careful youre overweight!";
        }
        if (result > 30)
        {
            Result.Text = result.ToString() + "Be careful youre really overweight!";
        }
        

	}
}

