﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;

namespace LeafSolutions.Models
{
    public static class Gmail
    {
        public static void SendMail(string body)
        {
            var fromAddress = new MailAddress("acabahacklenirmiyim@gmail.com", "Leaf Solutions Geribildirim");
            var toAddress = new MailAddress("acabahacklenirmiyim@gmail.com");
            const string subject = "Leaf Solutions Geribildirim";

            using (var smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, "trololol")
                //trololol kısmı e-posta adresinin şifresi
            })
            {
                using (var message = new MailMessage(fromAddress, toAddress) { Subject = subject, Body = body })
                {
                    smtp.Send(message);
                }
            }
        }
    }
}