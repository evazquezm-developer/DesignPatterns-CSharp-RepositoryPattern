// Interface que define el CRUD usando generics.
public interface IRepository<T> {
    IEnumerable<T> GetAll();
    T GetById(int id);
    void Add(T entity);
    void Update(T entity);
    void Delete(int id);
}