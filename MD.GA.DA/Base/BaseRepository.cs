using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MD.GA.DA;
using System.Data.Entity;
using MD.GA.BE.Entidades;

namespace MD.GA.DA.Base
{
    public class BaseRepository 
    {
        private static GestionAlmacen bd;
        public static GestionAlmacen dataBase {

            get
            {
                if (bd == null)
                {
                    bd = new GestionAlmacen();

                }
                return bd;

            }
            private set
            {
                bd = value;
            }
        }
        public static DbContextTransaction transaction;
        public BaseRepository()
        {
            
            if (dataBase.Database.Connection.State == System.Data.ConnectionState.Connecting)
            {
                throw new Exception("Conectando al servidor");
            }

        }

        public static DateTime GetServerDateTime() {
           return dataBase.Database.SqlQuery<DateTime>("SELECT getdate()").AsEnumerable().First();
        }

        public static void BeginTransaction() {
            if (transaction == null)
            {
                transaction = dataBase.Database.BeginTransaction();
            }
            else
            {
                throw new Exception("Existe una transacción activa");
            }
            
        }

        public static void CommitTransaction() {
            if (transaction != null)
            {
                transaction.Commit();
                transaction.Dispose();
                transaction = null;
            }
            else
            {
                throw new Exception("No se encontro transacción activa");
            }
            
        }

        public static void RollBackTransaction() {
            if (transaction != null)
            {
                transaction.Rollback();
                transaction.Dispose();
                transaction = null;
            }
            else
            {
                throw new Exception("No se encontro transacción activa");
            }
            
        }

    }
}
