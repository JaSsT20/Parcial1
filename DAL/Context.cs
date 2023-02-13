using Microsoft.EntityFrameworkCore;
//Crear el contexto hacer comentario y push.

public class Context : DbContext
{
    public DbSet<Books> Book { get; set; }
    public Context(DbContextOptions<Context> options ): base(options)
    {
        
    }
}