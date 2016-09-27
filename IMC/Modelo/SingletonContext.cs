using SimpleInjector;
using System.Data.Entity;

namespace Modelo
{
    public static class SingletonContext
    {
        private static Container _container = null;

        public static void CreateInstance()
        {
            Bootstrap();
        }

        private static void Bootstrap()
        {
            if (_container != null) return;

            _container = new Container();
            _container.Register<DbContext, Context>();
        }

        public static Modelo.Context GetContext()
        {
            var context = _container.GetInstance<Modelo.Context>();
            return context;
        }
    }
}
