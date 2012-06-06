using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;
using System.Net.Mime;
using System.Net;

namespace Metier
{
    public class Mail
    {
        //serveur Smtp
        private SmtpClient serveurSmtp;

        //objet Mail
        private MailMessage mailActuel;

        //
        private string hostSmtp = "smtp.gmail.com";
        private NetworkCredential hostCredentials = new NetworkCredential("youfoodrestaurant@gmail.com", "ProjetSupinf0");
        private MailAddress sender = new MailAddress("youfoodrestaurant@gamil.com", "YouFood Restaurant");

        //destinataire
        public string Destinataire
        {
            get
            {
                return this.mailActuel.To.ToString();
            }
            set
            {
                this.mailActuel.To.Add(new MailAddress(value));
            }
        }

        //Contenu du mail
        public string Message
        {
            get
            {
                return this.mailActuel.Body;
            }
            set
            {
                if (value != null || value != "")
                {
                    this.mailActuel.Body = value;
                }
            }
        }

        //titre du mail
        public string Titre
        {
            get
            {
                return this.mailActuel.Subject;
            }
            set
            {
                this.mailActuel.Subject = value;
            }
        }

        public Mail()
        {
            this.serveurSmtp = new SmtpClient();

            //initialise le serveur d'envoi sur celui de google
            this.serveurSmtp.Host = this.hostSmtp;

            this.serveurSmtp.UseDefaultCredentials = false;

            this.serveurSmtp.Credentials = this.hostCredentials;

            this.mailActuel = new MailMessage();

            //initialise l'adresse d'envoi
            this.mailActuel.From = this.sender;
        }

        public void envoyer()
        {
            this.serveurSmtp.Send(this.mailActuel);
        }
    }
}