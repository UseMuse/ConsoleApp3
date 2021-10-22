using System;

namespace ConsoleApp3
{

    class Program
    {
        static void Main(string[] args)
        {

            var product = new DataModelPromoPackListProduct() { ID = 1, PromoPackListID = 2 };

            IVM<DataModelProduct> productVM = new ViewModelProduct<DataModelProduct>(product);
            // var promoPackListID = productVM.Data.PromoPackListID;//ошибка

            IVM<DataModelPromoPackListProduct> productVM2 = new ViewModelPromoPackListProduct(product);
            var promoPackListID = productVM2.Data.PromoPackListID;


            var viewModelMain = new ViewModelMain<ViewModelProduct<DataModelProduct>>(productVM);
            viewModelMain.BuildProducts();
            Console.Read();
        }
    }
}
