using System.Text.Json;
using Dsw2025Ej14.Domain;

namespace Dsw2025Ej14.Api.Data
{
    public class PersistenciaEnMemoria
    {
        private const string Archivo = "Products.json";
        private List<Product> _productos = new();

        public void LoadProducts()
        {
            if (File.Exists(Archivo))
            {
                string json = File.ReadAllText(Archivo);
                var productos = JsonSerializer.Deserialize<List<Product>>(json);
                if (productos != null)
                {
                    _productos = productos;
                }
            }
        }

        public List<Product> ObtenerProductos()
        {
            return _productos;
        }
    }
}
