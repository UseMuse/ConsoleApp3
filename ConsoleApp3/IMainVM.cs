using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{

    interface IMainVM<TVMData> where TVMData : IVM<DataModelProduct>
    {
        //IVM<DataModelProduct>,IVM<DataModelPromoPackListProduct>
        //ViewModelProduct<DataModelProduct>,ViewModelProduct<DataModelPromoPackListProduct>
        //ViewModelPromoPackListProduct
        TVMData SelectedProduct { get; }
        //IEnumerable<IVM<DataModelProduct>>,IEnumerable<IVM<DataModelPromoPackListProduct>>
        //IEnumerable<ViewModelProduct<DataModelProduct>>,IEnumerable<ViewModelProduct<DataModelPromoPackListProduct>>
        //IEnumerable<ViewModelPromoPackListProduct>
        IEnumerable<TVMData> Products { get; }
        void BuildProducts();
    }

}
