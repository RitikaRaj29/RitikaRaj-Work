using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductDetails
{
    
    
        class Product : IComparable<Product>
        {
            public int ProductID { get; set; }
            public string BrandName { get; set; }

            public string Description { get; set; }
            public double Price { get; set; }




            public int CompareTo(Product other)
            {
                if (this.ProductID > other.ProductID)
                {
                    return 1;

                }
                else if (this.ProductID < other.ProductID)
                {
                    return -1;
                }
                else
                {
                    return 0;
                }
            }
        }




        class SortByBrandName : IComparer<Product>
        {
            public int Compare(Product x, Product y)
            {
                if (x.BrandName.Equals(y.BrandName))
                {
                    return x.Description.CompareTo(y.Description);
                }
                else
                {
                    return x.BrandName.CompareTo(y.BrandName);
                }
            }
        }



        class SortByPrice : IComparer<Product>
        {
            public int Compare(Product x, Product y)
            {
                if (x.Price > y.Price)
                {
                    return 1;
                }
                else if (x.Price < y.Price)
                {
                    return -1;
                }
                else
                {
                    if (x.ProductID > y.ProductID)
                    {
                        return -1;
                    }
                    else if (x.ProductID < y.ProductID)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    
}









    
