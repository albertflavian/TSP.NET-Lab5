using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFStudiuDeCaz.Business
{
    public class BusinessService
    {
        private readonly BusinessContext context;
        public BusinessService(BusinessContext context)
        {
            this.context = context;
        }

        public void Init()
        {
            var business = new Business
            {
                Name = "Corner Dry Cleaning",
                LicenseNumber = "100x1"
            };
            context.Businesses.Add(business);
            var retail = new Retail
            {
                Name = "Shop and Save",
                LicenseNumber =
            "200C",
                Address = "101 Main",
                City = "Anytown",
                State = "TX",
                ZIPCode = "76106"
            };
            context.Businesses.Add(retail);
            var web = new eCommerce
            {
                Name = "BuyNow.com",
                LicenseNumber =
            "300AB",
                URL = "www.buynow.com"
            };
            context.Businesses.Add(web);
            context.SaveChanges();

        }

        public void PrintAll()
        {
            Console.WriteLine("\n--- All Businesses ---");
            foreach (var b in context.Businesses)
            {
                Console.WriteLine("{0} (#{1})", b.Name, b.LicenseNumber);
            }
            Console.WriteLine("\n--- Retail Businesses ---");
            foreach (var r in context.Businesses.OfType<Retail>())
            {
                Console.WriteLine("{0} (#{1})", r.Name, r.LicenseNumber);
                Console.WriteLine("{0}", r.Address);
                Console.WriteLine("{0}, {1} {2}", r.City, r.State, r.ZIPCode);
            }
            Console.WriteLine("\n--- eCommerce Businesses ---");
            foreach (var e in context.Businesses.OfType<eCommerce>())
            {
                Console.WriteLine("{0} (#{1})", e.Name, e.LicenseNumber);
                Console.WriteLine("Online address is: {0}", e.URL);
            }

        }
    }
}
