namespace BTG.Credit.Ras.Interview.Service
{
    public static class ServiceProvider
    {
        public static IServiceProvider? Provider { get; set; }

        public static void Initialize(IServiceProvider serviceProvider)
        {
            Provider = serviceProvider;
        }
    }
}
