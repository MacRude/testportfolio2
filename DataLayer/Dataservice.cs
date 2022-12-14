using CITP_Portfolio_Subproject_2.DataLayer.Domain;
using CITP_Portfolio_Subproject_2.DataLayer.Model;
using Microsoft.EntityFrameworkCore;

namespace CITP_Portfolio_Subproject_2.DataLayer
{
    public class DataService : IDataService
    {
        public AkaAttribute? GetAkaAttribute(string Tconst)
        {
            using var db = new IMDBContext();
            return db.Attributes.Find(Tconst);
        }

        public IList<AkaAttribute> GetAkaAttributes()
        {
            using var db = new IMDBContext();
            return db.Attributes.ToList();
        }

        public akaType? GetAkaType(string Tconst)
        {
            using var db = new IMDBContext();
            return db.Types.Find(Tconst);
        }

        public IList<akaType> GetAkaTypes()
        {
            using var db = new IMDBContext();
            return db.Types.ToList();
        }

        public IList<ProduckSearchModel> GetAttributeByName(string search)
        {
            using var db = new IMDBContext();
            return db.Attributes
                .Include(x => x.Attribute)
                .Where(x => x.Tconst == search)
                .Select(x => new ProduckSearchModel
                {
                    AttributeName = x.Attribute,
                    TypeName = x.Tconst
                })
                .ToList();
        }

        public nameBasic? GetName(string nconst)
        {
            using var db = new IMDBContext();
            return db.nameBasics?.FirstOrDefault(x => x.Nconst == nconst);
        }

    }

}
