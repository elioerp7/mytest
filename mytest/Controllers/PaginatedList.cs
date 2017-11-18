using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


namespace GeekTextBooks
{
    public class PaginatedList<T> : List<T>
    {
        public int PageIndex { get; private set; }
        public int FirstIndex { get; private set; }
        public int TotalPages { get; private set; }
        public static int Size = 10;
        
        
        

        public PaginatedList(List<T> items, int count, int pageIndex, int pageSize)
        {
            PageIndex = pageIndex;
            TotalPages = (int)Math.Ceiling(count / (double)Size);
            FirstIndex = (int)Math.Ceiling(1 / (double)Size);

            this.AddRange(items);

        }

        public bool HasPreviousPage
        {
            get
            {
                return (PageIndex > 1);
            }
        }

        public bool HasNextPage
        {
            get
            {
                return (PageIndex < TotalPages);
            }
        }

        public static async Task<PaginatedList<T>> CreateAsync(IQueryable<T> source, int pageIndex, int pageSize)
        {
            if (pageSize == 20)
                Size = 20;
            else if (pageSize == 10)
                Size = 10;

            var count = await source.CountAsync();
            var items = await source.Skip((pageIndex - 1) * Size).Take(Size).ToListAsync();
            return new PaginatedList<T>(items, count, pageIndex, Size);
        }
    }
}
