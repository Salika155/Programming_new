namespace Model
{
    public class AppModel
    {
        private static AppModel _app = new AppModel();
        public static AppModel Instance => _app;

        public DatabaseRam Database => DatabaseRam.Instance;
        public DatabaseBBDD databaseBBDD => DatabaseBBDD.Instance;

        private AppModel()
        {
        }


    }
}
