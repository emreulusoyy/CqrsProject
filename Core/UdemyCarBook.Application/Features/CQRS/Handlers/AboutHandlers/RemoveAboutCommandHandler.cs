using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UdemyCarBook.Application.Features.CQRS.Commends;
using UdemyCarBook.Application.İnterfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.CQRS.Handlers.AboutHandlers
{
    public class RemoveAboutCommandHandler
    {
        private readonly IReposiyory<About> _repository;

        public RemoveAboutCommandHandler(IReposiyory<About> repository)
        {
            _repository = repository;
        }


        public async Task Handle(RemoveAboutCommend commend)
        {
            var value = await _repository.GetByIdAsync(commend.Id);
            await _repository.RemoveAsync(value);
        }

    }
}
