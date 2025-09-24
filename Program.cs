// Define the fees and rates as constants so they can't be changed by accident.
const double ADULT_TICKET_PRICE = 15.00;
const double CHILD_DISCOUNT = 0.25;
const double HIGH_OCCUPANCY_STATE_TAX = 6.00;
const double FEDERAL_TAX_RATE = 0.07;

// Surcharges for different vehicle types.
const double RV_SURCHARGE = 35.00;
const double OTHER_VEHICLE_SURCHARGE = 12.00;

// Entry point: Call Main
Main(args);

// Main method
static void Main(string[] args)
{
    RunMenu();
}

// Method definitions
static void RunMenu()
{
    while (true)
    {
        Console.Clear(); // Clear console before showing the menu
        string userInput = DisplayMenu();
        
        if (userInput.Equals("Compass", StringComparison.OrdinalIgnoreCase))
        {
            Console.Clear(); // Clear console before Compass action
            Console.WriteLine("Welcome to the Compass.");
            Compass();
        }
        else if (userInput.Equals("Park Fees", StringComparison.OrdinalIgnoreCase))
        {
            Console.Clear(); // Clear console before Park Fees action
            Console.WriteLine("Welcome to Park Fees.");
            VisitorFees();
        }
        else if (userInput.Equals("Exit", StringComparison.OrdinalIgnoreCase))
        {
            Console.Clear(); // Clear console before Exit prompt
            while (true)
            {
                Console.Write("Are you sure you want to Exit? (y/n): ");
                string input = Console.ReadLine()?.ToLower() ?? "";
                
                if (input.Length == 1 && (input == "y" || input == "n"))
                {
                    char confirmExit = input[0];
                    if (confirmExit == 'y')
                    {
                        Console.Clear();
                        Console.WriteLine("Exiting the application. Thanks for visiting!");
                        return;
                    }
                    else // confirmExit == 'n'
                    {
                        Console.WriteLine("Exit cancelled. Going back to the main menu.");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid choice, please enter 'y' or 'n'.");
                }
            }
        }
        else
        {
            Console.Clear(); // Clear console before showing error
            Console.WriteLine("Invalid option, please enter 'Compass', 'Park Fees', or 'Exit'.");
            Console.WriteLine("Press any key to try again...");
            Console.ReadKey();
        }
    }
}

static string DisplayMenu()
{
    Console.WriteLine(
        @"
                                                ZWX                            ZWTXZZ               
                                               XJIT                          ZTKHHHILTYZ            
                                               KHHLVZ                     ZXNHHHHHHHHHRZ            
                                               KHHHHIRXZZ             ZZVNHHHHHHHHHHHR              
                                               XGHHHHHHHHGGIKLMMLLKIGGHHHHHHHHHHHHHHP               
                                               ZWKHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHMZ               
                                                  YQKIIHHHHHHHHHHHHHHHHHHHHHHHHHHHIWZ               
                                                          ZYXWVURPKHHHHHHHHHHHHHHHSZ                
                                                               ZYOHHHHHHHHHHHHHHHOY                 
                                                              ZVKHHHHHHHJIHHHHHHJU                  
                                                             ZRHHHHHHHJTRHHHHHHHOZ                  
                                                            XMHHHHHHHOZWJHHHHHHKV                   
                                                          ZUJHHHHHHKW ZQHHHHHHHOZ                   
                                                         ZQIHHHHHHNXZ XIHHHHHHJW                    
                                                        XOHHHHHHHQZ   QHHHHHHHNZ                    
                                                      ZXLHHHHHHISZ   ZIHHHHHHIW                     
                                                      UIHHHHHHITZ    RHHHHHHHKZ                     
                                                     QHHHHHHHGV     ZIHHHHHHHV                      
                                                   ZNHHHHHHHGV      SHHHHHHHIZ                      
                                         ZZ       YMHHHHHHHGVZ      KHHHHHHHSZ                      
                                       YOIS      WLHHHHHHHHUZ      TIHHHHHHGWXXXYZ                  
                                      WHHIS    ZWJHHHHHHHJU        MHHHHHHHHHHHHHHIUZ               
                                     YHHHHMW   XIHHHHHHHHHLUTPKHFGHHHHHHHHHHHHHHHHHHHHU               
                                     VHHHHHHJPPHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHQ               
                                     YGHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHGU               
                                      RHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHJMRRLHHHPZ               
                                       VJHHHHHHHHHHHHHHHGHJKLKKOTTLHHHHHHHNY   ZRLVZ                
                                        ZZVLHHHHHHHHOVXZZZ       TJHHHHHHHQZ   ZZ                   
                                        ZYPHHHHHHHHPY            RIHHHHHHHRZ                        
                                        YQHHHHHHHHOY             QHHHHHHHHSZ                        
           ZZYZ                        ZQHHHHHHHHMY              QHHHHHHHHTZ                        
         ZYQJHS                       ZPHHHHHHHHLY              ZPHHHHHHHIT                         
        ZVKHHOY                      ZNHHHHHHHHMZ               XNHHHHHHHJU                         
        YJHHHTZ                     XLHHHHHHHHPZ                WMHHHHHHHIT                         
        RHHHHOY                   ZUKHHHHHHHGS                  WMHHHHHHHITZ                        
        PHHHHIU                  YQIHHHHHHHJVZ                  YOHHHHHHHHSZ                        
        SHHHHHHR               ZTJHHHHHHHHNY                    ZQHHHHHHHHQZ                        
        YJHHHHHHLVZ          YRJHHHHHHHHJTZ                      QHHHHHHHHIUZZZ     YUMJQZ          
        ZVHHHHHHHHJNTWYYYWSMIHHHHHHHHHHPZ                        YMHHHHHHHHHIKLMLKJIHHHJTZ          
         ZVKHHHHHHHHHHHHHHHHHHHHHHHHHPZ                           TJHHHHHHHHHHHHHHHHHHISZ           
           ZOHHHHHHHHHHHHHHHHHHHHHIRZ                              VIHHHHHHHHHHHHHHHHKWUXZ          
             ZTIHHHHHHHHHHHHHHHHQY                                   PHHHHHHHHHHHHLUZZUUVY          
                ZYTPLJJJJKMQVZZ                                        ZUQNNOQUYZ                   
    ");
    Console.WriteLine("\n____________________");
    Console.WriteLine("Welcome to the Menu!");
    Console.WriteLine("____________________");
    Console.WriteLine("Enter one of the following: Compass, Park Fees, Exit.");
    return Console.ReadLine() ?? "";
}

static void Compass()
{
    // Calculates the final direction based on a series of turns from a starting point of North.
    Console.WriteLine("\n--- Compass ---");
    int direction = 0; // 0 = North, 1 = East, 2 = South, 3 = West. We start at North.

    try
    {
        Console.Write("Enter the number of right turns you've made: ");
        int rightTurns = int.Parse(Console.ReadLine());

        Console.Write("Enter the number of left turns you've made: ");
        int leftTurns = int.Parse(Console.ReadLine());

        int netTurns = rightTurns - leftTurns;
        int finalDirectionIndex = (direction + netTurns % 4 + 4) % 4;

        string[] directions = { "North", "East", "South", "West" };
        string finalDirection = directions[finalDirectionIndex];

        Console.WriteLine($"\nBased on your turns, you are now facing: {finalDirection}");
    }
    catch (FormatException)
    {
        Console.WriteLine("Invalid input. Please enter a whole number for your turns.");
    }

    Console.WriteLine("\nPress any key to return to the main menu...");
    Console.ReadKey();
    Console.Clear(); // Clear console before returning to the main menu
}

static void VisitorFees()
{
    // Calculates the total visitor fees with taxes and discounts.
    Console.WriteLine("\n--- Visitor Fees ---");
    
    // Defining a child as anyone under 18.
    const int CHILD_AGE_LIMIT = 18;

    try
    {
        Console.Write("Are you driving an RV? (y/n): ");
        string vehicleType = Console.ReadLine()?.ToLower();
        while (vehicleType != "y" && vehicleType != "n")
        {
            Console.WriteLine("Invalid choice, please enter 'y' or 'n'.");
            Console.Write("Are you driving an RV? (y/n): ");
            vehicleType = Console.ReadLine()?.ToLower();
        }
        double vehicleSurcharge = (vehicleType == "y") ? RV_SURCHARGE : OTHER_VEHICLE_SURCHARGE;

        Console.Write("How many people are in your party? ");
        int numAttendees = int.Parse(Console.ReadLine());

        int childCount = 0;
        for (int i = 0; i < numAttendees; i++)
        {
            Console.Write($"What is the age of attendee #{i + 1}? ");
            int age = int.Parse(Console.ReadLine());
            if (age < CHILD_AGE_LIMIT)
            {
                childCount++;
            }
        }
        
        int adultCount = numAttendees - childCount;
        double adultCost = adultCount * ADULT_TICKET_PRICE;
        double childCost = childCount * (ADULT_TICKET_PRICE * (1 - CHILD_DISCOUNT));

        double subtotal = adultCost + childCost + vehicleSurcharge;
        double stateTax = (numAttendees >= 6) ? HIGH_OCCUPANCY_STATE_TAX : 0.0;
        double federalTaxBase = adultCost + childCost + vehicleSurcharge;
        double federalTax = federalTaxBase * FEDERAL_TAX_RATE;
        double totalDue = subtotal + stateTax + federalTax;

        Console.WriteLine($"\nSubtotal: {subtotal:C2}");
        Console.WriteLine($"State Tax: {stateTax:C2}");
        Console.WriteLine($"Federal Tax: {federalTax:C2}");
        Console.WriteLine($"Total Amount Due: {totalDue:C2}");

        double amountPaid = 0.0;
        while (amountPaid < totalDue)
        {
            Console.Write($"You have paid {amountPaid:C2}. Please enter the amount you are paying now: ");
            string paymentInput = Console.ReadLine();
            try
            {
                double newPayment = double.Parse(paymentInput);
                amountPaid += newPayment;

                if (amountPaid < totalDue)
                {
                    Console.WriteLine($"Oops! The amount paid ({amountPaid:C2}) is less than the total due ({totalDue:C2}). Please add more.");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter a valid number for payment.");
            }
        }
        
        double change = amountPaid - totalDue;
        Console.WriteLine($"\nPayment successful! Total paid: {amountPaid:C2}");
        Console.WriteLine($"Your change is: {change:C2}");
    }
    catch (FormatException)
    {
        Console.WriteLine("Invalid input. Please enter valid numbers for ages and attendees.");
    }

    Console.WriteLine("\nPress any key to return to the main menu...");
    Console.ReadKey();
    Console.Clear(); // Clear console before returning to the main menu
}