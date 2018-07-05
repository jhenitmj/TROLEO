﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrocaOleo
{
    public class ServicoTrocaOleo
    {
        public int Cod { get; set; }
        public DateTime Data { get; set; }
        public string Cliente { get; set; }
        public string Oleo { get; set; }
        public string QtdeLitro { get; set; }
        public string Categoria { get; set; }
        public string Tipo { get; set; }
        public string Fabricante { get; set; }
        public int ValorTotal { get; set; }
        public string Email { get; set; }
    }
}
