namespace NewsEfCore.DataAccess.UnitOfWork
{
    public interface IUnitOfWork
    {
        public int MyProperty { get; set; }
        public void SaveChanges();
    }
}
