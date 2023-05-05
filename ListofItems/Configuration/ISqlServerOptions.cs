namespace ListofItems.Configuration
{
    public interface ISqlServerOptions
    {
        string SqlServerConnection { get; set; }

        string ProductsTableName { get; set; }
    }
}
