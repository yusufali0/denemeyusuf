using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dto
{
    public record BookDtoForUpdate
    {
        private int ıd;

        public BookDtoForUpdate(int ıd, string title, decimal price)
        {
            this.ıd = ıd;
            Title = title;
            Price = price;
        }

        public int Id { get; init; }
        public String Title { get; init; }
        public decimal Price { get; init; }
    }
}
