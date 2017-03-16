using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NativeXamlCmd
{
	[XamlCompilation(XamlCompilationOptions.Skip)]
	public partial class NativeXamlCmdPage : ContentPage
	{
		public NativeXamlCmdPage()
		{
			InitializeComponent();

			BindingContext = new NativeXamlCmdViewModel(Navigation);
		}
	}
}
