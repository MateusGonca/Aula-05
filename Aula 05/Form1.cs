using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula_05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Time obj;
        Time[] v = new Time[10];
        int i = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            //Time timinho = new Time("Atibaia FC", "Brasil", "SP", 12);
            //MessageBox.Show("Nome:" + timinho.Nome + "\nPais: " + timinho.Pais + "\nEstado: " + timinho.Estado +
            //        "\nTitulos" + timinho.Titulo);
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            obj = new Time();   
            obj.Nome = txtNome.Text;
            obj.Pais = txtPais.Text;
            obj.Estado = txtEstado.Text;
            obj.Titulo = Convert.ToInt32(txtTitulo.Text);
            i = 9;
        }


        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            for (i = 0; i < 10; i++)
            {
                if (v[i].Nome.Equals(txtNome.Text))
                {
                    txtEstado.Text = v[i].Estado;
                    txtPais.Text = v[i].Pais;
                    txtTitulo.Text = v[i].Titulo.ToString();
                    i = 0;
                }
                else
                {
                    if (i == 9) MessageBox.Show("Time não encontrado!");
                }
            }
        }
    }
}
