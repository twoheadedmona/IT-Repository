using IT_Core;
using IT_Repository.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_Repository.Repository
{
    public class ClientRepository
    {
        private DatabaseContext db = new DatabaseContext();


        public List<Customer> GetAll()
        {
            List<Customer> customers = db.Customers.ToList();
            return customers;
        }
        public void Create(Customer newCustomer)
        {
            db.Customers.Add(newCustomer);
            db.SaveChanges();

        }
        public Customer GetByUsername(string username)
        {
            return db.Customers.FirstOrDefault(x => x.Username == username);
        }
        public Customer GetById(int id)
        {
            return db.Customers.FirstOrDefault(x => x.ID == id);
        }
        public Customer GetByFirstName(string firstName)
        {
            return db.Customers.FirstOrDefault(x => x.FirstName==firstName);
        }
        public Customer GetByEmail(string email)
        {
            return db.Customers.FirstOrDefault(x => x.Email == email);
        }
    }
}
