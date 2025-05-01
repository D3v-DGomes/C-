/*
Project Overview
You are developing a student assessment application that automates the calculation of grades 
for each student in a class. The parameters for your application are:

- Create a C# console application.
- Start with four students. Each student has five exam scores.
- Each exam score is an integer value, 0-100, where 100 represents 100% accuracy.
- A student's overall exam score is the average of their five exam scores.
- Criteria for assigning extra credits:
        - Include extra credit scores in the student's score matrix.
        - Extra credit scores are worth 10% of an exam grade (when calculating the final numerical grade).
        - Add extra credit scores to the student's total exam score before calculating the final numerical
        grade.

- Your application must automatically assign letter grades based on the final calculated score 
for each student.
- Your application must output/display each student's name and formatted grade.
- Your application must support the addition of additional students and scores with minimal impact to code.


You have already completed an initial version of the application. The initial code project for this
guided project module includes a Program.cs file that provides the following code resources:

- The code declares the variables used to set the student names and individual exam scores for each student.
- The code includes the variables and algorithms used to sum the exam scores and calculate the average
exam grade for each student.
- The code includes a hard-coded letter grade that the developer must apply manually.
- The code includes Console.WriteLine() statements to display the student's evaluation report.

Your goal is to update the existing code to include the following features:

- Use arrays to store student names and assignment scores.
- Use a foreach statement to iterate over the student names as an outer loop of the program.
- Use an if statement inside the outer loop to identify the current student's name and access that student's
assignment scores.
- Use a foreach statement inside the outer loop to iterate through the array of assignment scores and 
sum the values.
- Use an updated algorithm inside the outer loop to calculate the average exam score for each student.
- Use an if-elseif-else construct inside the outer loop to evaluate the average exam score and 
automatically assign a letter grade.
- Integrate extra credit scores when calculating the student's final score and grade as follows:
        - Your code should detect extra credit assignments based on the number of elements in the student's 
        score array.
        - Your code should apply the 10% weighting factor to the extra credit assignments before adding
        extra credit scores to the sum of the exam scores.


PART II:

In this exercise, you will add a string array to store student names, and then implement a nested foreach
structure that iterates through student names in an outer loop and student scores in the inner loop. 
You will start by constructing the studentNames array and a foreach loop that iterates through the 
elements of the array. Next, you will move the code used to calculate Sophia's grades into the "names" 
loop code block. Finally, you will implement the code logic that uses the student's name to access her 
scores array, calculate her average score, and write her grade to the console. The detailed tasks you 
will complete during this exercise are:

- Create names array: Create an array of student names.
- Create outer loop: Create a foreach loop that iterates through student names.
- Develop outer loop code block: Relocate the code that calculates and reports Sophia's score, 
placing it in the "names" loop code block.
- Update calculations and reporting: Update the code that performs student score calculations using
a new array of scores.


PART III:

In this task, you will update the code that performs student score calculations using a new array 
of scores. You will start by creating an array called studentScores that can be used to hold any 
student's scores. Next, you will create an if .. elseif construct that uses the current student's 
name to assign your array of scores to studentScores. Finally, you will update the code that calculates 
and reports student grades. When you are finished, the report should include the name and numeric score 
for all students.


PART IV:

In this exercise, you will develop code that automatically assigns a student a letter grade based on 
their final numeric score, and you will update the application so that extra credit project scores are 
factored into the student's final grade. You will begin by writing an if-elseif-else construct that can 
be used to evaluate the student's numeric score and assign the letter grade. You will then examine the 
application requirements related to extra credit work, and then walk through the necessary code updates. 
The detailed tasks that you will complete during this exercise are:

- Develop an if-elseif-else construct that evaluates the student's score to assign a letter grade. 
The evaluated expression compares the student's numeric score to a range of scores taken from a grade 
board provided by the teacher.
- Integrate extra credit scores into each student's scores array, and then update the code used to 
calculate the student's numeric score. The foreach that is used to sum the students' scores will be 
updated to include an if statement that branches the code. Exam scores will be applied to the sum in 
one branch, and extra credit scores in the other branch.


PART V:

Integrate Extra Credit Scores into a Code Branch

In this assignment, you will update the application to accommodate extra credit work that has been 
submitted by students. Students complete extra credit projects to earn bonus points that can help boost 
their grade. Your teacher has provided you with extra credit scores for each student based on what the 
students submitted:

- Sophia: 94, 90
- Andrew: 89
- Emma: 89, 89, 89
- Logan: 96
*/

// initialize variables - graded assignments 
int examAssignments = 5;

int[] sophiaScores = {90, 86, 87, 98, 100, 94, 90};
int[] andrewScores = {62, 79, 61, 86, 90, 89};
int[] emmaScores = {80, 85, 87, 82, 68, 89, 89, 89};
int[] loganScores = {80, 75, 82, 60, 56, 64};
int[] beckyScores = {62, 61, 60, 71, 72, 82, 92};
int[] chrisScores = {54, 66, 68, 80, 72, 94, 96, 98};
int[] ericScores = {100, 96, 100, 96, 97, 100, 80, 90};
int[] gregorScores = {91, 81, 90, 91, 91, 91, 91};

// Student names:
string[] studentNames = {"Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor"};

int[] studentScores = new int[10];

string currentStudentLetterGrade = "";

// Write the Report Header to the console:
Console.WriteLine("Student\t\tGrade\n");

foreach(string name in studentNames) {
    string currentStudent = name;

    if(currentStudent == "Sophia")
        // Assign Sophia's scores to the studentScores array
        studentScores = sophiaScores;

    else if(currentStudent == "Andrew")
        // Assign Andrew's scores to the studentScores array
        studentScores = andrewScores;

    else if(currentStudent == "Emma")
        // Assign Emma's scores to the studentScores array
        studentScores = emmaScores;

    else if (currentStudent == "Logan")
        // Assign Logan's scores to the studentScores array
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

    // Initialize/reset the sum of scored assignments:
    int sumAssignmentScores = 0;

    // Initialize/reset the calculated average of exam + extra credit scores:
    decimal currentStudentGrade = 0;

    // Initialize/reset a counter for the number of assignment:
    int gradedAssignments = 0;

    foreach(int score in studentScores) {
        // Increment  the assignment counter:
        gradedAssignments += 1;

        if (gradedAssignments <= examAssignments)
            // Add the exam score to the sum:
            sumAssignmentScores += score;
        else
            // Add the extra credit points to the sum - bonus points equal to 10% of an exam socre:
            sumAssignmentScores += score / 10;
    }

    currentStudentGrade = (decimal)(sumAssignmentScores) / examAssignments;

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

// Required for running in VS Code (keeps the Output windows open to view results):
Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();




