using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Todo.Model
{
    public class ToDoItem
    {
        public TimeSpan Time {get;set;}
        public string Note { get; set; }
        public Color NeedToDo
        {
            get
            {
                if ((Time - DateTime.Now.TimeOfDay).TotalMinutes > 30)
                {
                    return Color.DarkGreen;
                }
                else
                {
                    return Color.DarkRed;
                }
            }
        }

    }
}
