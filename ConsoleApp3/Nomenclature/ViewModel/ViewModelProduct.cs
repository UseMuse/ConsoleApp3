namespace ConsoleApp3
{
//class ViewModelMain<TVMData> : IMainVM<TVMData> where TVMData : ViewModelProduct<DataModelProduct>, new()

  class ViewModelProduct<TData> : IVM<TData> where TData : DataModelProduct, new()
    {
        private TData data;
  
        /// <summary>Элемент с данными.</summary>
        public TData Data { get => data; }

        /// <summary>Получение другого элемента с данными.</summary>
        /// <param name="data">Новый элемент с данными.</param>
        public void SetData(TData data) => this.data = data;

        public TData GetData => data;

        public ViewModelProduct()
        {

        }

        public ViewModelProduct(TData data)
        {
            this.data = data;
        }
     
    }
}
