using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection.Task.Services;

public static class Mapper
{
    //                              User,      UserDto
    public static TDestination Map<TSource, TDestination>(TSource source)
        where TDestination : new()
        where TSource : new()
    {
        TDestination destination = new();
        PropertyInfo[] sourceProps = typeof(TSource).GetProperties();
        PropertyInfo[] destinationProps = typeof(TDestination).GetProperties();

        foreach (var sourceProp in sourceProps)
        {
            var destProp = destinationProps
                .FirstOrDefault(x => x.Name == sourceProp.Name && x.PropertyType == sourceProp.PropertyType);
            if(destProp != null && destProp.CanWrite)
            {
                object value = sourceProp.GetValue(source);
                destProp.SetValue(destination, value);
            }
        }
        return destination;
    }
}
