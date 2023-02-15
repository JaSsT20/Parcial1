using Microsoft.EntityFrameworkCore;

public class BooksBLL
{
    private Context context;

    public BooksBLL(Context context)
    {
        this.context = context;
    }

    public bool Exist(int BookId)
    {
        return context.Book.Any(book => book.BookId == BookId);
    }

    public bool Insert(Books Book)
    {
        context.Book.Add(Book);
        return context.SaveChanges() > 0;
    }

    public bool Modify(Books Book)
    {
        context.Entry(Book).State = EntityState.Modified;
        return context.SaveChanges() > 0;
    }

    public bool Save(Books Book)
    {
        if(!Exist(Book.BookId))
            return Insert(Book);
        else
            return Modify(Book);
    }

    public bool Delete(Books Book)
    {
        context.Entry(Book).State = EntityState.Deleted;
        return context.SaveChanges() > 0;
    }

    public Books? Search(int BookId)
    {
        return context.Book.Where(book => book.BookId == BookId).AsNoTracking().SingleOrDefault();
    }

}