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
      Cliente bruno = new Cliente();
      Cliente gabriela = new Cliente();

      contaBruno.Depositar(500);
      contaGabriela.Depositar(900);
      contaGabriela.Transferencia(200, contaBruno);

      bruno.Nome = "Bruno";
      bruno.Cpf = "123.456.789-00";
      bruno.Profissao = "estudante";
      contaBruno.Titular = bruno;
      contaBruno.Numero = 22481122;
      contaBruno.Agencia = 4679;

      

      // usando os gets e sets criados nas propriedades
      contaBruno.Saldo = -10;
      Console.WriteLine("Saldo da Conta do Bruno: R$" + contaBruno.Saldo);
    }
  }
}
