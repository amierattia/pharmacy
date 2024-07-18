using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.fIDataHelper
{
    public interface OrderIdataHelper<Table>
    {
        List<ClsModel> GetAllModels();
    }
}
