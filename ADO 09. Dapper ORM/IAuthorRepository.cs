namespace ADO_09._Dapper_ORM;
internal interface IAuthorRepository
{
    Author Add(Author author);
    void AddAuthors(List<Author> authors);
    void Remove(int id);
    void RemoveByIdArray(int[] ids);
    void RemoveRange(int start, int end);
    Author Update(Author author);
    void UpdateAuthors(List<Author> authors);
    IEnumerable<Author> GetAll();
    Author GetById(int id);
}
