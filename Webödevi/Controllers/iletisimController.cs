﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using LeafSolutions.Models;

namespace LeafSolutions.Controllers
{
    public class iletisimController : Controller
    {
        //
        // GET: /iletisim/

        public ActionResult iletisim()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Iletisim(IletisimModel model)
        {
            if (ModelState.IsValid)
            {
                var body = new StringBuilder();
                body.AppendLine("Rumuz: " + model.NickName);
                body.AppendLine("İsim: " + model.FullName);
                body.AppendLine("Tel: " + model.Phone);
                body.AppendLine("Eposta: " + model.Email);
                body.AppendLine("Konu: " + model.Message);

                Gmail.SendMail(body.ToString());
                ViewBag.Success = true;
            }

            return View();

        }

    }
}
