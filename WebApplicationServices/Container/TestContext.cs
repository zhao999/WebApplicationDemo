using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplicationModel;

namespace WebApplicationServices.Container
{
    public class TestContext : BaseContext<TestContext>
    {
        public TestContext(string con)
            : base(con)
        {
        }
        public IDbSet<User> Users { get; set; }
    }
}
