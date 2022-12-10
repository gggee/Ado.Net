using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreetFood.BusinessObjects; 
public class PurchaseBO {
  public int Id { get; set; }
  public int IngredientId { get; set; }
  public int Count { get; set; }
  public DateTime Date { get; set; }
  public decimal PriceOneProduct { get; set; }
  public string Patner { get; set; }
}
