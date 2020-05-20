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
    public Cliente Titular { get; set; }
    public int Agencia { get; set; }
    public int Numero { get; set; }
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

    public bool Sacar(double valor)
    {
      if (_saldo >= valor && valor > 0)
      {
        _saldo -= valor;
        Console.WriteLine("Realizado saque de R$" + valor + ".");
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
