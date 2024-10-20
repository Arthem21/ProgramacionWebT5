using Microsoft.EntityFrameworkCore;

class Contexto:DbContext{

    public DbSet<Juegos>? Juegos{get;set;}=null;
    public DbSet<Personajes>? personajes{get;set;}=null;
    public DbSet<Plataformas>? plataformas{get;set;}=null;
    public Contexto(DbContextOptions<Contexto>options):base(options){}
}