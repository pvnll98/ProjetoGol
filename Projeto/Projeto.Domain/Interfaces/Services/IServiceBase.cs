using System;
using System.Collections.Generic;

namespace Projeto.Domain
{
    public interface IServiceBase<TEntity> where TEntity : class
    {
        void Dispose();
        IEnumerable<TEntity> GetAll();
    }
}
