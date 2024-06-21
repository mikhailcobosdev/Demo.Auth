   using System;
   using System.Collections.Generic;
   using System.Linq.Expressions;
   using System.Threading.Tasks;
   using Microsoft.EntityFrameworkCore;

   namespace MiProyecto.Dominio
   {
       public interface IRepositorioGenerico<TEntity> where TEntity : class
       {
           Task<IEnumerable<TEntity>> GetAllAsync();
           Task<TEntity> GetByIdAsync(object id);
           Task AddAsync(TEntity entity);
           void Update(TEntity entity);
           Task DeleteAsync(object id);
       }

       public class RepositorioGenerico<TEntity> : IRepositorioGenerico<TEntity> where TEntity : class
       {
           protected readonly DbContext Context;

           public RepositorioGenerico(DbContext context)
           {
               Context = context;
           }

           public async Task<IEnumerable<TEntity>> GetAllAsync()
           {
               return await Context.Set<TEntity>().ToListAsync();
           }

           public async Task<TEntity> GetByIdAsync(object id)
           {
               return await Context.Set<TEntity>().FindAsync(id);
           }

           public async Task AddAsync(TEntity entity)
           {
               await Context.Set<TEntity>().AddAsync(entity);
               await Context.SaveChangesAsync();
           }

           public void Update(TEntity entity)
           {
               Context.Set<TEntity>().Update(entity);
               Context.SaveChanges();
           }

           public async Task DeleteAsync(object id)
           {
               var entity = await GetByIdAsync(id);
               Context.Set<TEntity>().Remove(entity);
               await Context.SaveChangesAsync();
           }
       }
   }
   