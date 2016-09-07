using System;
using Xamarin.Forms;

namespace FoodList
{
	public class MainPage :ContentPage
	{
		Button addRecipeButton;
		Entry recipeName;
		StackLayout panel;
		StackLayout recipeList;

		public MainPage()
		{
			this.Padding = new Thickness(20, Device.OnPlatform(40, 20, 20), 20, 20);

			recipeList = new StackLayout { };
			panel = new StackLayout
			{
				VerticalOptions = LayoutOptions.FillAndExpand,
				HorizontalOptions = LayoutOptions.FillAndExpand,
				Orientation = StackOrientation.Vertical,
				Spacing = 15,
			};

			panel.Children.Add(new Label
			{
				HorizontalTextAlignment = TextAlignment.Center,
				Text = "Delicious!"
			});

			panel.Children.Add(recipeName = new Entry
			{
				Text = "Recipe Name"
			});

			panel.Children.Add(addRecipeButton = new Button
			{
				Text = "Add a Recipe"
			});

			panel.Children.Add(new ScrollView
			{
				Content = recipeList

			});

			this.Content = panel;

			addRecipeButton.Clicked += OnAddRecipe;
		}

		private void OnAddRecipe(object sender, EventArgs e)
		{
			recipeList.Children.Add(new Label
			{
				Text = recipeName.Text
			});
			recipeName.Text = "Recipe Name";
		}
	}
}

