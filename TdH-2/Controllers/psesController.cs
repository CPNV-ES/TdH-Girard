using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TdH.Utils;
using TdH_2.Models;
using PagedList;

namespace TdH_2.Controllers
{
    public class psesController : Controller
    {
        private tdhEntities db = new tdhEntities();

        // GET: pses
        public ActionResult Index(string sortOrder, string currentFilter, string searchString, int? page)
        {
            IOrderedQueryable<pse> pse = db.pse;

            ViewBag.CurrentSort = sortOrder;

            pse = pse.OrderByDescending(s => s.ID);

            // Pagination
            int pageSize = 20;
            int pageNumber = (page ?? 1);

            IPagedList<pse> pseList = pse.ToPagedList(pageNumber, pageSize);
            List<pse> data = pseList.ToList();

            for (int i = 0; i < data.Count; i++)
            {
                data[i] = LoadLists(data[i]);
            }

            ViewBag.pagination = pseList;
            return View(data);
        }

        // GET: pses/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            pse pse = db.pse.Find(id);
            if (pse == null)
            {
                return HttpNotFound();
            }
            return View(pse);
        }

        // GET: pses/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: pses/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,date_incident,lieu_incident,zone,pays,gravite_incident,responsabilite_tdh,resume_incident,violence_physique,violence_physique_nature,violence_physique_autre,violence_sexuelle,violence_sexuelle_nature,violence_sexuelle_autre,violence_psychologique,violence_psychologique_nature,violence_psychologique_autre,negligence,negligence_nature,negligence_autre,details_de_lincident,victime_enfant_statut,victime_enfant_nom,victime_enfant_date_de_naissance,victime_enfant_age,victime_enfant_sexe,victime_enfant_adresse,victime_enfant_handicap,victime_enfant_autre_information_importante,agresseur_statut,agresseur_nom,agresseur_position,agresseur_age,agresseur_sexe,agresseur_statut_familial,agresseur_nom_de_lemployeur,agresseur_lien_avec_tdh,agresseur_lien_avec_lenfant,agresseur_autre_information_importante,personne_signalant_nom,personne_signalant_position,personne_signalant_adresse,personne_signalant_nom_de_lemployeur,personne_signalant_lien_avec_tdh,personne_signalant_lien_avec_lenfant,personne_signalant_autre_information_importante,mesures_prises_pour_proteger_lenfant,mesures_prises_pour_eviter_la_recidive,mesures_prises_pour_proteger_laction_de_tdh,informations_supplementaires_quest_ce_que_lenfant_souhaite,informations_supplementaires_de_quel_soutien_lenfant_a_t_il_besoin,informations_supplementaires_qui_doit_apporter_ce_soutien,informations_supplementaires_y_a_t_il_dautres_actions,informations_supplementaires_qui_quand,informations_supplementaires_qui_va_suivre,informations_supplementaires_lecons_apprises,recommandations_du_delegue,rapport_rempli_par,date_de_lenvoi_au_siege,rapport_traite_par,mise_a_jour_du_cas,mise_a_jour_du_cas_date,a_remplir_par_le_siege_numero_de_lincident,a_remplir_par_le_siege_recu_par,a_remplir_par_le_siege_recu_par_autre,a_remplir_par_le_siege_traite_au_siege_par,a_remplir_par_le_siege_mise_a_jour_recommandation,a_remplir_par_le_siege_date_de_fermeture,a_remplir_par_le_siege_statut,annee,langue")] pse pse)
        {
            if (ModelState.IsValid)
            {
                db.pse.Add(pse);
                db.SaveChanges();

                TempData["message"] = "Le pse a été crée";
                return RedirectToAction("Index");
            }

            return View(pse);
        }

