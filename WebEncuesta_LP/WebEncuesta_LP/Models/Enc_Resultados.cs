//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebEncuesta_LP.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Enc_Resultados
    {
        public int ResultadoId { get; set; }
        public Nullable<int> UsuarioId { get; set; }
        public Nullable<int> PreguntaId { get; set; }
        public string TextoRespuesta { get; set; }
    }
}