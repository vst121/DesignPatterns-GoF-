using System.Collections.Generic;

namespace FactoryMethod
{
    public interface IViewEngine
    {
        string Render(string viewName, Dictionary<string, object> context);
    }
}