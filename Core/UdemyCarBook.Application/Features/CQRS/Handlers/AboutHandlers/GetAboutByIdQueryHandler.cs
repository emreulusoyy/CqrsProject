using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.CQRS.Queries.AboutQueries;
using UdemyCarBook.Application.Features.CQRS.Results.AboutResult;
using UdemyCarBook.Application.İnterfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.CQRS.Handlers.AboutHandlers
{
  
    public class GetAboutByIdQueryHandler
    {
        private readonly IReposiyory<About> _reposiyory;

        public GetAboutByIdQueryHandler(IReposiyory<About> reposiyory)
        {
            _reposiyory = reposiyory;
        }


        public async Task< GetAboutByIdQueryResult> Handle(GetAboutByIdQuery getAboutByIdQuery)
        {
            var values = await _reposiyory.GetByIdAsync(getAboutByIdQuery.Id);
            return new GetAboutByIdQueryResult
            {
               AboutID = values.AboutID,
               Description = values.Description,
               ImageUrl = values.ImageUrl,
               Title = values.Title,
            };
        }
    }
}
