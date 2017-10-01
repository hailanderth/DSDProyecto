using MD.GA.DA.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MD.GA.BE.Entidades;
using MD.GA.DA.Base;
using System.Data.Entity;

namespace MD.GA.DA.Repositories
{
    public class BancoRepository : IBancoRepository
    {
        public List<BANCO> GetAll()
        {
            return BaseRepository.dataBase.BANCOes.Where(tx => tx.Estado == "A").ToList();
        }

        public BANCO GetById(int? id_banco)
        {

            BANCO banco = BaseRepository.dataBase.BANCOes.FirstOrDefault(tx => tx.Id_Banco == id_banco);
            return banco;
        }

        public BANCO GetById(int id)
        {
            BANCO banco =  BaseRepository.dataBase.BANCOes.FirstOrDefault(tx => tx.Id_Banco == id);
            return banco;
        }

        public void Insert(BANCO datos)
        {
            BaseRepository.dataBase.BANCOes.Add(datos);
            BaseRepository.dataBase.SaveChanges();
        }

        public void Update(BANCO datos)
        {
            BaseRepository.dataBase.BANCOes.Attach(datos);
            var entry = BaseRepository.dataBase.Entry(datos);
            entry.State = EntityState.Modified;

            entry.Property(e => e.FechaCreacion).IsModified = false;
            entry.Property(e => e.UsuarioCreacion).IsModified = false;

            BaseRepository.dataBase.SaveChanges();
        }
    }
}
