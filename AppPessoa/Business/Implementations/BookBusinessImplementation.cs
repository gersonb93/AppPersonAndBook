using AppPessoa.Data.Converter.Implementations;
using RestWithASPNETUdemy.Model;
using RestWithASPNETUdemy.Repository;
using System.Collections.Generic;


namespace RestWithASPNETUdemy.Business.Implementations
{
	public class BookBusinessImplementation : IBookBusiness
	{
		private readonly IRepository<Book> _repository;

		private readonly BookConverter _converter;
		public BookBusinessImplementation(IRepository<Book> repository)
		{
			// Our exclusion logic would come here
			_repository = repository;
			_converter = new BookConverter();
		}
		public List<BookVO> FindAll()
		{
			return _converter.Parse(_repository.FindAll());
		}
		public BookVO FindByID(long id)
		{
			return _converter.Parse(_repository.FindByID(id));
		}

		// Method responsible to crete one new pessoa
		public BookVO Create(BookVO book)
		{

			var personEntity = _converter.Parse(book);
			personEntity = _repository.Create(personEntity);
			return _converter.Parse(personEntity);
		}

		// Method responsible for updating a pessoa for
		// being mock we return the same information passed
		// Method responsible for updating one person
		public BookVO Update(BookVO book)
		{
			var personEntity = _converter.Parse(book);
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