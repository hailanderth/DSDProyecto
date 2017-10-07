using MD.GA.BE.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MD.GA.BE
{
    public class UsuarioEntidad
    {
        [DataMember]
        public int Id_Usuario { get; set; }
        [DataMember]
        public string Nombres { get; set; }
        [DataMember]
        public string Apellidos { get; set; }
        [DataMember]
        public string Usuario1 { get; set; }
        [DataMember]
        public string Password { get; set; }
        [DataMember]
        public string UsuarioCreacion { get; set; }
        [DataMember]
        public System.DateTime FechaCreacion { get; set; }
        [DataMember]
        public string UsuarioModificacion { get; set; }
        [DataMember]
        public Nullable<System.DateTime> FechaModificacion { get; set; }
        [DataMember]
        public int Id_Puesto { get; set; }
        [DataMember]
        public string Estado { get; set; }
        [DataMember]
        public virtual Puesto Puesto { get; set; }
    }
}
