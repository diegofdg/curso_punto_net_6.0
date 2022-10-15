using Dapper;
using Microsoft.Extensions.Options;
using ProyectoFinal.Models;
using System.Data.SqlClient;

namespace ProyectoFinal.Rules
{
    public class PublicacionRule
    {
        public Publicacion GetOnePostRandom()
        {

            var connectionString = @"Server=DESKTOP-QR7T2GC; Database=BlogDatabase; Trusted_Connection=True";
            using var connection = new SqlConnection(connectionString);
            {
                connection.Open();
                var posts = connection.Query<Publicacion>("SELECT TOP 1 * FROM Publicacion");

                return posts.First();
            }
        }

    }
}
