using Refit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BuscaCEPWF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void mask_Leave(object sender, EventArgs e)
        {
            BuscarCep(mask.Text);
        }

        async Task BuscarCep(string cep)
        {
            try
            {

                var cepbuscar = RestService.For<ICepApiService>("https://viacep.com.br/");
                var endereco = await cepbuscar.GetAddressAsync(cep);

                txtLogradouro.Text = endereco.Logradouro;
                txtBairro.Text = endereco.Bairro;
                txtComplemento2.Text = endereco.Complemento;
                txtMunicipio.Text = endereco.Localidade;
                txtEstado.Text = endereco.Uf;

            }

            catch (Exception e)
            {
                MessageBox.Show("Falha! \n " + e.Message);
            }


            
        }


        
    }
}
