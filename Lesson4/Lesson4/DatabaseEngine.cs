using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    public class DatabaseEngine
    {
        public void  WriteValue<T>(T value, string password)
        {
        var databaseValue= new DatabaseValue<T>();
                       
        }
        public class DatabaseValue<T>
        {   public T value { get; set; }

            public string tableName { get; set; }
        }
    }
}
