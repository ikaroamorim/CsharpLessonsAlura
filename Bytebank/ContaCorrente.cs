using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank
{
  public class ContaCorrente
  {
    public static double TaxaOperacao { get; private set; }
    public static int TotalContas { get; private set; }
    public Cliente Titular { get; set; }


    //Os campos Número  e Agencia estão definidos da mesma forma, o compilador faz com que ambos se comportem da mesma forma
    private readonly int _agencia;
    public int Agencia { get;}
        
    public int Numero { get;}
    
    // quando for expandir precisa dessa estrutura
    private double _saldo;
    public double Saldo
    {
      get
      {
        return _saldo;
      }
      set
      {
        if (value < 0)
        {
          return;
        }
        else
        {
          _saldo = value;
        }
      }
    }

    public ContaCorrente(int agencia, int numero)
    {
      _agencia = agencia;
      _numero = numero;
      TaxaOperacao = 30 / TotalContas;

      TotalContas++;
    }

    public bool Sacar(double valor)
    {
      if (_saldo >= valor && valor > 0)
      {
        _saldo -= valor;
        Console.WriteLine("Realizado saque de R$" + valor + ". \n Seu novo saldo é R$ " + Saldo);
        return true;
      }
      else
      {
        Console.WriteLine("Valor maior que saldo ou inválido");
        return false;
      }
    }

    public void Depositar(double valor)
    {
      if (valor >= 0)
      {
        _saldo += valor;
        Console.WriteLine("Deposito realizado com sucesso");
      }
      else
      {
        Console.WriteLine("Valor inválido");
      }
    }

    public bool Transferencia(double valor, ContaCorrente contaDestino)
    {
      if (_saldo >= valor && valor > 0)
      {
        Sacar(valor);
        contaDestino.Depositar(valor);
        return true;
      }
      else
      {
        Console.WriteLine("Saldo insuficiente ou informações incorretas");
        return false;
      }

    }
  }
}
