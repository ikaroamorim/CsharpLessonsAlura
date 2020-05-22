using Bytebank.Funcionarios;
using Bytebank.Sistemas;
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
      //CalcularBonificacao();
      //UsarSistema();

      /*
       * Tratamento de Exceções
       * */

      try
      {
        MetodoErro();
      }
      catch (Exception erro)
      {
        Console.WriteLine("Mensagem: \n" + erro.Message);
        Console.WriteLine("StackTrace: \n" + erro.StackTrace);
        throw;
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
