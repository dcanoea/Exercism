static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        if (balance <0){
            return 3.213f;
        }else if (balance>=
                  
                  0 && balance<1000){
            return 0.5f;
        }else if (balance >=1000 && balance<5000){
            return 1.621f;
        }else {
            return 2.475f;
        }
    }

    public static decimal Interest(decimal balance)
    {
        return ((decimal)InterestRate(balance) * balance) / 100;
    }

    public static decimal AnnualBalanceUpdate(decimal balance)
    {
        return Interest(balance) + balance;
    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        decimal totalBalance = balance;
        int count = 0;
        while (totalBalance < targetBalance){
            totalBalance = Interest(totalBalance)+totalBalance;
            count++;
        }

        return count;
    }
}
