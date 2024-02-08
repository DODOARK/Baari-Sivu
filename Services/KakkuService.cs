using Data;
using Models;

namespace Services
{
    public class CakeService
    {
        private readonly CakeContext _context = default!;

        public CakeService(CakeContext context) 
        {
            _context = context;
        }

        public IList<Cake> GetCakes()
        {
            if(_context.Cakes != null)
            {
                return _context.Cakes.ToList();
            }
            return new List<Cake>();
        }

        public void AddCake(Cake cake)
        {
            if (_context.Cakes != null)
            {
                _context.Cakes.Add(cake);
                _context.SaveChanges();
            }
        }

        public void DeleteCake(int id)
        {
            if (_context.Cakes != null)
            {
                var cake = _context.Cakes.Find(id);
                if (cake != null)
                {
                    _context.Cakes.Remove(cake);
                    _context.SaveChanges();
                }
            }
        } 
    }
}