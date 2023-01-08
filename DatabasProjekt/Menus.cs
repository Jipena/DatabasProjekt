using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DatabasProjekt.Data;
using DatabasProjekt.Models;

namespace DatabasProjekt
{
    internal class Menus
    {
        int menuChoice = 0;
        bool loopIsRunning = true;
        bool isAChoice = false;

        public void StartMenu()
        {
            this.menuChoice = 0;
            this.loopIsRunning = true;

            do
            {
                switch (this.menuChoice)
                {
                    default:
                        this.menuChoice = 0;
                        Console.WriteLine("1. Personnel");
                        Console.WriteLine("2. Students");
                        Console.WriteLine("3. Subjects");
                        Console.WriteLine("4. Grades");
                        Console.WriteLine("5. Classes");
                        Console.WriteLine("6. Exit Program!");

                        do
                        {
                            int.TryParse(Console.ReadLine(), out this.menuChoice);
                            // simple if to check that the number is corrisponding to a 'Menu Item'
                            if (this.menuChoice == 1 || this.menuChoice == 2 || this.menuChoice == 3 || this.menuChoice == 4 || this.menuChoice == 5 || this.menuChoice == 6)
                            {
                                this.isAChoice = true;
                            }
                            else
                            {
                                Console.WriteLine("Wrong Input!");
                            }


                        } while (!this.isAChoice);//keep looping if it's not a number
                        break;

                    case 1:
                        Console.WriteLine("1");
                        PersonnelMenu();
                        goto default;

                    case 2:
                        Console.WriteLine("2");
                        StudentMenu();
                        goto default;
                    case 3:
                        Console.WriteLine("3");
                        SubjectMenu();
                        goto default;
                    case 4:
                        Console.WriteLine("4");
                        GradeMenu();
                        goto default;
                    case 5:
                        Console.WriteLine("5");
                        ClassMenu();
                        goto default;
                    case 6:
                        Console.WriteLine("6. Exit Program");
                        this.loopIsRunning = false; // to terminate the do while after choice is to terminate the program
                        Console.Clear();
                        Console.WriteLine("Thank you for running this program.");
                        break;
                }
            } while (this.loopIsRunning);
        }

