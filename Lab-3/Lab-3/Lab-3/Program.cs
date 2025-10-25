#region Task 1

// using Lab_3.Task1;
//
// Console.WriteLine("Nece film elave etmek isteyirsiz?");
// int len = Int32.Parse(Console.ReadLine());
// ActionMovie[] students = new ActionMovie[len];
// for (int i = 0; i < len; i++)
// {
//     Console.WriteLine("Yeni action movie ni elave edin");
//     Console.WriteLine("Filmin adi: ");
//     string title = Console.ReadLine();
//     Console.WriteLine("Filmin produseri : ");
//     string director = Console.ReadLine();
//     Console.WriteLine("Filmin uzunlugunu daxil edin: ");
//     int duration = Int32.Parse(Console.ReadLine());
//     students[i] = new ActionMovie(title, director, duration, 0);
// }
//
// while (true)
// {
//     Console.WriteLine("Ne elemek isteyirsiz? ");
//     Console.WriteLine("""
//                       1.Filmləri müddətə görə filterle
//                       2.Bütün filmləri göstər
//                       0. Proqramı bağla
//                       """);
//     int choice = Int32.Parse(Console.ReadLine());
//     switch (choice)
//     {
//         case 1:
//             for (int i = 0; i < students.Length; i++)
//             {
//                 for (int j = 1; j < students.Length - 1; j++)
//                 {
//                     int max = students[i].Duration;
//                     if (students[j].Duration > max)
//                     {
//                         students[i] = students[j];
//                     }
//                 }
//             }
//
//             foreach (var a in students)
//             {
//                 Console.WriteLine(
//                     $"Filmin adi : {a.Title}, Filmin Directoru : {a.Director}, Filmin Duration : {a.Duration}");
//             }
//
//             break;
//         case 2:
//             foreach (var a in students)
//             {
//                 Console.WriteLine(
//                     $"Filmin adi : {a.Title}, Filmin Directoru : {a.Director}, Filmin Duration : {a.Duration}");
//             }
//
//             break;
//         case 0:
//             return;
//         default:
//             Console.WriteLine("Xais olunur duzgun daxil edersiniz");
//             break;
//     }
// }

#endregion


#region Task 2

using Lab_3.Task2;

Console.WriteLine("Nece Student elave etmek isteyirsiz?");
int stuCount = Int32.Parse(Console.ReadLine());
GraduateStudent[] students = new GraduateStudent[stuCount];

for (int i = 0; i < stuCount; i++)
{
    Console.WriteLine("Studentin datasini daxil edin: ");
    Console.WriteLine("Studentin adi: ");
    string name = Console.ReadLine();
    Console.WriteLine("Studentin soyadi: ");
    string surname = Console.ReadLine();

    GraduateStudent student = new(name, surname, "title");
    students[i] = student;
}

while (true)
{
    Console.WriteLine("Ne elemek isteyirsiz? ");
    Console.WriteLine("""
                      1.GPA-yə gore filterle   
                      2.Butun studentləri goster
                      3. Studentin GPA ni update ele
                      0. Proqramı bağla
                      """);
    int choice = Int32.Parse(Console.ReadLine());
    switch (choice)
    {
        case 1:
            for (int i = 0; i < students.Length; i++)
            {
                for (int j = 1; j < students.Length - 1; j++)
                {
                    int max = students[i].Gpa;
                    if (students[j].Gpa > max)
                    {
                        students[i] = students[j];
                    }
                }
            }

            break;
        case 2:
            foreach (var graduateStudent in students)
            {
                graduateStudent.Details();
            }

            break;
        case 3:
            Console.WriteLine("Hansi studenti update edek? (Reqem secin)");
            int counter = 1;
            foreach (var graduateStudent in students)
            {
                Console.WriteLine(
                    $"{counter}) student's name: {graduateStudent.Name}, student's surname: {graduateStudent.Surname}, student's GPA : {graduateStudent.Gpa}");
                counter++;
            }

            var chosenStudent = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Yeni gpa nece olsun? ");
            int newGpa = Int32.Parse(Console.ReadLine());
            students[chosenStudent - 1].UpdateGpa(newGpa);
            Console.WriteLine("Ugurla yenilendi");
            break;
        case 0:
            Console.WriteLine("Proqram bitdi");
            break;
        default:
            Console.WriteLine("Duzgun secim edin");
            break;
    }
}

#endregion