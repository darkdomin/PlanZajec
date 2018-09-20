using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;

namespace PlanZajec
{
    class FunctionClassTime
    {

        //dodaj
        public static void add(Time objekt)
        {
            var db = Db.connect();
            var col = db.GetCollection<Time>("Time");
            col.Insert(objekt);
        }
        //wypełnij
        public static dynamic getAll()
        {
            var db = Db.connect();
            var col = db.GetCollection<Time>("Time");
            return col.FindAll();
        }
        //usuń
        public static void del(int id)
        {
            var db = Db.connect();
            var col = db.GetCollection<Time>("Time");
            col.Delete(id);

        }
        //znajdz po numerze ID
        public static Time getById(int id)
        {
            var db = Db.connect();
            var col = db.GetCollection<Time>("Time");
            return col.FindById(id);
        }
        //aktualizuj
        public static void update(Time p)
        {
            var db = Db.connect();
            var col = db.GetCollection<Time>("Time");
            col.Update(p);
        }
    }
}
