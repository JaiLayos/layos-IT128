using ProjectLibrary.Models;

namespace ProjectLibrary.Data
{
    public interface ISqlData
    {
        void AddItem(Item item);
        ItemList GetItems(int id);
        List<ItemList> ListItems();
    }
}