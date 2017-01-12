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
            set { responsabilite_tdh = (Byte) (value ? 1 : 0); }
        }

        public bool SignSupResp
        {
            get { return preuves_significatives_signalement_superieur_hierarchique == 1 ? true : false; }
            set { preuves_significatives_signalement_superieur_hierarchique = (Byte) (value ? 1 : 0); }
        }

        public bool ExternalImplication
        {
            get { return preuves_significatives_une_implication_externe == 1 ? true : false; }
            set { preuves_significatives_une_implication_externe = (Byte) (value ? 1 : 0); }
        }

        public bool LocalFollow
        {
            get { return incident_demande_suivi == 1 ? true : false; }
            set { incident_demande_suivi = (Byte) (value ? 1 : 0); }
        }

        public bool SupportNecessary
        {
            get { return support_necessaire == 1 ? true : false; }
            set { support_necessaire = (Byte) (value ? 1 : 0); }
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
            set { responsabilite_tdh = (Byte) (value ? 1 : 0); }
        }

        public SelectList listPhysical { get; set; }

        public bool ViolencePhysical
        {
            get { return violence_physique == 1 ? true : false; }
            set { violence_physique = (Byte) (value ? 1 : 0); }
        }

        public SelectList listSexual { get; set; }

        public bool ViolenceSexual
        {
            get { return violence_sexuelle == 1 ? true : false; }
            set { violence_sexuelle = (Byte) (value ? 1 : 0); }
        }

        public SelectList listPsy { get; set; }

        public bool ViolencePsy
        {
            get { return violence_psychologique == 1 ? true : false; }
            set { violence_psychologique = (Byte) (value ? 1 : 0); }
        }

        public SelectList listNegligence { get; set; }

        public bool ViolenceNegligence
        {
            get { return negligence == 1 ? true : false; }
            set { negligence = (Byte) (value ? 1 : 0); }
        }

        public SelectList listStatusChild { get; set; }

        public SelectList listSexChild { get; set; }

        public SelectList listStatusAgressor { get; set; }

        public SelectList listSexAgressor { get; set; }

    }

    [MetadataType(typeof(securitiesMetadata))]
    public partial class securities
    {
        public SelectList listPays { get; set; }

        public SelectList listZones { get; set; }

        public SelectList listGraviteIncidents { get; set; }

        public SelectList listResponsableTDH { get; set; }

        public bool Responsable
        {
            get { return responsabilite_tdh == 1 ? true : false; }
            set { responsabilite_tdh = (Byte)(value ? 1 : 0); }
        }

        public int selectedCountry { get; set; }


        public SelectList listHealthEmploye { get; set; }

        public SelectList listHealthNature { get; set; }

        public bool SafetyHealth
        {
            get { return sante == 1 ? true : false; }
            set { sante = (Byte)(value ? 1 : 0); }
        }

        public SelectList listAccident { get; set; }

        public bool SafetyAccident
        {
            get { return accident_lie_au_deplacement == 1 ? true : false; }
            set { accident_lie_au_deplacement = (Byte)(value ? 1 : 0); }
        }

        public SelectList listMaintenance { get; set; }

        public bool SafetyMaintenance
        {
            get { return maintenance_du_bureau == 1 ? true : false; }
            set { maintenance_du_bureau = (Byte)(value ? 1 : 0); }
        }

        public SelectList listDisaster { get; set; }

        public bool SafetyDesaster
        {
            get { return catastrophe_naturelle == 1 ? true : false; }
            set { catastrophe_naturelle = (Byte)(value ? 1 : 0); }
        }

        public SelectList listMaterials { get; set; }

        public bool SafetyMaterials
        {
            get { return degat_materiel == 1 ? true : false; }
            set { degat_materiel = (Byte)(value ? 1 : 0); }
        }

        public bool SafetyOther
        {
            get { return surete_autre == 1 ? true : false; }
            set { surete_autre = (Byte)(value ? 1 : 0); }
        }

        public SelectList listThreatsAgain { get; set; }

        public SelectList listThreatsNature { get; set; }

        public bool SecurityThreat
        {
            get { return menace == 1 ? true : false; }
            set { menace = (Byte)(value ? 1 : 0); }
        }

        public SelectList listAgressionEmployee { get; set; }

        public SelectList listAgressionNature { get; set; }

        public bool SecurityAgression
        {
            get { return agression == 1 ? true : false; }
            set { agression = (Byte)(value ? 1 : 0); }
        }

        public SelectList listKidnappingEmployee { get; set; }
        public SelectList listKidnappingNature { get; set; }

        public bool SecurityKidnapping
        {
            get { return enlevement == 1 ? true : false; }
            set { enlevement = (Byte)(value ? 1 : 0); }
        }

        public SelectList listStealNature { get; set; }

        public bool SecuritySteal
        {
            get { return vol_intrusion == 1 ? true : false; }
            set { vol_intrusion = (Byte)(value ? 1 : 0); }
        }

        public SelectList listAttackNature { get; set; }

        public bool SecurityAttack
        {
            get { return attaque == 1 ? true : false; }
            set { attaque = (Byte)(value ? 1 : 0); }
        }
        public SelectList listPublicTroubleNature { get; set; }

        public bool SecurityPublicTrouble
        {
            get { return troubles_publics == 1 ? true : false; }
            set { troubles_publics = (Byte)(value ? 1 : 0); }
        }
        public SelectList listSecurityOther { get; set; }

        public bool SecurityOther
        {
            get { return securite_autre == 1 ? true : false; }
            set { securite_autre = (Byte)(value ? 1 : 0); }
        }

        public bool ExternalImpilcationPolice
        {
            get { return implication_exterieure_police == 1 ? true : false; }
            set { implication_exterieure_police = (Byte)(value ? 1 : 0); }
        }

        public bool ExternalImpilcationJudge
        {
            get { return implication_exterieure_juge_de_paix == 1 ? true : false; }
            set { implication_exterieure_juge_de_paix = (Byte)(value ? 1 : 0); }
        }

        public bool ExternalImpilcationPopulation
        {
            get { return implication_exterieure_tiers_population == 1 ? true : false; }
            set { implication_exterieure_tiers_population = (Byte)(value ? 1 : 0); }
        }

        public bool ExternalImpilcationHospital
        {
            get { return implication_exterieure_hopital_centre_de_sante == 1 ? true : false; }
            set { implication_exterieure_hopital_centre_de_sante = (Byte)(value ? 1 : 0); }
        }

        public bool ExternalImpilcationInsuranceCompagny
        {
            get { return implication_exterieure_compagnie_dassurance == 1 ? true : false; }
            set { implication_exterieure_compagnie_dassurance = (Byte)(value ? 1 : 0); }
        }

        public bool ExternalImpilcationNone
        {
            get { return implication_exterieure_aucune == 1 ? true : false; }
            set { implication_exterieure_aucune = (Byte)(value ? 1 : 0); }
        }

        public bool ExternalImpilcationOther
        {
            get { return implication_exterieure_autre == 1 ? true : false; }
            set { implication_exterieure_autre = (Byte)(value ? 1 : 0); }
        }

        public bool ImpactOnProgramHibernate
        {
            get { return impact_sur_le_programme_hibernation == 1 ? true : false; }
            set { impact_sur_le_programme_hibernation = (Byte)(value ? 1 : 0); }
        }

        public bool ImpactOnProgramEvacuation
        {
            get { return impact_sur_le_programme_evacuation == 1 ? true : false; }
            set { impact_sur_le_programme_evacuation = (Byte)(value ? 1 : 0); }
        }

        public bool ImpactOnProgramMedicalEvacuation
        {
            get { return impact_sur_le_programme_evacuation_medicale == 1 ? true : false; }
            set { impact_sur_le_programme_evacuation_medicale = (Byte)(value ? 1 : 0); }
        }

        public bool ImpactOnProgramFinancialCost
        {
            get { return impact_sur_le_programme_cout_financier == 1 ? true : false; }
            set { impact_sur_le_programme_cout_financier = (Byte)(value ? 1 : 0); }
        }

        public bool ImpactOnProgramJudicalFollow
        {
            get { return impact_sur_le_programme_suivi_judicaire == 1 ? true : false; }
            set { impact_sur_le_programme_suivi_judicaire = (Byte)(value ? 1 : 0); }
        }

        public bool ImpactOnProgramNone
        {
            get { return impact_sur_le_programme_aucun == 1 ? true : false; }
            set { impact_sur_le_programme_aucun = (Byte)(value ? 1 : 0); }
        }

        public bool ImpactOnProgramOther
        {
            get { return impact_sur_le_programme_autre == 1 ? true : false; }
            set { impact_sur_le_programme_autre = (Byte)(value ? 1 : 0); }
        }

        public bool LocalFollowRequired
        {
            get { return incident_demande_suivi == 1 ? true : false; }
            set { incident_demande_suivi = (Byte)(value ? 1 : 0); }
        }

        public bool HeadQuarterSupport
        {
            get { return support_necessaire == 1 ? true : false; }
            set { support_necessaire = (Byte)(value ? 1 : 0); }
        }

        public bool SecurityPlanChanged
        {
            get { return plan_securite_change == 1 ? true : false; }
            set { plan_securite_change = (Byte)(value ? 1 : 0); }
        }

        public bool NewSecurityPlanSend
        {
            get { return plan_securite_envoyer_au_siege == 1 ? true : false; }
            set { plan_securite_envoyer_au_siege = (Byte)(value ? 1 : 0); }
        }

        public SelectList ReceiveBy { get; set; }

        public SelectList listStatus { get; set; }


    }
}