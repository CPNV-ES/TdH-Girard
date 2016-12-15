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
            fieldsDictionary.Add("zone", "zone");
            fieldsDictionary.Add("pays", "pays");
            fieldsDictionary.Add("gravite_incident", "gravite");

            fieldsDictionary.Add("nature_de_lincident_nature", "fraude_nature");
            //fieldsDictionary.Add("instance", "recours_instance");
            //fieldsDictionary.Add("recu_par", "recu_par");
            //fieldsDictionary.Add("statut", "statut");

        }
    }
}