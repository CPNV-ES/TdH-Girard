﻿using System;
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

        [Display(Name = "Lieu de l'incident")]
        public string lieu_incident;

        [Display(Name = "Zone")]
        public string zone;

        [Display(Name = "Pays")]
        public string pays;

        public bool SignSupResp;

        public bool ExternalImplication;

        [Display(Name = "Pays")]
        public SelectList listPays;

        public int selectedCountry;

        [Display(Name = "Gravité de l'incident")]
        public string gravite_incident;

        [Display(Name = "Tdh est-il responsable de l’incident ?")]
        public string responsabilite_tdh;

        [StringLength(100)]
        [Display(Name = "Résumé de l'incident (MAX 100 MOTS, respecter l’anonymat des intervenants)")]
        [DataType(DataType.MultilineText)]
        public string resume_incident;

        [Display(Name = "Nature")]
        public string nature_de_lincident_nature;

        [Display(Name = "Autre")]
        public string nature_de_lincident_autre;

        [Display(Name = "Estimation du montant (préciser la devise)")]
        public string nature_de_lincident_estimation_du_montant;

        [Display(Name = "Détails de l'incident (si besoin)")]
        [DataType(DataType.MultilineText)]
        public string details_de_lincident;

        [Display(Name = "Le signalement a-t-il été déjà fait à votre supérieur hiérarchique ?")]
        public string preuves_significatives_signalement_superieur_hierarchique;

        [Display(Name = "Date du signalement")]
        public string preuves_significatives_signalement_superieur_hierarchique_date;

        [Display(Name = "Recours à une implication externe à Tdh ?")]
        public string preuves_significatives_une_implication_externe;

        [Display(Name = "Dans l’affirmative, premier contact à quelle date ?")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public string preuves_significatives_une_implication_externe_date;

        [Display(Name = "Avec quelle instance ?")]
        public string preuves_significatives_avec_quelle_instance;

        [Display(Name = "Si autre, précisez")]
        public string preuves_significatives_si_autre;

        [Display(Name = "Mesures prises par la délégation suite à l’incident")]
        [DataType(DataType.MultilineText)]
        public string mesures_prises_par_la_delegation;

        [Display(Name = "Recommandations du délégué et/ou de la personne en charge des finances")]
        [DataType(DataType.MultilineText)]
        public string recommandations_du_delegue_et_ou_de_la_personne_en_charge_des_finances;

        [Display(Name = "Expatrié")]
        public string personnes_impliquees_expatrie;

        [Display(Name = "Consultant/Prestataire Expatrié")]
        public string personnes_impliquees_consultant_prestataire_expatrie;

        [Display(Name = "Staff National Tdh")]
        public string personnes_impliquees_staff_national_tdh;

        [Display(Name = "Consultant/ Prestataire Local")]
        public string personnes_impliquees_consultant_prestataire_local;

        [Display(Name = "Tiers")]
        public string personnes_impliquees_tiers;

        [Display(Name = "Nombre total de personnes impliquées dans l’incident (Tdh ou non)")]
        public string personnes_impliquees_nombre_total_de_personnes_impliquees;

        [Display(Name = "L’incident demande-t-il un suivi de la part de Tdh localement ?")]
        public string incident_demande_suivi;

        [Display(Name = "Si oui, de quel type")] public string incident_demande_suivi_type;

        [Display(Name = "Un support du siège est-il nécessaire ?")]
        public string support_necessaire;

        [Display(Name = "Si oui, de quel type")]
        public string support_necessaire_type;

        [Display(Name = "Rapport rempli par (Nom et Position)")]
        public string rapport_rempli_par;

        [Display(Name = "Date de l’envoi au siège")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public string date_de_lenvoi_au_siege;

        [Display(Name = "Rapport traité par (au niveau du terrain)")]
        public string rapport_traite_par;

        [Display(Name = "Merci de précisez")]
        [DataType(DataType.MultilineText)]
        public string mise_a_jour_du_cas;

        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public string mise_a_jour_du_cas_date;

        [Display(Name = "Numéro de l’incident")]
        public string a_remplir_par_le_siege_numero_de_lincident;

        [Display(Name = "Reçu par")]
        public string a_remplir_par_le_siege_recu_par;

        [Display(Name = "Autre")]
        public string a_remplir_par_le_siege_recu_par_autre;

        [Display(Name = "Traité au siège par")]
        public string a_remplir_par_le_siege_traite_au_siege_par;

        [Display(Name = "Estimation du montant en CHF")] public string a_remplir_par_le_siege_montant_chf;

        [Display(Name = "Mise à jour / Recommandation")]
        [DataType(DataType.MultilineText)] public string a_remplir_par_le_siege_mise_a_jour_recommandation;

        [Display(Name = "Date de fermeture")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public string a_remplir_par_le_siege_date_de_fermeture;

        [Display(Name = "Statut")] public string a_remplir_par_le_siege_statut;

        [Display(Name = "Année")] public string annee;

        [Display(Name = "Langue")] public string langue;
    }

    public class psesMetadata
    {
        [Display(Name = "Date de l'incident")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public string date_incident;

        [Display(Name = "Lieu de l'incident")]
        public string lieu_incident;


        [Display(Name = "Zone")]
        public string zone;

        [Display(Name = "Pays")]
        public string pays;

        [Display(Name = "Gravité de l'incident")]
        public string gravite_incident;

        [Display(Name = "Tdh est-il responsable de l’incident ?")]
        public string responsabilite_tdh;

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
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
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
        [DataType(DataType.MultilineText)]
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
        [DataType(DataType.MultilineText)]
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
        [DataType(DataType.MultilineText)]
        public string personne_signalant_autre_information_importante;
        

        [Display(Name = "Pour protéger l'enfant")]
        [DataType(DataType.MultilineText)]
        public string mesures_prises_pour_proteger_lenfant;

        [Display(Name = "Pour éviter la récidive de l’auteur présumé")]
        [DataType(DataType.MultilineText)]
        public string mesures_prises_pour_eviter_la_recidive;

        [Display(Name = "Pour protéger l’action de la fondation Terre des hommes")]
        [DataType(DataType.MultilineText)]
        public string mesures_prises_pour_proteger_laction_de_tdh;

        [Display(Name = "Qu’est-ce que l’enfant souhaite ? / Quelle est sa vision de la situation ?")]
        [DataType(DataType.MultilineText)]
        public string informations_supplementaires_quest_ce_que_lenfant_souhaite;

        [Display(Name = "De quel soutien l’enfant a-t-il besoin ?   (tel que médical & autre)  ")]
        [DataType(DataType.MultilineText)]
        public string informations_supplementaires_de_quel_soutien_lenfant_a_t_il_besoin;

        [Display(Name = "Qui doit apporter ce soutien et sous quel délai ?")]
        [DataType(DataType.MultilineText)]
        public string informations_supplementaires_qui_doit_apporter_ce_soutien;

        [Display(Name = "Y-a-t-il d’autres actions à prendre ?")]
        [DataType(DataType.MultilineText)]
        public string informations_supplementaires_y_a_t_il_dautres_actions;

        [Display(Name = "Préciser par qui & quand")]
        [DataType(DataType.MultilineText)]
        public string informations_supplementaires_qui_quand;

        [Display(Name = "Qui va suivre ce cas ?")]
        [DataType(DataType.MultilineText)]
        public string informations_supplementaires_qui_va_suivre;

        [Display(Name ="Y-a-t-il d’autres leçons apprises à la suite de cet incident qui pourraient être utiles pour le futur ? Dans l’affirmative, quelles sont les prochaines étapes à mettre en place pour éviter qu’un tel incident ne se reproduise ?")]
        [DataType(DataType.MultilineText)]
        public string informations_supplementaires_lecons_apprises;

        [Display(Name = "Recommandations du délégué et/ou du point local de la sauvegarde de l’enfant")]
        [DataType(DataType.MultilineText)]
        public string recommandations_du_delegue;

        [Display(Name = "Rapport rempli par (Nom et Position)")]
        public string rapport_rempli_par;

        [Display(Name = "Date de l’envoi au siège")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public string date_de_lenvoi_au_siege;

        [Display(Name = "Rapport traité par (au niveau du terrain)")]
        public string rapport_traite_par;

        [Display(Name = "Mise à jour du cas")]
        public string mise_a_jour_du_cas;
        [DataType(DataType.MultilineText)]

        [Display(Name = "Date")]
        public string mise_a_jour_du_cas_date;

        [Display(Name = "Numéro de l'incident")]
        public string a_remplir_par_le_siege_numero_de_lincident;

        [Display(Name = "Reçu par")]
        public string a_remplir_par_le_siege_recu_par;

        [Display(Name = "Autre")]
        public string a_remplir_par_le_siege_recu_par_autre;

        [Display(Name = "Traité au siège par")]
        public string a_remplir_par_le_siege_traite_au_siege_par;

        [Display(Name = "Mise à jour / Recommandation")]
        [DataType(DataType.MultilineText)]
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

    public class securitiesMetadata
    {
        [Display(Name = "Date de l'incident")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public string date_incident;

        [Display(Name = "Lieu de l'incident")]
        public string lieu_incident;

        [Display(Name = "Zone")]
        public string zone;

        [Display(Name = "Pays")]
        public string pays;

        [Display(Name = "Gravité de l'incident")]
        public string gravite_incident;

        [Display(Name = "Tdh est-il responsable de l’incident ?")]
        public string responsabilite_tdh;

        [Display(Name = "Résumé de l'incident (MAX 100 MOTS, respecter l’anonymat des intervenants)")]
        [DataType(DataType.MultilineText)]
        public string resume_incident;

        [Display(Name = "Santé")]
        public string sante;

        [Display(Name = "Employé ")]
        public SelectList sante_employe;

        [Display(Name = "Nature")]
        public string sante_nature;

        [Display(Name = "Si autre ")]
        public string sante_autre;

        [Display(Name = "Accident lié au déplacement")]
        public string accident_lie_au_deplacement;

        [Display(Name = "Nature")]
        public string accident_lie_au_deplacement_nature;

        [Display(Name = "Si autre ")]
        public string accident_lie_au_deplacement_autre;

        [Display(Name = "Maintenance au bureau")]
        public string maintenance_du_bureau;

        [Display(Name = "Nature")]
        public string maintenance_du_bureau_nature;

        [Display(Name = "Si autre ")]
        public string maintenance_du_bureau_autre;

        [Display(Name = "Catastrophe naturelle")]
        public string catastrophe_naturelle;

        [Display(Name = "Nature")]
        public string catastrophe_naturelle_autre;

        [Display(Name = "Si autre ")]
        public string catastrophe_naturelle_nature;

        [Display(Name = "Dégât matériel")]
        public string degat_materiel;

        [Display(Name = "Nature")]
        public string degat_materiel_nature;

        [Display(Name = "Si autre ")]
        public string degat_materiel_autre;

        [Display(Name = "Autre")]
        public string surete_autre;

        [Display(Name = "Description")]
        [DataType(DataType.MultilineText)]
        public string surete_autre_description;

        [Display(Name = "Menace")]
        public string menace;

        [Display(Name = "Envers")]
        public string menace_envers;

        [Display(Name = "Autre")]
        public string menace_envers_autre;

        [Display(Name = "Nature")]
        public string menace_nature;

        [Display(Name = "Si autre")]
        public string menace_nature_autre;

        [Display(Name = "Aggression")]
        public string agression;

        [Display(Name = "Employé")]
        public string agression_employe;

        [Display(Name = "Nature")]
        public string agression_nature;

        [Display(Name = "Si autre")]
        public string agression_autre;

        [Display(Name = "Enlèvement")]
        public string enlevement;

        [Display(Name = "Employé")]
        public string enlevement_employe;

        [Display(Name = "Nature")]
        public string enlevement_nature;

        [Display(Name = "Si autre")]
        public string enlevement_autre;

        [Display(Name = "Vol / Intrusion")]
        public string vol_intrusion;

        [Display(Name = "Nature")]
        public string vol_intrusion_nature;

        [Display(Name = "Si autre")]
        public string vol_intrusion_autre;

        [Display(Name = "Attaque")]
        public string attaque;

        [Display(Name = "nature")]
        public string attaque_nature;

        [Display(Name = "Si autre")]
        public string attaque_autre;

        [Display(Name = "Troubles publics")]
        public string troubles_publics;

        [Display(Name = "Nature")]
        public string troubles_publics_nature;

        [Display(Name = "Si autre")]
        public string troubles_publics_autre;

        [Display(Name = "Autre")]
        public string securite_autre;

        [Display(Name = "Description")]
        public string securite_autre_desctiption;

        [Display(Name = "Détails de l'incident (si besoin)")]
        [DataType(DataType.MultilineText)]
        public string details_de_lincident;

        [Display(Name = "Raison de la présence de Tdh sur les lieux de l'incident")]
        [DataType(DataType.MultilineText)]
        public string raisons_de_la_presence_de_tdh;

        [Display(Name = "Mesures prises par la délégation suite à l’incident")]
        [DataType(DataType.MultilineText)]
        public string mesures_prises_par_la_delegation;

        [Display(Name = "Recommandations du délégué et/ou de la personne en charge de la sécurité")]
        [DataType(DataType.MultilineText)]
        public string recommandations_du_delegue;

        [Display(Name = "Expatrié")]
        public string personnes_impliquees_expatrie;

        [Display(Name = "Consultant/Prestataire Expatrié")]
        public string personnes_impliquees_consultant_prestataire_expatrie;

        [Display(Name = "Staff National Tdh")]
        public string personnes_impliquees_staff_national_tdh;

        [Display(Name = "Consultant/ Prestataire Local")]
        public string personnes_impliquees_consultant_prestataire_local;

        [Display(Name = "Tiers")]
        public string personnes_impliquees_tiers;

        [Display(Name = "Nombre total de personnes impliquées dans l’incident (Tdh ou non) ")]
        public string personnes_impliquees_nombre_total_de_personnes;

        [Display(Name = "Police")]
        public string implication_exterieure_police;

        [Display(Name = "Juge de paix")]
        public string implication_exterieure_juge_de_paix;

        [Display(Name = "Tiers / Population")]
        public string implication_exterieure_tiers_population;

        [Display(Name = "Hôpital / Centre de Santé")]
        public string implication_exterieure_hopital_centre_de_sante;

        [Display(Name = "Compagnie d’assurance")]
        public string implication_exterieure_compagnie_dassurance;

        [Display(Name = "Aucune")]
        public string implication_exterieure_aucune;

        [Display(Name = "Autre")]
        public string implication_exterieure_autre;

        [Display(Name = "Description")]
        public string implication_exterieure_autre_description;

        [Display(Name = "Hibernation / Suspension d’activité")]
        public string impact_sur_le_programme_hibernation;

        [Display(Name = "Nombre de jours")]
        public string impact_sur_le_programme_nb_de_jours;

        [Display(Name = "Evacuation")]
        public string impact_sur_le_programme_evacuation;

        [Display(Name = "Nombre de personnes")]
        public string impact_sur_le_programme_nb_de_personnes;

        [Display(Name = "Evacuation médicale")]
        public string impact_sur_le_programme_evacuation_medicale;

        [Display(Name = "Nombre de jours sans travailler")]
        public string impact_sur_le_programme_nb_de_jours_sans_travailler;

        [Display(Name = "Coût financier")]
        public string impact_sur_le_programme_cout_financier;

        [Display(Name = "Montant approximatif  (préciser la devise)")]
        public string impact_sur_le_programme_montant_approximatif;

        [Display(Name = "Suivi judicaire")]
        public string impact_sur_le_programme_suivi_judicaire;

        [Display(Name = "Autre")]
        public string impact_sur_le_programme_autre;

        [Display(Name = "Aucun")]
        public string impact_sur_le_programme_aucun;

        [Display(Name = "Description")]
        public string impact_sur_le_programme_autre_description;

        [Display(Name = "L’incident demande-t-il un suivi de la part de Tdh localement")]
        public string incident_demande_suivi;

        [Display(Name = "Si oui, de quel type ")]
        public string incident_demande_suivi_type;

        [Display(Name = "Un support du siège est-il nécessaire")]
        public string support_necessaire;

        [Display(Name = "Si oui, de quel type")]
        public string support_necessaire_type;

        [Display(Name = "Le plan de sécurité a-t-il été changé suite à l’incident")]
        public string plan_securite_change;

        [Display(Name = "Suite à la mise à jour le plan de sécurité a-t-il été envoyé au siège")]
        public string plan_securite_envoyer_au_siege;

        [Display(Name = "Si oui, à quelle date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public string plan_securite_envoyer_au_siege_date;

        [Display(Name = "Rapport rempli par (Nom et Position)")]
        public string rapport_rempli_par;

        [Display(Name = "Date de l’envoi au siège")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public string date_de_lenvoi_au_siege;

        [Display(Name = "Rapport traité par (au niveau du terrain)")]
        public string rapport_traite_par;

        [Display(Name = "MISE A JOUR DU CAS")]
        [DataType(DataType.MultilineText)]
        public string mise_a_jour_du_cas;

        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public string mise_a_jour_du_cas_date;

        [Display(Name = "Numéro de l’incident")]
        public string a_remplir_par_le_siege_numero_de_lincident;

        [Display(Name = "Reçu par")]
        public string a_remplir_par_le_siege_recu_par;

        [Display(Name = "Autre")]
        public string a_remplir_par_le_siege_recu_par_autre;

        [Display(Name = "Traité au siège par")]
        public string a_remplir_par_le_siege_traite_au_siege_par;

        [Display(Name = "Mise à jour / Recommandation")]
        [DataType(DataType.MultilineText)]
        public string a_remplir_par_le_siege_mise_a_jour_recommandation;

        [Display(Name = "Statut")]
        public string a_remplir_par_le_siege_statut;

        [Display(Name = "Date de fermeture")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public string a_remplir_par_le_siege_date_de_fermeture;

        [Display(Name = "Annee")]
        public string annee;

        [Display(Name = "Langue")]
        public string langue;
    }

}