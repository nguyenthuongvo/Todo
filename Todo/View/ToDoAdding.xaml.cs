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
    public partial class ToDoAdding : ContentPage
    {
        private ToDoListVM vm;
        public ToDoAdding(ToDoListVM vm)
        {
            NavigationPage.SetHasBackButton(this, false);
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
            this.vm = vm;
            App.Current.Resources["ThemeColor"] = Color.Green;
            InitUI();
            InitEvent();
        }

        public void InitUI()
        {
            tpTime.Time = DateTime.Now.TimeOfDay;
        }

        public void InitEvent()
        {
            btnBack.Clicked += async delegate
            {
                await Navigation.PopAsync();
            };

            btnSave.Clicked += async delegate
            {
                vm.AddToDoItem(new Model.ToDoItem() { Time = tpTime.Time, Note = edNote.Text });
                await Navigation.PopAsync();
            };
        }
    }
}