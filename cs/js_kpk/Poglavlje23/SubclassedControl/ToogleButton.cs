using System;
using System.Drawing;
using System.Windows.Forms;

namespace SubclassedControl
{
    public class ToogleButton : CheckBox
    {
        private string checkedText;
        private string uncheckedText;
        private Color checkedColor;
        private Color uncheckedColor;

        public ToogleButton()
        {
            this.Appearance = Appearance.Button;
            this.checkedText = "Checked";
            this.uncheckedText = "Unchecked";
            this.checkedColor = Color.Gray;
            this.uncheckedColor = this.BackColor;
        }

        public string CheckedText
        {
            get { return checkedText; }
            set { checkedText = value; }
        }

        public string UncheckedText
        {
            get { return uncheckedText; }
            set { checkedText = value; }
        }

        public Color CheckedColor
        {
            get { return checkedColor; }
            set { checkedColor = value; }
        }

        public Color UncheckedColor
        {
            get { return uncheckedColor; }
            set { uncheckedColor = value; }
        }

        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            if(this.Checked)
            {
                this.Text = this.checkedText;
                this.BackColor = this.checkedColor;
            }
            else
            {
                this.Text = this.uncheckedText;
                this.BackColor = this.uncheckedColor;
            }
        }
    }
}
