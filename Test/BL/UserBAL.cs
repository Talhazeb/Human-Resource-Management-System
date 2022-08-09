using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

    class UserBAL
    {
        public int Insert(User_Details u_det)
        {

            UsersDAL UDAL = new UsersDAL();

            try
            {
                return UDAL.Insert(u_det);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                UDAL = null;
            }
        }


        public int Update(User_Details u_det)
        {

            UsersDAL UDAL = new UsersDAL();

            try
            {
                return UDAL.Update(u_det);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                UDAL = null;
            }
        }

        public DataSet Find_User(String str)
        {
            UsersDAL UDAL = new UsersDAL();
            DataSet data = null;

            data = UDAL.Find_User(str);

            return data;

        }
        public void Find_UID(User_Details u_id)
        {
            UsersDAL UDAL = new UsersDAL();
            try
            {
                UDAL.Find_UID(u_id);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                UDAL = null;
            }
        }

    }

