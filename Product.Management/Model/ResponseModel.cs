namespace Product.Management.Model
{
    public class ResponseModel<T>
    {
        public T Data { get; set; }
        public string Message { get; set; }
        public bool isSucess { get; set; }
    }
}
