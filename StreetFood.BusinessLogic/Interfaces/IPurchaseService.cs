using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StreetFood.BusinessObjects;
namespace StreetFood.BusinessLogic.Interfaces; 
public interface IPurchaseService {
  void AddPurchase(PurchaseBO purchaseBO);
}
