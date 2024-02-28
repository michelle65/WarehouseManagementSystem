using System.Text.Json;
using WarehouseManagementSystem.Domain;
internal class LocalData
{
    public static IEnumerable<Order> Load()
    {
        var json = File.ReadAllText("orders.json");

        return JsonSerializer.Deserialize<IEnumerable<Order>>(json) ?? Enumerable.Empty<Order>();
    }

    public static void GenerateAndSave()
    {
        var warehouses = new Warehouse[] {
      new Warehouse {
        Id = Guid.NewGuid(),
          Location = "Germany" // Change warehouse location
      },
      new Warehouse {
        Id = Guid.NewGuid(),
          Location = "Canada" // Change warehouse location
      }
    };

        var items = new Item[] {
      new Item {
        Id = Guid.NewGuid(), Name = "Audio-Technica AT2020", InStock = 10, Price = 149.99m, Description = "Quality condenser microphone for studio recording", Warehouses = warehouses
      },
      new Item {
        Id = Guid.NewGuid(), Name = "Rode NT1-A", InStock = 8, Price = 229.95m, Description = "Versatile large-diaphragm condenser microphone", Warehouses = warehouses
      }
    };

        var shippingProviders = new ShippingProvider[] {
      new ShippingProvider {
        Id = Guid.NewGuid(), Name = "Deutsche Post", FreightCost = 8.50m
      }, // Change shipping provider name and cost
      new ShippingProvider {
        Id = Guid.NewGuid(), Name = "Canada Post", FreightCost = 7.25m
      } // Change shipping provider name and cost
    };

        var customer = new Customer()
        {
            Id = Guid.NewGuid(),
            Name = "John Doe", // Change customer name
            Address = "123 Main Street", // Change customer address
            Country = "Germany", // Change customer country
            PhoneNumber = "+49 123 456 789", // Change customer phone number
            PostalCode = "12345" // Change customer postal code
        };

        var orders = new Order[] {
      new Order {
        Id = Guid.NewGuid(),
          Customer = customer,
          LineItems = new LineItem[] {
            new LineItem {
              Id = Guid.NewGuid(), Item = items[0], Quantity = 3
            }, // Change item and quantity
            new LineItem {
              Id = Guid.NewGuid(), Item = items[1], Quantity = 2
            } // Change item and quantity
          },
          ShippingProvider = shippingProviders.First()
      },
      new Order {
        Id = Guid.NewGuid(),
          Customer = customer,
          LineItems = new LineItem[] {
            new LineItem {
              Id = Guid.NewGuid(), Item = items[1], Quantity = 1
            } // Change item and quantity
          },
          ShippingProvider = shippingProviders[1]
      }

    };

        var json = JsonSerializer.Serialize(orders);

        File.WriteAllText("orders.json", json);
    }
}