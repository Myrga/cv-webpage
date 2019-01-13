using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FormationCV.Front.Models;
using FormationCV.Data;
using FormationCV.Front.ViewModels;
using Microsoft.EntityFrameworkCore;

namespace FormationCV.Front.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            using (var context = new Context())
            {
                var CV = context.CVs.Select(cv => new CVVM
                {
                    Id = cv.Id,
                    CodePostal = cv.CodePostal,
                    Commune = cv.Commune,
                    DateDeNaissance = cv.DateDeNaissance,
                    Nom = cv.Nom,
                    NumeroDeRue = cv.NumeroDeRue,
                    Permis = cv.Permis,
                    Prenom = cv.Prenom,
                    Rue = cv.Rue,
                    Titre = cv.Titre,
                    Competences = cv.Competences.Select(comp => new CompetenceVM
                    {
                        Id = comp.Id,
                        Label = comp.Label
                    }),
                    Experiences = cv.Experiences.Select(exp => new ExperienceVM
                    {
                        Id = exp.Id,
                        DateDebut = exp.DateDebut,
                        DateFin = exp.DateFin,
                        Description = exp.Description,
                        Entreprise = exp.Entreprise,
                        Poste = exp.Poste
                    }),
                    Formations = cv.Formations.Select(form => new FormationVM
                    {
                        Id = form.Id,
                        DateDebut = form.DateDebut,
                        DateFin = form.DateFin,
                        Description = form.Description,
                        Diplome = form.Diplome,
                        Ecole = form.Ecole,
                        Intitule = form.Intitule
                    }),
                    Langues = cv.Langues.Select(lang => new LangueVM
                    {
                        Id = lang.Id,
                        Label = lang.Label,
                        Niveau = lang.Niveau
                    })
                }).FirstOrDefault(cv => cv.Id == 1005);

                return View("Index_bootstrap", CV);
            }
        }

        public IActionResult ModifierExperience(ExperienceVM experience)
        {
            using (var context = new Context())
            {
                var experienceModel = context.Experiences.FirstOrDefault(e => e.Id == experience.Id);
                experienceModel.Description = experience.Description;
                experienceModel.Poste = experience.Poste;
                experienceModel.DateDebut = experience.DateDebut;
                experienceModel.DateFin = experience.DateFin;
                experienceModel.Entreprise = experience.Entreprise;

                context.SaveChanges();

                var CV = context.CVs.Select(cv => new CVVM
                {
                    Id = cv.Id,
                    CodePostal = cv.CodePostal,
                    Commune = cv.Commune,
                    DateDeNaissance = cv.DateDeNaissance,
                    Nom = cv.Nom,
                    NumeroDeRue = cv.NumeroDeRue,
                    Permis = cv.Permis,
                    Prenom = cv.Prenom,
                    Rue = cv.Rue,
                    Titre = cv.Titre,
                    Competences = cv.Competences.Select(comp => new CompetenceVM
                    {
                        Id = comp.Id,
                        Label = comp.Label
                    }),
                    Experiences = cv.Experiences.Select(exp => new ExperienceVM
                    {
                        Id = exp.Id,
                        DateDebut = exp.DateDebut,
                        DateFin = exp.DateFin,
                        Description = exp.Description,
                        Entreprise = exp.Entreprise,
                        Poste = exp.Poste
                    }),
                    Formations = cv.Formations.Select(form => new FormationVM
                    {
                        Id = form.Id,
                        DateDebut = form.DateDebut,
                        DateFin = form.DateFin,
                        Description = form.Description,
                        Diplome = form.Diplome,
                        Ecole = form.Ecole,
                        Intitule = form.Intitule
                    }),
                    Langues = cv.Langues.Select(lang => new LangueVM
                    {
                        Id = lang.Id,
                        Label = lang.Label,
                        Niveau = lang.Niveau
                    })
                }).FirstOrDefault(cv => cv.Id == 1005);

                return View("Index_bootstrap", CV);
            }
        }

        public IActionResult ModifierExperienceAjax(ExperienceVM experience)
        {
            using (var context = new Context())
            {
                var experienceModel = context.Experiences.FirstOrDefault(e => e.Id == experience.Id);
                experienceModel.Description = experience.Description;
                experienceModel.Poste = experience.Poste;
                experienceModel.DateDebut = experience.DateDebut;
                experienceModel.DateFin = experience.DateFin;
                experienceModel.Entreprise = experience.Entreprise;

                context.SaveChanges();

                return Json(null);
            }
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
