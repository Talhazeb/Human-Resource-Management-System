using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Test;
using System.Data;
    class AttenBAL
    {
        public int Insert(Atten_Details att_det)
        {

            AttenDAL ADAL = new AttenDAL();

            try
            {
                return ADAL.Insert(att_det);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                //att_det = null;
            }
        }


        public int Upate_Att(Atten_Details att_det)
        {

            AttenDAL ADAL = new AttenDAL();

            try
            {
                return ADAL.Update_Att(att_det);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                att_det = null;
            }
        }

        

        public int Delete_leave(Atten_Details att)
        {

            AttenDAL ADDAL = new AttenDAL();

            try
            {
                return ADDAL.Delete_Att(att);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                att = null;
            }
        }


        public DataTable BindGrid()
        {

            AttenDAL ADDAL = new AttenDAL();

            try
            {
               return ADDAL.GetData();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
               
            }
        }



        public DataSet Find_Attdet(String str)
        {
            AttenDAL ALF = new AttenDAL();
            DataSet data = null;

            data = ALF.Find_att(str);//PDAL.Find(str);

            return data;

        }

    }

