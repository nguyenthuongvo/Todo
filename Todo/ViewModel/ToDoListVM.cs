using System;
using System.Collections.Generic;
using System.Text;
using Todo.Model;
using System.Collections.ObjectModel;
namespace Todo.ViewModel
{
    public class ToDoListVM
    {
        public ObservableCollection<ToDoItem> ToDoList { get; set; } = new ObservableCollection<ToDoItem>();
        public ToDoListVM()
        {

        }

        public void AddToDoItem(ToDoItem item)
        {
            ToDoList.Add(item);
            App.Current.Resources["isVisibleList"] = ToDoList.Count > 0;
            App.Current.Resources["isVisibleNoItem"] = ToDoList.Count == 0;
        }

        public void DeleteItem(ToDoItem item)
        {
            ToDoList.Remove(item);
            App.Current.Resources["isVisibleList"] = ToDoList.Count > 0;
            App.Current.Resources["isVisibleNoItem"] = ToDoList.Count == 0;
        }
    }
}
