using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplicationServices.Container;

namespace WebApplicationServices
{
    public class TestBaseManager : BaseManager<TestContext>
    {
        /// <summary>
        ///   这里可以做分库处理，重写字符串即可
        /// </summary>
        public TestBaseManager()
        {
            _WriteConnectStringName = "WriteTestContext";
            _ReaedConnectStringName = "ReadTestContext";
        }

        /// <summary>
        ///   重写父类获取 Context db
        /// </summary>
        /// <param name="connectionStr">连接字符串</param>
        /// <returns></returns>
        protected override TestContext GetContext(string connectionStr)
        {
            return new TestContext(connectionStr);
        }
    }
}
