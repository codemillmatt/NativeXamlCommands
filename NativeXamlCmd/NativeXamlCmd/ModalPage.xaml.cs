using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace NativeXamlCmd
{
	public partial class ModalPage : ContentPage
	{
		public ModalPage()
		{
			InitializeComponent();
		}

		async void Handle_Activated(object sender, System.EventArgs e)
		{
			await Navigation.PopModalAsync(true);
		}
	}
}
