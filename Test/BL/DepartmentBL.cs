using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Test;
using System.Data;
   class DepartmentBL
    {

        public int Insert(Department_Details Dpm)
        {
            
            DepartmentDAL PDAL = new DepartmentDAL();

            try
            {
                return PDAL.Insert(Dpm);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                PDAL = null;
            }
        }


        public int Update_Dep(Department_Details Dpm)
        {

            DepartmentDAL PDAL = new DepartmentDAL();

            try
            {
                return PDAL.Update(Dpm);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                PDAL = null;
            }
        }

        public int Delete_Dep(Department_Details Dpm)
        {

            DepartmentDAL PDAL = new DepartmentDAL();

            try
            {
                return PDAL.Delete_Dep(Dpm);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                PDAL = null;
            }
        }
        public void Find_DID(Department_Details p_id)
        {
            DepartmentDAL DDAL = new DepartmentDAL();
            try
            {
                DDAL.Find_DID(p_id);
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

        public DataTable Bind_Grid_with(Department_Details p_id)
        {
            DepartmentDAL DDAL = new DepartmentDAL();
            try
            {
               return DDAL.GetDataWith(p_id);
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

        public DataTable Bind_Grid()
        {
            DepartmentDAL DDAL = new DepartmentDAL();
            try
            {
              return  DDAL.GetData();
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

        public DataSet Find_Depdet(String str)
        {
            DepartmentDAL PDALF = new DepartmentDAL();
            DataSet data = null;

            data = PDALF.Find_dep(str);//PDAL.Find(str);

            return data;

        }
    }

