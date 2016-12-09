using Xamarin.Forms;

namespace NativeXamlCmd
{
	public partial class NativeXamlCmdPage : ContentPage
	{
		public NativeXamlCmdPage()
		{
			InitializeComponent();

			BindingContext = new NativeXamlCmdViewModel(Navigation);
		}
	}
}
