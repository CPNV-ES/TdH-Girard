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

        [Display(Name = "Violence physique")]
        public string violence_physique;

        [Display(Name = "Violence sexuelle")]
        public string violence_sexuelle;

        [Display(Name = "Violence psychologique")]
        public string violence_psychologique;

        [Display(Name = "Négligence")]
        public string negligence;

        [Display(Name = "Détails de l'incident")]
        [DataType(DataType.MultilineText)]
        public string details_de_lincident;

        [Display(Name = "Status")]
        public string victime_enfant_statut;

        [Display(Name = "Nom")]
        public string victime_enfant_nom;

        [Display(Name = "Date de naissance")]
        public string victime_enfant_date_de_naissance;

        [Display(Name = "Age")]
        public string victime_enfant_age;

        [Display(Name = "Sexe")]
        public string victime_enfant_sexe;

        [Display(Name = "Adresse")]
        public string victime_enfant_adresse;

        [Display(Name = "Handicap - si applicable (physique ou mental)")]
        public string victime_enfant_handicap;

        [Display(Name = "Autre information importante")]
        public string victime_enfant_autre_information_importante;

        [Display(Name = "Status")]
        public string agresseur_statut;

        [Display(Name = "Nom")]
        public string agresseur_nom;

        [Display(Name = "Position")]
        public string agresseur_position;

        [Display(Name = "Age")]
        public string agresseur_age;

        [Display(Name = "Sexe")]
        public string agresseur_sexe;

        [Display(Name = "Statut familial")]
        public string agresseur_statut_familial;

        [Display(Name = "Nom de l'employeur")]
        public string agresseur_nom_de_lemployeur;

        [Display(Name = "Lien avec TdH")]
        public string agresseur_lien_avec_tdh;

        [Display(Name = "Lien avec l'enfant")]
        public string agresseur_lien_avec_lenfant;

        [Display(Name = "Autre information importante")]
        public string agresseur_autre_information_importante;

        [Display(Name = "Nom")]
        public string personne_signalant_nom;

        [Display(Name = "Position")]
        public string personne_signalant_position;

        [Display(Name = "Adresse")]
        public string personne_signalant_adresse;

        [Display(Name = "Nom de l'employeur")]
        public string personne_signalant_nom_de_lemployeur;

        [Display(Name = "Lien avec TdH")]
        public string personne_signalant_lien_avec_tdh;

        [Display(Name = "Lien avec l'enfant")]
        public string personne_signalant_lien_avec_lenfant;

        [Display(Name = "Autre information importante")]
        public string personne_signalant_autre_information_importante;

        [Display(Name = "Pour protéger l'enfant")]
        public string mesures_prises_pour_proteger_lenfant;

        [Display(Name = "Pour éviter la récidive de l’auteur présumé")]
        public string mesures_prises_pour_eviter_la_recidive;

        [Display(Name = "Pour protéger l’action de la fondation Terre des hommes")]
        public string mesures_prises_pour_proteger_laction_de_tdh;

        [Display(Name = "Qu’est-ce que l’enfant souhaite ? / Quelle est sa vision de la situation ?")]
        public string informations_supplementaires_quest_ce_que_lenfant_souhaite;

        [Display(Name = "De quel soutien l’enfant a-t-il besoin ?   (tel que médical & autre)  ")]
        public string informations_supplementaires_de_quel_soutien_lenfant_a_t_il_besoin;

        [Display(Name = "Qui doit apporter ce soutien et sous quel délai ?")]
        public string informations_supplementaires_qui_doit_apporter_ce_soutien;

        [Display(Name = "Y-a-t-il d’autres actions à prendre ?")]
        public string informations_supplementaires_y_a_t_il_dautres_actions;

        [Display(Name = "Préciser par qui & quand")]
        public string informations_supplementaires_qui_quand;

        [Display(Name = "Qui va suivre ce cas ?")]
        public string informations_supplementaires_qui_va_suivre;

        [Display(Name = "Y-a-t-il d’autres leçons apprises à la suite de cet incident qui pourraient être utiles pour le futur ? Dans l’affirmative, quelles sont les prochaines étapes à mettre en place pour éviter qu’un tel incident ne se reproduise ?")]
        public string informations_supplementaires_lecons_apprises;

        [Display(Name = "Recommandations du délégué et/ou du point focal de la sauvegarde de l’enfant")]
        public string recommandations_du_delegue;

        [Display(Name = "Rapport rempli par (Nom et Position)")]
        public string rapport_rempli_par;

        [Display(Name = "Date de l’envoi au siège:")]
        public string date_de_lenvoi_au_siege;

        [Display(Name = "Rapport traité par :(au niveau du terrain)")]
        public string rapport_traite_par;

        [Display(Name = "Mise à jour du cas")]
        public string mise_a_jour_du_cas;

        [Display(Name = "Date")]
        public string mise_a_jour_du_cas_date;

        [Display(Name = "Numéro de l'incident")]
        public string a_remplir_par_le_siege_numero_de_lincident;

        [Display(Name = "Reçu par")]
        public string a_remplir_par_le_siege_recu_par;

        [Display(Name = "Autre")]
        public string a_remplir_par_le_siege_recu_par_autre;

        [Display(Name = "TRaité au siège par")]
        public string a_remplir_par_le_siege_traite_au_siege_par;

        [Display(Name = "Mise à jour / Recommandation")]
        public string a_remplir_par_le_siege_mise_a_jour_recommandation;

        [Display(Name = "Date de fermeture")]
        public string a_remplir_par_le_siege_date_de_fermeture;

        [Display(Name = "Statut")]
        public string a_remplir_par_le_siege_statut;

        [Display(Name = "Année")]
        public string annee;

        [Display(Name = "Langue")]
        public string langue;
    }
}