using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Domain
{
    public class DOC
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DOCState State { get; set; }
        public Client Client { get; set; }
        public IEnumerable<ProductBox> ProductBoxesOut { get; set; }
        public Dictionary<BoxType, int> BoxesIn { get; set; }
        public double Total {
                get 
                {
                    double total = 0;
                    foreach (var box in ProductBoxesOut)
                    {
                        total += box.ProductQuantity * box.Product.Cost + box.BoxType.Cost * box.BoxQuantity;
                    }

                    foreach (var (box, quantity) in BoxesIn)
                    {
                        total -= box.Cost * quantity;
                    }

                    return total;
                }
            }
    }

    public enum DOCState
    {
        Open,
        Closed
    }
}
