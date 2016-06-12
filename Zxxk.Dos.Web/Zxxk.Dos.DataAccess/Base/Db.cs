using Dos.ORM;

namespace Zxxk.Dos.DataAccess
{
    public class Db { public static readonly DbSession Context = new DbSession("SqlServerConn"); }
}