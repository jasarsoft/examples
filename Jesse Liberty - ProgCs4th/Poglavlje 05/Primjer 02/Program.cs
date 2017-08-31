using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AbstractMethods
{
    abstract public class Control
    {
        protected int top;
        protected int left;

        //konstruktor uzima dvije cjelobrojne vrijednosti za fiksiranje lokacije na konzoli
        public Control(int top, int left)
        {
            this.top = top;
            this.left = left;
        }

        //simulira iscrtavanje prozora
        //napomena: nema implementacije
        abstract public void DrawWindow();
    }

    //ListBox izvodi iz Control klase
    public class ListBox : Control
    {
        private string listboxContents; //nova vrijabla clanica

        //kontruktor dodaje prametar    
        public ListBox(int top, int left, string contents) : base(top, left) //poziva osnovni kontruktor
        {
            listboxContents = contents;
        }

        //premoscena inacnica implementira abstrktnu metodu
        public override void DrawWindow()
        {
            Console.WriteLine("Writing string to listbox: {0}", listboxContents);
        }
    }

    public class Button : Control
    {
        public Button(int top, int left) : base(top, left)
        {
            
        }

        //implementira bastraktnu metodu
        public override void DrawWindow()
        {
            Console.WriteLine("Drawing a button at {0}, {1}", top, left);
        }
    }

    class Program
    {
        static void Main()
        {
            Control[] winArray = new Control[3];
            winArray[0] = new ListBox(1, 2, "First List box");
            winArray[1] = new ListBox(3, 4, "Second list box");
            winArray[2] = new Button(5, 6);

            for (int i = 0; i < 3; i++)
            {
                winArray[i].DrawWindow();
            }
        }
    }
}
