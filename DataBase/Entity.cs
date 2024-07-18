using DataBase.fIDataHelper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Models;
using System.Linq;
using System.Xml;

namespace DataBase
{
    public class Entity : IdataHelper<ClsModel>
    {
        DBContext db;

        public Entity()
        {
            db = new DBContext();
        }
        public ClsModel _model;

        #region Orders
        public List<ClsModel> GetAll()
        {
            return db.Order.ToList();
        }

        public List<ClsModel> Search(string sreachItem)
        {
            return db.Order.Where(x => x.Productname.ToString().Contains(sreachItem)).ToList();
        }

        public ClsModel Find(string name)
        {


            if (name != null)
            {
                return db.Order.Where(x => x.Id.ToString() == name).First();

            }
            else
                return null;



        }

        public void Add(ClsModel table)
        {

            db.Order.Add(table);
            db.SaveChanges();
        }

        public void Delet(string Name)
        {
            _model = Find(Name);
            GetAll();
            db.Order.Remove(_model);
            db.SaveChanges();
        }

        public void Edite(ClsModel table)
        {
            ClsModel f = new ClsModel();
            f = Find(table.Id.ToString());
            if (f != null && f.Id.ToString() != null)
            {
                db = new DBContext();
                db.Order.Update(table);
                db.SaveChanges();
            }

            else
            {

                return;
            }


        }

        #endregion

        #region Users
        public void AddUser(UsersDb table)
        {
            db.Users.Add(table);
            db.SaveChanges();
        }

        public List<UsersDb> GetAllUser()
        {
            return db.Users.ToList();
        }

        public UsersDb FindEmail(string UserName)
        {
            return db.Users.Where(x => x.username == UserName).First();
        }
        #endregion

        #region Returns
        public void Addreturn(returnesModels table)
        {
            db.Returnes.Add(table);
            db.SaveChanges();
        }
        #endregion



        #region Stoke
        public void AddStoke(StokeModel table)
        {
            db.Soke.Add(table);
            db.SaveChanges();
        }

        public List<StokeModel> GetAllStoke()
        {
            return db.Soke.ToList();
        }

        public List<SalesModels> GetAllSales()
        {
            return db.Sales.ToList();
        }

        #endregion

        #region Sales
        public void AddSales(SalesModels sales)
        {


            // Add the Sales record with the Customer relationship intact
            db.Sales.Add(sales);
            db.SaveChanges();
        }
        #endregion

        public List<storeModels> GetAllStore()
        {
            return db.store.ToList();
        }

        public void AddStore(storeModels table)
        {
            db.store.Add(table);
            db.SaveChanges();
        }

        #region Customer
        public void AddCstomer(Cstomer table)
        {
            db.Cstomer.Add(table);
            db.SaveChanges();
        }



        public void EditeCstomer(Cstomer table)
        {
            db.Cstomer.Update(table);
            db.SaveChanges();
        }

        public List<Cstomer> GetAllCustomer()
        {
            List<Cstomer> data = new List<Cstomer>();
            return data.ToList();
        }

        #endregion
    }
}
