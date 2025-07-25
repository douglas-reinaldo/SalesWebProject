using Microsoft.EntityFrameworkCore;
using SalesWebMVC.Data;
using SalesWebMVC.Models;

namespace SalesWebMVC.Services
{
    public class SalesRecordService
    {
        private readonly SalesWebMVCContext _context;

        public SalesRecordService(SalesWebMVCContext context) 
        {
            _context = context;
        }


        public async Task<List<SalesRecord>> FindByDateAsync(DateTime? minDate, DateTime? maxDate) 
        {
            var result = _context.SalesRecord.Select(n => n);
            if (minDate.HasValue) 
            {
                result = result.Where(n => n.Date >= minDate);
            }
            if (maxDate.HasValue) 
            {
                result = result.Where(n => n.Date <= maxDate);
            }

            return await result.
                Include(n => n.Seller).
                Include(n => n.Seller.Department).
                OrderByDescending(n => n.Date).
                ToListAsync();
        }
    }
}
