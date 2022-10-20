class SweetandSalty{

    //runs the app
    public void run(){
        Console.WriteLine("Please seperately enter a pair of numbers at most 1000 numbers apart.");
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());

        int diff = num2 - num1;
        //checks if there is more than 1000 numbers between the two
        bool check = false;
        //checks if numbers were given in wrong order
        bool check2 = false;
        if(diff > 1000){
            check = true;
        }
        if (num1 > num2){
            check2 = true;
        }
        while(check2 == true){
            check2 = false;
            Console.WriteLine("You entered the numbers in the wrong order, please enter the smallest number first");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            if (num1 > num2){
                check2 = true;
            }else{
                check2 = false;
            }
        }
        while(check == true){
            check = false;
            Console.WriteLine("There are more than 1000 digits between the two numberes, please enter two numbers with 1000 or less digits between them.");
            num1 = int.Parse(Console.ReadLine());
            num2 = int.Parse(Console.ReadLine());
            diff = num2 - num1;
            if(diff > 1000){
                check = true;
            }
        }
        Console.WriteLine("How many numbers should be printed per line?");
        int num3 = int.Parse(Console.ReadLine());
        //checks that number is not less than 5 or greater than 30
        bool check3 = false;
        if (num3 > 30){
            check3 = true;
        }
        if (num3 < 5){
            check3 = true;
        }
        while(check3 == true){
            check3 = false;
            Console.WriteLine("The amount should be less than 30 and greater than 5, please pick again.");
            num3 = int.Parse(Console.ReadLine());
            if (num3 > 30){
                check3 = true;
            }
            if (num3 < 5){
                check3 = true;
            }
        }
        Generate(num1, num2, num3);
    }
    
    //generates numbers
    public void Generate(int num, int num2, int num3){
        int countSweetnSalty = 0;
        int countSweet = 0;
        int countSalty = 0;
        for(int i = num; i <= num2; i++){
            bool next = false;
            int count = 0;
            //prints specified amount per line with replacements
            while( next == false){
                if(i <= num2){
                    if (i % 3 == 0 && i % 5 == 0){
                        Console.Write("Sweet'nSalty, ");
                        countSweetnSalty = countSweetnSalty + 1;
                    }
                    else if (i % 3 == 0){
                        Console.Write("Sweet, ");
                        countSweet = countSweet + 1;
                    }else if (i % 5 == 0){
                        Console.Write("Salty, ");
                        countSalty = countSalty + 1;
                    }else{
                        Console.Write(i + ", ");
                    }
                    //checks num per line
                    count = count + 1;
                    i = i + 1;
                    if (count == num3){
                        next = true;
                    }
                }else{
                    break;
                }
            }
            Console.WriteLine();
        }
        Console.WriteLine("Number of SweetnSalty nums: " + countSweetnSalty);
        Console.WriteLine("Number of Sweet nums: " + countSweet);
        Console.WriteLine("Number of Salty nums: " + countSalty);
    }
}
