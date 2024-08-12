// See https://aka.ms/new-console-template for more information
Random dice = new Random();
int roll1 = dice.Next(3, 17);
int roll2 = dice.Next(10, 27);
int roll3 = dice.Next(15, 70);
string message = "The quick brown fox jumps over the lazy dog.";

string[] fraudulentOrderIDs = [ "A123", "B456","C789","B450","B356" ];
int[] inventory = [ 200, 450, 700, 175, 250 ];
int sumOfItems = 0;
int shelf = 0;
string[] numberPlates = ["B123","C234","A345","C151","B177", "G303", "C235", "B179"];
string[] orderIDs = new string[5];
int currentAssignments = 5;

int[] sophiaScores = new int[] { 50, 76, 87, 48, 55, 64, 50 };
int[] andrewScores = new int[] { 62, 55, 80, 60, 50, 89 };
int[] emmaScores = new int[] { 40, 55, 87, 48, 68, 59, 49, 89 };
int[] loganScores = new int[] { 50, 55, 87, 88, 76, 26 };
int[] beckyScores = new int[] { 62, 71, 40, 51, 72, 92, 59 };
int[] chrisScores = new int[] { 84, 86, 58, 60, 72, 54, 66, 78 };
int[] ericScores = new int[] { 80, 90, 40, 50, 59, 80, 70, 20 };
int[] gregorScores = new int[] { 71, 81, 41, 71, 91, 69, 31 };    

// Student names
string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };

// Student scores
int[] studentScores = new int[10];
string currentStudentLetterGrade = "";
int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    Console.WriteLine("You rolled doubles! +2 bonus to total!");
    total += 2;
}

if ((roll1 == roll2) && (roll2 == roll3)) 
{
    Console.WriteLine("You rolled triples! +6 bonus to total!");
    total += 6;
}

if (total >= 15)
{
    Console.WriteLine("You win!");
}

if (total < 15)
{
    Console.WriteLine("Sorry, you lose.");
}

bool result = message.Contains("dog");
Console.WriteLine(result);

if (message.Contains("fox"))
{
    Console.WriteLine("What does the fox say?\n");
}

Console.WriteLine(fraudulentOrderIDs[3]);

foreach (string names in fraudulentOrderIDs)
{
    Console.WriteLine(names);    
}

foreach (int items in inventory)
{
    sumOfItems +=items;
    shelf++;
    Console.WriteLine($"Shelf {shelf} = {items} items, (Running Total: {sumOfItems})");
}

Console.WriteLine($"We have {sumOfItems} items in inventory.\n");

foreach (string plates in numberPlates)
{
    if(plates.StartsWith("B")){
        Console.WriteLine(plates);
    }
}

/*
  The following code creates five random OrderIDs
  to test the fraud detection process.  OrderIDs 
  consist of a letter from A to E, and a three
  digit number. Ex. A123.
*/

for (int i = 0; i < orderIDs.Length; i++)
{
    int prefixValue = dice.Next(65, 70);
    string prefix = Convert.ToChar(prefixValue).ToString();
    string suffix = dice.Next(1, 1000).ToString("000");
    orderIDs[i] = prefix + suffix;
        
}

foreach (var orderID in orderIDs)
{
    Console.WriteLine(orderID);
}

/*
   This code reverses a message, counts the number of times 
   a particular character appears, then prints the results
   to the console window.
*/

char[] info = message.ToCharArray();
Array.Reverse(info);

int letterCount = 0;

foreach (char letter in info)
{
    if (letter == 'o')
    {
        letterCount++;
    }
}

string newMessage = new String(info);

Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {letterCount} times.");

//Learners Grade
Console.WriteLine("Student\t\tExam Score\tOvaral Grade\t Extra Credits\n");

foreach (string studentName in studentNames)
{
    string currentStudent = studentName;

    if (currentStudent == "Sophia")
        studentScores = sophiaScores;

    else if (currentStudent == "Andrew")
        studentScores = andrewScores;

    else if (currentStudent == "Emma")
        studentScores = emmaScores;

    else if (currentStudent == "Logan")
        studentScores = loganScores;

    else if (currentStudent == "Becky")
    studentScores = beckyScores;

    else if (currentStudent == "Chris")
        studentScores = chrisScores;

    else if (currentStudent == "Eric")
        studentScores = ericScores;

    else if (currentStudent == "Gregor")
        studentScores = gregorScores;

    else
        continue;

    // initialize/reset the sum of scored assignments
    int sumAssignmentScores = 0;

    // initialize/reset the calculated average of exam + extra credit scores
    decimal currentStudentGrade = 0;

    foreach (int score in studentScores)
    {
        // add the exam score to the sum
        sumAssignmentScores += score;
    }

    currentStudentGrade = (decimal)(sumAssignmentScores) / currentAssignments;

    if (currentStudentGrade >= 97)
        currentStudentLetterGrade = "A+";

    else if (currentStudentGrade >= 93)
        currentStudentLetterGrade = "A";

    else if (currentStudentGrade >= 90)
        currentStudentLetterGrade = "A-";

    else if (currentStudentGrade >= 87)
        currentStudentLetterGrade = "B+";

    else if (currentStudentGrade >= 83)
        currentStudentLetterGrade = "B";

    else if (currentStudentGrade >= 80)
        currentStudentLetterGrade = "B-";

    else if (currentStudentGrade >= 77)
        currentStudentLetterGrade = "C+";

    else if (currentStudentGrade >= 73)
        currentStudentLetterGrade = "C";

    else if (currentStudentGrade >= 70)
        currentStudentLetterGrade = "C-";

    else if (currentStudentGrade >= 67)
        currentStudentLetterGrade = "D+";

    else if (currentStudentGrade >= 63)
        currentStudentLetterGrade = "D";

    else if (currentStudentGrade >= 60)
        currentStudentLetterGrade = "D-";
    else
        currentStudentLetterGrade = "F";
    Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");
}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();