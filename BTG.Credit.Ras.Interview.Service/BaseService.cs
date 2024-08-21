using Microsoft.Extensions.DependencyInjection;

namespace BTG.Credit.Ras.Interview.Service
{
    public class BaseService<TRepository> where TRepository : class
    {
        protected readonly TRepository _repository;

        public BaseService()
        {
            _repository = ServiceProvider.Provider!.GetRequiredService<TRepository>();
        }
    }
}
