using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto.Domain.Entities
{
    public class Cliente
    {
        public int ID { get; set; }
        public String Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public Double Salario { get; set; }

    }
}
