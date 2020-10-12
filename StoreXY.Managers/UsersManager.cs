using StoreXY.DAL;
using StoreXY.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StoreXY.Managers
{
    public class UsersManager
    {
        /// <summary>
        /// Method that returns all clients
        /// </summary>
        /// <returns>List<SelectUserDTO></returns>
        public static List<SelectUserDTO> GetAllUsers()
        {
            List<SelectUserDTO> selectUserDTOs = new List<SelectUserDTO>();
            using (StoreXYEntities db = new StoreXYEntities())
            {
                foreach (Clients user in db.Clients)
                {
                    selectUserDTOs.Add(new SelectUserDTO(user));
                }
            }

            return selectUserDTOs;
        }

        /// <summary>
        /// Method that returns a client by an id
        /// </summary>
        /// <param name="id">long</param>
        /// <returns>SelectUserDTO</returns>
        public static SelectUserDTO GetUserById(long id)
        {
            SelectUserDTO selectUserDTO;
            using (StoreXYEntities db = new StoreXYEntities())
            {
                selectUserDTO = new SelectUserDTO(db.Clients.Where(x => x.id == id).FirstOrDefault());
            }

            return selectUserDTO;
        }
    }
}
