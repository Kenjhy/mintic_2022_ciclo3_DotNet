using System;
					
namespace HomePetCare.App.Dominio
{
	public class Persona
	{
		public String Documento{get;set;}
		public String Nombre{get;set;}
		public String Apellidos{get;set;}
		public String Telefono{get;set;}
	}
	
	public class Dueño : Persona
	{
		public String Cuidad{get;set;}
		public String Direccion{get;set;}
	}
	
	public class Medico : Persona
	{
		public String TarjetaProfesional{get;set;}
	}
	
	public class Recomendaciones
	{
		public int Id{get;set;}
		public DateTime FechaHora{get;set;}
		public String sugerencia{get;set;}
	}
	
	public class Historia
	{
		public int Id{get;set;}
		public String Diagnostico{get;set;}
		public list<Recomendaciones> Recomendaciones{get;set;}
	}
	
	public class Mascota
	{
		public int Id{get;set;}
		public String Nombre{get;set;}
		public String Raza{get;set;}
		public int Edad{get;set;}
		public Historia Historia { get; set; }
		public System.Collections.Generic.List<SignoVital> SignosVitales { get; set; }
	}
	
	public enum TipoSigno
	{
		Peso,
		FrecuenciaCardiaca,
		FrecuenciaRespiratoria
	}
	
	public enum Animo
	{
		Alegre,
		Triste,
		Agresivo
	}
	
	public class SignoVital
	{
		public int Id { get; set;}
        public DateTime FechaHora  { get; set;}
        public float Valor {get;set;}
        public TipoSigno Signo { get; set;}
		public Animo Animo{get;set;}
	}
	
	
	public class Visita
	{
		public int Id{get;set;}
		public DateTime FechaVisita{get;set;}
		public System.Collections.Generic.List<SignoVital> SignosVitales { get; set; }
		public Mascota MascotaVisitada{get;set;}
	}
	
}