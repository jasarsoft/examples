using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Vjezba_24
{
    public partial class fclsMain : Form
    {
        public fclsMain()
        {
            InitializeComponent();

            //prijava dogadjaja
            this.txtVelicinaFonta.KeyPress += new KeyPressEventHandler(this.txtSize_KeyPress);
            this.txtVelicinaFonta.Validating += new CancelEventHandler(this.txtSize_Validacija);

            this.rtfText.LinkClicked += new LinkClickedEventHandler(this.rtfText_LinkedClick);
        }

        private void btnBold_Click(object sender, EventArgs e)
        {
            Font stariFont;
            Font noviFont;

            //dobijemo font koji se trenutno korisit u izabranom tekstu
            stariFont = this.rtfText.SelectionFont;

            //ako se koristi bold font, onda ga uklonimo
            if (stariFont.Bold)
                noviFont = new Font(stariFont, stariFont.Style & ~FontStyle.Bold);
            else
                noviFont = new Font(stariFont, stariFont.Style | FontStyle.Bold);

            //ubacijemo novi font i vratimo fokus u RichtTextBox kontrolu
            this.rtfText.SelectionFont = noviFont;
            this.rtfText.Focus();
        }

        private void btnItalic_Click(object sender, EventArgs e)
        {
            Font stariFont;
            Font noviFont;

            //dobijemo font koji se trenutno korisit u izabranom tekstu
            stariFont = this.rtfText.SelectionFont;

            //ako je stil koji se koristi je kurziv, onda ga uklanjamo
            if (this.rtfText.SelectionFont.Italic)
                noviFont = new Font(stariFont, stariFont.Style & ~FontStyle.Italic);
            else
                noviFont = new Font(stariFont, stariFont.Style | FontStyle.Italic);

            //ubacijemo novi font i vratimo fokus u RichtTextBox kontrolu
            this.rtfText.SelectionFont = noviFont;
            this.rtfText.Focus();
        }

        private void btnUnderline_Click(object sender, EventArgs e)
        {
            Font stariFont;
            Font noviFont;

            //dobijemo font koji se trenutno korisit u izabranom tekstu
            stariFont = this.rtfText.SelectionFont;

            //ako je stil koji se koristi podvucen onda ga uklanjamo
            if (this.rtfText.SelectionFont.Underline)
                noviFont = new Font(stariFont, stariFont.Style & ~FontStyle.Underline);
            else
                noviFont = new Font(stariFont, stariFont.Style | FontStyle.Underline);

            //ubacijemo novi font i vratimo fokus u RichtTextBox kontrolu
            this.rtfText.SelectionFont = noviFont;
            this.rtfText.Focus();
        }

        private void btnCenter_Click(object sender, EventArgs e)
        {
            if (this.rtfText.SelectionAlignment == HorizontalAlignment.Center)
                this.rtfText.SelectionAlignment = HorizontalAlignment.Left;
            else
                this.rtfText.SelectionAlignment = HorizontalAlignment.Center;

            this.rtfText.Focus();
        }

        private void txtSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            //uklanjamo sve karaktere koji nisu brojevi, backspace ili enter
            if((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 13)
            {
                e.Handled = true;
            }
            else
            {
                //primjenjujemo velicinu ako korisnik pritisne eneter
                TextBox txt = (TextBox)sender;

                if (txt.Text.Length > 0)
                    PrihvatiTextSize(txt.Text);

                e.Handled = true;
                this.rtfText.Focus();
            }
        }

        private void txtSize_Validacija(object sender, CancelEventArgs e)
        {
            TextBox txt = (TextBox)sender;

            PrihvatiTextSize(txt.Text);
            this.rtfText.Focus();
        }

        private void PrihvatiTextSize(string textSize)
        {
            //konvertujemo tekst u float
            float newSize = Convert.ToSingle(textSize);
            FontFamily currentFontFamily;
            Font newFont;

            //konvertujemo novi font iste familije, ali razlicite velicine
            currentFontFamily = this.rtfText.SelectionFont.FontFamily;
            newFont = new Font(currentFontFamily, newSize);

            //podesimo font izabranog teksta na novi font
            this.rtfText.SelectionFont = newFont;
        }

        private void rtfText_LinkedClick(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            //uvitavano tekstu  kontrolu RichTextBox
            try
            {
                rtfText.LoadFile("test.rtf");
            }
            catch (Exception)
            {
                MessageBox.Show("Jos nije ucitan fajl");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //snimamo text
            try
            {
                rtfText.SaveFile("test.rtf");
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
        }
    }
}
