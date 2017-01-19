using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PagedList;
using TdH.Utils;
using TdH_2.Models;

namespace TdH_2.Controllers
{
    public class securitiesController : Controller
    {
        private tdhEntities db = new tdhEntities();

        // GET: securities
        public ActionResult Index(string sortOrder, string currentFilter, string searchString, int? page)
        {
            IOrderedQueryable<securities> s = db.securities;

            ViewBag.CurrentSort = sortOrder;

            s = s.OrderByDescending(so => so.ID);

            // Pagination
            int pageSize = 20;
            int pageNumber = (page ?? 1);

            IPagedList<securities> securitiesList = s.ToPagedList(pageNumber, pageSize);
            List<securities> data = securitiesList.ToList();

            for (int i = 0; i < data.Count; i++)
            {
                data[i] = LoadLists(data[i]);
            }

            ViewBag.pagination = securitiesList;
            return View(data);
        }

        // GET: securities/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            securities securities = db.securities.Find(id);
            if (securities == null)
            {
                return HttpNotFound();
            }
            return View(securities);
        }

        // GET: securities/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: securities/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,date_incident,lieu_incident,zone,pays,gravite_incident,responsabilite_tdh,resume_incident,sante,sante_employe,sante_nature,sante_autre,accident_lie_au_deplacement,accident_lie_au_deplacement_nature,accident_lie_au_deplacement_autre,maintenance_du_bureau,maintenance_du_bureau_nature,maintenance_du_bureau_autre,catastrophe_naturelle,catastrophe_naturelle_nature,catastrophe_naturelle_autre,degat_materiel,degat_materiel_nature,degat_materiel_autre,surete_autre,surete_autre_description,menace,menace_envers,menace_envers_autre,menace_nature,menace_nature_autre,agression,agression_employe,agression_nature,agression_autre,enlevement,enlevement_employe,enlevement_nature,enlevement_autre,vol_intrusion,vol_intrusion_nature,vol_intrusion_autre,attaque,attaque_nature,attaque_autre,troubles_publics,troubles_publics_nature,troubles_publics_autre,securite_autre,securite_autre_desctiption,details_de_lincident,raisons_de_la_presence_de_tdh,mesures_prises_par_la_delegation,recommandations_du_delegue,personnes_impliquees_expatrie,personnes_impliquees_consultant_prestataire_expatrie,personnes_impliquees_staff_national_tdh,personnes_impliquees_consultant_prestataire_local,personnes_impliquees_tiers,personnes_impliquees_nombre_total_de_personnes,implication_exterieure_police,implication_exterieure_juge_de_paix,implication_exterieure_tiers_population,implication_exterieure_hopital_centre_de_sante,implication_exterieure_compagnie_dassurance,implication_exterieure_aucune,implication_exterieure_autre,implication_exterieure_autre_description,impact_sur_le_programme_hibernation,impact_sur_le_programme_nb_de_jours,impact_sur_le_programme_evacuation,impact_sur_le_programme_nb_de_personnes,impact_sur_le_programme_evacuation_medicale,impact_sur_le_programme_nb_de_jours_sans_travailler,impact_sur_le_programme_cout_financier,impact_sur_le_programme_montant_approximatif,impact_sur_le_programme_suivi_judicaire,impact_sur_le_programme_autre,impact_sur_le_programme_aucun,impact_sur_le_programme_autre_description,incident_demande_suivi,incident_demande_suivi_type,support_necessaire,support_necessaire_type,plan_securite_change,plan_securite_envoyer_au_siege,plan_securite_envoyer_au_siege_date,rapport_rempli_par,date_de_lenvoi_au_siege,rapport_traite_par,mise_a_jour_du_cas,mise_a_jour_du_cas_date,a_remplir_par_le_siege_numero_de_lincident,a_remplir_par_le_siege_recu_par,a_remplir_par_le_siege_recu_par_autre,a_remplir_par_le_siege_traite_au_siege_par,a_remplir_par_le_siege_mise_a_jour_recommandation,a_remplir_par_le_siege_statut,a_remplir_par_le_siege_date_de_fermeture,annee,langue")] securities securities)
        {
            if (ModelState.IsValid)
            {
                db.securities.Add(securities);
                db.SaveChanges();
                TempData["message"] = "La sécurité et sureté a été créée";
                return RedirectToAction("Index");
            }

            return View(securities);
        }

