using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using System.Web.Security;
using PagedList;
using TdH.Utils;
using TdH_2.Models;


namespace TdH_2.Controllers
{
    public class fraudsController : Controller
    {
        private tdhEntities db = new tdhEntities();

        // GET: frauds
        // Install-Package PagedList.Mvc
        public ActionResult Index(string sortOrder, string currentFilter, string searchString, int? page)
        {

            IOrderedQueryable<frauds> f = db.frauds;

            ViewBag.CurrentSort = sortOrder;

            f =  f.OrderByDescending(s => s.id);

            // Pagination
            int pageSize = 20;
            int pageNumber = (page ?? 1);

            IPagedList<frauds> fraudList = f.ToPagedList(pageNumber, pageSize);
            List<frauds> data = fraudList.ToList();

            for (int i = 0; i < data.Count; i++)
            {
                data[i] = LoadLists(data[i]);
            }

            ViewBag.pagination = fraudList;
            return View(data);

        }

        // GET: frauds/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            frauds frauds = db.frauds.Find(id);
            if (frauds == null)
            {
                return HttpNotFound();
            }
            return View(frauds);
        }

        // GET: frauds/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: frauds/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,date_incident,lieu_incident,zone,pays,gravite_incident,responsabilite_tdh,Responsable,resume_incident,nature_de_lincident_nature,nature_de_lincident_autre,nature_de_lincident_estimation_du_montant,details_de_lincident,preuves_significatives_signalement_superieur_hierarchique,SignSupResp,preuves_significatives_signalement_superieur_hierarchique_date,preuves_significatives_une_implication_externe,ExternalImplication,preuves_significatives_une_implication_externe_date,preuves_significatives_avec_quelle_instance,preuves_significatives_si_autre,mesures_prises_par_la_delegation,recommandations_du_delegue_et_ou_de_la_personne_en_charge_des_finances,personnes_impliquees_expatrie,personnes_impliquees_consultant_prestataire_expatrie,personnes_impliquees_staff_national_tdh,personnes_impliquees_consultant_prestataire_local,personnes_impliquees_tiers,personnes_impliquees_nombre_total_de_personnes_impliquees,incident_demande_suivi,incident_demande_suivi_type,support_necessaire,support_necessaire_type,rapport_rempli_par,date_de_lenvoi_au_siege,rapport_traite_par,mise_a_jour_du_cas,mise_a_jour_du_cas_date,a_remplir_par_le_siege_numero_de_lincident,a_remplir_par_le_siege_recu_par,a_remplir_par_le_siege_recu_par_autre,a_remplir_par_le_siege_traite_au_siege_par,a_remplir_par_le_siege_montant_chf,a_remplir_par_le_siege_mise_a_jour_recommandation,a_remplir_par_le_siege_date_de_fermeture,a_remplir_par_le_siege_statut,annee,langue")] frauds frauds)
        {
            if (ModelState.IsValid)
            {
                db.frauds.Add(frauds);
                db.SaveChanges();
                TempData["message"] = "La fraude a été crée";
                return RedirectToAction("Index");
            }

            return View(frauds);
        }

        // GET: frauds/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            frauds frauds = db.frauds.Find(id);
            if (frauds == null)
            {
                return HttpNotFound();
            }
            frauds.selectedCountry = (int)frauds.pays;

            return View(LoadLists(frauds));
        }

        // POST: frauds/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,date_incident,lieu_incident,zone,pays,gravite_incident,responsabilite_tdh,Responsable,resume_incident,nature_de_lincident_nature,nature_de_lincident_autre,nature_de_lincident_estimation_du_montant,details_de_lincident,preuves_significatives_signalement_superieur_hierarchique,SignSupResp,preuves_significatives_signalement_superieur_hierarchique_date,preuves_significatives_une_implication_externe,ExternalImplication,preuves_significatives_une_implication_externe_date,preuves_significatives_avec_quelle_instance,preuves_significatives_si_autre,mesures_prises_par_la_delegation,recommandations_du_delegue_et_ou_de_la_personne_en_charge_des_finances,personnes_impliquees_expatrie,personnes_impliquees_consultant_prestataire_expatrie,personnes_impliquees_staff_national_tdh,personnes_impliquees_consultant_prestataire_local,personnes_impliquees_tiers,personnes_impliquees_nombre_total_de_personnes_impliquees,incident_demande_suivi,incident_demande_suivi_type,support_necessaire,support_necessaire_type,rapport_rempli_par,date_de_lenvoi_au_siege,rapport_traite_par,mise_a_jour_du_cas,mise_a_jour_du_cas_date,a_remplir_par_le_siege_numero_de_lincident,a_remplir_par_le_siege_recu_par,a_remplir_par_le_siege_recu_par_autre,a_remplir_par_le_siege_traite_au_siege_par,a_remplir_par_le_siege_montant_chf,a_remplir_par_le_siege_mise_a_jour_recommandation,a_remplir_par_le_siege_date_de_fermeture,a_remplir_par_le_siege_statut,annee,langue")] frauds frauds)
        {
            if (ModelState.IsValid)
            {
                db.Entry(frauds).State = EntityState.Modified;
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

            return View(frauds);
        }

        // GET: frauds/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            frauds frauds = db.frauds.Find(id);
            if (frauds == null)
            {
                return HttpNotFound();
            }
            return View(frauds);
        }

        // POST: frauds/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            frauds frauds = db.frauds.Find(id);
            db.frauds.Remove(frauds);
            db.SaveChanges();
            TempData["message"] = "La fraude a bien été supprimée";
            return RedirectToAction("Index");
        }

    
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
        private frauds LoadLists(frauds fraud)
        {
            TranslateManager translateManager = new TranslateManager(1);
            var pays = translateManager.loadTranslate("pays");
            var zone = translateManager.loadTranslate("zone");
            var graviteIncidents = translateManager.loadTranslate("gravite_incident");
            var natureIncidents = translateManager.loadTranslate("nature_de_lincident_nature");
            var recuPar = translateManager.loadTranslate("a_remplir_par_le_siege_recu_par");
            var status = translateManager.loadTranslate("a_remplir_par_le_siege_statut");
            var instance = translateManager.loadTranslate("preuves_significatives_avec_quelle_instance");


            //var responsableTDH = translateManager.loadTranslate("incident");

            fraud.listPays = translateManager.convertToSelectList(pays);
            fraud.listZones = translateManager.convertToSelectList(zone);
            fraud.listGraviteIncidents = translateManager.convertToSelectList(graviteIncidents);
            fraud.listNatureIncidents = translateManager.convertToSelectList(natureIncidents); 
            fraud.listRecuPar = translateManager.convertToSelectList(recuPar); 
            fraud.listStatus = translateManager.convertToSelectList(status);

            fraud.listInstance = translateManager.convertToSelectList(instance);


            return fraud;
        }
    }
}
