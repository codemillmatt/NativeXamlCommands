using System;
using Xamarin.Forms;
using System.ComponentModel;
using System.Runtime.InteropServices.WindowsRuntime;
namespace NativeXamlCmd
{
	public class NativeXamlCmdViewModel : INotifyPropertyChanged
	{
		public event PropertyChangedEventHandler PropertyChanged;

		INavigation _nav;

		public NativeXamlCmdViewModel(INavigation nav)
		{
			_nav = nav;
			CanShowModal = true;
		}

		bool _canShowModal;
		public bool CanShowModal
		{
			get
			{
				return _canShowModal;
			}
			set
			{
				_canShowModal = value;
				PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CanShowModal)));

				ShowModalCommand.ChangeCanExecute();
			}
		}

		Command _showModal;
		public Command ShowModalCommand
		{
			get
			{
				if (_showModal == null)
				{
					_showModal = new Command(async () =>
					{
						var modalPage = new ModalPage();

						await _nav.PushModalAsync(new NavigationPage(modalPage), true);
					}, () =>
					{
						return CanShowModal;
					});
				}

				return _showModal;
			}
		}
	}
}
