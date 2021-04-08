namespace WindowsFormsApp1
{
    public interface IBankAccount
    {
        decimal AccountBalance { get; }
        string AccountHolder { get; set; }
        int AccountNumber { get; set; }

        event OverdrawDelegate Overdraw;

        void Deposit(decimal amount);
        void Withdrawl(decimal amount);
    }
}