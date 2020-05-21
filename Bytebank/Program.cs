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
      /*ContaCorrente contaGabriela = new ContaCorrente(4679, 37289);

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

      Funcionario carlos = new Funcionario("123.456.789 - 00",2000);
      carlos.Nome = "Carlos";
      
      gerenciador.Registrar(carlos);


      Funcionario pedro = new Diretor("123.456.789 - 00",5000);
      pedro.Nome = "Pedro";
      gerenciador.Registrar(pedro);

      Console.WriteLine(carlos.Nome + carlos.getBonificacao());
      Console.WriteLine(pedro.Nome + pedro.getBonificacao());
      Console.WriteLine(gerenciador.GetTotalBonificacao());

      Console.WriteLine(carlos.Salario + "antes do aumento" );
      carlos.AumentarSalario();
      Console.WriteLine(carlos.Salario + "depois do aumento");*/

      CalcularBonificacao();
    }

    public static void CalcularBonificacao()
    {
      GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

      Auxiliar alexandre = new Auxiliar("123.456.789-77");
      alexandre.Nome = "alexandre";
      gerenciador.Registrar(alexandre);
      Designer beatriz = new Designer("123.456.789-77");
      beatriz.Nome = "beatriz";
      beatriz.AumentarSalario();
      gerenciador.Registrar(beatriz);
      Diretor carlos = new Diretor("123.456.789-77");
      carlos.Nome = "carlos";
      gerenciador.Registrar(carlos);
      GerenteConta denis = new GerenteConta("123.456.789-77");
      denis.Nome = "denis";
      gerenciador.Registrar(denis);

      Console.WriteLine("Total de bonificações do mês: R$" + gerenciador.GetTotalBonificacao());


    }
  }
}
