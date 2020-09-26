using System;
using Todo.View;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Todo
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new NavigationPage(new ToDoList());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
