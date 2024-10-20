using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System.ComponentModel.DataAnnotations;


public class Juegos(){

    public string ID {set;get;}= Guid.NewGuid().ToString();

    [Required(ErrorMessage= "El campo nombre es requerido")]
    public string Nombre{get;set;}=string.Empty;
    [Required(ErrorMessage= "El campo desarrollador es requerido")]
    public string? Desarrollador{get;set;}=string.Empty;

    public string? Plataforma{get;set;}=string.Empty;
    [Required(ErrorMessage= "El campo género es requerido")]
    public string? Género{get;set;}=string.Empty;
    [Required(ErrorMessage= "El campo fecha de lanzamiento es requerido")]
    public DateOnly? Fecha{get;set;}=DateOnly.FromDateTime(DateTime.Now);
    public string? Portada{get;set;}=string.Empty;
    public string? Descripción{get;set;}=string.Empty;

    public List<Personajes>? personajes {get;set;}=new List<Personajes>();

    public Plataformas plataforma{get;set;}=new Plataformas();

    public string plataformaID{get;set;}=" ";
    
}

