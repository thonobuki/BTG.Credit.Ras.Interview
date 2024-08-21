using BTG.Credit.Ras.Interview.Domain.DataList;

namespace BTG.Credit.Ras.Interview.Service.DataList
{
    public class DataListService : IDataListService
    {
        private readonly IDataListRepository _dataListRepository;

        public IList<ListItem> ListThatContainsCustomersWithBirthDate(DateTime birthDate)
        {
            return _dataListRepository.GetAll().Where(x => x.ReferenceDate == birthDate).ToList();
        }
    }
}