        // GET: securities/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            securities securities = db.securities.Find(id);
            if (securities == null)
            {
                return HttpNotFound();
            }

            securities.selectedCountry = (int)securities.pays;

            return View(LoadLists(securities));

        }

        // POST: securities/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,date_incident,lieu_incident,zone,pays,gravite_incident,responsabilite_tdh,resume_incident,sante,sante_employe,sante_nature,sante_autre,accident_lie_au_deplacement,accident_lie_au_deplacement_nature,accident_lie_au_deplacement_autre,maintenance_du_bureau,maintenance_du_bureau_nature,maintenance_du_bureau_autre,catastrophe_naturelle,catastrophe_naturelle_nature,catastrophe_naturelle_autre,degat_materiel,degat_materiel_nature,degat_materiel_autre,surete_autre,surete_autre_description,menace,menace_envers,menace_envers_autre,menace_nature,menace_nature_autre,agression,agression_employe,agression_nature,agression_autre,enlevement,enlevement_employe,enlevement_nature,enlevement_autre,vol_intrusion,vol_intrusion_nature,vol_intrusion_autre,attaque,attaque_nature,attaque_autre,troubles_publics,troubles_publics_nature,troubles_publics_autre,securite_autre,securite_autre_desctiption,details_de_lincident,raisons_de_la_presence_de_tdh,mesures_prises_par_la_delegation,recommandations_du_delegue,personnes_impliquees_expatrie,personnes_impliquees_consultant_prestataire_expatrie,personnes_impliquees_staff_national_tdh,personnes_impliquees_consultant_prestataire_local,personnes_impliquees_tiers,personnes_impliquees_nombre_total_de_personnes,implication_exterieure_police,implication_exterieure_juge_de_paix,implication_exterieure_tiers_population,implication_exterieure_hopital_centre_de_sante,implication_exterieure_compagnie_dassurance,implication_exterieure_aucune,implication_exterieure_autre,implication_exterieure_autre_description,impact_sur_le_programme_hibernation,impact_sur_le_programme_nb_de_jours,impact_sur_le_programme_evacuation,impact_sur_le_programme_nb_de_personnes,impact_sur_le_programme_evacuation_medicale,impact_sur_le_programme_nb_de_jours_sans_travailler,impact_sur_le_programme_cout_financier,impact_sur_le_programme_montant_approximatif,impact_sur_le_programme_suivi_judicaire,impact_sur_le_programme_autre,impact_sur_le_programme_aucun,impact_sur_le_programme_autre_description,incident_demande_suivi,incident_demande_suivi_type,support_necessaire,support_necessaire_type,plan_securite_change,plan_securite_envoyer_au_siege,plan_securite_envoyer_au_siege_date,rapport_rempli_par,date_de_lenvoi_au_siege,rapport_traite_par,mise_a_jour_du_cas,mise_a_jour_du_cas_date,a_remplir_par_le_siege_numero_de_lincident,a_remplir_par_le_siege_recu_par,a_remplir_par_le_siege_recu_par_autre,a_remplir_par_le_siege_traite_au_siege_par,a_remplir_par_le_siege_mise_a_jour_recommandation,a_remplir_par_le_siege_statut,a_remplir_par_le_siege_date_de_fermeture,annee,langue")] securities securities)
        {
            if (ModelState.IsValid)
            {
                db.Entry(securities).State = EntityState.Modified;
                if (db.SaveChanges() == -1)
                {
                    TempData["css"] = "danger";
                    TempData["message"] = "Problème lors de l'enregistrement !";
                }
                else
                {
                    TempData["css"] = "success";
                    TempData["message"] = "L'entrée a bien été mise à jour";
                }
                return RedirectToAction("Index");
            }
            return View(securities);
        }

        // GET: securities/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            securities securities = db.securities.Find(id);
            if (securities == null)
            {
                return HttpNotFound();
            }
            return View(securities);
        }

        // POST: securities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            securities securities = db.securities.Find(id);
            db.securities.Remove(securities);
            db.SaveChanges();
            TempData["message"] = "La sécurité et sureté a été supprimée";
            return RedirectToAction("Index");
        }

        public JsonResult getSecurities()
        {
            var dbResult = db.securities.ToList();
            var securities = (from security in dbResult
                        select new
                        {
                            security.ID,
                            security.date_incident,
                            security.lieu_incident,
                            security.zone,
                            security.pays,
                            security.gravite_incident,
                            security.responsabilite_tdh,
                            security.details_de_lincident
                        });
            return Json(securities, JsonRequestBehavior.AllowGet);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private securities LoadLists(securities security)
        {
            TranslateManager translateManager = new TranslateManager(1);
            var pays = translateManager.loadTranslate("pays");
            var zone = translateManager.loadTranslate("zone");
            var graviteIncidents = translateManager.loadTranslate("gravite_incident");
            var santeEmploye = translateManager.loadTranslate("sante_employe");
            var santeNature = translateManager.loadTranslate("sante_nature");
            var accidentTravel  = translateManager.loadTranslate("accident_lie_au_deplacement_nature");
            var maintenanceOffice = translateManager.loadTranslate("maintenance_du_bureau_nature");
            var naturalDisaster = translateManager.loadTranslate("catastrophe_naturelle_nature");
            var materials = translateManager.loadTranslate("degat_materiel_nature");
            var threatAgainst = translateManager.loadTranslate("menace_envers");
            var threatNature = translateManager.loadTranslate("menace_nature");
            var aggressionEmploye = translateManager.loadTranslate("agression_employe");
            var aggressionNature = translateManager.loadTranslate("agression_nature");
            var kidnappingEmploye = translateManager.loadTranslate("enlevement_employe");
            var kidnappingNature = translateManager.loadTranslate("enlevement_nature");
            var steal = translateManager.loadTranslate("vol_intrusion_nature");
            var attack = translateManager.loadTranslate("attaque_nature");
            var publicDisorder = translateManager.loadTranslate("troubles_publics_nature");
            var receivedBy = translateManager.loadTranslate("a_remplir_par_le_siege_recu_par");
            var status = translateManager.loadTranslate("a_remplir_par_le_siege_statut");


            security.listPays = translateManager.convertToSelectList(pays);
            security.listZones = translateManager.convertToSelectList(zone);
            security.listGraviteIncidents = translateManager.convertToSelectList(graviteIncidents);
            security.listHealthEmploye = translateManager.convertToSelectList(santeEmploye);
            security.listHealthNature = translateManager.convertToSelectList(santeNature);
            security.listAccident = translateManager.convertToSelectList(accidentTravel);
            security.listMaintenance = translateManager.convertToSelectList(maintenanceOffice);
            security.listDisaster = translateManager.convertToSelectList(naturalDisaster);
            security.listMaterials = translateManager.convertToSelectList(materials);
            security.listThreatsAgain = translateManager.convertToSelectList(threatAgainst);
            security.listThreatsNature = translateManager.convertToSelectList(threatNature);
            security.listAgressionEmployee = translateManager.convertToSelectList(aggressionEmploye);
            security.listAgressionNature = translateManager.convertToSelectList(aggressionNature);
            security.listKidnappingEmployee = translateManager.convertToSelectList(kidnappingEmploye);
            security.listKidnappingNature = translateManager.convertToSelectList(kidnappingNature);
            security.listStealNature = translateManager.convertToSelectList(steal);
            security.listAttackNature = translateManager.convertToSelectList(attack);
            security.listPublicTroubleNature = translateManager.convertToSelectList(publicDisorder);
            security.ReceiveBy = translateManager.convertToSelectList(receivedBy);
            security.listStatus = translateManager.convertToSelectList(status);
        
            return security;
        }
    }
}
