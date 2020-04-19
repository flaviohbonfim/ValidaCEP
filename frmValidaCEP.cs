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

namespace ValidaCEP
{
    public partial class frmValidaCEP : Form
    {
        public frmValidaCEP()
        {
            InitializeComponent();
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var cepClient = RestService.For<ICepApiService>("http://viacep.com.br");
                var address = await cepClient.GetAddressAsync(txtCEP.Text);
                txtLogradouro.Text = address.Logradouro;
                txtComplemento.Text = address.Complemento;
                txtBairro.Text = address.Bairro;
                txtLocalidade.Text = address.Localidade;
                txtEstado.Text = address.UF;
                txtIBGE.Text = address.Ibge;
                txtGia.Text = address.Gia;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao consultar CEP: " + ex.Message, "Erro", MessageBoxButtons.OK);
            }
        }
    }
}
