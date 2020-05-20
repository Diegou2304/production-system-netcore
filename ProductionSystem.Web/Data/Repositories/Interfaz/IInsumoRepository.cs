﻿

namespace ProductionSystem.Web.Data.Repositories.Interfaz
{
    using Entities;
 
    public interface IInsumoRepository : IGenericRepository<Insumo>
    {

        Insumo GetInsumoById(int id);


    }
}
