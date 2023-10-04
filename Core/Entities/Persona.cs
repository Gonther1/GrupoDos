using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Persona : BaseEntity
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int IdCiudadFk { get; set; }
        public Ciudad Ciudades { get; set; }
        public int IdTipoPersonaFk { get; set; }
        public TipoPersona TipoPersonas { get; set; }
        public ICollection<Matricula> Matriculas { get; set; }
    }
}