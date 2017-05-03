using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// 抽象工厂模式：提供一个创建一系列相关或相互依赖对象的接口，而无需指定它们具体的类。
/// </summary>
namespace BLL.AbstractFactoryPattern
{
    public class User
    {
        private int _id;

        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }

    public interface IUser
    {
        void Insert(User user);

        User GetUser(int id);
    }

    public class SqlserverUser : IUser
    {
        public void Insert(User user)
        {
            Console.WriteLine("在Sqlserver中插入一条数据");
        }

        public User GetUser(int id)
        {
            Console.WriteLine("在Sqlserver中获得一条数据");
            return null;
        }
    }

    public class AccessUser : IUser
    {
        public void Insert(User user)
        {
            Console.WriteLine("在Access中插入一条数据");
        }

        public User GetUser(int id)
        {
            Console.WriteLine("在Access中获得一条数据");
            return null;
        }
    }

    public class DataAccess
    {
        private static readonly string db = "Sqlserver";
        //private static readonly string db = "Access";

        private static readonly string AssemblyName = "BLL";

        public static IUser CreateUser()
        {
            //IUser result = null;
            //switch (db)
            //{
            //    case "Sqlserver":
            //        result = new SqlserverUser();
            //        break;

            //    case "Access":
            //        result = new AccessUser();
            //        break;

            //    default:
            //        break;
            //}
            //return result;

            string typeName = AssemblyName + ".AbstractFactoryPattern." + db + "User";

            var assembly = Assembly.Load(AssemblyName);
            IUser result = (IUser)assembly.CreateInstance(typeName);
            return result;
        }
    }
}