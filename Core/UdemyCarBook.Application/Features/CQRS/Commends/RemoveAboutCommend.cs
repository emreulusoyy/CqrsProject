using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UdemyCarBook.Application.Features.CQRS.Commends
{
    public class RemoveAboutCommend
    {
        public RemoveAboutCommend(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
