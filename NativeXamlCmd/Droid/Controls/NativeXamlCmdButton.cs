using System;
using Xamarin.Forms;

using Android.Support.Design.Widget;

namespace NativeXamlCmd.Droid
{
	public class NativeXamlCmdButton : FloatingActionButton
	{
		bool canExecute = true;

		public Command Command { get; set; }

		public NativeXamlCmdButton() : base(Forms.Context)
		{
			SetImageResource(Resource.Drawable.ic_add_white_24dp);

			Click += (sender, e) =>
			{
				if (canExecute)
					Command?.Execute(null);
			};


		}

		protected override void OnAttachedToWindow()
		{
			base.OnAttachedToWindow();

			// Respond to changes in whether the command can execute or not
			if (Command != null)
			{
				Command.CanExecuteChanged += (sender, e) =>
				{
					if (Command.CanExecute(null))
					{
						canExecute = true;
						SetImageResource(Resource.Drawable.ic_add_white_24dp);
					}
					else
					{
						SetImageResource(Resource.Drawable.ic_highlight_off_white_24dp);
						canExecute = false;
					}
				};
			}
		}
	}
}
