using System;

namespace ConsoleApp3
{
    // Этот класс является рооизводным от DataModelProduct
    // и по сигнатуре класса ViewModelMain
    // должен работать без ошибок.
    // Поэтому компилятор никких предупреждения не показывает.
    // Но в рунтайме они выкидывают исключения.
    class DataModelProducts : DataModelProduct {}
    class Program
    {
        static void Main(string[] args)
        {

            var product = new DataModelPromoPackListProduct() { ID = 1, PromoPackListID = 2 };

            IVM<DataModelProduct> productVM = new ViewModelProduct<DataModelProduct>(product);
            // var promoPackListID = productVM.Data.PromoPackListID;//ошибка

            var productVM2 = new ViewModelPromoPackListProduct(product);
            var promoPackListID = productVM2.Data.PromoPackListID;


            var viewModelMain = new ViewModelMain<ViewModelProduct<DataModelProducts>>();

            IVM<DataModelProduct> SelectedProductProductVM = viewModelMain.SelectedProduct;

            Console.Read();
        }
    }
}
