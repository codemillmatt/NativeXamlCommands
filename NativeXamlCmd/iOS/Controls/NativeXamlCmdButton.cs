using System;
using Xamarin.Forms;

namespace NativeXamlCmd.iOS
{
public class NativeXamlCmdButton : FabButton
{
	public Command Command { get; set; }

	public NativeXamlCmdButton()
	{
		ButtonPressed += (sender, e) =>
		{
			Command?.Execute(null);
		};
	}
}
}