        public void PersonnelMenu()
        {
            this.menuChoice = 0;
            this.loopIsRunning = true;
            do
            {
                switch (this.menuChoice)
                {
                    default:
                        Console.Clear();
                        Console.WriteLine("1. Overview");
                        Console.WriteLine("2. Add Personnel");
                        Console.WriteLine("3. Departement");
                        Console.WriteLine("4. Salary");
                        Console.WriteLine("5. Exit Program!");
                        do
                        {
                            int.TryParse(Console.ReadLine(), out this.menuChoice);
                            // simple if to check that the number is corrisponding to a 'Menu Item'
                            if (this.menuChoice == 1 || this.menuChoice == 2 || this.menuChoice == 3 || this.menuChoice == 4 || this.menuChoice == 5)
                            {
                                this.isAChoice = true;
                            }
                            else
                            {
                                Console.WriteLine("Wrong Input!");
                                Console.ReadLine();
                            }


                        } while (!this.isAChoice);//keep looping if it's not a number
                        break;

                    case 1:
                        Console.WriteLine("Select p.FirstName, p.LastName, p.Position , DATEDIFF(YEAR,HiredDate,GETDATE()) AS 'YearsHired'");
                        Console.WriteLine("From Personnel p");
                        Console.WriteLine("Order by p.LastName");
                        Console.ReadLine();
                        goto default;
                    case 2:
                        Console.WriteLine("Insert into Personnel(FirstName, LastName, Phone#, City, Position, HiredDate, Salary)");
                        Console.WriteLine("Values ('Larry', 'Jonsson', '0703322111', 'New York', 'Teacher', '2023-01-07', 25000)");
                        Console.ReadLine();
                        goto default;
                    case 3:
                        Console.WriteLine("Departments");
                        using (var context1 = new SchoolContext())
                        {
                            var myDepartment = from x in context1.Personnel
                                             orderby x.Position ascending
                                             select x;
                            foreach (var postition in myDepartment)
                            {
                                Console.WriteLine(postition.Position + " " + postition.FirstName + " " + postition.LastName);
                            }
                        }
                        Console.ReadLine();
                        goto default;
                    case 4:
                        Console.WriteLine("4");
                        PersonnelSalaryMenu();
                        goto default;
                    case 5:
                        Console.WriteLine("5. Exit Program!");
                        this.loopIsRunning = false; // to terminate the do while after choice is to terminate the program
                        Console.Clear();
                        Console.WriteLine("Thank you for running this program.");
                        break;

                }
            } while (this.loopIsRunning);
        }
        public void StudentMenu()
        {
            this.menuChoice = 0;
            this.loopIsRunning = true;

            do
            {
                switch (this.menuChoice)
                {
                    default:
                        Console.Clear();
                        Console.WriteLine("1. Students Information");
                        Console.WriteLine("2. Save Students");
                        Console.WriteLine("3. Student Class");
                        Console.WriteLine("4. Student Grade");
                        Console.WriteLine("5. Important information");
                        Console.WriteLine("6. Exit Program!");
                        do
                        {
                            int.TryParse(Console.ReadLine(), out this.menuChoice);
                            // simple if to check that the number is corrisponding to a 'Menu Item'
                            if (this.menuChoice == 1 || this.menuChoice == 2 || this.menuChoice == 3 || this.menuChoice == 4 || this.menuChoice == 5 || this.menuChoice == 6)
                            {
                                this.isAChoice = true;
                            }
                            else
                            {
                                Console.WriteLine("Wrong Input!");
                                Console.ReadLine();
                            }


                        } while (!this.isAChoice);//keep looping if it's not a number
                        break;

                    case 1:
                        Console.WriteLine("Students Information");
                        using (var context1 = new SchoolContext())
                        {
                            var myStudents = from c in context1.Students
                                             orderby c.FirstName ascending
                                             select c;
                            foreach (var student in myStudents)
                            {
                                Console.WriteLine(student.FirstName + " " + student.LastName + " " + student.City + " " + student.Phone);
                            }
                        }
                        Console.ReadLine();
                        goto default;

                    case 2:
                        Console.WriteLine("Insert into Student (FirstName, LastName, Phone#, City, SocialSecurityNumber, FK_ClassId)");
                        Console.WriteLine("Values ('Kurt', 'Jansson', '0703322441', 'Mora', '9206231297', 3)");
                        Console.ReadLine();
                        goto default;
                    case 3:
                        Console.WriteLine("Select FirstName, LastName, ClassName");
                        Console.WriteLine("From Student S");
                        Console.WriteLine("Inner Join Class ON ClassId = FK_ClassId");
                        Console.WriteLine("Order By LastName");
                        Console.ReadLine();
                        goto default;
                    case 4:
                        Console.WriteLine("Insert into Grade(Grade, DateOfGrade, FK_SubjectId, FK_StudentId, FK_PersonnelId)");
                        Console.WriteLine("Values (5, '2022-11-01', 27, 14, 9)");
                        Console.WriteLine("-------------------------------------------");
                        Console.WriteLine("Select (P.FirstName + ' ' + P.LastName) AS 'TeacherName', G.DateOfGrade, G.Grade,");
                        Console.WriteLine("(S.FirstName + ' ' + S.LastName) AS 'StudentName',");
                        Console.WriteLine("Sub.SubjectName");
                        Console.WriteLine("From Grade G");
                        Console.WriteLine("Inner Join Personnel P ON P.PersonnelId = G.FK_PersonnelId");
                        Console.WriteLine("Inner Join Student S ON s.StudentId = G.FK_StudentId");
                        Console.WriteLine("Inner Join [Subject] Sub ON Sub.SubjectId = G.FK_SubjectId");
                        Console.WriteLine("Order By TeacherName");
                        Console.ReadLine();
                        goto default;
                    case 5:
                        Console.WriteLine("Create Procedure SP_Student_Info @StudentId int");
                        Console.WriteLine("As");
                        Console.WriteLine("Select * From Student");
                        Console.WriteLine("Where StudentId = @StudentId");
                        Console.WriteLine();
                        Console.WriteLine("exec SP_Student_Info @StudentId = '1'");
                        Console.ReadLine();
                        goto default;
                    case 6:
                        Console.WriteLine("5. Exit Program!");
                        this.loopIsRunning = false; // to terminate the do while after choice is to terminate the program
                        Console.Clear();
                        Console.WriteLine("Thank you for running this program.");
                        break;

                }
            } while (this.loopIsRunning);
        }
        public void SubjectMenu()
        {
            this.menuChoice = 0;
            this.loopIsRunning = true;

            do
            {
                switch (this.menuChoice)
                {
                    default:
                        Console.Clear();
                        Console.WriteLine("1. Active Subjects");
                        Console.WriteLine("2. Exit Program!");
                        do
                        {
                            int.TryParse(Console.ReadLine(), out this.menuChoice);
                            // simple if to check that the number is corrisponding to a 'Menu Item'
                            if (this.menuChoice == 1 || this.menuChoice == 2)
                            {
                                this.isAChoice = true;
                            }
                            else
                            {
                                Console.WriteLine("Wrong Input!");
                                Console.ReadLine();
                            }


                        } while (!this.isAChoice);//keep looping if it's not a number
                        break;

                    case 1:
                        Console.WriteLine("Active Subjects");
                        using (var context2 = new SchoolContext())
                        {
                            var mySubjects = from y in context2.Subjects
                                             orderby y.SubjectName ascending
                                             select y;
                            foreach (var subject in mySubjects)
                            {
                                Console.WriteLine(subject.SubjectName);
                            }
                        }
                        Console.ReadLine();
                        goto default;
                    case 2:
                        Console.WriteLine("2. Exit Program!");
                        this.loopIsRunning = false; // to terminate the do while after choice is to terminate the program
                        Console.Clear();
                        Console.WriteLine("Thank you for running this program.");
                        break;

                }
            } while (this.loopIsRunning);
        }
        public void GradeMenu()
        {
            this.menuChoice = 0;
            this.loopIsRunning = true;

            do
            {
                switch (this.menuChoice)
                {
                    default:
                        Console.Clear();
                        Console.WriteLine("1. Set grade.");
                        Console.WriteLine("2. Exit Program!");
                        do
                        {
                            int.TryParse(Console.ReadLine(), out this.menuChoice);
                            // simple if to check that the number is corrisponding to a 'Menu Item'
                            if (this.menuChoice == 1 || this.menuChoice == 2)
                            {
                                this.isAChoice = true;
                            }
                            else
                            {
                                Console.WriteLine("Wrong Input!");
                                Console.ReadLine();
                            }


                        } while (!this.isAChoice);//keep looping if it's not a number
                        break;

                    case 1:
                        Console.WriteLine("begin tran");
                        Console.WriteLine("Insert into Grade(Grade, DateOfGrade, FK_SubjectId, FK_StudentId, FK_PersonnelId)");
                        Console.WriteLine("Values (5, '2022-11-01', 27, 14, 9)");
                        Console.WriteLine("rollback");
                        Console.ReadLine();
                        goto default;
                    case 2:
                        Console.WriteLine("2. Exit Program!");
                        this.loopIsRunning = false; // to terminate the do while after choice is to terminate the program
                        Console.Clear();
                        Console.WriteLine("Thank you for running this program.");
                        break;

                }
            } while (this.loopIsRunning);
        }
        public void ClassMenu()
        {
            this.menuChoice = 0;
            this.loopIsRunning = true;

            do
            {
                switch (this.menuChoice)
                {
                    default:
                        Console.Clear();
                        Console.WriteLine("1. Overview Classes.");
                        Console.WriteLine("2. Exit Program!");
                        do
                        {
                            int.TryParse(Console.ReadLine(), out this.menuChoice);
                            // simple if to check that the number is corrisponding to a 'Menu Item'
                            if (this.menuChoice == 1 || this.menuChoice == 2)
                            {
                                this.isAChoice = true;
                            }
                            else
                            {
                                Console.WriteLine("Wrong Input!");
                                Console.ReadLine();
                            }


                        } while (!this.isAChoice);//keep looping if it's not a number
                        break;

                    case 1:
                        Console.WriteLine("1. Overview Classes.");
                        using (var context1 = new SchoolContext())
                        {
                            var myClasses = from y in context1.Classes
                                             orderby y.ClassName ascending
                                             select y;
                            foreach (var classes in myClasses)
                            {
                                Console.WriteLine(classes.ClassName);
                            }
                        }
                        Console.ReadLine();
                        goto default;
                    case 2:
                        Console.WriteLine("2. Exit Program!");
                        this.loopIsRunning = false; // to terminate the do while after choice is to terminate the program
                        Console.Clear();
                        Console.WriteLine("Thank you for running this program.");
                        break;

                }
            } while (this.loopIsRunning);
        }
        public void PersonnelSalaryMenu()
        {
            this.menuChoice = 0;
            this.loopIsRunning = true;

            do
            {
                switch (this.menuChoice)
                {
                    default:
                        Console.Clear();
                        Console.WriteLine("1. See salary for departments per month.");
                        Console.WriteLine("2. See average salary for departments.");
                        Console.WriteLine("3. Exit Program!");
                        do
                        {
                            int.TryParse(Console.ReadLine(), out this.menuChoice);
                            // simple if to check that the number is corrisponding to a 'Menu Item'
                            if (this.menuChoice == 1 || this.menuChoice == 2 || this.menuChoice == 3)
                            {
                                this.isAChoice = true;
                            }
                            else
                            {
                                Console.WriteLine("Wrong Input!");
                                Console.ReadLine();
                            }


                        } while (!this.isAChoice);//keep looping if it's not a number
                        break;

                    case 1:
                        Console.WriteLine("Select SUM(P.Salary), P.Position");
                        Console.WriteLine("From Personnel P");
                        Console.WriteLine("Group By P.Position");
                        Console.ReadLine();
                        goto default;
                    case 2:
                        Console.WriteLine("Select P.Position, AVG(P.Salary) as AvgSalary");
                        Console.WriteLine("from Personnel P");
                        Console.WriteLine("Group By P.Position");
                        Console.ReadLine();
                        goto default;
                    case 3:
                        Console.WriteLine("3. Exit Program!");
                        this.loopIsRunning = false; // to terminate the do while after choice is to terminate the program
                        Console.Clear();
                        Console.WriteLine("Thank you for running this program.");
                        break;

                }
            } while (this.loopIsRunning);
        }
    }
}
