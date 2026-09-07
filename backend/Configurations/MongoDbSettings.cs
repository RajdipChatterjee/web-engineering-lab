namespace backend.Configurations
{
    public class MongoDbSettings
    {
        public string ConnectionString { get; set; } = null!;
        public string DatabaseName { get; set; } = null!;
        public string TasksCollectionName { get; set; } = null!;
        public string UsersCollectionName { get; set; } = null!;
    }
}
