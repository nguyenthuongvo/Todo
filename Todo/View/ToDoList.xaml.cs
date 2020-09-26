using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Todo.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Todo.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ToDoList : ContentPage
    {
        private ToDoListVM vm;
        public ToDoList()
        {
            NavigationPage.SetHasBackButton(this, false);
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();

            InitUI();

            InitEvent();
        }

        public void InitUI()
        {
            vm = new ToDoListVM();
            BindingContext = vm;

        }

        private void InitEvent()
        {

            var tapGestureRecognizer = new TapGestureRecognizer();
            tapGestureRecognizer.Tapped += async (s, e) => {
                 await Navigation.PushAsync(new ToDoAdding(vm));
            };
            btnAdd.GestureRecognizers.Add(tapGestureRecognizer);

        }

        private void DeleteButtonClicked(object sender, EventArgs e)
        {
            var todoItem = ((Xamarin.Forms.Button)sender).BindingContext as Model.ToDoItem;
            vm.DeleteItem(todoItem);

            Toast.MakeText(Android.App.Application.Context, "Item [" + todoItem.Note +  "] has been deleted", ToastLength.Long).Show();
        }
    }
}