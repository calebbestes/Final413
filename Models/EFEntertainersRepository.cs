using Final.Data;

namespace Final.Models;

public class EFEntertainersRepository : IEntertainersRepository
{
    private readonly EntertainerContext _context;

    public EFEntertainersRepository(EntertainerContext context)
    {
        _context = context;
    }
    
    public IQueryable<Entertainer> Entertainers => _context.Entertainers;

   
    public void Add(Entertainer entertainer)
    {
        _context.Entertainers.Add(entertainer);
    }
    
    public void SaveChanges()
    {
        _context.SaveChanges();
    }
    
    public void Update(Entertainer entertainer)
    {
        _context.Entertainers.Update(entertainer);
    }

    public void Remove(Entertainer entertainer)
    {
        _context.Entertainers.Remove(entertainer);
    }
}