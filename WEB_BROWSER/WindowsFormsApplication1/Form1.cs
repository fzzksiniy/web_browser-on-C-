using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int i = 0;
        WebBrowser web = new WebBrowser();
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            web.Visible = true;
            web.ScriptErrorsSuppressed = true;
            web.Dock = DockStyle.Fill;
            web.DocumentCompleted += Web_DocumentCompleted;
            tabControl1.TabPages.Add("Новая вкладка " + i);
            tabControl1.SelectTab(i);
            tabControl1.SelectedTab.Controls.Add(web);
            i += 1;
        }

        private void Web_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            tabControl1.SelectedTab.Text = ((WebBrowser)tabControl1.SelectedTab.Controls[0]).DocumentTitle;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null)
            {
                ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate(textBox1.Text);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            web.Visible = true;
            web.ScriptErrorsSuppressed = true;
            web.Dock = DockStyle.Fill;
            web.DocumentCompleted += Web_DocumentCompleted;
            tabControl1.TabPages.Add("Новая вкладка");
            tabControl1.SelectTab(i);
            tabControl1.SelectedTab.Controls.Add(web);
            i += 1;
            ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate("ya.ru");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ((WebBrowser)tabControl1.SelectedTab.Controls[0]).GoBack();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ((WebBrowser)tabControl1.SelectedTab.Controls[0]).GoForward();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Refresh();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate("ya.ru");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Count > 1)
            {
                tabControl1.TabPages.RemoveAt(tabControl1.SelectedIndex);
                tabControl1.SelectTab(tabControl1.TabPages.Count - 1);
                i -= 1;
            }
            else
                Application.Exit();
        }

        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate(textBox1.Text);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Favourites fav = new Favourites();
            fav.Show(); 
        }
    }
}
