using System;
using System.Configuration;

namespace RazorPage
{
    public class RazorPageDbContex
    {
        //public T Get<T>(Func<string, T> parseFunc, Func<T> defaultTValueFunc, string key)
        //{
        //    try
        //    {
        //        var rawConfigValue = Configuration.AppSettings[key];
        //        return !string.IsNullOrEmpty(rawConfigValue) ? parseFunc(rawConfigValue) : defaultTValueFunc();
        //    }
        //    catch (ConfigurationException exception)
        //    {
        //        new Logger().Write(LogType.Exception, exception.Message);
        //        return default(T);
        //    }
        //}
    }
}
