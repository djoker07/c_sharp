using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

using Xamarin.Forms;

namespace Master
{
    public partial class TODO : ContentPage
    {
        public TODO()
        {
            InitializeComponent();
        }

        void AddTask(object sender, EventArgs e)
        {
            var newTask = new TODOItem();
            var newPage = new TodoPage();
            newPage.BindingContext = newTask;

            Navigation.PushAsync(newPage);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            ((App)App.Current).ResumeAtTodoId = -1;
            TODOList.ItemsSource = App.Database.GetItems();
        }

        void itemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var todo = (TODOItem)e.SelectedItem;
            var newPage = new TodoPage();
            newPage.BindingContext = todo;

            ((App)App.Current).ResumeAtTodoId = todo.ID;
            Debug.WriteLine("setting resumeAtTodoID = " + todo.ID);

            Navigation.PushAsync(newPage);
        }
    }
}
