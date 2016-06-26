using IT_Core;
using IT_Repository.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_Repository.Repository
{
    public class PlaneRepository
    {
        private DatabaseContext db = new DatabaseContext();


        public List<Plane> GetAll()
        {
            List<Plane> planes = db.Planes.ToList();
            return planes;
        }
        public void Create(Plane newPlane)
        {
            db.Planes.Add(newPlane);
            db.SaveChanges();

        }
        public Plane GetBySerial(string serial)
        {
            return db.Planes.FirstOrDefault(x => x.SerialNum == serial);
        }

        public Plane GetByID(int ID)
        {
            return db.Planes.FirstOrDefault(x => x.ID == ID);
        }
        
    }
}
