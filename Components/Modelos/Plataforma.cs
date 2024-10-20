using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System.ComponentModel.DataAnnotations;



public class Plataformas(){

    public string ID {set;get;}= Guid.NewGuid().ToString();

    [Required(ErrorMessage= "El campo nombre es requerido")]
    public string? Nombre{get;set;}=string.Empty;

    public bool Estado{get;set;}= true;

    public string? icono{get;set;}=string.Empty;
    public List<Juegos>? juegos{set;get;}= new List<Juegos>();
    
}

