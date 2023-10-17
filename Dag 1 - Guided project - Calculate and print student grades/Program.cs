// initialize variables - graded assignments 
using System.Xml.Schema;

double currentAssignments = 5.0;

double person_to_gpa(int grade_1, int grade_2, int grade_3, int grade_4, int grade_5)
{
    return (grade_1+grade_2+grade_3+grade_4+grade_5) / currentAssignments;
}

int sophia1 = 93;
int sophia2 = 87;
int sophia3 = 98;
int sophia4 = 95;
int sophia5 = 100;
double sophia = person_to_gpa(
    sophia1, sophia2, sophia3, sophia4, sophia5
);

int nicolas1 = 80;
int nicolas2 = 83;
int nicolas3 = 82;
int nicolas4 = 88;
int nicolas5 = 85;
double nicolas = person_to_gpa(
    nicolas1, nicolas2, nicolas3, nicolas4, nicolas5
);

int zahirah1 = 84;
int zahirah2 = 96;
int zahirah3 = 73;
int zahirah4 = 85;
int zahirah5 = 79;
double zahirah = person_to_gpa(
    zahirah1, zahirah2, zahirah3, zahirah4, zahirah5
);

int jeong1 = 90;
int jeong2 = 92;
int jeong3 = 98;
int jeong4 = 100;
int jeong5 = 97;
double jeong = person_to_gpa(
    jeong1, jeong2, jeong3, jeong4, jeong5
);

Console.WriteLine("GPA Score for Sophia: " + sophia.ToString("F2")); // F2 = 2 decimals.
Console.WriteLine("GPA Score for Nicolas: " + nicolas.ToString("F2"));
Console.WriteLine("GPA Score for Zahira: " + zahirah.ToString("F2"));
Console.Write("GPA Score for Jeong: " + jeong.ToString("F2"));