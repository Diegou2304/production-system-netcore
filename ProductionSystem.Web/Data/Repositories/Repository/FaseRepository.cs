﻿

namespace ProductionSystem.Web.Data.Repositories.Repository
{
    using Microsoft.EntityFrameworkCore;
    using ProductionSystem.Web.Data.Entities;
    using ProductionSystem.Web.Data.Repositories.Interfaz;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class FaseRepository : GenericRepository<Fase>, IFaseRepository
    {
        private readonly DataContext context;

        public FaseRepository(DataContext context) : base(context)
        {
            this.context = context;
        }

        //Obtener fase por id
        public async Task<Fase> GetFase(int id)
        {
            return await this.context.Fases
            .Where(c => c.Id == id)
            .FirstOrDefaultAsync();
        }


        public async Task<Fase> GetFasePorNumeroAsync(int numero)
        {
            return await this.context.Fases
            .Where(c => c.Numero == numero)
            .FirstOrDefaultAsync();
        }

        public Fase GetLastRecord()
        {
            return context.Fases.OrderByDescending(f => f.Id).FirstOrDefault();

        }

        /*
        //Obtener fase por id
        public async Task<Fase> GetUltimaFase(int id)
        {
            return await this.context.Fases
            .Where(c => c.Id == id)
            .FirstOrDefaultAsync();
        }*/



        //para obtener solo el nombre de una fase con el id
        public async Task<string> GetNombreFaseAsync (int id)
        {
            var fase = await this.GetFase(id);
            return fase.Nombre;
        }


        public async Task<int> GetNumeroFaseAsync(int id)
        {
            var fase = await this.GetFase(id);
            return fase.Numero;
        }

        public int GetNumeroUltimaFase()
        {
            var fase = this.GetLastRecord();
            return fase.Numero;
        }


        //



    }
}
