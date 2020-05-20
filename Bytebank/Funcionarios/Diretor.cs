using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank.Funcionarios
{
  class Diretor : Funcionario
  {
    public override double getBonificacao()
    {
      return Salario + base.getBonificacao();
    }
  }
}
