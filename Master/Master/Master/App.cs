using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

using Xamarin.Forms;

namespace Master
{
    public class App : Application
    {
        static TodoDatabase database;

        public App()
        {
            // The root page of your application
            var tabs = new TabbedPage();

            tabs.Children.Add(createTodoPage());
            tabs.Children.Add(createEventsPage());

            MainPage = tabs;

        }

        private Page createEventsPage()
        {
            var button = new Button { Text = "button1" };
            var page = new EventsList();

            NavigationPage.SetHasNavigationBar(page, true);
            var navPage = new NavigationPage(page) { Title = "Events" } ;

            button.Clicked += (s, e) => navPage.PushAsync(new EventsList());
            return navPage;
        }

        private Page createTodoPage()
        {
            var button = new Button { Text = "button1" };
            var page = new TODO();

            NavigationPage.SetHasNavigationBar(page, true);
            var navPage = new NavigationPage(page) { Title = "TODOs" };

            button.Clicked += (s, e) => navPage.PushAsync(new TODO());
            return navPage;
        }



        public static TodoDatabase Database
        {
            get
            {
                if(database == null)
                {
                    database = new TodoDatabase();
                }
                return database;
            }
        }

        public int ResumeAtTodoId { get; set; }

        protected override void OnStart()
        {
            // Handle when your app starts


        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps

        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
