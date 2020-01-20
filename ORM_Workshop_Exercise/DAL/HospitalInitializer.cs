using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
//using System.Data.Entity;
using ORM_Workshop_Exercise.Models;
using Microsoft.EntityFrameworkCore;

namespace ORM_Workshop_Exercise.DAL
{
    public class HospitalInitializer //: System.Data.Entity.DropCreateDatabaseIfModelChanges<HospitalContext>
    {
        /*protected override void Seed(HospitalContext context)
        {
            var person = new List<Person>
            {
                new Person{PersonName="John",PersonSurname="Ojo",Gender=Gender.M,PersonIDnumber="970711",PersonEmail="j@gmail.com",PersonContactNumber="0123456789",PersonID=new Guid("0"),Active=Active.Y},
                new Person{PersonName="Anne",PersonSurname="Paul",Gender=Gender.F,PersonIDnumber="970722",PersonEmail="a@gmail.com",PersonContactNumber="0123456788",PersonID=new Guid("2"),Active=Active.Y}
            };

            person.ForEach(p => context.Person.Add(p));
            context.SaveChanges();

            var doctor = new List<Doctor>
            {
                new Doctor{DoctorID=new Guid("0"),PersonID=new Guid("0"),Specialist=Specialist.Y,CountryCode="ZAR"}
            };

            doctor.ForEach(p => context.Doctor.Add(p));
            context.SaveChanges();

            var visits = new List<Visits>
            {
                new Visits{VisitID=new Guid("0"),DoctorID=new Guid("0"),ClientID=new Guid("0")}
            };

            visits.ForEach(p => context.Visits.Add(p));
            context.SaveChanges();

            var client = new List<Client>
            {
                new Client{ClientID=new Guid("0"),PersonID=new Guid("1"),IllnessID=new Guid("0")}
            };

            client.ForEach(p => context.Client.Add(p));
            context.SaveChanges();

        }*/
    }
}
