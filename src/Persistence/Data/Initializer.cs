namespace Persistence.Data
{
    public class Initializer
    {
        private readonly Context _context;

        public Initializer(Context context)
        {
            _context = context;
        }

        public void InitializeData()
        {
            //TODO delete in production or db will be deleted
            _context.Database.EnsureDeleted();
            if (_context.Database.EnsureCreated())
            {

            }
        }
    }
}
