using System;
using System.Reflection;

namespace to_do2.Object_Mapper
{
    public class ModalMappingHelper
    {

        public static TMappee MapModals<TMapper, TMappee>(TMapper mapper) where TMappee : new()
        {

            TMappee mappee = new TMappee();

            foreach (PropertyInfo property in mapper.GetType().GetProperties())
            {
                try
                {

                    string propertyName = property.Name;

                    //On the last iteration propertyName is Database
                    if (propertyName == "Database")
                    {
                        break;
                    }

                    var propertyValue = property.GetValue(mapper);
                    var propertyInfo = mappee.GetType().GetProperty(propertyName);

                    propertyInfo.SetValue(mappee, propertyValue);

                }
                catch (Exception ex)
                {

                }

            }

            return mappee;

        }

    }
}
