const int MAX_SALES = 100;

string userInput = GetMenuChoice();
int count =  0;
double[] sales = new double[MAX_SALES];

while(userInput != "4"){
    if(userInput == "1"){
        EnterSales(sales, ref count);
    } else if(userInput == "2"){
        FindAverage(sales, count);
    } else if(userInput == "3"){
        FindMinMax(sales, count);
    } else{
        System.Console.WriteLine("Invalid input, please try again");
    }
   userInput = GetMenuChoice();
}

static string GetMenuChoice(){
    System.Console.WriteLine("1. Enter Sales\n2. Find Average\n3. Find Min & Max\n4. Exit");
    return Console.ReadLine();
}

static void EnterSales(double[] sales, ref int count){
    System.Console.WriteLine("Please enter sales (-1 to stop)");
    double sale = double.Parse(Console.ReadLine());
    while(sale > -1){
        sales[count] = sale;
        count++;

        System.Console.WriteLine("Please enter sales (-1 to stop)");
        sale = double.Parse(Console.ReadLine());
    }
}

static void FindAverage(double[] sales, int count){
    double total = 0;
    for(int i = 0; i < count; i++){
        total += sales[i];
    }
    System.Console.WriteLine($"The average sales amount is ${total/count}");
}

static void FindMinMax(double[] sales, int count){
    double min = sales[0];
    double max = sales[0];

    for(int i = 1; i < count; i++){
        if(sales[i] > max){
            max = sales[i];
        } else if(sales[i] < min){
            min = sales[i];
        }
    }
    System.Console.WriteLine($"The max is: ${max} the min is: ${min}");
}