namespace ConsoleApp3
{
    class ViewModelPromoPackListProduct : ViewModelProduct<DataModelPromoPackListProduct>
    {
        public int MyUniqueProp { get; set; }
        public ViewModelPromoPackListProduct(DataModelPromoPackListProduct data) : base(data)
        {
            var d = GetData;
        }

        public ViewModelPromoPackListProduct()
        {

        }
    }

}
