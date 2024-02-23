namespace NewsEfCore.DataAccess.Entities
{
    public class News
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public int WriterId { get; set; }
        public DateTime RegisterDate { get; set; }
        public string ImageName { get; set; }
        public int CategoryId { get; set; }

        #region navigation Propety

        

        #endregion
    }
}
