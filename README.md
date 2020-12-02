# .Net_Assignments

# Day2_Assignment 1

Create a Class Employee with te following specifications


Properties
===========
string Name -> no blank names should be allowed
int EmpNo -> must be readonly and autogenerated
decimal Basic -> must be between some range
short DeptNo -> must be > 0

Methods
========
decimal GetNetSalary() -> returns calculated net salary (Use any formula to get net salary based on Basic salary)


Create overloaded constructors to accept initial values for Employee obj
Employee o1 = new Employee("Amol",123465, 10);
Employee o2 = new Employee("Amol",123465);
Employee o3 = new Employee("Amol");
Employee o4 = new Employee();




EmpNo must be autogenerated ... i.e.
first object should automatically get EmpNo 1
second object should automatically get EmpNo 2
third object should automatically get EmpNo 3
...and so on...

Test Cases

Employee o1 = new Employee();
Employee o2 = new Employee();
Employee o3 = new Employee();
cw(o1.EmpNo);
cw(o2.EmpNo);
cw(o3.EmpNo);
cw(o3.EmpNo);
cw(o2.EmpNo);
cw(o1.EmpNo);


-------------------------------------------------------------------------------------------------

# Day3_Assignment 2

private static int lastEmpNo = 0;

private int empNo;
public int EmpNo
{
	get {return empNo;}
	private set {empNo = value;}   /// Property Accessor
}
// 1. Only 1 of get/set can be given an accessor
// 2. You can reduce access, not increase it
/// public
/// protected internal
/// protected / internal
/// private


public Employee(string Name="noname", decimal Basic=10000, short DeptNo=10)
{
	empNo = ++lastEmpNo;
	this.Name = Name;
	this.Basic = Basic;
	this.DeptNo = DeptNo;
}

Main()
{
	Employee o = new Employee();
	//o.EmpNo = 123;
}

--------------------------------------------------------