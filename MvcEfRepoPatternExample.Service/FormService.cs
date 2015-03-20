using System.Collections.Generic;
using MvcEfRepoPatternExample.Model;
using MvcEfRepoPatternExample.Repository;
using MvcEfRepoPatternExample.Repository.Common;
using MvcEfRepoPatternExample.Service.Common;

namespace MvcEfRepoPatternExample.Service
{
    class FormService:EntityService<Form>,IFormService
    {
        readonly IFormRepository _formRepository;

        public FormService(IUnitOfWork unitOfWork, IFormRepository repository) : base(unitOfWork, repository)
        {
            _formRepository = repository;
        }

        public IEnumerable<Form> GetPagedList(int page, int pageSize)
        {
            return _formRepository.GetPagedList(page, pageSize);
        }

        public int GetCount()
        {
            return _formRepository.GetCount();
        }
    }
}
