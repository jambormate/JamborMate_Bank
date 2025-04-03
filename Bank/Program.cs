namespace Bank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Owner owner = new Owner { Name = "Valaki Ember Jr." };

            Bank bank = new Bank(1);

            BankAccount savingsAccount = bank.NewAccount(owner, 0);
            BankAccount creditAccount = bank.NewAccount(owner, 1000);
            Console.WriteLine($"SavingsAccount jelenlegi egyenlege: {savingsAccount.Balance}");
            Console.WriteLine($"CreditAccount jelenlegi egyenlege: {creditAccount.Balance}");

            savingsAccount.Deposit(500);
            Console.WriteLine($"SavingsAccount pénz hozzáadása után: {savingsAccount.Balance}");

            savingsAccount.Withdraw(200);
            Console.WriteLine($"SavingsAccount pénz kivevése után: {savingsAccount.Balance}");

            creditAccount.Deposit(1000);
            Console.WriteLine($"CreditAccount pénz hozzáadása után: {creditAccount.Balance}");
        } 
    }
}
    
