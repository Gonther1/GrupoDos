using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities;

    public class Salon : BaseEntity
    {
        public string Nombre { get; set; }
        public int Capacidad { get; set; }
        public ICollection<Matricula> Matriculas { get; set; }
    }
