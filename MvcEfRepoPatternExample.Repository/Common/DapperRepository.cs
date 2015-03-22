using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using MvcEfRepoPatternExample.Model.Common;

namespace MvcEfRepoPatternExample.Repository.Common
{
    public class DapperRepository<T>:IDapperRepository<T> where T: class
    {
        public IDbConnection Connection
        {
            get
            {
                return new SqlConnection(ConfigurationManager.ConnectionStrings["ReportDbContext"].ConnectionString);
            }
        }

        public T FindById(int id)
        {
            using (var cn = Connection)
            {
                cn.Open();
                return cn.Get<T>(id);
            }
        }

        public IEnumerable<T> GetAll()
        {
            using (var cn = Connection)
            {
                cn.Open();
                return cn.GetList<T>();
            }
        }

        public IEnumerable<T> GetAll(Func<T, bool> predicate)
        {
            using (var cn = Connection)
            {
                cn.Open();
                return cn.GetList<T>().Where(predicate);
            }
        }
    }
}
