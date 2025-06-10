using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Dsw2025Ej14.Domain
{
    public class Product
    {
        private string _sku;
        private string _name;
        private decimal _currentUnitPrice;
        private bool _IsActive;

        public Product(string sku, string name, decimal currentUnitPrice, bool isActive)
        {
            Sku = sku;
            Name = name;
            CurrentUnitPrice = currentUnitPrice;
            IsActive = isActive;
        }

        public string Sku { get => _sku; set => _sku = value; }
        public string Name { get => _name; set => _name = value; }
        public decimal CurrentUnitPrice { get => _currentUnitPrice; set => _currentUnitPrice = value; }
        public bool IsActive { get => _IsActive; set => _IsActive = value; }
    }
}