using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace EmporiumServer.Controllers
{
    public interface ICostumeDao
    {
        Costume[] GetAllCostumes();
        Costume GetCostume(int id);
        void Delete(int id);
        Costume Create(Costume costume);
        Costume Update(Costume costume);
    }
}