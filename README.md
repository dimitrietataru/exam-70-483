# EXAM 70-483 - Programming in C#


## :heavy_exclamation_mark:  **ASSEMBLY**


> You are creating a console application by using C#. You need to access the application assembly.  
> Which code segment should you use?

* A. `Assembly.GetAssembly(this);`
* B. `this.GetType();`
* C. `Assembly.Load();`
* D. `Assembly.GetExecutingAssembly();`

<details> 
  <summary><b><i>Correct</i> answer</b></summary>
  D
</details>

---

> You are developing an assembly that will be used by multiple applications.  
> You need to install the assembly in the Global Assembly Cache (GAC).  
> Which two actions can you perform to achieve this goal?

* A. Use the `Assembly Registration` tool (*regasm.exe*) to register the assembly and to copy the assembly to the GAC.
* B. Use the `Strong Name` tool (*sn.exe*) to copy the assembly into the GAC.
* C. Use `Microsoft Register Server` (*regsvr32.exe*) to add the assembly to the GAC.
* D. Use the `Global Assembly Cache` tool (*gacutil.exe*) to add the assembly to the GAC.
* E. Use `Windows Installer 2.0` to add the assembly to the GAC

<details> 
  <summary><b><i>Correct</i> answer</b></summary>
  D E
</details>


## :heavy_exclamation_mark:  **DEBUGGING**

> You are debugging an application that calculates loan interest. The application includes the following code:
> ``` csharp
> private static decimal CalculateInterest(decimal loanAmount, int loanTerm, decimal loanRate)
> {
>     _____
>     decimal interestAmount = loanAmount * loanRate * loanTerm;
> 
>     return interestAmount;
> }
> ```
>
> You need to ensure that the debugger breaks execution within the `CalculateInterest()` method when the `loanAmount` variable is less than or equal to zero in all builds of the application.  
> What should you do?

* A. Insert the following code segment at line 03: `Trace.Assert(loanAmount > 0);`
* B. Insert the following code segment at line 03: `Debug.Assert(loanAmount > 0);`
* C. Insert the following code segment at line 05: `Debug.Write(loanAmount > 0);`
* D. Insert the following code segment at line 05: `Trace.Write(loanAmount > 0);`

<details> 
  <summary><b><i>Correct</i> answer</b></summary>
  A
</details>


## :heavy_exclamation_mark:  **EVENTS** | **DELEGATES** | **CALLBACKS**


You are modifying an application that processes leases. The following code defines the Lease class.
``` csharp
public class Lease
{
    _____
    private int _term;
    private const int MaximumTerm = 5;
    private const decimal Rate = 0.034m;
    public int Term
    {
        get
        {
            return _term;
        }
        set
        {
            if (value < MaximumTerm)
            {
                _term = value;
            }
            else
            {
                _____
            }
        }
    }
}
public delegate void MaximumTermReachedHandler(object source, EventArgs e);
```
Leases are restricted to a maximum term of 5 years. The application must send a notification message if a lease request exceeds 5 years.
You need to implement the notification mechanism.
Which two actions should you perform?
* A. Insert the following code segment at line 03: `public event MaximumTermReachedHandler OnMaximumTermReached;`
* B. Insert the following code segment at line 21:
``` csharp
if (OnMaximumTermReached != null)
{
    OnMaximumTermReached(this, new EventArgs());
}
// OnMaximumTermReached?.Invoke(this, new EventArgs());
```
* C. Insert the following code segment at line 21: `value = MaximumTerm;`
* D. Insert the following code segment at line 03: `public string MaximumTermEventReachedEvent { get; set; }`
* E. Insert the following code segment at line 03: `private string MaximumTermEventReachedEvent;`
* F. Insert the following code segment at line 03: `value = 5;`

<details> 
  <summary><b><i>Correct</i> answer</b></summary>
  A B
</details>

---

You are developing an application that includes a class named `UserTracker`.
The application includes the following code segment.

```
public delegate void AddUserCallback(int i);
public class UserTracker
{
    List<object> users = new List<object>();
    public void AddUser(string name, AddUserCallback callback)
    {
        users.Add(new object());
        callback(users.Count);
    }
}
public class Runner
{
    _____
    UserTracker tracker = new UserTracker();
    public void Add(string name)
    {
        _____
    }
}
```

You need to add a user to the UserTracker instance.
What should you do?
* A.
``` csharp
// Insert the following code segment at line 14:
private static void PrintUseCount(int i)
{
    ...
}
// Insert the following code segment at line 18:
AddUserCallback callback = PrintUserCount;
```

* B.
``` csharp
// Insert the following code segment at line 11:
delegate void AddUserDelegate(UserTracker userTracker);

// Insert the following code segment at line 18:
AddUserDelegate addDelegate = (userTracker) =>
    {
        ...
    }
addDelegate(tracker);
```

