using System;
using System.Collections.Generic;
using System.Text;

namespace EFCorePractice.Framework.DataFactory
{
    public interface IDataFactory<out TEntity> where TEntity : class
    {
        TEntity[] Seed { get; }
        void Generate();
    }
}
