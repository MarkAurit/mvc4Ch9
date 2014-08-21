using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using Microsoft.Ajax.Utilities;

namespace Models02.Models
{
    public class ConferenceContextInitializer : DropCreateDatabaseAlways<ConferenceContext>
    {
        protected override void Seed(ConferenceContext context)
        {

            context.Sessions.Add(
                new Session()
                {
                    Title = "I want Pizza",
                    Abstract = "Pepperoni",
                    Speaker = context.Speakers.Add(
                        new Speaker()
                        {
                            Name = "Drew Brees",
                            EmailAddress = "db@saints.com"
                        })
                });
            context.SaveChanges();
        }
    }
}