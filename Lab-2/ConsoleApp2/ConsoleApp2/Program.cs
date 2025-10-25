#region ATM

// Console.Write("Mebleg daxil edin: ");
// var amount = int.Parse(Console.ReadLine()!);
//
//
// int hundreds = amount / 100; //2
// amount %= 100; //75
//
// int fifties = amount / 50; //1
// amount %= 50; //25
//
// int twenties = amount / 20;
// amount %= 20;
//
// int tens = amount / 10;
// amount %= 10;
//
// int fives = amount / 5;
// amount %= 5;
// int ones = amount / 1;
//
// Console.WriteLine("\nPul bolunmesi :");
// if (hundreds > 0) Console.WriteLine($"100 AZN: {hundreds} eded");
// if (fifties > 0) Console.WriteLine($"50 AZN: {fifties} eded");
// if (twenties > 0) Console.WriteLine($"20 AZN: {twenties} eded");
// if (tens > 0) Console.WriteLine($"10 AZN: {tens} eded");
// if (fives > 0) Console.WriteLine($"5 AZN: {fives} eded");
// if(ones > 0) Console.WriteLine($"1 azn  : {ones} erded");
//
// Console.WriteLine(amount > 0
//     ? $"\nQalıq {amount} AZN verilmədi (5 AZN-likdən kiçik nominal yoxdur)."
//     : "\nPul tam şəkildə verildi ");
//     
//     

#endregion

#region Password checker

// Console.Write("Sifreni daxil et: ");
// string password = Console.ReadLine();
//
// bool hasUpper = false;
// bool hasLower = false;
// bool hasDigit = false;
// bool hasSpecial = false;

// if (!string.IsNullOrEmpty(password) && password.Length >= 8)
// {
//     foreach (char c in password)
//     {
//         if (char.IsUpper(c)) hasUpper = true;
//         else if (char.IsLower(c)) hasLower = true;
//         else if (char.IsDigit(c)) hasDigit = true;
//         else hasSpecial = true;
//     }
//
//     if (hasUpper && hasLower && hasDigit && hasSpecial)
//     {
//         Console.WriteLine("Success ");
//         return;
//     }
// }

// Console.WriteLine("Invalid password");

#endregion

#region Longest Word

//
// string sentence = Console.ReadLine();
// var words = sentence.Split(' ');
//
// var maxLen = 0;
// var maxWord = string.Empty; // " "
// foreach (var word in words)
// {
//     if (word.Length > maxLen)
//     {
//         maxLen = word.Length;
//         maxWord = word;
//     }
// }
//
// Console.WriteLine($"The longest word is: {maxWord}, it's size is: {maxLen}");

#endregion


#region Currency Converter

//
// Console.WriteLine("Enter the amount of money you want to convert:");
// var amount = int.Parse(Console.ReadLine()!);
// var usd = amount / 1.7;
// var eur = amount / 1.9;
// var tr =  amount * 25;
// Console.WriteLine($"In USD: {usd}");
// Console.WriteLine($"In EUR: {eur}");
// Console.WriteLine($"In TRY: {tr}");

#endregion

//
// #region Tempreature
//
// int[] dailyTemps = [20, 21, 23, 45, 68, 65, 43];
// int sum = 0;
// int average = 0;
// for (int i = 0; i < dailyTemps.Length; i++)
// {
//     sum += dailyTemps[i];
// }
//
// average = sum / dailyTemps.Length;
// int max = dailyTemps[0];
// int min = dailyTemps[0];
//
// for (int i = 0; i < dailyTemps.Length; i++)
// {
//     if (t > max)
//         max = t;
//     if (t < min)
//         min = t;
// }
//
// Console.WriteLine(max);
// Console.WriteLine(min);
// Console.WriteLine(average);
//
// #endregion

#region BakuBus

// int age = 12;
// bool isStudent = true;
// var price = 0.6;
//
// if(age <= 6) Console.WriteLine("Gedis pulsuzdur");
//
// if (isStudent || (age > 6 && age < 18))
// {
//     price *= 0.5;
//     Console.WriteLine($"total price: {price}");
//     return;
// }
// if(age > 60)
// {
//     price = price * 0.7;
//     Console.WriteLine($"total price: {price}");
// }

#endregion


// var enterTime = 9;
// var exitTime = 12;
// var hourlyFee = 2;
// var stayTime = exitTime - enterTime;
// Console.WriteLine(hourlyFee * stayTime);


#region word counter

// string input = Console.ReadLine().ToLower();//AAA => aaa
//
// string[] words = input.Split(' ');//salam salam => [salam, salam]
//
// for (int i = 0; i < words.Length; i++)
// {
//     if (words[i] == "") continue;
//
//     int count = 1;
//     for (int j = i + 1; j < words.Length; j++)
//     {
//         if (words[i] == words[j])
//         {
//             count++;
//             words[j] = "";
//         }
//     }
//
//     Console.WriteLine($"{words[i]} = {count}");
// }

#endregion


#region Guess the number

// Random rand = new Random();
// int secret = rand.Next(1, 101); // random number 1–100
// int guess = 0;
// int attempts = 0;
//
// Console.WriteLine("Find the number between 1 and 100");
//
//
// while (guess != secret)
// {
//     Console.WriteLine("Guess the number: ");
//     guess = int.Parse(Console.ReadLine());
//     attempts++;
//
//     if (guess < secret)
//         Console.WriteLine("Too small");
//     else if (guess > secret)
//         Console.WriteLine("Too big");
//     else
//         Console.WriteLine($"You found it in {guess} guesses");
// }
//

#endregion

#region Time Printer

// for (int i = 0; i <= 23; i++)
// {
//     for (int j = 0; j <= 59; j++)
//     {
//         if (j >= 0 && j <= 9)
//         {
//             if (i >= 0 && i <= 9)
//             {
//                 Console.WriteLine($"0{i} : 0{j}");
//             }
//             else
//             {
//                 Console.WriteLine($"{i} : 0{j}");
//             }
//         }
//         else
//         {
//             if (i >= 0 && i <= 9)
//             {
//                 Console.WriteLine($"0{i} : {j}");
//             }
//             else
//             {
//                 Console.WriteLine($"{i} : {j}");
//             }
//         }
//     }
// }

#endregion

Console.WriteLine(FindProduct(3));
return;

static double FindProduct(int n)
{
    double result = 1;
    var i = 1;
    var k = 1;

    while (i <= n)
    {
        result *= 1 + k * (1.0 / (i * i));
        // result *= 1 +  (1.0 / (i * i)) * k ;
        k *= -1;
        i++;
    }

    return result;
}