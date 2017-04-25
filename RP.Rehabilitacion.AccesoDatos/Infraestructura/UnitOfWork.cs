using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 
using System.Transactions;
using System.Data.Entity;
using RP.Rehabilitacion.Entidades;
namespace RP.Rehabilitacion.AccesoDatos.Infraestructura
{
    public class UnitOfWork : IUnitOfWork
    {
        private TransactionScope _transaction;
        private readonly RPDBContext _db;


        public UnitOfWork()
        {
            _db = new RPDBContext();

        }

        public void Dispose() {
        }

        public void StartTransaction()
        {
            _transaction = new TransactionScope();
        }

        public void Commit()
        {
            _db.SaveChanges();
            _transaction.Complete();
        }

        public DbContext Db
        {
            get { return _db; }
        }

    }
}
