using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ByteBank
{
  public class ContaCorrente
  {
    public Cliente titular;
    public int agencia;
    public int numero;
    private double saldo;

    public double GetSaldo()
    {
      return saldo;
    }

    public void SetSaldo(double saldo)
    {
      if (saldo < 0)
      {
        return;
      }
      else
      {
        this.saldo = saldo;
      }
    }

    public bool Sacar(double valor)
    {
      if (saldo >= valor && valor > 0)
      {
        saldo -= valor;
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
        saldo += valor;
        Console.WriteLine("Deposito realizado com sucesso");
      }
      else
      {
        Console.WriteLine("Valor inválido");
      }
    }

    public bool Transferencia(double valor, ContaCorrente contaDestino)
    {
      if (saldo >= valor && valor > 0)
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
