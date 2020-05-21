using Bytebank.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank.Sistemas
{
  public abstract class Autenticavel : Funcionario
  {
    public string Senha { get; set; }

    public Autenticavel(double salario, string cpf): base(cpf, salario)
    {

    }

    public bool Autenticar(string senha)
    {
      return senha == Senha;
    }
  }
}
