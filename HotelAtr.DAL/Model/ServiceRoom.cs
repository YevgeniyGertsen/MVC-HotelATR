using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAtr.DAL.Model
{
    public class ServiceRoom
    {
        private static readonly HotelAtrEntities Db = new HotelAtrEntities();
        public static bool AddRoom(Room room)
        {
            try
            {
                room.RoomTypeId = 2;
                Db.Rooms.Add(room);
                Db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool DeleteRoom(int roomId)
        {
            try
            {
                Room room = Db.Rooms.Find(roomId);
                if (room != null)
                {
                    Db.Rooms.Remove(room);
                    Db.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static bool SaveRoom(Room room)
        {
            try
            {
                Room fRoom = Db.Rooms.Find(room.RoomId);

                if (fRoom != null)
                {
                    fRoom = room;
                    Db.Entry(fRoom).State = EntityState.Modified;
                    Db.SaveChanges();
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
