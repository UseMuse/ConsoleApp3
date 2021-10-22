using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{

    interface IVM<out TData> where TData : DataModelProduct, new()
    {
        //DataModelProduct,DataModelPromoPackListProduct
        TData Data { get; }
    }

}
