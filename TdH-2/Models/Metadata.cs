using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace TdH_2.Models
{
    public class fraudsMetadata
    {
        [Display(Name = "Date de l'incident")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public string date_incident;

        [StringLength(50)]
        [Display(Name = "Lieu de l'incident")]
        public string lieu_incident;

        [Display(Name = "Zone")]
        public string zone;

        //[StringLength(50)]
        [Display(Name = "Pays")]
        public string pays;

        public bool SignSupResp;

        public bool ExternalImplication;


        [Display(Name = "Pays")]
        public SelectList listPays;

        public int selectedCountry;

        //[StringLength(50)]
        [Display(Name = "Gravité de l'incident")]
        public string gravite_incident;

        //[StringLength(50)]
        [Display(Name = "Tdh est-il responsable de l’incident ?")]
        public string responsabilite_tdh;

        [StringLength(100)]
        [Display(Name = "Résumé de l'incident (MAX 100 MOTS, respecter l’anonymat des intervenants)")]
        [DataType(DataType.MultilineText)]
        public string resume_incident;

        //[StringLength(50)]
        [Display(Name = "Nature")]
        public string nature_de_lincident_nature;

        //[StringLength(50)]
        [Display(Name = "Autre")]
        public string nature_de_lincident_autre;

        //[StringLength(50)]
        [Display(Name = "Estimation du montant (préciser la devise)")]
        public string nature_de_lincident_estimation_du_montant;

        //[StringLength(50)]
        [Display(Name = "Détails de l'incident (si besoin)")]
        [DataType(DataType.MultilineText)]
        public string details_de_lincident;

        //[StringLength(50)]
        [Display(Name = "Le signalement a-t-il été déjà fait à votre supérieur hiérarchique ?")]
        public string preuves_significatives_signalement_superieur_hierarchique;

        //[StringLength(50)]
        [Display(Name = "Date du signalement")]
        public string preuves_significatives_signalement_superieur_hierarchique_date;

        //[StringLength(50)]
        [Display(Name = "Recours à une implication externe à Tdh ?")]
        public string preuves_significatives_une_implication_externe;

        //[StringLength(50)]
        [Display(Name = "Dans l’affirmative, premier contact à quelle date ?")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public string preuves_significatives_une_implication_externe_date;

        //[StringLength(50)]
        [Display(Name = "Avec quelle instance ?")]
        public string preuves_significatives_avec_quelle_instance;

        //[StringLength(50)]
        [Display(Name = "Si autre, précisez")]
        public string preuves_significatives_si_autre;

        //[StringLength(50)]
        [Display(Name = "Mesures prises par la délégation suite à l’incident")]
        [DataType(DataType.MultilineText)]
        public string mesures_prises_par_la_delegation;

        //[StringLength(50)]
        [Display(Name = "Recommandations du délégué et/ou de la personne en charge des finances")]
        [DataType(DataType.MultilineText)]
        public string recommandations_du_delegue_et_ou_de_la_personne_en_charge_des_finances;

        //[StringLength(50)]
        [Display(Name = "Expatrié")]
        public string personnes_impliquees_expatrie;

        //[StringLength(50)]
        [Display(Name = "Consultant/Prestataire Expatrié")]
        public string personnes_impliquees_consultant_prestataire_expatrie;

        //[StringLength(50)]
        [Display(Name = "Staff National Tdh")]
        public string personnes_impliquees_staff_national_tdh;

        //[StringLength(50)]
        [Display(Name = "Consultant/ Prestataire Local")]
        public string personnes_impliquees_consultant_prestataire_local;

        //[StringLength(50)]
        [Display(Name = "Tiers")]
        public string personnes_impliquees_tiers;

        //[StringLength(50)]
        [Display(Name = "Nombre total de personnes impliquées dans l’incident (Tdh ou non)")]
        public string personnes_impliquees_nombre_total_de_personnes_impliquees;

        //[StringLength(50)]
        [Display(Name = "L’incident demande-t-il un suivi de la part de Tdh localement ?")]
        public string incident_demande_suivi;

        //[StringLength(50)]
        [Display(Name = "Si oui, de quel type")]
        public string incident_demande_suivi_type;

        //[StringLength(50)]
        [Display(Name = "Un support du siège est-il nécessaire ?")]
        public string support_necessaire;

        //[StringLength(50)]
        [Display(Name = "Si oui, de quel type")]
        public string support_necessaire_type;

        //[StringLength(50)]
        [Display(Name = "Rapport rempli par (Nom et Position)")]
        public string rapport_rempli_par;

        //[StringLength(50)]
        [Display(Name = "Date de l’envoi au siège")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public string date_de_lenvoi_au_siege;

        //[StringLength(50)]
        [Display(Name = "Rapport traité par (au niveau du terrain)")]
        public string rapport_traite_par;

        //[StringLength(50)]
        [Display(Name = "Merci de précisez")]
        [DataType(DataType.MultilineText)]
        public string mise_a_jour_du_cas;

        //[StringLength(50)]
        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public string mise_a_jour_du_cas_date;

        //[StringLength(50)]
        [Display(Name = "Numéro de l’incident")]
        public string a_remplir_par_le_siege_numero_de_lincident;

        //[StringLength(50)]
        [Display(Name = "Reçu par")]
        public string a_remplir_par_le_siege_recu_par;

        //[StringLength(50)]
        [Display(Name = "Autre")]
        public string a_remplir_par_le_siege_recu_par_autre;

        //[StringLength(50)]
        [Display(Name = "Traité au siège par")]
        public string a_remplir_par_le_siege_traite_au_siege_par;

        //[StringLength(50)]
        [Display(Name = "Estimation du montant en CHF")]
        public string a_remplir_par_le_siege_montant_chf;

        //[StringLength(50)]
        [Display(Name = "Mise à jour / Recommandation")]
        [DataType(DataType.MultilineText)]
        public string a_remplir_par_le_siege_mise_a_jour_recommandation;

        //[StringLength(50)]
        [Display(Name = "Date de fermeture")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public string a_remplir_par_le_siege_date_de_fermeture;

        //[StringLength(50)]
        [Display(Name = "Statut")]
        public string a_remplir_par_le_siege_statut;

        //[StringLength(50)]
        [Display(Name = "Année")]
        public string annee;

        //[StringLength(50)]
        [Display(Name = "Langue")]
        public string langue;
    }

    public class psesMetadata
    {
        [Display(Name = "Date de l'incident")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public string date_incident;

        [StringLength(50)]
        [Display(Name = "Lieu de l'incident")]
        public string lieu_incident;


        [Display(Name = "Zone")]
        public string zone;

        //[StringLength(50)]
        [Display(Name = "Pays")]
        public string pays;

        //[StringLength(50)]
        [Display(Name = "Gravité de l'incident")]
        public string gravite_incident;

        //[StringLength(50)]
        [Display(Name = "Tdh est-il responsable de l’incident ?")]
        public string responsabilite_tdh;

        //[StringLength(50)]
        [Display(Name = "Résumé de l'incident (MAX 100 MOTS, respecter l’anonymat des intervenants)")]
        [DataType(DataType.MultilineText)]
        public string resume_incident;
    }
}