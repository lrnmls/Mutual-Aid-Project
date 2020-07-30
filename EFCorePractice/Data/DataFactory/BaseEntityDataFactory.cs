using EFCorePractice.Data.Context;
using EFCorePractice.Framework.Entities;
using EFCorePractice.Framework.DataFactory;
using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace EFCorePractice.Data.DataFactory
{
    public abstract class BaseEntityDataFactory<TEntity> : BaseDataFactory<TEntity> where TEntity : BaseEntity
    {
        protected BaseEntityDataFactory(PracticeContext practiceContext) : base(practiceContext)
        {
            Schema = "[Common].";
        }

        public abstract TEntity[] Seed { get; }

        public override void Generate()
        {
            Trace.WriteLine($"Generating {typeof(TEntity).Name}...");
            Context.Database.OpenConnection();
            try
            {
                var setIdentityInsertCommand = $"SET IDENTITY_INSERT {Schema}[{typeof(TEntity).Name}] ON;";
                Context.Database.ExecuteSqlRaw(setIdentityInsertCommand);
                foreach (var baseEntity in Seed)
                {
                    if (!Context.Set<TEntity>().Any(b => b.Id == baseEntity.Id))
                    {
                        Context.Set<TEntity>().Add(baseEntity);
                    }
                    else
                    {
                        Context.Set<TEntity>().Update(baseEntity);
                    }
                }

                Context.SaveChanges();
            }
            catch (Exception ex)
            {
                Trace.WriteLine($"Error when seeding data for {typeof(TEntity).Name}...{ex}");
            }
            finally
            {
                var setIdentityInsertCommand = $"SET IDENTITY_INSERT {Schema}[{typeof(TEntity).Name}] OFF;";
                Context.Database.ExecuteSqlRaw(setIdentityInsertCommand);
            }

            Trace.WriteLine("Done.");
        }
    }
}
