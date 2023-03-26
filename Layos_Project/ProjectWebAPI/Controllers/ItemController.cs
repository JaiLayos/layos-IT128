using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjectLibrary.Data;
using ProjectLibrary.Models;
using System.Xml.Linq;

namespace ProjectWebAPI.Controllers
{
    public class ItemController : Controller
    {
        private ISqlData _db;
        public IActionResult Index()
        {
            return View();
        }
        public ItemController(ISqlData db)
        {
            _db = db;
        }
        [AllowAnonymous]
        [HttpPost]
        [Route("/api/[controller]/add")]
        public ActionResult AddPost([FromBody] Item form)
        {
            Item item = new Item();
            item.Code = form.Code;
            item.Name = form.Name;
            item.Brand = form.Brand;
            item.UnitPrice = form.UnitPrice;
            item.DateOrdered = DateTime.Now;
            _db.AddItem(item);
            return Ok("Post Created.");
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("/api/[controller]/listitems")]
        public ActionResult ListItems()
        {
            List<ItemList> items = _db.ListItems();
            return Ok(items);
        }

        [AllowAnonymous]
        [HttpGet]
        [Route("/api/[controller]/{id}")]
        public ActionResult GetItems(int id)
        {
            ItemList item = _db.GetItems(id);
            return Ok(item);
        }
    }
}
