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


    //Os campos Número  e Agencia estão equivalentes, o compilador faz com que ambos se comportem da mesma forma
    private readonly int _agencia;
    public int Agencia { get; }

    public int Numero { get; }

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
      if (agencia <= 0)
      {
        throw new ArgumentException("Número de Agencia inválido.", nameof(agencia));
      }
      if (numero <= 0)
      {
        throw new ArgumentException("Número da conta inválido.", nameof(numero));
      }
      else
      {
        _agencia = agencia;
        Numero = numero;
        TotalContas++;
        TaxaOperacao = 30 / TotalContas;
      }

    }

    public void Sacar(double valor)
    {
      if (valor <= 0)
      {
        throw new ArgumentException();
      }
      if (_saldo <= valor)
      {
        throw new SaldoInsuficienteException("Saldo insuficiente para o saque de: R$ " + valor + ".");
      }
      else
      {
        Console.WriteLine("Realizado saque de R$" + valor + ". \n Seu novo saldo é R$ " + Saldo);
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
