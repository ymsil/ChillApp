using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ChillApp.Pages
{
	public partial class WelcomePage : ContentPage
	{
		public WelcomePage()
		{
			InitializeComponent();
		}

	    private void SignInButton_OnPressed(object sender, EventArgs e)
	    {
	        ChillApp.Pages.SignInPage sign_in_page = new ChillApp.Pages.SignInPage();
	    }
	}
}
