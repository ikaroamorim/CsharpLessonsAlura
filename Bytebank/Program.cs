using Bytebank.Funcionarios;
using Bytebank.Sistemas;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank
{
  class Program
  {
    static void Main(string[] args)
    {
      CarregarContas();

    }


    private static void CarregarContas()
    {
      using (LeitordeArquivo leitor = new LeitordeArquivo("contas.txt"))
      {
        leitor.LerProximaLinha();
      }


      //
      //--------------------
      //
      //LeitordeArquivo leitor = null;
      //try
      //{
      //  leitor = new LeitordeArquivo("contas.txt");
      //  leitor.LerProximaLinha();
      //  leitor.LerProximaLinha();
      //  leitor.LerProximaLinha();
      //}
      //catch (IOException)
      //{
      //  Console.WriteLine("Exceção do tipo IO não tratada!");
      //  throw;
      //}
      //finally
      //{
      //  if (leitor != null)
      //    leitor.Fechar();
      //}

    }

    private static void TestaInnerException()
    {
      try
      {
        ContaCorrente c1 = new ContaCorrente(2222, 99999);
        ContaCorrente c2 = new ContaCorrente(3333, 77777);
        c1.Depositar(50);
        c2.Depositar(50);
        c1.Transferir(500, c2);
      }
      catch (ArgumentException e)
      {
        Console.WriteLine("Exceção de argumento");
        Console.WriteLine(e.Message);
        Console.WriteLine(e.StackTrace);

      }
      catch (OperacaoFinanceiraException e)
      {
        Console.WriteLine("Exceção de saldo");
        Console.WriteLine(e.Message);
        Console.WriteLine(e.StackTrace);
        Console.WriteLine("Inner exception" + e.InnerException);
      }
      catch (Exception e)
      {
        Console.WriteLine(e.Message);
        Console.WriteLine(e.StackTrace);

      }
    }


    public static void MetodoErro()
    {
      TestaDivisao(0);
    }
    public static void TestaDivisao(int divisor)
    {
      int resultado = Dividir(10, divisor);
    }
    public static int Dividir(int numero, int divisor)
    {
      try
      {
        return numero / divisor;
      }
      catch (DivideByZeroException)
      {
        Console.WriteLine("Erro na divisão de: " + numero + " por: " + divisor);
        throw;
      }


    }

    /*
     * Fim do teste de Exceções
     * */

    public static void UsarSistema()
    {
      SistemaInterno sistemaInterno = new SistemaInterno();

      Diretor carlos = new Diretor("123.456.789-77");
      carlos.Nome = "carlos";
      carlos.Senha = "123";

      GerenteConta denis = new GerenteConta("123.456.789-77");
      denis.Nome = "denis";
      denis.Senha = "456aa";

      ParceiroComercial eduardo = new ParceiroComercial();
      eduardo.Senha = "213";


      sistemaInterno.Logar(carlos, "123");
      sistemaInterno.Logar(carlos, "321");

      sistemaInterno.Logar(denis, "456aa");
      sistemaInterno.Logar(denis, "321");

      sistemaInterno.Logar(eduardo, "321");
      sistemaInterno.Logar(eduardo, "213");
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
