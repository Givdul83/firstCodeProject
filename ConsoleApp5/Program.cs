// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, and welcome. this is a tool to calculate your monthly budget.");
Console.WriteLine("What´s your name?");
string name = Console.ReadLine();
Console.WriteLine("Hello" + " " + name + "," + " " + "first up, what´s your salary per month pre taxes (in SEK)?");
double salary = Convert.ToDouble(Console.ReadLine());
double yearlySalary = salary * 12;
double stateIncomeTax = 554900;
double taxdiff = yearlySalary - stateIncomeTax;
double stateTax = taxdiff * 0.2;
double churchTax = 0.01161;
double funeralTax = 0.00261;
double churchTaxPayed = yearlySalary * churchTax;
double funeralTaxPayed = yearlySalary * funeralTax;
double churchTaxShown = Math.Round(churchTaxPayed);
double funeralTaxShown = Math.Round(funeralTaxPayed);
double tax = 0.69;
double salaryPostTaxes = salary * tax;
double yearlySalaryPostTaxes;
if (yearlySalary > stateIncomeTax)
{
    yearlySalaryPostTaxes = yearlySalary * tax - stateTax;
    double salaryShown = Math.Round(yearlySalaryPostTaxes);
    Console.WriteLine("Your yearly income post taxes is" + " " + salaryShown + " SEK" + "," + " " + "you pay" + " " + stateTax + " " + " SEK in State income tax per year.");
}
else
{
    yearlySalaryPostTaxes = yearlySalary * tax;
    double salaryShown = Math.Round(yearlySalaryPostTaxes);
    Console.WriteLine("Your yearly income post taxes is" + " " + salaryShown + " SEK");
}

Console.WriteLine("Great, next question" + " , " + "what´s your living arrangement?" +
    " " + "1. Free bought house" +
    " " + "2. Condominiun" +
    " " + "3. Rental " + "");
