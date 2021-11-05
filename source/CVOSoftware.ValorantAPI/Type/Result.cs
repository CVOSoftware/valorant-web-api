namespace CVOSoftware.ValorantAPI.Type
{
    public class Result<T>
    {
        internal Result()
        {
            Status = false;
        }

        internal Result(T value)
        {
            Status = true;
            Value = value;
        }

        public bool Status { get; }

        public T Value { get; }
    }
}