using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplicationServices.Container;

namespace WebApplicationServices
{
    public abstract class BaseManager<ContextType> where ContextType : class, IDisposable
    {
        /// <summary>
        /// 数据库连接name，  不可设置为静态，方便多库
        /// </summary>
        protected string _WriteConnectStringName;

        protected string _ReaedConnectStringName;

        // <summary>
        /// 构造函数
        /// 设置默认数据库连接
        /// </summary>
        protected BaseManager()
        {
            _WriteConnectStringName = "WriteConStrName";
            _ReaedConnectStringName = "ReadConStrName";
        }
        // <summary>
        /// 为了使用多个DbContext，并且context连接信息必须构造函数中初始化
        /// 同时为了避免反射带来的性能消耗。这里仅提供虚方法，不做具体处理
        /// </summary>
        /// <param name="connectionStr">连接信息</param>
        /// <returns></returns>
        protected abstract ContextType GetContext(string connectionStr);

        protected internal TestContext ReadTextContext
        {
            get { return new TestContext("WriteTestContext"); }
        }
        protected internal TestContext WriteTextContext
        {
            get { return new TestContext("WriteTestContext"); }
        }
    }
}
