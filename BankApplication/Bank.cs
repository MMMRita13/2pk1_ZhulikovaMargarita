namespace BankApplication
{
    internal class Bank<T>
    {
        private string v;

        public Bank(string v)
        {
            this.v = v;
        }

        internal void CalculatePercentage()
        {
            throw new NotImplementedException();
        }
    }
}