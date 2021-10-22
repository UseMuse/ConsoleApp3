using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{

    class ViewModelMain<TVMData> : IMainVM<TVMData> where TVMData : IVM<DataModelProduct>, new()
    {
        private TVMData selectedProduct = new TVMData();
        public TVMData SelectedProduct => selectedProduct;
        private IEnumerable<TVMData> products => new List<TVMData>();
        public IEnumerable<TVMData> Products => products;

        public ViewModelMain(IVM<DataModelProduct> vM)
        {

        }

        public void BuildProducts()
        {
            var product = new DataModelPromoPackListProduct() { ID = 1, PromoPackListID = 2 };
            var product2 = new DataModelPromoPackListProduct() { ID = 2, PromoPackListID = 2 };

            IVM<DataModelProduct> dsds = new ViewModelProduct<DataModelProduct>(product);
            var t = selectedProduct.GetType().ToString();//ConsoleApp3.ViewModelProduct`1[ConsoleApp3.DataModelProduct]
            var t2 = dsds.GetType().ToString();          //ConsoleApp3.ViewModelProduct`1[ConsoleApp3.DataModelProduct]
            //selectedProduct = dsds;//ошибка

        }
    }

}
