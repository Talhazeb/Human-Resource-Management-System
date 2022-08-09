using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;


    class PaymentBAL
    {
        public int Insert(Payment pay_det)
        {

            PaymentDAL PDAL = new PaymentDAL();

            try
            {
                return PDAL.Insert(pay_det);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                pay_det = null;
            }
        }

        public int Update_Pay(Payment pay_det)
        {

            PaymentDAL PDAL = new PaymentDAL();

            try
            {
                return PDAL.Update_Pay(pay_det);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                pay_det = null;
            }
        }



        public int Delete_Pay(Payment P)
        {

            PaymentDAL PDAL = new PaymentDAL();

            try
            {
                return PDAL.Delete_Pay(P);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {

            }
        }

        public DataTable BindGrid()
        {

            PaymentDAL PDAL = new PaymentDAL();

            try
            {
                return PDAL.GetData();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {

            }
        }

        public DataSet Find_Pay(String str)
        {
            PaymentDAL PDAL = new PaymentDAL();
            DataSet data = null;

            data = PDAL.Find_pay(str);

            return data;

        }


        public DataSet Find_Pay_Firstly(String str)
        {
            PaymentDAL PDAL = new PaymentDAL();
            DataSet data = null;

            data = PDAL.Find_Pay_First(str);

            return data;

        }


        public DataTable BindGrid_with(Payment P)
        {

            PaymentDAL PDAL = new PaymentDAL();

            try
            {
                return PDAL.GetData_with(P);
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {

            }
        }
    }

