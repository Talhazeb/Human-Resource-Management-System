using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Test;

    class LeaveBAL
    {
        public int Insert(Leave leave)
        {

            LeaveDAL ADAL = new LeaveDAL();

            try
            {
                return ADAL.Insert(leave);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                leave = null;
            }
        }

        public void Update_Leave(Leave l_id)
        {
            LeaveDAL DDAL = new LeaveDAL();
            try
            {
                DDAL.Update_Leave(l_id);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                DDAL = null;
            }
        }

        public int Delete_leave(Leave leave)
        {

            LeaveDAL ADAL = new LeaveDAL();

            try
            {
                return ADAL.Delete_Leave(leave);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                leave = null;
            }
        }

       

    }

