using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase.fIDataHelper
{
    public interface IdataHelper<Table>
    {
        //orders
        #region Order
        public List<Table> Search(string sreachItem);
        public Table Find(string name);
        public void Add(ClsModel table);
        public void Delet(string Name);
        public void Edite(Table table);
        public List<Table> GetAll();
        #endregion

        // users
        #region Users
        public void AddUser(UsersDb table);
        public List<UsersDb> GetAllUser();
        public UsersDb FindEmail(string UserName);
        #endregion

        // sales
        #region Sales
        public List<SalesModels> GetAllSales();
        public void AddSales(SalesModels table);
        #endregion

        //Cstomer
        #region Costumer
        List<Cstomer> GetAllCustomer();
        public void AddCstomer(Cstomer table);
        public void EditeCstomer(Cstomer table);
        #endregion

        // returnes
        #region returnes
        public void Addreturn(returnesModels table);

        #endregion

        // stoke
        #region stoke
        public void AddStoke(StokeModel table);
        public List<StokeModel> GetAllStoke(); 
        #endregion


    }
}
