namespace MapaApp_jcm.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class locales
    {
        [Key]
        public int codigo { get; set; }

        [Required]
        [StringLength(150)]
        public string nombre { get; set; }

        public DateTime? ult_evento { get; set; }

        public DateTime? ult_audit { get; set; }

        public int cad_cantidad_sala { get; set; }

        public int cad_sindatos { get; set; }

        public int maq_cantidad_sala { get; set; }

        public int maq_sindatos { get; set; }

        [Required]
        [StringLength(100)]
        public string departamento { get; set; }

        [StringLength(50)]
        public string latitud { get; set; }

        [StringLength(50)]
        public string longitud { get; set; }
    }
}
