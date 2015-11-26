using Android.App;
using Android.Widget;
using Android.OS;
using System;
using Android.Content;
using Android.Views;
using Android.Graphics;

namespace BottomToolbar
{
	[Activity (Label = "BottomToolbar", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{
		private ImageButton tab1Button, tab2Button, tab3Button, tab4Button;
		private TextView tab1Text, tab2Text, tab3Text, tab4Text, headingText;
		private Color selectedColor, deselectedColor;

		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);
			RequestWindowFeature(WindowFeatures.NoTitle);
			SetContentView(Resource.Layout.Main);

			tab1Button=this.FindViewById<ImageButton>(Resource.Id.tab1_icon);
			tab2Button=this.FindViewById<ImageButton>(Resource.Id.tab2_icon);
			tab3Button=this.FindViewById<ImageButton>(Resource.Id.tab3_icon);
			tab4Button=this.FindViewById<ImageButton>(Resource.Id.tab4_icon);

			headingText = this.FindViewById<TextView>(Resource.Id.heading_text);

			tab1Text=this.FindViewById<TextView>(Resource.Id.tab1_text);
			tab2Text=this.FindViewById<TextView>(Resource.Id.tab2_text);
			tab3Text=this.FindViewById<TextView>(Resource.Id.tab3_text);
			tab4Text=this.FindViewById<TextView>(Resource.Id.tab4_text);

			selectedColor = Resources.GetColor(Resource.Color.white);
			deselectedColor = Resources.GetColor(Resource.Color.theme_blue);

			tab1Button.Click += delegate {
				showTab1();
			};

			tab2Button.Click += delegate {
				showTab2();
			};

			tab3Button.Click += delegate {
				showTab3();
			};

			tab4Button.Click += delegate {
				showTab4();
			};
				
			showTab1();

		}

		private void deselectAll()
		{
			tab1Button.SetColorFilter (deselectedColor);
			tab2Button.SetColorFilter (deselectedColor);
			tab3Button.SetColorFilter (deselectedColor);
			tab4Button.SetColorFilter (deselectedColor);

			tab1Text.SetTextColor (deselectedColor);
			tab2Text.SetTextColor (deselectedColor);
			tab3Text.SetTextColor (deselectedColor);
			tab4Text.SetTextColor (deselectedColor);

		}

		private void showFragment (Fragment fragment)
		{
			var ft = FragmentManager.BeginTransaction();
			ft.Replace(Resource.Id.container, fragment);
			ft.Commit();
		}


		private void showTab1()
		{
			deselectAll ();

			headingText.Text="Tab 1";

			tab1Button.SetColorFilter (selectedColor);
			tab1Text.SetTextColor (selectedColor);
			// Make new fragment to show this selection.
			Fragment fragment = FirstFragment.NewInstance();
			// Execute a transaction, replacing any existing
			showFragment(fragment);
		}

		private void showTab2()
		{
			deselectAll ();

			headingText.Text="Tab 2";

			tab2Button.SetColorFilter (selectedColor);
			tab2Text.SetTextColor (selectedColor);
			// Make new fragment to show this selection.
			Fragment fragment = SecondFragment.NewInstance();
			// Execute a transaction, replacing any existing
			showFragment(fragment);
		}

		private void showTab3()
		{
			deselectAll ();

			headingText.Text="Tab 3";

			tab3Button.SetColorFilter (selectedColor);
			tab3Text.SetTextColor (selectedColor);
			// Make new fragment to show this selection.
			Fragment fragment = ThirdFragment.NewInstance();
			// Execute a transaction, replacing any existing
			showFragment(fragment);
		}

		private void showTab4()
		{
			deselectAll ();

			headingText.Text="Tab 4";

			tab4Button.SetColorFilter (selectedColor);
			tab4Text.SetTextColor (selectedColor);
			// Make new fragment to show this selection.
			Fragment fragment = FourthFragment.NewInstance();
			// Execute a transaction, replacing any existing
			showFragment(fragment);
		}
			
	}
}


