using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank
{
  public class SaldoInsuficienteException : Exception
  {
    public SaldoInsuficienteException() : base()
    {

    }

    public SaldoInsuficienteException(string message): base(message)
    {

    }
  }
}
