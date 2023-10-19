using System.Data.SqlClient;
using Dapper;
using Tp10_Series.Models;

public static class BD {
    private static string _connectionString = @"Server=localhost;
            DataBase=BDSeries; Trusted_Connection=True;";

        

    public static List<Actores> infoActores(int IdSerie)
    {
         List<Actores> ListaActores = new List<Actores>(); 
         using(SqlConnection db = new SqlConnection(_connectionString) )
        {
            string sql ="SELECT * FROM Actores WHERE IdSerie = @idSerie";
        
        ListaActores = db.Query<Actores>(sql, new {idSerie = IdSerie}).ToList();
        }
        return ListaActores;
    }
     
 public static List<Temporadas> infoTemperadas(int IdSerie)
    {
        List<Temporadas> ListaTemporadas = new List<Temporadas>(); 
         using(SqlConnection db = new SqlConnection(_connectionString) )
        {
            string sql ="SELECT * FROM Temporadas WHERE IdSerie = @idSerie";
        
        ListaTemporadas = db.Query<Temporadas>(sql, new {idSerie = IdSerie}).ToList();
        }
        return ListaTemporadas;
    }

        
    public static List<Series> infoSeries()
    {
         List<Series> ListaSeries = new List<Series>(); 
         using(SqlConnection db = new SqlConnection(_connectionString) )
        {
            string sql ="SELECT * FROM Series";
        
        ListaSeries = db.Query<Series>(sql).ToList();
        }
        return ListaSeries;
    }
    public static Series infoSerie(int IdSerie)
    {
         Series serie = null;
         using(SqlConnection db = new SqlConnection(_connectionString) )
        {
            string sql ="SELECT * FROM Series WHERE IdSerie = @idSerie";
        
        serie = db.QueryFirstOrDefault<Series>(sql, new {idSerie = IdSerie});
        }
        return serie;
    }

}