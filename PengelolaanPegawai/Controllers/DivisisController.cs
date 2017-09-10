﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PengelolaanPegawai.Models;

namespace PengelolaanPegawai.Controllers
{
    public class DivisisController : Controller
    {
        private PegawaiDBEntities db = new PegawaiDBEntities();

        // GET: Divisis
        public ActionResult Index()
        {
            return View(db.Divisi.ToList());
        }

        // GET: Divisis/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Divisi divisi = db.Divisi.Find(id);
            if (divisi == null)
            {
                return HttpNotFound();
            }
            return View(divisi);
        }

        // GET: Divisis/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Divisis/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "DivisiId,NamaDivisi")] Divisi divisi)
        {
            if (ModelState.IsValid)
            {
                db.Divisi.Add(divisi);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(divisi);
        }

        // GET: Divisis/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Divisi divisi = db.Divisi.Find(id);
            if (divisi == null)
            {
                return HttpNotFound();
            }
            return View(divisi);
        }

        // POST: Divisis/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "DivisiId,NamaDivisi")] Divisi divisi)
        {
            if (ModelState.IsValid)
            {
                db.Entry(divisi).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(divisi);
        }

        // GET: Divisis/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Divisi divisi = db.Divisi.Find(id);
            if (divisi == null)
            {
                return HttpNotFound();
            }
            return View(divisi);
        }

        // POST: Divisis/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Divisi divisi = db.Divisi.Find(id);
            db.Divisi.Remove(divisi);
            db.SaveChanges();
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
    }
}
