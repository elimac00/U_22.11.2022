using Microsoft.Maui.Graphics.Text;
using System.Globalization;

namespace U_22._11._2022;

public partial class MainPage : ContentPage
{
	// Konsttruktor der Main Page; Gleiche Name wie die Klassse Oben
	Label label;
	Button button;
	Entry entry;

	public MainPage()
	{
		InitializeComponent();

		WorkItem workitem = new WorkItem();
		BindingContext = workitem;

		Grid grid = new Grid()
		{
			BackgroundColor = Colors.White,
			RowDefinitions =
			{
				new RowDefinition(),
				new RowDefinition(),
				new RowDefinition(),
				new RowDefinition()
			}
			
		};
		Content = grid;

		// Entry erzeugen 
		entry = new()
		{
			TextColor = Colors.Blue,
			BackgroundColor = Colors.Black
		};

		entry.SetBinding(Entry.TextProperty, "Input");
		grid.Add(entry, 5,5);

		//Button erzeugen
		button = new()
		{
			TextColor = Colors.Black
		};

		button.SetBinding(Button.TextProperty, "ButtonText");
		grid.Add(button, 0,1);

		TapGestureRecognizer tapGestureRecognizer = new TapGestureRecognizer();
		tapGestureRecognizer.Tapped += Button_Tap;
		button.GestureRecognizers.Add(tapGestureRecognizer);

	}

    private void Button_Tap(object sender, TappedEventArgs e)
    {
		//Display Alert
		if (sender is Button button)
		{
			var textvar1 = Double.Parse(entry.Text);
			var textvar2 = textvar1 * 0.55;
			entry.Text = textvar2.ToString();
        }

		else
		{
			DisplayAlert("Bitte Gehalt eingeben", "Wenn korrekt dann bestätigen", "Bestätigen");
		}
			

    }
}

