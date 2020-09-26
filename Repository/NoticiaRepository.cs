using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using XNews.Domain;
using Dapper;

namespace XNews.Repository
{
    public class NoticiaRepository : BaseRepository
    {
        public List<Noticia> Listar()
        {
            string query = @"
                SELECT [Id]
                      ,[Titulo]
                      ,[Descricao]
                  FROM [dbo].[Noticia]
            ";

            var con = new SqlConnection(_connectionString);
            con.Open();
            return con.Query<Noticia>(query).ToList();
        }
    }
}
