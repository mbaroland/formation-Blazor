using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace dataForm.Data
{
    public class Tache
    {
        public string Id {set; get;}

        [Required(ErrorMessage="Nom est obligatoire")]
        [MaxLength(100,ErrorMessage="Nom trop long")]
        public string Nom {set; get;}

        public bool Realisee {set; get;}=false;
    }
}