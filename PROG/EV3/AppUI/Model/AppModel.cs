namespace Model
{
    public class AppModel
    {
        private static AppModel _app = new AppModel();
        public static AppModel Instance => _app;

        public DatabaseRam Database => DatabaseRam.Instance;
        public DatabaseSQL databaseBBDD => DatabaseSQL.Instance;

        private AppModel()
        {
        }
    }
}
