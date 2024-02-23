namespace NewsEfCore.DataAccess.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }


        #region navigation Propety

        public List<News> News { get; set; }

        #endregion
    }
}
