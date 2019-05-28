using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaixaMercado
{
    public class ClassCadastro
    {
        private string nome;
        private int codigo;        
        private double preco;

        public string Nome { get => nome; set => nome = value; }
        public int Codigo { get => codigo; set => codigo = value; }
        public double Preco { get => preco; set => preco = value; }       
    }
}
