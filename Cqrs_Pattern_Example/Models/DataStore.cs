namespace Cqrs_Pattern_Example.Models
{
    public class DataStore
    {
        public static List<Book> _books = new()
        {
            new(){Id=1, Title="OOP" , Price=32},
            new(){Id=2, Title="Angular" , Price=23},
            new(){Id=3, Title="React" , Price=34},
            new(){Id=4, Title="Vue" , Price=12}
        };


        public async Task AddAsync(Book book)
        {
            _books.Add(book);
            await Task.CompletedTask;
        }

        public async Task<IEnumerable<Book>> GetBooksAsync()
        {
            return await Task.FromResult(_books);
        }

        public async Task<Book> GetBookById(int id)
        {
            return await Task.FromResult(_books.FirstOrDefault(x => x.Id == id));
        }

        public async Task UpdateAsync(Book book)
        {
            var data = _books.FirstOrDefault(x => x.Id == book.Id);
            data.Title = book.Title;
            data.Price = book.Price;
            await Task.CompletedTask;
        }
        public async Task<Book> DeleteAsync(int id)
        {
            var data = _books.FirstOrDefault(x => x.Id == id);
            _books.Remove(data);
            return await Task.FromResult(data);
        }

    }
}
