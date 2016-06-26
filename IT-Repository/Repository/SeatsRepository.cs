using IT_Core;
using IT_Repository.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_Repository.Repository
{
    public class SeatsRepository
    {
        private DatabaseContext db = new DatabaseContext();

        public Seat getByID(int ID)
        {
            return db.Seats.FirstOrDefault(x => x.ID == ID);
        }

        public List<Seat> GetAll()
        {
            List<Seat> seats = db.Seats.ToList();
            return seats;
        }



    }
}
