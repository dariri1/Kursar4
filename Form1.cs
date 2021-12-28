using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

/*
  if условие1 
  then команды1 
    else if условие2 then команды2
    else if условие3 then команды3
        ... 
          else if условиеN-1 then командыN-1
            else командыN end;
 */

namespace Conventer_Valut{
    public partial class Form1 : Form{
    public Form1(){
         InitializeComponent();
         listBox1.SelectedIndex = 0;//значення будуть на 0
         listBox2.SelectedIndex = 1;//значення будуть на 1
         }
           public void button1_Click(object sender, EventArgs e){
           MessageBox.Show("Для користування програмою потрібен інтернет.");
           if (listBox1.SelectedItem.ToString() == listBox2.SelectedItem.ToString())
           {//прирівнюємо, для помилки
           MessageBox.Show("Одна й та же валюта.");
           }
           else if(textBox1.Text==""){//якщо в головноту текстбоксі пусто
           MessageBox.Show("Введіть кількість валюти для транзакції.");
           }
           else{
           MessageBox.Show("Конвертер працює.");
           webBrowser1.Navigate("http://griven.com.ua/сколько/" + textBox1.Text + "_" + listBox1.SelectedItem.ToString() + "_в_" + listBox2.SelectedItem.ToString()); // беремо сайт і трохи воображенія
           }
           
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void webBrowser2_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            
        
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void webBrowser3_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

    }
}
