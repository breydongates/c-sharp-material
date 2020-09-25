# Lecture Code

## New Concepts

* Class Variables
* Method Overloading
* Get-only Properties set from the Constructor
* Properties with Bodies
* Static Methods & Variables

## Reading This Specification

- X in the set column indicates it **must have a `set` accessor**.
- Nothing in the set column indicates the property is a derived property.
- `Readonly` properties don't have a `set` accessor and their values are set from the class's constructor.
- Private setters require the property to have `private set`.

## Company Class

Create `Company.cs`

### Company Constructor

Create a constructor that accepts the parameters: `string name` and `string address` and sets the appropriate properties.

### Company Properties

| Property          | Data Type | Get | Set      | Notes                                  |
| ----------------- | --------- | --- | -------- | -------------------------------------- |
| Name              | string    | X   | readonly |                                        |
| Address           | string    | X   | X        |                                        |
| WirelessPassword  | string    | X   | private  | Starts at Password1                    |

### Company Methods

Create a method called `Hire` that returns nothing and accepts parameters of type `Employee` called `employee` and `decimal` called `salary`. Set the employee's salary base on `salary`.

Create a method called `Pay` that invokes the parameter-less version of the `Pay` method for each employee.

## Employee Class

Create `Employee.cs`

### Employee Constructor

Create a constructor that accepts the parameters: `int id`, `string firstName`, and `string lastName`. Use these parameters to set the appropriate properties.

### Employee Properties

| Property          | Data Type | Get | Set      | Notes                                  |
| ----------------- | --------- | --- | -------- | -------------------------------------- |
| Id                | int       | X   | readonly |                                        |
| FirstName         | string    | X   | X        | Reject empty / whitespace values       |
| LastName          | string    | X   | X        | Reject empty / whitespace values       |
| FullName          | string    | X   |          | FirstName LastName                     |
| Salary            | decimal   | X   | X        | 							              |

### Employee Methods

Create a `Pay` method that does not take in any parameters. This increases a private variable named `amountPaid` by the employee's salary minus the calculated withholding on that pay stub.

Create a `Pay` method that takes in a `decimal` parameter named `amount` and returns the total amount paid to that employee thus far. This increases a private variable named `amountPaid` by amount minus the calculated withholding on that pay stub.

Create a `static` method called `CalculateWithholdingAmount` that takes in a decimal `payAmount` parameter and returns the amount of money to withhold from the payment. This is calculated at 5% of the amount.