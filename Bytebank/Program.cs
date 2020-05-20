using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank
{
  class Program
  {
    static void Main(string[] args)
    {
      ContaCorrente contaBruno = new ContaCorrente();
      ContaCorrente contaGabriela = new ContaCorrente();


      contaBruno.Depositar(500);
      contaGabriela.Depositar(900);
      contaGabriela.Transferencia(200, contaGabriela);
    }
  }
}
