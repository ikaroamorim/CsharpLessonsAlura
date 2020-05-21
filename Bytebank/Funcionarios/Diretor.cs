﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank.Funcionarios
{
  class Diretor : Funcionario
  {
    public Diretor(string cpf):base(cpf, 5000)
    {

    }

    public override void AumentarSalario()
    {
      Salario *= 1.15;
    }
    public override double getBonificacao()
    {
      return Salario*0.5;
    }
  }
}
