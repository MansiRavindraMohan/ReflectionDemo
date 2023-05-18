using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionDemo
{
    // reflection is process of discribing the metadata of type methord and field in a code
    // metadeta refers to a binary information saved in a memory or a language runtime portable executable file
    // Metadata inclued type defenation version infomation external assembly
    //why Metadata? - understandable data, sorting or searching data easily
    public class CustomerInfo
    {
        public static void Customer()
        {
            Type type = Type.GetType("ReflectionDemo.Customer");
            Console.WriteLine(type.FullName);
            Console.WriteLine(type.Name);
            Console.WriteLine(type.Namespace);
            Console.WriteLine(type.Assembly);
            PropertyInfo[] properties= type.GetProperties();
            foreach (PropertyInfo property in properties)
            {
                Console.WriteLine(property.PropertyType.Name+" "+property.Name);
            }
            ConstructorInfo[] constructors=type.GetConstructors();
            foreach (ConstructorInfo constructor in constructors)
            {
                Console.WriteLine(constructor.ToString());
            }
            MethodInfo[] methods=type.GetMethods();
            foreach(MethodInfo method in methods)
            {
                Console.WriteLine(method.Name+" "+method.ReturnType.Name);
            }
        }
    }
}
