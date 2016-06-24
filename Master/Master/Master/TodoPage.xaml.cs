using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Master
{
    public partial class TodoPage : ContentPage
    {
        public TodoPage()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, true);
        }

        void saveClicked(object sender, EventArgs e)
        {
            var todo = (TODOItem)BindingContext;
            App.Database.SaveItem(todo);
            this.Navigation.PopAsync();
        }

        void deleteClicked(object sender, EventArgs e)
        {
            var todo = (TODOItem)BindingContext;
            App.Database.DeleteItem(todo.ID);
            this.Navigation.PopAsync();
        }

        void cancelClicked(object sender, EventArgs e)
        {
            var todo = (TODOItem)BindingContext;
            this.Navigation.PopAsync();
        }

    }
}
