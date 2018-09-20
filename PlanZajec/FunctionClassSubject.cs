using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;

namespace PlanZajec
{
     class FunctionClassSubject
    {
        //dodaj
        public static void add(Subject objekt)
        {
            var db = Db.connect();
            var col = db.GetCollection<Subject>("subject");
            col.Insert(objekt);
        }
        //wypełnij
        public static dynamic getAll()
        {
            var db = Db.connect();
            var col = db.GetCollection<Subject>("subject");
            return col.FindAll();
        }
        //usuń
        public static void del(int id)
        {
            var db = Db.connect();
            var col = db.GetCollection<Subject>("subject");
            col.Delete(id);

        }
        //znajdz po numerze ID
        public static Subject getById(int id)
        {
            var db = Db.connect();
            var col = db.GetCollection<Subject>("subject");
            return col.FindById(id);
        }
        //aktualizuj
        public static void update(Subject p)
        {
            var db = Db.connect();
            var col = db.GetCollection<Subject>("subject");
            col.Update(p);
        }
      

    }
   

}
