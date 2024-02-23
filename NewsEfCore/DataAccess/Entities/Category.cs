namespace NewsEfCore.DataAccess.Entities
{
    public class Category
    {

        public Category()
        {
            News = new List<News>();
        }

        public int Id { get; set; }
        public string Title { get; set; }


        #region navigation Propety

        public List<News> News { get; set; }

        #endregion
    }
}
