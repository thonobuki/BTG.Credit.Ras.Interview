namespace BTG.Credit.Ras.Interview.Domain.DataList
{
    public interface IDataListService
    {
        IList<ListItem> ListThatContainsCustomersWithBirthDate(DateTime birthdate);
    }
}
