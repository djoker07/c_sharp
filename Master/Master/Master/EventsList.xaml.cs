using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

using Xamarin.Forms;

namespace Master
{
    public partial class EventsList : ContentPage
    {
        public EventsList()
        {
            InitializeComponent();
        }

        void AddEvent(object sender, EventArgs e)
        {
            var temp = new EventItem();
            var newPage = new EventPage();
            newPage.BindingContext = temp;

            Navigation.PushAsync(newPage);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            ((App)App.Current).ResumeAtTodoId = -1;
            eventList.ItemsSource = App.Database.GetEventItems();
        }

        void itemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var temp = (EventItem)e.SelectedItem;
            var newPage = new EventPage();
            newPage.BindingContext = temp;

            ((App)App.Current).ResumeAtTodoId = temp.ID;
            Debug.WriteLine("setting resumeAtTodoID = " + temp.ID);

            Navigation.PushAsync(newPage);
        }
    } 
}
