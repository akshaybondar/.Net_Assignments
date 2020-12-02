# .Net_Assignments

# Day2_Assignment 1(Employee)

Create a Class Employee with te following specifications

Properties=>

string Name -> no blank names should be allowed

int EmpNo -> must be readonly and autogenerated

decimal Basic -> must be between some range

short DeptNo -> must be > 0

Methods=>

decimal GetNetSalary() -> returns calculated net salary 

(Use any formula to get net salary based on Basic salary)


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

# Day3_Assignment 2(Inheritance Assign)
Create the following classes.

Employee

   Prop	
   
	string Name -> no blanks

	int EmpNo -> readonly, autogenerated

	short DeptNo -> > 0

	abstract decimal Basic 

   Methods

	abstract decimal CalcNetSalary()

Manager : Employee

   Prop

	string Designation -> cant be blank

GeneralManager : Manager

   Prop

 	string Perks -> no validations

CEO : Employee

      Make CalNetSalary() a sealed method

NOTE : Overloaded constructors in all classes calling their base class constructor 

All classes must implement IDbFunctions interface

All classes to override the abstract members defined in the base class(Employee). 

Basic property to have different validation in different classes.


--------------------------------------------------------