using System;
using System.Collections.Generic;
using MpgMvc.Models;

namespace MpgMvc.DAL
{
    public class MpgInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<MpgContext>
    {
        protected override void Seed(MpgContext context)
        {
            var users = new List<User>
            {
            new User{ID=1,Username="talz13",Password="test1234",LastLoginDt=DateTime.Parse("2020/02/25"),CreatedDt=DateTime.Parse("2020/02/24")}
            };

            users.ForEach(s => context.Users.Add(s));
            context.SaveChanges();

            var vehicles = new List<Vehicle>
            {
                new Vehicle{ID=1,UserID=1,Year=1994,Make="Nissan",Model="Altima",Trim="GLE",Color="Beige",DatePurchased=DateTime.Parse("2003/11/13"),DateSold=DateTime.Parse("2008/03/28"),MileagePurchased=45000,MileageCurrent=70000,MileageSold=70000,PricePurchased=5500,PriceSold=3000,LastUpdateDt=DateTime.Parse("2020/02/25 18:48:49"),CreateDt=DateTime.Parse("2020/02/25 18:48:49"),DefaultVehicle=false,Vin="VIN 1"},
                new Vehicle{ID=2,UserID=1,Year=2008,Make="Honda",Model="Civic",Trim="EX-Nav",Color="Atomic Blue Metallic",DatePurchased=DateTime.Parse("2008/03/28"),MileagePurchased=12,MileageCurrent=6500,PricePurchased=21000,LastUpdateDt=DateTime.Parse("2020/02/25 18:49:03"),CreateDt=DateTime.Parse("2020/02/25 18:49:03"),DefaultVehicle=true,Vin="VIN 2"}
            };
            vehicles.ForEach(s => context.Vehicles.Add(s));
            context.SaveChanges();

            var mileages = new List<Mileage>
            {
                new Mileage{ID=1,Date=DateTime.Parse("2007-03-07"),Miles=236.6M,Gallons=10.735M,PriceGallon=2.389M,VehicleID=1,UserID=1,Comment="",CreateDt=DateTime.Parse("2007-03-07")},
                new Mileage{ID=2,Date=DateTime.Parse("2007-03-25"),Miles=231.4M,Gallons=10.283M,PriceGallon=2.339M,VehicleID=1,UserID=1,Comment="",CreateDt=DateTime.Parse("2007-03-25")},
                new Mileage{ID=3,Date=DateTime.Parse("2007-04-13"),Miles=237.9M,Gallons=10.898M,PriceGallon=2.779M,VehicleID=1,UserID=1,Comment="",CreateDt=DateTime.Parse("2007-04-13")},
                new Mileage{ID=4,Date=DateTime.Parse("2007-05-01"),Miles=235.2M,Gallons=11.142M,PriceGallon=2.859M,VehicleID=1,UserID=1,Comment="ethanol?",CreateDt=DateTime.Parse("2007-05-01")},
                new Mileage{ID=5,Date=DateTime.Parse("2007-05-13"),Miles=158.1M,Gallons=7.239M,PriceGallon=3.159M,VehicleID=1,UserID=1,Comment="",CreateDt=DateTime.Parse("2007-05-13")},
                new Mileage{ID=6,Date=DateTime.Parse("2007-06-04"),Miles=236.6M,Gallons=10.71M,PriceGallon=3.099M,VehicleID=1,UserID=1,Comment="",CreateDt=DateTime.Parse("2007-06-04")},
                new Mileage{ID=7,Date=DateTime.Parse("2007-07-06"),Miles=154.2M,Gallons=7.65M,PriceGallon=2.869M,VehicleID=1,UserID=1,Comment="costco",CreateDt=DateTime.Parse("2007-07-06")},
                new Mileage{ID=8,Date=DateTime.Parse("2007-07-20"),Miles=105.3M,Gallons=4.861M,PriceGallon=2.879M,VehicleID=1,UserID=1,Comment="circle k",CreateDt=DateTime.Parse("2007-07-20")},
                new Mileage{ID=9,Date=DateTime.Parse("2007-07-22"),Miles=281.2M,Gallons=10M,PriceGallon=2.859M,VehicleID=1,UserID=1,Comment="sheetz, PA",CreateDt=DateTime.Parse("2007-07-22")},
                new Mileage{ID=10,Date=DateTime.Parse("2007-07-22"),Miles=263.5M,Gallons=6.723M,PriceGallon=2.869M,VehicleID=1,UserID=1,Comment="circle k",CreateDt=DateTime.Parse("2007-07-22")},
                new Mileage{ID=11,Date=DateTime.Parse("2007-08-08"),Miles=212.1M,Gallons=10.128M,PriceGallon=2.599M,VehicleID=1,UserID=1,Comment="costco",CreateDt=DateTime.Parse("2007-08-08")},
                new Mileage{ID=12,Date=DateTime.Parse("2007-09-03"),Miles=209.9M,Gallons=9.281M,PriceGallon=2.919M,VehicleID=1,UserID=1,Comment="",CreateDt=DateTime.Parse("2007-09-03")},
                new Mileage{ID=13,Date=DateTime.Parse("2007-09-30"),Miles=226.8M,Gallons=10.514M,PriceGallon=2.459M,VehicleID=1,UserID=1,Comment="",CreateDt=DateTime.Parse("2007-09-30")},
                new Mileage{ID=14,Date=DateTime.Parse("2007-10-20"),Miles=228.7M,Gallons=9.971M,PriceGallon=2.689M,VehicleID=1,UserID=1,Comment="",CreateDt=DateTime.Parse("2007-10-20")},
                new Mileage{ID=15,Date=DateTime.Parse("2007-11-02"),Miles=208.8M,Gallons=8.76M,PriceGallon=2.949M,VehicleID=1,UserID=1,Comment="costco",CreateDt=DateTime.Parse("2007-11-02")},
                new Mileage{ID=16,Date=DateTime.Parse("2007-11-09"),Miles=116M,Gallons=5.044M,PriceGallon=3.059M,VehicleID=1,UserID=1,Comment="costco",CreateDt=DateTime.Parse("2007-11-09")},
                new Mileage{ID=17,Date=DateTime.Parse("2007-11-16"),Miles=88.6M,Gallons=4.61M,PriceGallon=3.059M,VehicleID=1,UserID=1,Comment="costco",CreateDt=DateTime.Parse("2007-11-16")},
                new Mileage{ID=18,Date=DateTime.Parse("2007-11-28"),Miles=238.3M,Gallons=9.622M,PriceGallon=2.889M,VehicleID=1,UserID=1,Comment="",CreateDt=DateTime.Parse("2007-11-28")},
                new Mileage{ID=19,Date=DateTime.Parse("2007-12-05"),Miles=164.3M,Gallons=7.307M,PriceGallon=2.799M,VehicleID=1,UserID=1,Comment="",CreateDt=DateTime.Parse("2007-12-05")},
                new Mileage{ID=20,Date=DateTime.Parse("2007-12-13"),Miles=207.7M,Gallons=8.491M,PriceGallon=2.649M,VehicleID=1,UserID=1,Comment="",CreateDt=DateTime.Parse("2007-12-13")},
                new Mileage{ID=21,Date=DateTime.Parse("2007-12-24"),Miles=215.4M,Gallons=9.056M,PriceGallon=2.849M,VehicleID=1,UserID=1,Comment="",CreateDt=DateTime.Parse("2007-12-24")},
                new Mileage{ID=22,Date=DateTime.Parse("2007-12-31"),Miles=186.7M,Gallons=7.942M,PriceGallon=2.949M,VehicleID=1,UserID=1,Comment="",CreateDt=DateTime.Parse("2007-12-31")},
                new Mileage{ID=23,Date=DateTime.Parse("2008-01-21"),Miles=158M,Gallons=7.021M,PriceGallon=2.849M,VehicleID=1,UserID=1,Comment="",CreateDt=DateTime.Parse("2008-01-21")},
                new Mileage{ID=24,Date=DateTime.Parse("2008-02-01"),Miles=254.1M,Gallons=11.117M,PriceGallon=2.849M,VehicleID=1,UserID=1,Comment="",CreateDt=DateTime.Parse("2008-02-01")},
                new Mileage{ID=25,Date=DateTime.Parse("2008-02-11"),Miles=243.1M,Gallons=9.967M,PriceGallon=2.729M,VehicleID=1,UserID=1,Comment="",CreateDt=DateTime.Parse("2008-02-11")},
                new Mileage{ID=26,Date=DateTime.Parse("2008-02-19"),Miles=183.2M,Gallons=7.491M,PriceGallon=2.829M,VehicleID=1,UserID=1,Comment="",CreateDt=DateTime.Parse("2008-02-19")},
                new Mileage{ID=27,Date=DateTime.Parse("2008-02-29"),Miles=262M,Gallons=11.315M,PriceGallon=2.979M,VehicleID=1,UserID=1,Comment="",CreateDt=DateTime.Parse("2008-02-29")},
                new Mileage{ID=28,Date=DateTime.Parse("2008-03-09"),Miles=209.2M,Gallons=9.155M,PriceGallon=2.979M,VehicleID=1,UserID=1,Comment="",CreateDt=DateTime.Parse("2008-03-09")},
                new Mileage{ID=29,Date=DateTime.Parse("2008-03-26"),Miles=290.6M,Gallons=9.431M,PriceGallon=3.109M,VehicleID=2,UserID=1,Comment="first civic fillup",CreateDt=DateTime.Parse("2008-03-26")},
                new Mileage{ID=30,Date=DateTime.Parse("2008-04-08"),Miles=322.7M,Gallons=9.58M,PriceGallon=3.099M,VehicleID=2,UserID=1,Comment="",CreateDt=DateTime.Parse("2008-04-08")},
                new Mileage{ID=31,Date=DateTime.Parse("2008-04-22"),Miles=341.6M,Gallons=9.909M,PriceGallon=3.229M,VehicleID=2,UserID=1,Comment="",CreateDt=DateTime.Parse("2008-04-22")},
                new Mileage{ID=32,Date=DateTime.Parse("2008-05-08"),Miles=367M,Gallons=10.29M,PriceGallon=3.649M,VehicleID=2,UserID=1,Comment="",CreateDt=DateTime.Parse("2008-05-08")},
                new Mileage{ID=33,Date=DateTime.Parse("2008-05-19"),Miles=372.2M,Gallons=10.484M,PriceGallon=3.739M,VehicleID=2,UserID=1,Comment="",CreateDt=DateTime.Parse("2008-05-19")},
                new Mileage{ID=34,Date=DateTime.Parse("2008-05-28"),Miles=218.8M,Gallons=6.409M,PriceGallon=3.779M,VehicleID=2,UserID=1,Comment="",CreateDt=DateTime.Parse("2008-05-28")},
                new Mileage{ID=35,Date=DateTime.Parse("2008-06-13"),Miles=377.4M,Gallons=10.68M,PriceGallon=3.819M,VehicleID=2,UserID=1,Comment="",CreateDt=DateTime.Parse("2008-06-13")},
                new Mileage{ID=36,Date=DateTime.Parse("2008-06-30"),Miles=366.1M,Gallons=10.449M,PriceGallon=3.799M,VehicleID=2,UserID=1,Comment="",CreateDt=DateTime.Parse("2008-06-30")},
                new Mileage{ID=37,Date=DateTime.Parse("2008-07-10"),Miles=262.6M,Gallons=7.722M,PriceGallon=3.779M,VehicleID=2,UserID=1,Comment="",CreateDt=DateTime.Parse("2008-07-10")},
                new Mileage{ID=38,Date=DateTime.Parse("2008-07-26"),Miles=371.6M,Gallons=10.572M,PriceGallon=3.669M,VehicleID=2,UserID=1,Comment="",CreateDt=DateTime.Parse("2008-07-26")},
                new Mileage{ID=39,Date=DateTime.Parse("2008-09-02"),Miles=368.1M,Gallons=10.553M,PriceGallon=3.569M,VehicleID=2,UserID=1,Comment="",CreateDt=DateTime.Parse("2008-09-02")},
                new Mileage{ID=40,Date=DateTime.Parse("2008-09-13"),Miles=293.6M,Gallons=8.657M,PriceGallon=3.739M,VehicleID=2,UserID=1,Comment="",CreateDt=DateTime.Parse("2008-09-13")},
                new Mileage{ID=41,Date=DateTime.Parse("2008-09-28"),Miles=354.6M,Gallons=11.501M,PriceGallon=3.399M,VehicleID=2,UserID=1,Comment="excessive fillup",CreateDt=DateTime.Parse("2008-09-28")},
                new Mileage{ID=42,Date=DateTime.Parse("2008-10-10"),Miles=320.3M,Gallons=8.455M,PriceGallon=2.899M,VehicleID=2,UserID=1,Comment="",CreateDt=DateTime.Parse("2008-10-10")},
                new Mileage{ID=43,Date=DateTime.Parse("2008-10-22"),Miles=282.6M,Gallons=8.016M,PriceGallon=2.419M,VehicleID=2,UserID=1,Comment="",CreateDt=DateTime.Parse("2008-10-22")},
                new Mileage{ID=44,Date=DateTime.Parse("2008-10-31"),Miles=190.2M,Gallons=6.388M,PriceGallon=1.979M,VehicleID=2,UserID=1,Comment="excessive fillup",CreateDt=DateTime.Parse("2008-10-31")},
                new Mileage{ID=45,Date=DateTime.Parse("2008-11-18"),Miles=375.6M,Gallons=10.874M,PriceGallon=1.769M,VehicleID=2,UserID=1,Comment="",CreateDt=DateTime.Parse("2008-11-18")},
                new Mileage{ID=46,Date=DateTime.Parse("2008-11-28"),Miles=306.5M,Gallons=9.217M,PriceGallon=1.629M,VehicleID=2,UserID=1,Comment="",CreateDt=DateTime.Parse("2008-11-28")},
                new Mileage{ID=47,Date=DateTime.Parse("2008-12-10"),Miles=266.9M,Gallons=10.008M,PriceGallon=1.449M,VehicleID=2,UserID=1,Comment="",CreateDt=DateTime.Parse("2008-12-10")},
                new Mileage{ID=48,Date=DateTime.Parse("2008-12-23"),Miles=293.3M,Gallons=9.111M,PriceGallon=1.579M,VehicleID=2,UserID=1,Comment="",CreateDt=DateTime.Parse("2008-12-23")},
                new Mileage{ID=49,Date=DateTime.Parse("2008-12-29"),Miles=206.1M,Gallons=6.413M,PriceGallon=1.549M,VehicleID=2,UserID=1,Comment="",CreateDt=DateTime.Parse("2008-12-29")},
                new Mileage{ID=50,Date=DateTime.Parse("2009-01-12"),Miles=275.7M,Gallons=9.235M,PriceGallon=1.849M,VehicleID=2,UserID=1,Comment="",CreateDt=DateTime.Parse("2009-01-12")}
            };
            mileages.ForEach(s => context.Mileages.Add(s));
            context.SaveChanges();

            //var mileages = new List<Mileage>
            //{
            //    new Mileage{ID=1,Date=DateTime.Parse("2007-03-07"),Miles=236.6M,Gallons=10.735M,PriceGallon=2.389M,VehicleID=1,UserID=1,Comment="",CreateDt=DateTime.Parse("2007-03-07")},
            //    new Mileage{ID=2,Date=DateTime.Parse("2007-03-25"),Miles=231.4M,Gallons=10.283M,PriceGallon=2.339M,VehicleID=1,UserID=1,Comment="",CreateDt=DateTime.Parse("2007-03-25")},
            //    new Mileage{ID=3,Date=DateTime.Parse("2007-04-13"),Miles=237.9M,Gallons=10.898M,PriceGallon=2.779M,VehicleID=1,UserID=1,Comment="",CreateDt=DateTime.Parse("2007-04-13")},
            //    new Mileage{ID=4,Date=DateTime.Parse("2007-05-01"),Miles=235.2M,Gallons=11.142M,PriceGallon=2.859M,VehicleID=1,UserID=1,Comment="ethanol?",CreateDt=DateTime.Parse("2007-05-01")},
            //    new Mileage{ID=5,Date=DateTime.Parse("2007-05-13"),Miles=158.1M,Gallons=7.239M,PriceGallon=3.159M,VehicleID=1,UserID=1,Comment="",CreateDt=DateTime.Parse("2007-05-13")},
            //    new Mileage{ID=6,Date=DateTime.Parse("2007-06-04"),Miles=236.6M,Gallons=10.71M,PriceGallon=3.099M,VehicleID=1,UserID=1,Comment="",CreateDt=DateTime.Parse("2007-06-04")},
            //    new Mileage{ID=7,Date=DateTime.Parse("2007-07-06"),Miles=154.2M,Gallons=7.65M,PriceGallon=2.869M,VehicleID=1,UserID=1,Comment="costco",CreateDt=DateTime.Parse("2007-07-06")},
            //    new Mileage{ID=8,Date=DateTime.Parse("2007-07-20"),Miles=105.3M,Gallons=4.861M,PriceGallon=2.879M,VehicleID=1,UserID=1,Comment="circle k",CreateDt=DateTime.Parse("2007-07-20")},
            //    new Mileage{ID=9,Date=DateTime.Parse("2007-07-22"),Miles=281.2M,Gallons=10M,PriceGallon=2.859M,VehicleID=1,UserID=1,Comment="sheetz, PA",CreateDt=DateTime.Parse("2007-07-22")},
            //    new Mileage{ID=10,Date=DateTime.Parse("2007-07-22"),Miles=263.5M,Gallons=6.723M,PriceGallon=2.869M,VehicleID=1,UserID=1,Comment="circle k",CreateDt=DateTime.Parse("2007-07-22")},
            //    new Mileage{ID=11,Date=DateTime.Parse("2007-08-08"),Miles=212.1M,Gallons=10.128M,PriceGallon=2.599M,VehicleID=1,UserID=1,Comment="costco",CreateDt=DateTime.Parse("2007-08-08")},
            //    new Mileage{ID=12,Date=DateTime.Parse("2007-09-03"),Miles=209.9M,Gallons=9.281M,PriceGallon=2.919M,VehicleID=1,UserID=1,Comment="",CreateDt=DateTime.Parse("2007-09-03")},
            //    new Mileage{ID=13,Date=DateTime.Parse("2007-09-30"),Miles=226.8M,Gallons=10.514M,PriceGallon=2.459M,VehicleID=1,UserID=1,Comment="",CreateDt=DateTime.Parse("2007-09-30")},
            //    new Mileage{ID=14,Date=DateTime.Parse("2007-10-20"),Miles=228.7M,Gallons=9.971M,PriceGallon=2.689M,VehicleID=1,UserID=1,Comment="",CreateDt=DateTime.Parse("2007-10-20")},
            //    new Mileage{ID=15,Date=DateTime.Parse("2007-11-02"),Miles=208.8M,Gallons=8.76M,PriceGallon=2.949M,VehicleID=1,UserID=1,Comment="costco",CreateDt=DateTime.Parse("2007-11-02")},
            //    new Mileage{ID=16,Date=DateTime.Parse("2007-11-09"),Miles=116M,Gallons=5.044M,PriceGallon=3.059M,VehicleID=1,UserID=1,Comment="costco",CreateDt=DateTime.Parse("2007-11-09")},
            //    new Mileage{ID=17,Date=DateTime.Parse("2007-11-16"),Miles=88.6M,Gallons=4.61M,PriceGallon=3.059M,VehicleID=1,UserID=1,Comment="costco",CreateDt=DateTime.Parse("2007-11-16")},
            //    new Mileage{ID=18,Date=DateTime.Parse("2007-11-28"),Miles=238.3M,Gallons=9.622M,PriceGallon=2.889M,VehicleID=1,UserID=1,Comment="",CreateDt=DateTime.Parse("2007-11-28")},
            //    new Mileage{ID=19,Date=DateTime.Parse("2007-12-05"),Miles=164.3M,Gallons=7.307M,PriceGallon=2.799M,VehicleID=1,UserID=1,Comment="",CreateDt=DateTime.Parse("2007-12-05")},
            //    new Mileage{ID=20,Date=DateTime.Parse("2007-12-13"),Miles=207.7M,Gallons=8.491M,PriceGallon=2.649M,VehicleID=1,UserID=1,Comment="",CreateDt=DateTime.Parse("2007-12-13")},
            //    new Mileage{ID=21,Date=DateTime.Parse("2007-12-24"),Miles=215.4M,Gallons=9.056M,PriceGallon=2.849M,VehicleID=1,UserID=1,Comment="",CreateDt=DateTime.Parse("2007-12-24")},
            //    new Mileage{ID=22,Date=DateTime.Parse("2007-12-31"),Miles=186.7M,Gallons=7.942M,PriceGallon=2.949M,VehicleID=1,UserID=1,Comment="",CreateDt=DateTime.Parse("2007-12-31")},
            //    new Mileage{ID=23,Date=DateTime.Parse("2008-01-21"),Miles=158M,Gallons=7.021M,PriceGallon=2.849M,VehicleID=1,UserID=1,Comment="",CreateDt=DateTime.Parse("2008-01-21")},
            //    new Mileage{ID=24,Date=DateTime.Parse("2008-02-01"),Miles=254.1M,Gallons=11.117M,PriceGallon=2.849M,VehicleID=1,UserID=1,Comment="",CreateDt=DateTime.Parse("2008-02-01")},
            //    new Mileage{ID=25,Date=DateTime.Parse("2008-02-11"),Miles=243.1M,Gallons=9.967M,PriceGallon=2.729M,VehicleID=1,UserID=1,Comment="",CreateDt=DateTime.Parse("2008-02-11")},
            //    new Mileage{ID=26,Date=DateTime.Parse("2008-02-19"),Miles=183.2M,Gallons=7.491M,PriceGallon=2.829M,VehicleID=1,UserID=1,Comment="",CreateDt=DateTime.Parse("2008-02-19")},
            //    new Mileage{ID=27,Date=DateTime.Parse("2008-02-29"),Miles=262M,Gallons=11.315M,PriceGallon=2.979M,VehicleID=1,UserID=1,Comment="",CreateDt=DateTime.Parse("2008-02-29")},
            //    new Mileage{ID=28,Date=DateTime.Parse("2008-03-09"),Miles=209.2M,Gallons=9.155M,PriceGallon=2.979M,VehicleID=1,UserID=1,Comment="",CreateDt=DateTime.Parse("2008-03-09")},
            //    new Mileage{ID=29,Date=DateTime.Parse("2008-03-26"),Miles=290.6M,Gallons=9.431M,PriceGallon=3.109M,VehicleID=2,UserID=1,Comment="first civic fillup",CreateDt=DateTime.Parse("2008-03-26")},
            //    new Mileage{ID=30,Date=DateTime.Parse("2008-04-08"),Miles=322.7M,Gallons=9.58M,PriceGallon=3.099M,VehicleID=2,UserID=1,Comment="",CreateDt=DateTime.Parse("2008-04-08")},
            //    new Mileage{ID=31,Date=DateTime.Parse("2008-04-22"),Miles=341.6M,Gallons=9.909M,PriceGallon=3.229M,VehicleID=2,UserID=1,Comment="",CreateDt=DateTime.Parse("2008-04-22")},
            //    new Mileage{ID=32,Date=DateTime.Parse("2008-05-08"),Miles=367M,Gallons=10.29M,PriceGallon=3.649M,VehicleID=2,UserID=1,Comment="",CreateDt=DateTime.Parse("2008-05-08")},
            //    new Mileage{ID=33,Date=DateTime.Parse("2008-05-19"),Miles=372.2M,Gallons=10.484M,PriceGallon=3.739M,VehicleID=2,UserID=1,Comment="",CreateDt=DateTime.Parse("2008-05-19")},
            //    new Mileage{ID=34,Date=DateTime.Parse("2008-05-28"),Miles=218.8M,Gallons=6.409M,PriceGallon=3.779M,VehicleID=2,UserID=1,Comment="",CreateDt=DateTime.Parse("2008-05-28")},
            //    new Mileage{ID=35,Date=DateTime.Parse("2008-06-13"),Miles=377.4M,Gallons=10.68M,PriceGallon=3.819M,VehicleID=2,UserID=1,Comment="",CreateDt=DateTime.Parse("2008-06-13")},
            //    new Mileage{ID=36,Date=DateTime.Parse("2008-06-30"),Miles=366.1M,Gallons=10.449M,PriceGallon=3.799M,VehicleID=2,UserID=1,Comment="",CreateDt=DateTime.Parse("2008-06-30")},
            //    new Mileage{ID=37,Date=DateTime.Parse("2008-07-10"),Miles=262.6M,Gallons=7.722M,PriceGallon=3.779M,VehicleID=2,UserID=1,Comment="",CreateDt=DateTime.Parse("2008-07-10")},
            //    new Mileage{ID=38,Date=DateTime.Parse("2008-07-26"),Miles=371.6M,Gallons=10.572M,PriceGallon=3.669M,VehicleID=2,UserID=1,Comment="",CreateDt=DateTime.Parse("2008-07-26")},
            //    new Mileage{ID=39,Date=DateTime.Parse("2008-09-02"),Miles=368.1M,Gallons=10.553M,PriceGallon=3.569M,VehicleID=2,UserID=1,Comment="",CreateDt=DateTime.Parse("2008-09-02")},
            //    new Mileage{ID=40,Date=DateTime.Parse("2008-09-13"),Miles=293.6M,Gallons=8.657M,PriceGallon=3.739M,VehicleID=2,UserID=1,Comment="",CreateDt=DateTime.Parse("2008-09-13")},
            //    new Mileage{ID=41,Date=DateTime.Parse("2008-09-28"),Miles=354.6M,Gallons=11.501M,PriceGallon=3.399M,VehicleID=2,UserID=1,Comment="excessive fillup",CreateDt=DateTime.Parse("2008-09-28")},
            //    new Mileage{ID=42,Date=DateTime.Parse("2008-10-10"),Miles=320.3M,Gallons=8.455M,PriceGallon=2.899M,VehicleID=2,UserID=1,Comment="",CreateDt=DateTime.Parse("2008-10-10")},
            //    new Mileage{ID=43,Date=DateTime.Parse("2008-10-22"),Miles=282.6M,Gallons=8.016M,PriceGallon=2.419M,VehicleID=2,UserID=1,Comment="",CreateDt=DateTime.Parse("2008-10-22")},
            //    new Mileage{ID=44,Date=DateTime.Parse("2008-10-31"),Miles=190.2M,Gallons=6.388M,PriceGallon=1.979M,VehicleID=2,UserID=1,Comment="excessive fillup",CreateDt=DateTime.Parse("2008-10-31")},
            //    new Mileage{ID=45,Date=DateTime.Parse("2008-11-18"),Miles=375.6M,Gallons=10.874M,PriceGallon=1.769M,VehicleID=2,UserID=1,Comment="",CreateDt=DateTime.Parse("2008-11-18")},
            //    new Mileage{ID=46,Date=DateTime.Parse("2008-11-28"),Miles=306.5M,Gallons=9.217M,PriceGallon=1.629M,VehicleID=2,UserID=1,Comment="",CreateDt=DateTime.Parse("2008-11-28")},
            //    new Mileage{ID=47,Date=DateTime.Parse("2008-12-10"),Miles=266.9M,Gallons=10.008M,PriceGallon=1.449M,VehicleID=2,UserID=1,Comment="",CreateDt=DateTime.Parse("2008-12-10")},
            //    new Mileage{ID=48,Date=DateTime.Parse("2008-12-23"),Miles=293.3M,Gallons=9.111M,PriceGallon=1.579M,VehicleID=2,UserID=1,Comment="",CreateDt=DateTime.Parse("2008-12-23")},
            //    new Mileage{ID=49,Date=DateTime.Parse("2008-12-29"),Miles=206.1M,Gallons=6.413M,PriceGallon=1.549M,VehicleID=2,UserID=1,Comment="",CreateDt=DateTime.Parse("2008-12-29")},
            //    new Mileage{ID=50,Date=DateTime.Parse("2009-01-12"),Miles=275.7M,Gallons=9.235M,PriceGallon=1.849M,VehicleID=2,UserID=1,Comment="",CreateDt=DateTime.Parse("2009-01-12")}
            //};
            //mileages.ForEach(s => context.Mileages.Add(s));
            //context.SaveChanges();
        }
    }
}