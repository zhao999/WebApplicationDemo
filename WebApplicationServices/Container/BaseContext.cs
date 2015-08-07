using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplicationServices.Container
{
    public class BaseContext<ContextType> : DbContext where ContextType : DbContext
    {
        public BaseContext(string con)
            : base(con)
        {
            //  去除元数据验证，去除 初始化数据库 功能。   
            //  注：如果使用 modelBuilder.Conventions.Remove<IncludeMetadataConvention>();   仅仅去除初始化功能，但仍然会进行元数据验证  ，使用miniprofile时，首次报错
            Database.SetInitializer<ContextType>(null);
        }

    }
}
