﻿using Assignment_12.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment_12.Controllers
{
    public class CricketController : Controller
    {

        // GET: Cricket
        static List<Cricket> listCricketTeams = new List<Cricket>()
     {
     new Cricket() { TeamId =1,TeamName="india",NOWC=2},
    new Cricket() { TeamId =2,TeamName="Australia",NOWC=4},
    new Cricket() { TeamId =3,TeamName="Weat Indies",NOWC=2},
    new Cricket() { TeamId =4,TeamName="England",NOWC=1},
     };
        // GET: Cricket
        [HttpGet]
        public ActionResult create()
        {
            return View(new Cricket());
        }

        [HttpPost]
        public ActionResult Create(Cricket team)
        {
            if (ModelState.IsValid)
            {
                listCricketTeams.Add(team);
            }
            return RedirectToAction("Index");
        }
        public ActionResult Index()
        {
            return View(listCricketTeams);
        }
        public ActionResult Display()
        {
            return View();
        }

    }
}