using DataAccessExample.Core;
using System.Collections.Generic;

namespace DataAccess.Example.EntityFramework
{
    public interface IColorsDataManager
    {
        void Insert(Color color);

        void Update(Color color);

        Color Get(int id);

        IList<Color> GetAll();

        void Delete(int id);
    }
}
