using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CITP_Portfolio_Subproject_2.DataLayer.Model;
using CITP_Portfolio_Subproject_2.DataLayer.Domain;



namespace CITP_Portfolio_Subproject_2.DataLayer
{
    public interface IDataService
    {
        IList<AkaAttribute> GetAkaAttributes();
        AkaAttribute? GetAkaAttribute(string Tconst);
        IList<akaType> GetAkaTypes();
        akaType? GetAkaType(string Tconst);

        IList<ProduckSearchModel> GetAttributeByName(string search);

        nameBasic? GetName(string nconst);
    }
}
