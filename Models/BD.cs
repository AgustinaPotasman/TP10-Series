using System.Data.SqlClient;
using Dapper;

public class BD {
    private static string _connectionString = @"Server=localhost;
            DataBase=TP10. scriptBDSeries; Trusted_Connection=True;";

         List<Actores> ListaActores = new List<Actores>(); /* Cambiar nombre */

    public List<Actores> infoActores()
    {
         using(SqlConnection db = new SqlConnection(_connectionString) )
        {
            string sql ="SELECT * FROM Actores WHERE IdSerie = @idSerie";
        }
        ListaActores = db.Query<Actores>(sql, new {idSerie = IdSerie}.ToList());
        return ListaActores;
    }
        List<Temporadas> ListaTemporadas = new List<Temporadas>(); 
 public List<Temporadas> infoTemperadas(int IdSerie)
    {
         using(SqlConnection db = new SqlConnection(_connectionString) )
        {
            string sql ="SELECT * FROM Temporadas WHERE IdSerie = @idSerie";
        }
        ListaTemporadas = db.Query<Temporadas>(sql, new {idSerie = IdSerie}.ToList());
        return ListaTemporadas;
    }

        List<Series> ListaSeries = new List<Series>(); 
     public List<Series> infoSeries()
    {
         using(SqlConnection db = new SqlConnection(_connectionString) )
        {
            string sql ="SELECT * FROM Series";
        }
        ListaSeries = db.Query<Series>(sql).ToList();
        return ListaSeries;
    }
}