using Bytebank.Funcionarios;
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
      ContaCorrente contaGabriela = new ContaCorrente(4679, 37289);

      ContaCorrente contaBruno = new ContaCorrente(4679, 59488);
      Cliente bruno = new Cliente();

      contaBruno.Depositar(500);
      contaGabriela.Depositar(900);
      contaGabriela.Transferencia(200, contaBruno);

      bruno.Nome = "Bruno";
      bruno.Cpf = "123.456.789-00";
      bruno.Profissao = "estudante";
      contaBruno.Titular = bruno;

      Console.WriteLine("Número de constas: " + ContaCorrente.TotalContas);

      // usando os gets e sets criados nas propriedades
      contaBruno.Saldo = -10;
      Console.WriteLine("Saldo da Conta do Bruno: R$" + contaBruno.Saldo);

      GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

      Funcionario carlos = new Funcionario();
      carlos.Nome = "Carlos";
      carlos.Cpf = "123.456.789-00";
      carlos.Salario = 2000;
      gerenciador.Registrar(carlos);


      Funcionario pedro = new Diretor();
      pedro.Nome = "Pedro";
      pedro.Cpf = "123.456.789-00";
      pedro.Salario = 5000;
      gerenciador.Registrar(pedro);

      Console.WriteLine(carlos.Nome + carlos.getBonificacao());
      Console.WriteLine(pedro.Nome + pedro.getBonificacao());
      Console.WriteLine(gerenciador.GetTotalBonificacao());
    }
  }
}
