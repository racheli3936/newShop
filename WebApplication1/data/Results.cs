namespace WebApplication1.data
{
    public class Results<T>
    {
        public int Code { get; set; }
        public T Data { get; set; }
        public string msg {  get; set; }
    }
}
