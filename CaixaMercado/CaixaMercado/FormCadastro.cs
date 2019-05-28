using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CaixaMercado
{
    public partial class FormCadastro : Form
    {        
        public static Dictionary<int, ClassCadastro> Map = new Dictionary<int, ClassCadastro>();
        

        public FormCadastro()
        {            
            InitializeComponent();
            
        }
                
        private void bttnCadastrar_Click(object sender, EventArgs e)
        {
            txtBxNomeProduto.Focus();
            double PrecoProduto = Convert.ToDouble(txtBxValor.Text);
            string NomeProduto = txtBxNomeProduto.Text;
                       
            if (!Regex.IsMatch(NomeProduto, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("Campo nome aceita apenas letras!", "Aviso");
                txtBxNomeProduto.Clear();
                if(Regex.IsMatch(txtBxValor.Text, @"^[0-9]+[.[0-9]+]?"))
                {
                    MessageBox.Show("Campo Preço em formato incorreto!", "Aviso");
                    txtBxValor.Clear();
                }
            }
            else
            {
                ClassCadastro Lancar = new ClassCadastro();
                if (!FormCaixa.Marcador)
                {                    
                    Lancar.Nome = NomeProduto;                   
                    Lancar.Preco = PrecoProduto;
                    Lancar.Codigo = 1;
                    txtBxCodigoProduto.Text = "1";
                    
                    Map.Add(1, Lancar);
                    DialogResult Resultado = MessageBox.Show("Código: " + txtBxCodigoProduto.Text + "\n" + "Deseja cadastrar um novo produto?",
                        "Cadastro Concluído..",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (Resultado == DialogResult.Yes)
                    {
                        txtBxCodigoProduto.Clear();
                        txtBxNomeProduto.Clear();
                        txtBxValor.Clear();
                        txtBxNomeProduto.Focus();

                        FormCaixa.Marcador = true;
                    }
                    else
                    {
                        Close();

                    }
                }
                else
                {
                    if (!Map.Any(r => r.Value.Nome == NomeProduto))
                    {
                        Lancar.Nome = NomeProduto;
                    }
                    else
                    {
                        MessageBox.Show("Nome já cadastrado!", "Aviso");
                        txtBxNomeProduto.Clear();
                    }
                    //Colocar o preco do produto
                    Lancar.Preco = PrecoProduto;
                      
                    //Colocar o codigo do produto
                    int Final = Map.Count;
                    Lancar.Codigo = Convert.ToInt16(Map[Final].Codigo) + 1;
                    Map.Add(Lancar.Codigo, Lancar);
                    txtBxCodigoProduto.Text = Lancar.Codigo.ToString();                    

                    DialogResult Resultado = MessageBox.Show("Código: " + txtBxCodigoProduto.Text + "\n" + "Deseja cadastrar um novo produto?",
                        "Cadastro Concluído..",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                    if (Resultado == DialogResult.Yes)
                    {
                        txtBxCodigoProduto.Clear();
                        txtBxNomeProduto.Clear();
                        txtBxValor.Clear();
                        txtBxNomeProduto.Focus();
                    }
                    else
                    {
                        Close();

                    }
                }
            }
            
        }
    }
}
