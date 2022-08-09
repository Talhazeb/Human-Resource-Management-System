using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Test;
using System.Data;

    class JBHistoryBL
    {
        Commoncls cls = new Commoncls();
        JBHistoryDAL JBDAL = new JBHistoryDAL();

        public int InsertJBH(JBHistory JBH)
        {
            try
            {
                return JBDAL.InsertJBH(JBH);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                //JBDAL = null;
            }
        }

        public int Update_JBH(JBHistory JBH)
        {
            try
            {
                return JBDAL.Update(JBH);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                //JBDAL = null;
            }
        }


        public int Delete_JBH(JBHistory JBH)
        {
            try
            {
                return JBDAL.Delete(JBH);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                JBDAL = null;
            }
        } 

        public DataSet Find_JBH(String str)
        {
            JBHistoryDAL JDALF = new JBHistoryDAL();
            DataSet data = null;

            data = JDALF.Find_Jobh(str);

            return data;

        }
    }

