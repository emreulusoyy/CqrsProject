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
    public class CreateAboutCommendHandler
    {
        private readonly IReposiyory<About> _repository;

        public CreateAboutCommendHandler(IReposiyory<About> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateAboutCommend command)
        {
            await _repository.CreateAsync(new About
            {
                Title = command.Title,
                Description = command.Description,
                ImageUrl = command.ImageUrl
            });
        }
    }
}
