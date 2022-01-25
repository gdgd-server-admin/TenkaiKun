using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LiteDB;

namespace TenkaiLib.Models
{
    public class Tenkai
    {
        public ObjectId Id { get; set; }
        public string Name { get; set; }
        public string Version { get; set; }
        public string Changelog { get; set; }
        public string LaunchPath { get; set; }
        public string FileName { get; set; }

        public bool Save()
        {
            using(var db = new LiteDatabase("tenkaikun.db"))
            {
                var collection = db.GetCollection<Tenkai>("Tenkai");
                if(collection.Count(x => x.Id == Id) != 0)
                {
                    var row = collection.FindOne(x => x.Id == Id);
                    row.Version = Version;
                    row.Changelog = Changelog;
                    row.FileName = FileName;
                    row.LaunchPath = LaunchPath;
                    collection.Update(row);
                }
                else
                {
                    collection.Insert(this);
                }
            }
            return true;
        }

        public static Tenkai Find(string Name)
        {
            using (var db = new LiteDatabase("tenkaikun.db"))
            {
                var collection = db.GetCollection<Tenkai>("Tenkai");
                if (collection.Count(x => x.Name == Name) != 0)
                {
                    return collection.FindOne(x => x.Name == Name);
                }
                else
                {
                    return new Tenkai()
                    {
                        Changelog = "",
                        Name = Name,
                        Version = "0.0.0.0",
                        FileName = "",
                        LaunchPath = ""
                    };
                }
            }

            
        }

        public static List<Tenkai> All()
        {
            using (var db = new LiteDatabase("tenkaikun.db"))
            {
                var collection = db.GetCollection<Tenkai>("Tenkai");
                return collection.FindAll().ToList();
            }
        }
    }
}
