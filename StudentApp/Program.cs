using System;

public class Student
{
    private int rollNo;
    private string name;
    private double cgpa;

    //all get methods
    public int RollNo { get { return rollNo; } }
    public string Name { get { return name; } }
    public double CGPA { get { return cgpa; } }


    //all set methods which sets values after validating else returns false
    public bool SetRollNo(int value)
    {
        if (value > 0)
        {
            rollNo = value;
            return true;
        }
        else
        {
            return false;
        }
    }

    public void SetName(string value)
    {
        if (value.Length >= 5)
        {
            name = value;
           
        }
        else
        {
            name = "";
        }
    }

    public bool SetCGPA(double value)
    {
        if (value >= 1 && value <= 10)
        {
            cgpa = value;
            return true;
        }
        else
        {
            return false;
        }
    }

    public double CalculatePercentage()
    {
        return CGPA * 10;
    }

    public void PrintDetails()
    {
        Console.WriteLine($"Student Name: {Name}");
        Console.WriteLine($"Roll Number: {RollNo}");
        Console.WriteLine($"CGPA: {CGPA}");
        Console.WriteLine($"Percentage: {CalculatePercentage()}%");
    }
}

class StudentApp
{
    static void Main(string[] args)
    {
        //creating student class object
        Student student1 = new Student();
        
        //taking rollno input
        int rollno;
        do
        {
            Console.Write("Enter Roll Number (positive integer): ");
            rollno = int.Parse(Console.ReadLine());
        } while (!student1.SetRollNo(rollno));

        //taking name input
        string name;   
        Console.Write("Enter Name (minimum 5 characters): ");
        name = Console.ReadLine();

        //taking cgpa input
        double cgpa;
        do
        {
            Console.Write("Enter CGPA (between 1 and 10): ");
             cgpa = double.Parse(Console.ReadLine());
            student1.SetCGPA(cgpa);
        } while (!student1.SetCGPA(cgpa));

        //calling print function
        student1.PrintDetails();
    }
}