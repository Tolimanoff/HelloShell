using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloShell
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Dogs : ContentPage
	{
		public Dogs ()
		{
			InitializeComponent ();
		}
	}
}