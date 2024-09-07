using C42_G02_EF01.Data;

namespace C42_G02_EF01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using CompanyDbContext dbContext = new CompanyDbContext();

            var employees = dbContext.Employees.Where(E => E.Age > 20).ToList();

            #region What is EF Core

            /*
            ORM: Object Relational Mapper
             
            1. Mapping: 2 approaches

                // code first
                1.1.from code (classes) -> generate database (tables)
             
            1. ORM builds class DBContext: responsible for connecting to and 
            communicating with DB
            a prop for every table and view in DB of type (DBSet)

            2. domain models
            */



            #endregion
        }
    }
}
