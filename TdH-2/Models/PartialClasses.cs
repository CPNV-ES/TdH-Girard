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

        public SelectList listNatureIncidents { get; set; }


        public SelectList listRecuPar { get; set; }

        public SelectList listStatus { get; set; }

        public SelectList listInstance { get; set; }

        public int selectedCountry { get; set; }

        public bool Responsable
        {
            get { return responsabilite_tdh == 1 ? true : false; }
            set
            {
                responsabilite_tdh = (Byte)(value ? 1 : 0);

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

        public bool LocalFollow
        {
            get { return incident_demande_suivi == 1 ? true : false; }
            set
            {
                incident_demande_suivi = (Byte)(value ? 1 : 0);
            }
        }

        public bool SupportNecessary
        {
            get { return support_necessaire == 1 ? true : false; }
            set
            {
                support_necessaire = (Byte)(value ? 1 : 0);
            }
        }
    }

    [MetadataType(typeof(psesMetadata))]
    public partial class pse
    {

        public SelectList listPays { get; set; }

        public SelectList listZones { get; set; }

        public SelectList listGraviteIncidents { get; set; }

        public SelectList listResponsableTDH { get; set; }

        public SelectList listNatureIncidents { get; set; }

        public bool Responsable
        {
            get { return responsabilite_tdh == 1 ? true : false; }
            set
            {
                responsabilite_tdh = (Byte)(value ? 1 : 0);

            }
        }

        public SelectList listPhysical { get; set; }

        public bool ViolencePhysical
        {
            get { return violence_physique == 1 ? true : false; }
            set
            {
                violence_physique = (Byte)(value ? 1 : 0);

            }
        }

        public SelectList listSexual { get; set; }

        public bool ViolenceSexual
        {
            get { return violence_sexuelle == 1 ? true : false; }
            set
            {
                violence_sexuelle = (Byte)(value ? 1 : 0);

            }
        }

        public SelectList listPsy { get; set; }

        public bool ViolencePsy
        {
            get { return violence_psychologique == 1 ? true : false; }
            set
            {
                violence_psychologique = (Byte)(value ? 1 : 0);

            }
        }

        public SelectList listNegligence { get; set; }

        public bool ViolenceNegligence
        {
            get { return negligence == 1 ? true : false; }
            set
            {
                negligence = (Byte)(value ? 1 : 0);

            }
        }

        public SelectList listStatusChild { get; set; }

        public SelectList listSexChild { get; set; }

        public SelectList listStatusAgressor { get; set; }

        public SelectList listSexAgressor { get; set; }






    }
}