namespace BTG.Credit.Ras.Interview.Domain.DataList
{
    public class ListItem
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime ReferenceDate { get; set; }
        public List<Customer> Customers { get; set; }
    }
}
