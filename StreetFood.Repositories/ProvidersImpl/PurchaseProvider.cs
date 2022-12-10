using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StreetFood.BusinessObjects;
using StreetFood.Entities;
using StreetFood.Providers;
using StreetFood.Repositories.Interfaces;

namespace StreetFood.Repositories.ProvidersImpl;
public class PurchaseProvider : IPurchaseProvider {
  private IPurchaseRepository purchaseRepository;
  public void AddPurchase(PurchaseBO purchaseBO) {
    Purchase purchaseEntity = new Purchase() {
      Count= purchaseBO.Count,
      Date= purchaseBO.Date,
      PriceOneProduct= purchaseBO.PriceOneProduct,
      Patner= purchaseBO.Patner
    };
    purchaseRepository.AddPurchase(purchaseEntity);
  }
}
