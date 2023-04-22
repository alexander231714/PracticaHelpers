using Microsoft.EntityFrameworkCore;

namespace PracticaHelpers.Models
{
    public class Context_Helper : DbContext
    {
        public Context_Helper(DbContextOptions options) : base(options){

        }
    }
}
