using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StreetFood.BusinessLogic.Interfaces;
using StreetFood.BusinessObjects;
using StreetFood.Providers;

namespace StreetFood.BusinessLogic.Implementations;
public class PurchaseService : IPurchaseService {
  private IPurchaseProvider purchaseProvider;
  public void AddPurchase(PurchaseBO purchaseBO) {
    purchaseProvider.AddPurchase(purchaseBO);
  }
}
