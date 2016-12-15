using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace TdH_2.Models
{
    [MetadataType(typeof(fraudsMetadata))]
    
    public partial class frauds
    {
        public SelectList listPays { get; set; }

        public SelectList listZones { get; set; }

        public SelectList listGraviteIncidents { get; set; }

        public SelectList listResponsableTDH { get; set; }

        public int selectedCountry { get; set; }
        public bool Responsable
        {
            get { return responsabilite_tdh == 1 ? true : false; }
            set
            {
                responsabilite_tdh = (Byte)(value ? 1 : 0);
                //if (value)
                //{
                //    responsabilite_tdh = 1;
                //}
                //else
                //{
                //    responsabilite_tdh = 0;
                //}
            }
        }
        public bool SignSupResp
        {
            get { return preuves_significatives_signalement_superieur_hierarchique == 1 ? true : false; }
            set
            {
                preuves_significatives_signalement_superieur_hierarchique = (Byte)(value ? 1 : 0);
            }
        }
        public bool ExternalImplication
        {
            get { return preuves_significatives_une_implication_externe == 1 ? true : false; }
            set
            {
                preuves_significatives_une_implication_externe = (Byte)(value ? 1 : 0);
            }
        }
    }

    [MetadataType(typeof(psesMetadata))]
    public partial class pse
    {
    }
}