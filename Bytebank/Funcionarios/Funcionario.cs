using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank.Funcionarios
{
  class Funcionario
  {
    public string Nome { get; set; }
    public string Cpf { get; set; }
    public double Salario { get; set; }

    public virtual double getBonificacao()
    {
      return 0.1 * Salario;
    }

  }
}
