using AppPessoa.Data.Converter.Implementations;
using AppPessoa.Data.VO;
using RestWithASPNETUdemy.Model;
using RestWithASPNETUdemy.Repository;
using System.Collections.Generic;


namespace RestWithASPNETUdemy.Business.Implementations
{
	public class PersonBusinessImplementation : IPersonBusiness
	{
		private readonly IRepository<Person> _repository;

		private readonly PersonConverter _converter;
		public PersonBusinessImplementation(IRepository<Person> repository)
		{
			// Our exclusion logic would come here
			_repository = repository;
			_converter = new PersonConverter(); 
		}
		public List<PersonVO> FindAll()
		{
			return _converter.Parse(_repository.FindAll());
		}
		public PersonVO FindByID(long id)
		{
			return _converter.Parse(_repository.FindByID(id));
		}

		// Method responsible to crete one new pessoa
		public PersonVO Create(PersonVO person)
		{
			var personEntity = _converter.Parse(person);
			personEntity = _repository.Create(personEntity);
			return _converter.Parse(personEntity);

		}

		// Method responsible for updating a pessoa for
		// being mock we return the same information passed
		// Method responsible for updating one person
		public PersonVO Update(PersonVO person)
		{
			var personEntity = _converter.Parse(person);
			personEntity = _repository.Update(personEntity);
			return _converter.Parse(personEntity);
		}
		// Method responsible for deleting a person from an ID
		public void Delete(long id)
		{
			_repository.Delete(id);
		}
		
	}
}