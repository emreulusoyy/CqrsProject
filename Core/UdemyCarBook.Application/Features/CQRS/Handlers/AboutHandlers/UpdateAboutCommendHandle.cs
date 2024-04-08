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
    public class UpdateAboutCommendHandle
    {
        private readonly IReposiyory<About> _repository;

        public UpdateAboutCommendHandle(IReposiyory<About> repository)
        {
            _repository = repository;
        }


        public async Task Handle(UpdateAboutCommend commend)
        {
            var values = await _repository.GetByIdAsync(commend.AboutID);
            values.Description = commend.Description;
            values.Title = commend.Title;
            values.ImageUrl = commend.ImageUrl;
            await _repository.UpdateAsync(values);
        }
    }
}