* C.
``` csharp
// Insert the following code segment at line 11:
delegate void AddUserDelegate(string name, AddUserCallback callback);

// Insert the following code segment at line 18:
AddUserDelegate addDelegate = (userTracker) =>
    {
        ...
    }
```

<details> 
  <summary><b><i>Correct</i> answer</b></summary>
  None. D is missing..
</details>

## :heavy_exclamation_mark:  **FILES**


> You are developing an application. The application includes a method named ReadFile that reads data from a file.  
> The `ReadFile()` method must meet the following requirements:  
> * It must not make changes to the data file.  
> * It must allow other processes to access the data file.  
> * It must not throw an exception if the application attempts to open a data file that does not exist.
>
> You need to implement the ReadFile() method. Which code segment should you use?  

* A. `var fs = File.Open(Filename, FileMode.OpenOrCreate, FileAccess.Read,FileShare.ReadWrite);`
* B. `var fs = File.Open(Filename, FileMode.Open, FileAccess.Read,FileShare.ReadWrite);`
* C. `var fs = File.Open(Filename, FileMode.OpenOrCreate, FileAccess.Read,FileShare.Write);`
* D. `var fs = File.ReadAllLines(Filename);`
* E. `var fs = File.ReadAllBytes(Filename);`

<details> 
  <summary><b><i>Correct</i> answer</b></summary>
  A
</details>


## :heavy_exclamation_mark:  **LANGUAGE** | **TYPES**


> You are implementing a method named Calculate that performs conversions between value types and reference types.  
> The following code segment implements the method.
>
> ``` csharp
> public static void Calculate(float amount)
> {
>     object amountRef = amount;
>     _____
>     Console.WriteLine(balance);
> }
> ```
>
> You need to ensure that the application does not throw exceptions on invalid conversions.  
> Which code segment should you insert at line 04?

* A. `int balance = (int)(float)amountRef;`
* B. `int balance = (int)amountRef;`
* C. `int balance = amountRef;`
* D. `int balance = (int)(double) amountRef;`

<details> 
  <summary><b><i>Correct</i> answer</b></summary>
  A
</details>

---

> You are developing an application that accepts the input of dates from the user. Users enter the date in their local format.  
> The date entered by the user is stored in a `string` variable named `inputDate`.  
> The valid date value must be placed in a `DateTime` variable named `validatedDate`.  
> You need to validate the entered date and convert it to Coordinated Universal Time (UTC). The code must not cause an exception to be thrown.  
> Which code segment should you use?

* A.
``` csharp
bool validDate = DateTime.TryParse(
    inputDate,
    CultureInfo.CurrentCulture,
    DateTimeStyles.AdjustToUniversal | DateTimeStyles.AssumeLocal,
    out validatedDate);
```
* B.
``` csharp
bool validDate = DateTime.TryParse(
    inputDate,
    CultureInfo.CurrentCulture,
    DateTimeStyles.AssumeUniversal,
    out validatedDate);
```
* C.
``` csharp
bool validDate = true;
try
{
    validatedDate = DateTime.Parse(inputDate);
}
catch
{
    validatedDate = false;
}
```
* D.
``` csharp
validatedDate = DateTime.ParseExact(
    inputDate,
    "g",
    CultureInfo.CurrentCulture,
    DateTimeStyles.AdjustToUniversal | DateTimeStyles.AssumeUniversal);
```

<details> 
  <summary><b><i>Correct</i> answer</b></summary>
  A
</details>


## :heavy_exclamation_mark:  **LOGGING** | **EXCEPTIONS**


> You are developing an application that uses structured exception handling.  
> The application includes a class named ExceptionLogger.  
> The ExceptionLogger class implements a method named LogException by using the following code segment: `public static void LogException(Exception ex)`  
>
> You have the following requirements:
> * Log all exceptions by using the LogException() method of the ExceptionLogger class.
> * Rethrow the original exception, including the entire exception stack.
>
> You need to meet the requirements. Which code segment should you use?

* A.
``` csharp
catch (Exception ex)
{
    ExceptionLogger.LogException(ex);
    throw;
}
```
* B.
``` csharp
catch (Exception ex)
{
    ExceptionLogger.LogException(ex);
    throw ex;
}
```
* C.
``` csharp
catch
{
    ExceptionLogger.LogException(new Exception());
    throw;
}
```
* D.
``` csharp
catch
{
    var ex = new Exception();
    throw ex;
}
```

<details> 
  <summary><b><i>Correct</i> answer</b></summary>
  A
</details>


## :heavy_exclamation_mark:  **OOP**


