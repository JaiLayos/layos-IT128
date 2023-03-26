using ProjectLibrary.Database;
using ProjectLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectLibrary.Data
{
    public class SqlData : ISqlData
    {
        private ISqlDataAccess _db;
        private const string connectionStringName = "SqlDb";

        public SqlData(ISqlDataAccess db)
        {
            _db = db;
        }
        public void AddItem(Item item)
        {
            _db.SaveData("dbo.spItem_add", new
            {
                item.Name,
                item.UnitPrice,
                item.Code,
                item.Brand,
                item.DateOrdered
            }, connectionStringName, true);
        }
        public List<ItemList> ListItems()
        {
            return _db.LoadData<ItemList, dynamic>("dbo.spItem_list",
                new { }, connectionStringName, true).ToList();
        }
        public ItemList GetItems(int id)
        {
            return _db.LoadData<ItemList, dynamic>("dbo.spItem_get",
                new { id }, connectionStringName, true).FirstOrDefault();
        }
    }
}
