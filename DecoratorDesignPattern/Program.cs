using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var campaignProduct = new CampaignProduct
            {
                ProductName = "Kol Saati",
                Price = 1000
                
            };
            SpecialOffer specialOffer = new SpecialOffer(campaignProduct);

            specialOffer.DiscountPercentage = 25;

            Console.WriteLine("Ojinal Fiyat: {0}",campaignProduct.Price);
            Console.WriteLine("%25 İndirimli Hali: {0}",specialOffer.Price);
            Console.ReadKey();
        }
    }
    public abstract class ProductsBase
    {
        public abstract string ProductName { get; set; }
        public abstract decimal Price { get; set; }
    }
    public abstract class ProductsDecoratorBase: ProductsBase
    {
        private ProductsBase _products;
        public ProductsDecoratorBase(ProductsBase productBase)
        {
            _products = productBase;
        }
    }
    public class CampaignProduct : ProductsBase
    {
        public override string ProductName { get; set; }
        public override decimal Price { get; set ; }
    }
    public class SpecialOffer : ProductsDecoratorBase
    {
        public int DiscountPercentage { get; set; }
        private readonly ProductsBase _productBase;

        public SpecialOffer(ProductsBase productsBase) : base(productsBase)
        {
            _productBase = productsBase;
        }



        public override string ProductName { get ; set ; }
        public override decimal Price { get { return _productBase.Price - _productBase.Price * DiscountPercentage / 100; } set { } }
    }
}