> You are creating a class named Employee. The class exposes a string property named EmployeeType.
>
> ``` csharp
> public class Employee
> {
>     internal string EmployeeType
>     {
>         get;
>         set;
>     }
> }
> ```
>
> The EmployeeType property value must be accessed and modified only by code within the Employee class **or** within a class derived from the Employee class.  
> You need to ensure that the implementation of the EmployeeType property meets the requirements.  
> Which two actions should you perform?

* A. Replace line 05 with the following code segment: `protected get;`
* B. Replace line 06 with the following code segment: `private set;`
* C. Replace line 03 with the following code segment: `public string EmployeeType`
* D. Replace line 05 with the following code segment: `private get;`
* E. Replace line 03 with the following code segment: `protected string EmployeeType`
* F. Replace line 06 with the following code segment: `protected set;`

<details> 
  <summary><b><i>Correct</i> answer</b></summary>
  B E
</details>


## :heavy_exclamation_mark:  **SERIALIZERS**


> An application receives JSON data in the following format:  
> ``` json
> {
>    "FirstName": "David",
>    "LastName": "Jones",
>    "Values": [ 0, 1, 2]
> }
> ```
>
> The application includes the following code segment.  
> ``` csharp
> public class Name
> {
>     public string FirstName { get; set; }
>     public string LastName { get; set; }
>     public int[] Values { get; set; }
> }
> public static Name ConvertToName(string json)
> {
>     var ser = new JavaScriptSerializer();
>     _____
> }
> ```
> You need to ensure that the ConvertToName() method returns the JSON input string as a Name object.  
> Which code segment should you insert at line 10?  

* A. `return ser.ConvertToType<Name>(json);`
* B. `return ser.DeserializeObject(json);`
* C. `return ser.Deserialize<Name>(json);`
* D. `return (Name)ser.Serialize(json);`

<details> 
  <summary><b><i>Correct</i> answer</b></summary>
  C
</details>

---

> You are developing an application. The application converts a Location object to a string by using a method named WriteObject. The WriteObject() method accepts two parameters, a Location object and an XmlObjectSerializer object.  
> The application includes the following code.  
> ``` csharp
> public enum Compass
> {
>     North,
>     South,
>     East,
>     West
> }
> [DataContract]
> public class Location
> {
>     [DataMember]
>     public string Label { get; set; }
>     [DataMember]
>     public Compass Direction { get; set; }
> }
> void DoWork()
> {
>     var location = new Location { Label = "Test", Direction = Compass.West };
>     Console.WriteLine(WriteObject(location,
>         _____
>     ));
> }
> ```
>
> You need to serialize the Location object as a JSON object.  
> Which code segment should you insert at line 20?

* A. `new DataContractSerializer(typeof(Location))`
* B. `new XmlSerializer(typeof(Location))`
* C. `new NetDataContractSenalizer()`
* D. `new DataContractJsonSerializer(typeof(Location))`

<details> 
  <summary><b><i>Correct</i> answer</b></summary>
  D
</details>


## :heavy_exclamation_mark:  **THREADING** | **TASKS** | **async/await**


> You use the `Task.Run()` method to launch a long-running data processing operation.  
> The data processing operation often fails in times of heavy network congestion.  
> If the data processing operation fails, a second operation must clean up any results of the first operation.  
> You need to ensure that the second operation is invoked only if the data processing operation throws an unhandled exception.  
> What should you do?

* A. Create a `TaskCompletionSource<T>` object and call the `TrySetException()` method of the object.
* B. Create a task by calling the `Task.ContinueWith()` method.
* C. Examine the `Task.Status` property immediately after the call to the `Task.Run()` method.
* D. Create a task inside the existing `Task.Run()` method by using the `AttachedToParent` option.

<details> 
  <summary><b><i>Correct</i> answer</b></summary>
  B
</details>

---

> You are adding a public method named `UpdateScore` to a public class named `ScoreCard`.  
> The code region that updates the score field must meet the following requirements:  
> * It must be accessed by only one thread at a time.
> * It must not be vulnerable to a deadlock situation.
>
> You need to implement the UpdateScore() method. What should you do?

* A. Place the code region inside the following lock statement:
``` csharp
lock (this)
{
}
```

* B. Add a private object named `lockObject` to the `ScoreCard` class. Place the code region inside the following lock statement:
``` csharp
lock (lockObject)
{
}
```

* C. Apply the following attribute to the `UpdateScore()` method signature:
``` csharp
[MethodImpl(MethodImplOptions.Synchronized)]
```

* D. Add a public static object named `lockObject` to the `ScoreCard` class. Place the code region inside the following lock statement:
``` csharp
lock (typeof(ScoreCard))
{
}
```

<details> 
  <summary><b><i>Correct</i> answer</b></summary>
  B
</details>
