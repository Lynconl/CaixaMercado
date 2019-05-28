using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaixaMercado
{
    public partial class FormCaixa : Form
    {
        //Este bool serve para separar o primeiro registro dos demais.
        public static bool Marcador = false;
        int Cod, x=0;
        
        public FormCaixa()
        {
            InitializeComponent();
        }
        
        private void bttnInserir_Click(object sender, EventArgs e)
        {
            //Verificar se foi inserido o codigo do produto
            if(txtBxCodProduto.Text == "")
            {
                MessageBox.Show("Favor inserir um código de produto", "Atenção");
                txtBxCodProduto.Focus();
            }
            else
            {
                //Verificar se existe registro no sistema
                if (FormCadastro.Map.Count == 0)
                {
                    MessageBox.Show("Nenhum produto no sistema, favor cadastrar!", "Atenção");
                    txtBxCodProduto.Clear();
                    txtBxCodProduto.Focus();
                }
                else
                {
                    //Transfere o valor inserido para a variavel: Cod
                    Cod = Convert.ToInt32(txtBxCodProduto.Text);
                    //Adiciona linha ao Grid                    
                    dataGridViewCaixa.Rows.Add();
                    //Muda a cor de fundo do Grid
                    dataGridViewCaixa.RowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
                    //Transfere os valores ao Grid com base no codigo do produto ( Cod )
                    dataGridViewCaixa.Rows[x].Cells[0].Value = FormCadastro.Map[Cod].Codigo;
                    dataGridViewCaixa.Rows[x].Cells[1].Value = FormCadastro.Map[Cod].Nome;
                    dataGridViewCaixa.Rows[x].Cells[2].Value = "R$ " + FormCadastro.Map[Cod].Preco.ToString("N2");
                    dataGridViewCaixa.Rows[x].Cells[3].Value = numericUDQtde.Value.ToString() + " UN.";
                    dataGridViewCaixa.Rows[x].Cells[4].Value = "R$ " + (FormCadastro.Map[Cod].Preco * Convert.ToDouble(numericUDQtde.Value)).ToString("N2");
                    double Total= 0;
                    //Faz a soma do total em R$ de produtos inseridos no Grid
                    for (int i = 0; i <= x; i++)
                    {
                        Total += Convert.ToDouble(dataGridViewCaixa.Rows[i].Cells[4].Value.ToString().Substring(3));
                        lblQtdeTotal.Text = "R$ " + Total.ToString("N2");
                    }
                    //Para ir para proxima linha do Grid
                    x++;
                }
            }
            //Limpa o registro anterior e da o foco ao field em questão
            txtBxCodProduto.Clear();
            txtBxCodProduto.Focus();
            
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult Resultado = MessageBox.Show("Deseja mesmo excluir todos os registros?",
                "Atenção..", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (Resultado == DialogResult.Yes)
            {
                FormCadastro.Map.Clear();
            }
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Abrir o FormCadastro para inserir novos registros no sistema
            FormCadastro Abrir = new FormCadastro();
            Abrir.ShowDialog();
        }
    }
}
