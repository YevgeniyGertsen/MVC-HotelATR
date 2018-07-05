using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HotelAtr.DAL.Model;

namespace Hotel.Atr.Admin.Controllers
{
    public class RoomController : BaseController
    {

        // GET: Room
        public ActionResult Index()
        {
            return View(db.Rooms.ToList());
        }


        public ActionResult AddRoom(Room room, string action, int statusCode = -1, int roomId=0)
        {
            ViewBag.RoomTypeList = db.RoomTypes.Select(s => new SelectListItem() { Text = s.Name, Value = s.RoomTypeId.ToString() }).ToList();
            //if (ModelState.IsValid)
            //{
            if (roomId == 0 && action == "add")
            {
                if (ServiceRoom.AddRoom(room))
                {
                    return RedirectToAction("Index");
                }
            }
            else if (action == "save")
            {
                ServiceRoom.SaveRoom(room);
                return RedirectToAction("Index");
            }
            else if (roomId != 0)
            {
                room = db.Rooms.Find(roomId);
                return View(room);
            }

            ViewBag.StatusCode = 1;
            //}
            return View();
        }

        public ActionResult Delete(int roomId)
        {
            ServiceRoom.DeleteRoom(roomId);
            return RedirectToAction("Index");
        }

        
    }
}