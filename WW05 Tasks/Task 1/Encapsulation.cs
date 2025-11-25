class BankAccount
{
    private string accountNumber = "123456789";
    private double balance;

    //creating 2 public properties

    //only allowing get method
    public string AccountNumber
    {
        get { return this.accountNumber; }
    }

    //allowing both get and set
    public double Balance
    {
        get { return this.balance; }

        //allowing set only if the value is greater than 0 so that  value is not invalid
        set
        {
            if (value >= 0)
            {
                this.balance = value;
            }
        }
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            this.balance += amount;  // add to current balance
        }
        else
        {
            Console.WriteLine("Deposit amount must be positive!");
        }
    }


    public void Withdraw(double amount)
    {
        if (amount > 0 && amount <= this.balance)
        {
            this.balance -= amount; //subtract from existing amount
        }
        else
        {
            Console.WriteLine("Insufficient balance or invalid amount!");
        }
    }

}