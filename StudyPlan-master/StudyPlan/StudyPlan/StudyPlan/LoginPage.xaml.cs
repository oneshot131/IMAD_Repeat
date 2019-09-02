using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Data;

namespace StudyPlan
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

       

        private void btnLogin_Clicked(object sender, EventArgs e)
        {
            bool isUserEmpty =
                string.IsNullOrEmpty(entryUsername.Text);
            bool isPassEntry =
                string.IsNullOrEmpty(entryPassword.Text);

            if (isUserEmpty || isPassEntry)
            {

            }
            else
            {
                //all conditions met to navigate forward
                Navigation.PushAsync(new HomePage());

            }
        }

        private void btnNotRegistered_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Registration());
        }
        
    }
}
