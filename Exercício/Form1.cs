using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercício
{
    public partial class frmModelo : Form
    {
        int[] id = new int[10];
        int j = 1;
        string nome;
        ListViewItem listitem;          

        public frmModelo()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox_id.Text = Convert.ToString("00" + j);
            textBox_id.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox_nome.Text == "")
            {
                MessageBox.Show("Digite um nome!!");
            }
            else
            {
                nome = textBox_nome.Text;
                listitem = listView_Data.Items.Add(textBox_id.Text);
                listitem.SubItems.Add(nome);
                textBox_nome.Text = "";
                j++;
                textBox_id.Text = Convert.ToString("00" + j);
            }            
        }

        private void btn_Sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
