using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{

    class ViewModelMain<TVMData> : IMainVM<TVMData> where TVMData : IVM<DataModelProduct>, new()
    {
        //IVM<DataModelProduct>,IVM<DataModelPromoPackListProduct>
        //ViewModelProduct<DataModelProduct>,ViewModelProduct<DataModelPromoPackListProduct>
        //ViewModelPromoPackListProduct
        private TVMData selectedProduct = new TVMData();

        public TVMData SelectedProduct => selectedProduct;


        //IEnumerable<IVM<DataModelProduct>>,IEnumerable<IVM<DataModelPromoPackListProduct>>
        //IEnumerable<ViewModelProduct<DataModelProduct>>,IEnumerable<ViewModelProduct<DataModelPromoPackListProduct>>
        //IEnumerable<ViewModelPromoPackListProduct>
        private IEnumerable<TVMData> products = new List<TVMData>();
        public IEnumerable<TVMData> Products => products;

        public ViewModelMain()
        {
            BuildProducts();
        }

        public void BuildProducts()
        {
            var product = new DataModelPromoPackListProduct() { ID = 1, PromoPackListID = 2 };
            var product2 = new DataModelPromoPackListProduct() { ID = 2, PromoPackListID = 2 };

            IVM<DataModelProduct> productVM1 = new ViewModelProduct<DataModelProduct>(product);
            IVM<DataModelProduct> productVM2 = new ViewModelProduct<DataModelProduct>(product2);

            selectedProduct = (TVMData)productVM1;//решается ошибка путём явного приведения

            products = new List<TVMData>() { (TVMData)productVM1, (TVMData)productVM2 };

        }
    }

}
