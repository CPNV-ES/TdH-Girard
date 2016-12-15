using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using TdH_2.Models;

namespace TdH.Utils
{
    public class TranslateManager
    {
        private tdhEntities _db = new tdhEntities();
        private List<Traductions> _traductions;
        private List<Listes> _listes;
        private int _idLang;
        // <database column name, Nom_liste>
        private Dictionary<String, String> fieldsDictionary = new Dictionary<string, string>();

        public TranslateManager(int idLang)
        {
            init(idLang);
            initFieldsDictionary();
        }

        private void init(int idLang)
        {
            _idLang = idLang;
            _traductions = _db.Traductions.Where(traductions => traductions.FK_Langues == idLang).ToList();
            _listes = _db.Listes.ToList();

        }

        public List<Traductions> getList(string type)
        {
            return _db.Traductions.Where(t => t.FK_Langues == _idLang && t.FK_Listes == _db.Listes.Where(l => l.Nom_liste == type).Select(l => l.IDListes).First()).ToList();
        }


        public List<Traductions> loadTranslate(string type)
        {
            // Load values
            fieldsDictionary.TryGetValue(type, out type);

            List<Traductions> t = new List<Traductions>();
            foreach (Listes current in _listes)
            {
                if (current.Nom_liste == type)
                {
                    foreach (Traductions traduction in _traductions)
                    {
                        if (traduction.FK_Listes == current.IDListes)
                        {
                            t.Add(traduction);
                        }
                    }
                    return t;
                }
            }
            return t;
        }

        public List<Traductions> traductions
        {
            get { return _traductions; }
            set { _traductions = value; }
        }

        public SelectList convertToSelectList(List<Traductions> translate)
        {
            return new SelectList(translate, "Valeur", "Traduction");
        }

        private void initFieldsDictionary()
        {
            //Generic
            fieldsDictionary.Add("zone", "zone");
            fieldsDictionary.Add("pays", "pays");
            fieldsDictionary.Add("gravite_incident", "gravite");
            fieldsDictionary.Add("responsabilite_tdh", "oui_non");
            fieldsDictionary.Add("support_necessaire", "oui_non");
            fieldsDictionary.Add("incident_demande_suivi", "oui_non");

            fieldsDictionary.Add("a_remplir_par_le_siege_recu_par", "recu_par");
            fieldsDictionary.Add("a_remplir_par_le_siege_statut", "statut");

            //Fraude
            fieldsDictionary.Add("nature_de_lincident_nature", "fraude_nature");
            fieldsDictionary.Add("preuves_significatives_signalement_superieur_hierarchique", "oui_non");
            fieldsDictionary.Add("preuves_significatives_une_implication_externe", "oui_non");
            fieldsDictionary.Add("preuves_significatives_avec_quelle_instance", "recours_instance");

            //PSE
            fieldsDictionary.Add("violence_physique_nature", "violence_physique_nature");
            fieldsDictionary.Add("violence_sexuelle_nature", "violence_sexuelle_nature");
            fieldsDictionary.Add("violence_psychologique_nature", "violence_psychologique_nature");
            fieldsDictionary.Add("negligence_nature", "negligence");
            fieldsDictionary.Add("informations_supplementaires_y_a_t_il_dautres_actions", "oui_non");

            fieldsDictionary.Add("victime_enfant_statut", "victime_statut");
            fieldsDictionary.Add("victime_enfant_sexe", "sexe");

            fieldsDictionary.Add("agresseur_statut", "agresseur_statut");
            fieldsDictionary.Add("agresseur_sexe", "sexe");

            //Securities
            fieldsDictionary.Add("sante_employe", "sante_employe");
            fieldsDictionary.Add("sante_nature", "sante_nature");
            fieldsDictionary.Add("accident_lie_au_deplacement_nature", "accident_deplacement_nature");
            fieldsDictionary.Add("maintenance_du_bureau_nature", "maintenance_bureau");
            fieldsDictionary.Add("catastrophe_naturelle_nature", "catastrophe_naturelle");
            fieldsDictionary.Add("degat_materiel_nature", "degat_materiel");

            fieldsDictionary.Add("menace_envers", "menace_envers");
            fieldsDictionary.Add("menace_nature", "menace_nature");
            fieldsDictionary.Add("agression_employe", "sante_employe");
            fieldsDictionary.Add("agression_nature", "agression_nature");
            fieldsDictionary.Add("enlevement_employe", "sante_employe");
            fieldsDictionary.Add("enlevement_nature", "enlevement_nature");
            fieldsDictionary.Add("vol_intrusion_nature", "vol_intrusion_nature");
            fieldsDictionary.Add("attaque_nature", "attaque_nature");
            fieldsDictionary.Add("troubles_public_nature", "troubles_publics_nature");
            fieldsDictionary.Add("impact_sur_le_programme_suivi_judicaire", "oui_non");
        }
    }
}