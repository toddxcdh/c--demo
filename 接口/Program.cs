using System;

namespace 接口
{
    class Program : IControl
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public void Paint() { }
        
    }
    interface IControl
    {
        void Paint();
    }
    interface ITextBox : IControl
    {
        void SetText(string text);
    }
    interface IListBox : IControl
    {
        void SetItems(string[] items);
    }
    interface IComboBox : ITextBox, IListBox { }
   
}
