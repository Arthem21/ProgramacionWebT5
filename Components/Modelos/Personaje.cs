using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System.ComponentModel.DataAnnotations;

public class Personajes(){

    public string ID {set;get;}= Guid.NewGuid().ToString();
    [Required(ErrorMessage= "El campo nombre es requerido")]
    public string Nombre{get;set;}=string.Empty;
    public string? Alias{get;set;}=string.Empty;

     [Required(ErrorMessage= "El campo rol es requerido")]
    public string? Rol {get;set;}=string.Empty;

     [Required(ErrorMessage= "El campo hablilidad es requerido")]
    public string? Habilidad{get;set;}=string.Empty;

     [Required(ErrorMessage= "El campo arma es requerido")]
    public string? Arma {get;set;}=string.Empty;

     [Required(ErrorMessage= "El campo nivel es requerido")]
    public int? Nivel{get;set;}=0;
    public string? Imagen {get;set;}=string.Empty;
    public Juegos? juego{get; set;}= new Juegos();
    public string? juegosid{get;set;}=string.Empty;
    
}