string living = Console.ReadLine();
double baseCostLiving = 0;
double yearlyBaseCostLiving = 0;
double baseCostMonthlyShown = 0;
double baseCostYearlyShown = 0;
if (living == "1")
{
    Console.WriteLine("How big is your loan on your property (in SEK)?");
    double loan = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("What´s your intrest rate?");
    decimal interest1 = Convert.ToDecimal(Console.ReadLine());
    double interest = Convert.ToDouble(interest1);
    Console.WriteLine("How big is your monthly installment on your loan (in SEK)?");
    double installment = Convert.ToDouble(Console.ReadLine());
    double interestYear = loan * (interest / 100);
    double interestMonth = interestYear / 12;
    baseCostLiving = installment + interestMonth;
    yearlyBaseCostLiving = baseCostLiving * 12;
    baseCostMonthlyShown = Math.Round(baseCostLiving);
    baseCostYearlyShown = Math.Round(yearlyBaseCostLiving);
    Console.WriteLine("Your base cost of living is" + " " + baseCostMonthlyShown + " " + "SEK per month" + " " + "and" + " " + baseCostYearlyShown + " " + "SEK per year");


}
else if (living == "2")
{
    Console.WriteLine("How big is your loan on your property (in SEK)?");
    double loan = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("What´s your intrest rate?");
    decimal interest2 = Convert.ToDecimal(Console.ReadLine());
    double interest = Convert.ToDouble(interest2);
    Console.WriteLine("How big is your monthly installment on your loan (in SEK)?");
    double installment = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("How much is your monthly fee to the tenant-owner association (in SEK)?");
    double fee = Convert.ToDouble(Console.ReadLine());
    double interestYear = loan * (interest / 100);
    double interestMonth = interestYear / 12;
    baseCostLiving = installment + interestMonth + fee;
    yearlyBaseCostLiving = baseCostLiving * 12;
    baseCostMonthlyShown = Math.Round(baseCostLiving);
    baseCostYearlyShown = Math.Round(yearlyBaseCostLiving);

    Console.WriteLine("Your base cost of living is" + " " + baseCostMonthlyShown + " " + " SEK per month" + " " + "and" + " " + baseCostYearlyShown + " " + "SEK per year");
}
else if (living == "3")
{
    Console.WriteLine("Okay, what´s your montly rent (in SEK)?");
    double rent = Convert.ToDouble(Console.ReadLine());
    baseCostLiving = rent;
    yearlyBaseCostLiving = rent * 12;
    baseCostMonthlyShown = Math.Round(baseCostLiving);
    baseCostYearlyShown = Math.Round(yearlyBaseCostLiving);
    Console.WriteLine("Your base cost of living is" + " " + baseCostMonthlyShown + " SEK per month" + " " + "and" + " " + baseCostYearlyShown + " " + "SEK per year");
}
Console.WriteLine("Okay ,great let´s continue!");
Console.WriteLine("How much in total do you pay for electricity per month (in SEK)?");
double electricity = Convert.ToDouble(Console.ReadLine());
double yearlyElectricity = electricity * 12;
Console.WriteLine("How much do you pay in insurance fees per month (house, car, life etc (in SEK))?");
double insurance = Convert.ToDouble(Console.ReadLine());
double yearlyInsurance = insurance * 12;
Console.WriteLine("Do you have a car?(y/n)");
string car = Console.ReadLine();
if (car == "y")
{
    Console.WriteLine("The car you have, do you:" +
        " " + "1. Own it without loans" +
        " " + "2. Own it with loans" +
        " " + "3. Lease it");
}
string cardeal = Console.ReadLine();
double monthlyCarCost = 0;
double yearlyCarCost = 0;
if (cardeal == "2")
{
    Console.WriteLine("How much do you owe on your car(in SEK)?");
    double carloan = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("What´s your intrest rate on your car loan(in SEK)?");
    decimal carintrest1 = Convert.ToDecimal(Console.ReadLine());
    double carintrest = Convert.ToDouble(carintrest1);
    double totalCarIntrest = carloan * (carintrest / 100);
    Console.WriteLine("how much is your monthly installment on your car loan(in SEK)?");
    double carinstallment = Convert.ToDouble(Console.ReadLine());
    double monthlyCarIntrest = totalCarIntrest / 12;
    double yearlyCarInstallment = carinstallment * 12;
    monthlyCarCost = monthlyCarIntrest + carinstallment;
    yearlyCarCost = monthlyCarCost * 12;
    double monthlyCarShown = Math.Round(monthlyCarCost);
    double yearlyCarShown = Math.Round(yearlyCarCost);
    Console.WriteLine("Your car cost you" + " " + monthlyCarShown + " " + "SEK every month" + "," + " and" + " " + yearlyCarShown + " " + "SEK yearly");
}
if (cardeal == "3")
{
    Console.WriteLine("What´s your monthly leasing fee?");
    monthlyCarCost = Convert.ToDouble(Console.ReadLine());
    yearlyCarCost = monthlyCarCost * 12;
    Console.WriteLine("Your car cost you" + " " + yearlyCarCost + " SEK yearly");
}
Console.WriteLine("How much do you pay in cell phone plans per month(in SEK)?");
double cellPhone = Convert.ToDouble(Console.ReadLine());
double yearlyCellPhone = cellPhone * 12;
Console.WriteLine("You pay" + " " + yearlyCellPhone + " " + "SEK per year for your cell phone");
Console.WriteLine("how much do you pay for streaming services per month(in SEK)?");
double streaming = Convert.ToDouble(Console.ReadLine());
double yearlyStreaming = streaming * 12;
Console.WriteLine("Your streaming services costs you" + " " + yearlyStreaming + " " + "SEK per year");
Console.WriteLine("Are you a member of the swedish state church?(y/n)");
string church = Console.ReadLine();
double churchCost = 0;
{
    if (church == "y")
    {
        churchCost = yearlySalary * churchTax;

        Console.WriteLine("You pay" + " " + churchTaxShown + " " + "SEK yearly in taxes to the swedish state church");
    }
    if (church == "n")
    {
        churchCost = yearlySalary * funeralTax;
        Console.WriteLine("You pay" + " " + funeralTaxShown + " " + "SEK yearly in taxes for your future funeral cost"); }

}
Console.WriteLine("Do you have any other income of significance(y/n)");
string otherIncome = Console.ReadLine();
double yearlyExtraIncome = 0;
{
    if (otherIncome == "y")
    {
        Console.WriteLine("How much money do you make from your side income per month (in SEK)?");
        double extraIncome = Convert.ToDouble(Console.ReadLine());
        yearlyExtraIncome = extraIncome * 12;
        Console.WriteLine("Your other incomes gets you an extra" + " " + yearlyExtraIncome + "SEK per year.");
    }
    else if (otherIncome == "n")
    {
        yearlyExtraIncome = 0;
    }
}
double totalIncome = yearlySalaryPostTaxes + yearlyExtraIncome;
double baseOutgoing = yearlyBaseCostLiving + yearlyElectricity + yearlyInsurance + yearlyCellPhone + churchCost;
double extra = yearlyStreaming + yearlyCarCost;
double extraShown = Math.Round(extra);
double monthlyIncome = totalIncome / 12;
double monthlyBaseOut = baseOutgoing / 12;
double monthlyExtra = extra / 12;
double monthlyExtraShown = Math.Round(monthlyExtra);
double incomeShown = Math.Round(totalIncome);
double baseShown = Math.Round(baseOutgoing);
double monthlyIncomeShown = Math.Round(monthlyIncome);
double monthlyBaseOutShown = Math.Round(monthlyBaseOut);
double yearlyBudget = totalIncome - baseOutgoing - extra;
double yearlyBudgetShown = Math.Round(yearlyBudget);
double monthlyBudget = yearlyBudget / 12;
double monthlyBudgetShown = Math.Round(monthlyBudget);
double trouble = baseOutgoing + extra - totalIncome;
double troubleShown = Math.Round(trouble);
double monthlyTrouble = trouble / 12;
double monthlyTroubleShown = Math.Round(monthlyTrouble);
double breakPoint = 0;
double goodBreakPoint = 100000;
Console.WriteLine("Your total yearly income after taxes payed is" + " " + incomeShown + " SEK" + "." + " " + "That equals" + " " + monthlyIncomeShown +" SEK per month");
Console.WriteLine("Your total neccesary expenses are" + " " + baseShown + " SEK per year. That makes your neccesary expenses per month" + " " + monthlyBaseOutShown +" SEK");
Console.WriteLine("Your perhaps not neccesary expenses are" + " " + extraShown + " SEK per year" + "." + " " + "That equals" + " " + monthlyExtraShown + " SEK per month");
if (yearlyBudget >= goodBreakPoint)
{
    Console.WriteLine("Congrats, you have a sorted economy" + "." + " " + "You have" + " " + yearlyBudgetShown + " SEK left after your fixed expenses every year");
    Console.WriteLine("This gives you a budget of" + " " + monthlyBudgetShown + " SEK to do with as you will!");
}
if ((goodBreakPoint > yearlyBudget) && (yearlyBudget > breakPoint)) 
{ 
    Console.WriteLine("You have an decent economy, however you don´t have big margins. You have" + " " + yearlyBudgetShown + " SEK left after your fixed expenses every year");
    Console.WriteLine("This give gives you a budget of" + " " + monthlyBudgetShown + "SEK to spend every month. Perhaps it´s time to cut some expenses or get a little bit of side income?");
}
if ( breakPoint > yearlyBudget)
    {
    Console.WriteLine("This is not good" + "," + " " + "you lose" + " " + troubleShown + " SEK per year");
            Console.WriteLine("That equals" + " " + monthlyTroubleShown + " SEK per month" + "." + "Time for you to get your economy in order!"); }
Console.WriteLine("Thank you for testning this progamme, have a great day");
