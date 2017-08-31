using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VirtualMethods
{
    public class Control
    {
        //ovi clanovi su zasticeni i zbog toga vidljivi metodama izvedene klase
        protected int top;
        protected int left;

        //konstruktor uzima dvije cjelobrojne vrijednosti za fiksiranje lokacije na konzoli
        public Control(int top, int left)
        {
            this.top = top;
            this.left = left;
        }

        //simulira iscrtavanje prozora
        public virtual void DrawWindow()
        {
            Console.WriteLine("Control: drawing control at {0}, {1}", top, left);
        }
    }

    //ListBox izvodi iz Control klase
    public class ListBox : Control
    {
        private string listboxContents; //nova vrijabla clanica

        //kontruktor dodaje prametar    
        public ListBox(int top, int left, string contents) : base (top, left) //poziva osnovni kontruktor
        {
            listboxContents = contents;
        }

        //premoscena inacnica (pogledajte kljucnu rijec) jer u
        //izvedenoj metodi mijenjamo ponasanje
        public override void DrawWindow()
        {
            base.DrawWindow(); //poziva osnovnu metodu
            Console.WriteLine("Writing string to listbox: {0}", listboxContents);
        }
    }

    public class Button : Control
    {
        public Button(int top, int left) : base (top, left)
        {

        }

        //premoscena inacnica (pogledaj kljucnu rijec) jer u
        //izvedenoj metodi mijenjamo ponasanje
        public override void DrawWindow()
        {
            //base.DrawWindow();
            Console.WriteLine("Drawing a button at {0}, {1}", top, left);
        }
    }

    class Program
    {
        static void Main()
        {
            Control win = new Control(1, 2);
            ListBox lb = new ListBox(3, 4, "Stand alone list box");
            Button b = new Button(5, 6);

            win.DrawWindow();
            lb.DrawWindow();
            b.DrawWindow();

            Control[] winArray = new Control[3];
            winArray[0] = new Control(1, 2);
            winArray[1] = new ListBox(3, 4, "List box in array");
            winArray[2] = new Button(5, 6);

            for (int i = 0; i < 3; i++)
            {
                winArray[i].DrawWindow();
            }
        }
    }
}