        // GET: pses/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            pse pse = db.pse.Find(id);
            if (pse == null)
            {
                return HttpNotFound();
            }
            return View(LoadLists(pse));
        }

        // POST: pses/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,date_incident,lieu_incident,zone,pays,gravite_incident,responsabilite_tdh,resume_incident,violence_physique,violence_physique_nature,violence_physique_autre,violence_sexuelle,violence_sexuelle_nature,violence_sexuelle_autre,violence_psychologique,violence_psychologique_nature,violence_psychologique_autre,negligence,negligence_nature,negligence_autre,details_de_lincident,victime_enfant_statut,victime_enfant_nom,victime_enfant_date_de_naissance,victime_enfant_age,victime_enfant_sexe,victime_enfant_adresse,victime_enfant_handicap,victime_enfant_autre_information_importante,agresseur_statut,agresseur_nom,agresseur_position,agresseur_age,agresseur_sexe,agresseur_statut_familial,agresseur_nom_de_lemployeur,agresseur_lien_avec_tdh,agresseur_lien_avec_lenfant,agresseur_autre_information_importante,personne_signalant_nom,personne_signalant_position,personne_signalant_adresse,personne_signalant_nom_de_lemployeur,personne_signalant_lien_avec_tdh,personne_signalant_lien_avec_lenfant,personne_signalant_autre_information_importante,mesures_prises_pour_proteger_lenfant,mesures_prises_pour_eviter_la_recidive,mesures_prises_pour_proteger_laction_de_tdh,informations_supplementaires_quest_ce_que_lenfant_souhaite,informations_supplementaires_de_quel_soutien_lenfant_a_t_il_besoin,informations_supplementaires_qui_doit_apporter_ce_soutien,informations_supplementaires_y_a_t_il_dautres_actions,informations_supplementaires_qui_quand,informations_supplementaires_qui_va_suivre,informations_supplementaires_lecons_apprises,recommandations_du_delegue,rapport_rempli_par,date_de_lenvoi_au_siege,rapport_traite_par,mise_a_jour_du_cas,mise_a_jour_du_cas_date,a_remplir_par_le_siege_numero_de_lincident,a_remplir_par_le_siege_recu_par,a_remplir_par_le_siege_recu_par_autre,a_remplir_par_le_siege_traite_au_siege_par,a_remplir_par_le_siege_mise_a_jour_recommandation,a_remplir_par_le_siege_date_de_fermeture,a_remplir_par_le_siege_statut,annee,langue")] pse pse)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pse).State = EntityState.Modified;
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
            return View(pse);
        }

        // GET: pses/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            pse pse = db.pse.Find(id);
            if (pse == null)
            {
                return HttpNotFound();
            }
            return View(pse);
        }

        // POST: pses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            pse pse = db.pse.Find(id);
            db.pse.Remove(pse);
            if (db.SaveChanges() == -1)
            {
                TempData["css"] = "danger";
                TempData["message"] = "Problème lors de la suppression !";
            }
            else
            {
                TempData["css"] = "success";
                TempData["message"] = "L'entrée a bien été supprimée";
            }
            return RedirectToAction("Index");
        }

        public JsonResult getPses()
        {
            var dbResult = db.pse.ToList();
            var pses = (from pse in dbResult
                          select new
                          {
                              pse.ID,
                              pse.date_incident,
                              pse.lieu_incident,
                              pse.zone,
                              pse.pays,
                              pse.gravite_incident,
                              pse.responsabilite_tdh,
                              pse.details_de_lincident
                          });
            return Json(pses, JsonRequestBehavior.AllowGet);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }


        private pse LoadLists(pse pse)
        {
            TranslateManager translateManager = new TranslateManager(1);
            var pays = translateManager.loadTranslate("pays");
            var zone = translateManager.loadTranslate("zone");
            var graviteIncidents = translateManager.loadTranslate("gravite_incident");
            var violencePhysique = translateManager.loadTranslate("violence_physique_nature");
            var violenceSexual = translateManager.loadTranslate("violence_sexuelle_nature");
            var violencePsy = translateManager.loadTranslate("violence_psychologique_nature");
            var violenceNegligence = translateManager.loadTranslate("negligence_nature");
            var statusChild = translateManager.loadTranslate("victime_enfant_statut");
            var sexChild = translateManager.loadTranslate("victime_enfant_sexe");
            var statusAgressor = translateManager.loadTranslate("agresseur_statut");
            var sexAgressor = translateManager.loadTranslate("agresseur_sexe");
            var status = translateManager.loadTranslate("a_remplir_par_le_siege_statut");

            pse.listPays = translateManager.convertToSelectList(pays);
            pse.listZones = translateManager.convertToSelectList(zone);
            pse.listGraviteIncidents = translateManager.convertToSelectList(graviteIncidents);
            pse.listPhysical = translateManager.convertToSelectList(violencePhysique);
            pse.listSexual = translateManager.convertToSelectList(violenceSexual);
            pse.listPsy = translateManager.convertToSelectList(violencePsy);
            pse.listNegligence = translateManager.convertToSelectList(violenceNegligence);
            pse.listStatusChild = translateManager.convertToSelectList(statusChild);
            pse.listSexChild = translateManager.convertToSelectList(sexChild);
            pse.listStatusAgressor = translateManager.convertToSelectList(statusAgressor);
            pse.listSexAgressor = translateManager.convertToSelectList(sexAgressor);
            pse.listSexAgressor = translateManager.convertToSelectList(sexAgressor);
            pse.listStatus = translateManager.convertToSelectList(status);



            return pse;
        }
    }
}
