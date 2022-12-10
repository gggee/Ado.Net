using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StreetFood.DAL;
using StreetFood.Entities;
using StreetFood.Repositories.Interfaces;
namespace StreetFood.Repositories.Implementations;
public class PurchaseRepository : IPurchaseRepository {
  public void AddPurchase(Purchase purchaseEntity) {
    using (StreetFoodDbContext streetFoodDbContext = new StreetFoodDbContext()) {
      streetFoodDbContext.Add(purchaseEntity);
      streetFoodDbContext.SaveChanges();
    }
  }
}
