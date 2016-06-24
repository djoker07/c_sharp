using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Master
{
    public partial class EventPage : ContentPage
    {
        public EventPage()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, true);
        }

        void saveClicked(object sender, EventArgs e)
        {
            var tempEvent = (EventItem)BindingContext;
            App.Database.SaveEventItem(tempEvent);
            this.Navigation.PopAsync();
        }

        void deleteClicked(object sender, EventArgs e)
        {
            var tempEvent = (EventItem)BindingContext;
            App.Database.DeleteEventItem(tempEvent.ID);
            this.Navigation.PopAsync();
        }

        void cancelClicked(object sender, EventArgs e)
        {
            var tempEvent = (EventItem)BindingContext;
            this.Navigation.PopAsync();
        }
    }
}
