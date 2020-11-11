# EXAM 70-483 - Programming in C#


# Table of contents
* [Assembly](#heavy_exclamation_mark--assembly)
* [Debugging](#heavy_exclamation_mark--debugging)
* [Events | Delegates | Callbacks](#heavy_exclamation_mark--events--delegates--callbacks)
* [Files](#heavy_exclamation_mark--files)
* [Language | Types](#heavy_exclamation_mark--language--types)
* [Logging | Exceptions](#heavy_exclamation_mark--logging--exceptions)
* [Networking](#heavy_exclamation_mark--networking)
* [OOP](#heavy_exclamation_mark--oop)
* [Security](#heavy_exclamation_mark--security)
* [Serializers](#heavy_exclamation_mark--serializers)
* [Threading | Tasks](#heavy_exclamation_mark--threading--tasks)


## :heavy_exclamation_mark:  **ASSEMBLY**


> You are developing an assembly that will be used by multiple applications.  
> You need to install the assembly in the Global Assembly Cache (GAC).  
> Which two actions can you perform to achieve this goal?

* A. Use the `Assembly Registration` tool (*regasm.exe*) to register the assembly and to copy the assembly to the GAC
* B. Use the `Strong Name` tool (*sn.exe*) to copy the assembly into the GAC
* C. Use `Microsoft Register Server` (*regsvr32.exe*) to add the assembly to the GAC
* D. Use the `Global Assembly Cache` tool (*gacutil.exe*) to add the assembly to the GAC
* E. Use `Windows Installer 2.0` to add the assembly to the GAC

<details> 
  <summary><b><i>Correct</i> answer</b></summary>
  D E
</details>

---

> You are creating a class library that will be used in a web application.  
> You need to ensure that the class library assembly is strongly named.  
> What should you do?

* A. Use the `csc.exe /target:Library` option when building the application
* B. Use the `AL.exe` command-line tool
* C. Use the `aspnet_regiis.exe` command-line tool
* D. Use the `EdmGen.exe` command-line tool

<details> 
  <summary><b><i>Correct</i> answer</b></summary>
  B
</details>

---

> You are creating a class library that will be used in a web application.  
> You need to ensure that the class library assembly is strongly named.  
> What should you do?

* A. Use `assembly attributes`
* B. Use the `csc.exe /target:Library` option when building the application
* C. Use the `xsd.exe` command-line tool
* D. Use the `EdmGen.exe` command-line tool

<details> 
  <summary><b><i>Correct</i> answer</b></summary>
  A
</details>

---

> You are creating a class library that will be used in a web application.  
> You need to ensure that the class library assembly is strongly named.  
> What should you do?

* A. Use the `gacutil.exe` command-line tool
* B. Use the `xsd.exe` command-line tool
* C. Use the `aspnet_regiis.exe` command-line tool
* D. Use `assembly attributes`

<details> 
  <summary><b><i>Correct</i> answer</b></summary>
  D
</details>

---

> You have two assemblies named `Assembly1` and `Assembly2` that are written in C#.  
> Assembly1 loads Assembly2 by executing the following code [...]  
> You create a new project in Microsoft Visual Studio to build a new assembly that will replace Assembly2.  
> The new assembly has the same name and version as the original Assembly2 assembly.  
> When you execute the code, Assembly1 cannot load Assembly2.  
> What should you do to ensure that Assembly1 can load Assembly2?

* A. Modify the project properties. Click Delay sign only
* B. Change the version of new Assembly2 assembly to 1.0.2.5
* C. Use the `sn.exe` command to create a new key file. Set the `assembly:AssemblyKeyFileAttribute` attribute to the new key file
* D. Run the `al.exe` command to sign Assembly2. Use the same key file used for the original Assembly2 assembly

<details> 
  <summary><b><i>Correct</i> answer</b></summary>
  C
</details>

---

> You have an assembly named Assembly named `Assembly1` that is written in C#.  
> Your company plans to sell Assembly1 to customers. The customers might debug Assembly1.  
> You need to minimize the amount of information contained within the debug symbols that are shipped with Assembly1.  
> How should you create the debug symbols for Assembly1?

* A. Create a new PDB file by running `pdbcopy.exe`
* B. Build Assembly1 by using a `Debug configuration`
* C. On the Build page of the project properties for Assembly1, click `Define TRACE` constant and `clear Define DEBUG` constant
* D. Build Assembly1 by using a `Release configuration`

<details> 
  <summary><b><i>Correct</i> answer</b></summary>
  C
</details>

---

> You are developing an application that produces an executable named `MyApp.exe` and an assembly named `MyApp.dll`.  
> The application will be sold to several customers.  
> You need to ensure that enough debugging information is available for `MyApp.exe`, so that if the application throws an error in a customer's environment, you can debug the error in your own development environment.
> What should you do?

* A. Digitally sign MyApp.dll
* B. Produce program database (PDB) information when you compile the code
* C. Compile MyApp.exe by using the /unsafe compiler option
* D. Initializes a new instance of the AssemblyDelaySignAttribute class in the MyApp.dll constructor

<details> 
  <summary><b><i>Correct</i> answer</b></summary>
  B
</details>

---

> You are developing an application by using C#. You provide a public key to the development team during development.  
> You need to specify that the assembly is not fully signed when it is built.  
> Which two assembly attributes should you include in the source code?

* A. `AssemblyKeyNameAttribute`
* B. `ObfuscateAssemblyAttribute`
* C. `AssemblyDelaySignAttribute`
* D. `AssemblyKeyFileAttribute`

<details> 
  <summary><b><i>Correct</i> answer</b></summary>
  C D
</details>

---

> You are developing an application that will be deployed to multiple computers.  
> You set the assembly name. You need to create a unique identity for the application assembly.  
> Which two assembly identity attributes should you include in the source code?

* A. `AssemblyTitleAttribute`
* B. `AssemblyCultureAttribute`
* C. `AssemblyVersionAttribute`
* D. `AssemblyKeyNameAttribute`
* E. `AssemblyFileVersion`

<details> 
  <summary><b><i>Correct</i> answer</b></summary>
  B C
</details>

---

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

> You are creating a console application by using C#.  
> You need to access the assembly found in the file named `car.dll`.  
> Which code segment should you use?

* A. `Assembly.Load();`
* B. `Assembly.GetExecutingAssembly();`
* C. `This.GetType();`
* D. `Assembly.LoadFile("car.dll");`

<details> 
  <summary><b><i>Correct</i> answer</b></summary>
  D
</details>

---

> You are developing code for an application that retrieves information about Microsoft .NET Framework assemblies.  
> The following code segment is part of the application
> ``` csharp
> public void ViewMetadata(string filePath)
> {
>     var bytes = File.ReadAllBytes(filepath);
>     _____
> }
> ```
>
> You need to insert code at line 04. The code must load the assembly.  
> Once the assembly is loaded, the code must be able to read the assembly metadata, but the code must be denied access from executing code from the assembly.  
> Which code segment should you insert at line 04?

* A. `Assembly.ReflectionOnlyLoadFrom(bytes);`
* B. `Assembly.ReflectionOniyLoad(bytes);`
* C. `Assembly.Load(bytes);`
* D. `Assembly.LoadFrom(bytes);`

<details> 
  <summary><b><i>Correct</i> answer</b></summary>
  C
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

---

> You are creating an assembly named `Assembly1` by using the Class Library project template in Microsoft Visual Studio. Assembly1 is used by a C# application named App1.  
> You do not have access to the Visual Studio project for App1.  
> You need to ensure that you can debug Assembly1.  
> What should you configure in the project properties?

* A. On the Application page, set the *Output type to Windows Application*
* B. On the Build page, click *Allow unsafe code*
* C. On the Debug page, set the *Start external program* option for App1
* D. On the Debug page, click *Enable native code debugging*

<details> 
  <summary><b><i>Correct</i> answer</b></summary>
  C
</details>

---

> You plan to debug an application remotely by using Microsoft Visual Studio 2013.  
> You set a breakpoint in the code.  
> When you compile the application, you get the following error message: `The breakpoint will not currently be hit. No symbols have been loaded for this document.`  
> You need to ensure that you can debug the application remotely.  
> What should you do?

* A. Modify the `AssemblyInfo.cs` file
* B. `Copy .exe files` to the Symbols folder on the local computer
* C. `Copy .cs files` to the remote server
* D. Use `.NET Remote Symbol Loading`

<details> 
  <summary><b><i>Correct</i> answer</b></summary>
  A
</details>

---

> You have a C# application named App1 that invokes a method in an external assembly named Assembly1.  
> Assembly1 is written in C++ and is natively compile by using a debug build.  
> When you debug App1, you do not see any debug information for Assembly1.  
> You need to ensure that when you debug App1, you see the debug information for Assebly1.  
> What should you do?

* A. On the Debugging page of the configuration properties for the C++ project, set the `Debugger Type to Native Only`
* B. On the Debugging page of the configuration properties for the C++ project, set the `Debugger Type to Mixed`
* C. On the Debug page of the project properties for App1, click `Enable native code debugging`
* D. In the project properties for App1, set the `working directory` to the same directory as Assembly1

<details> 
  <summary><b><i>Correct</i> answer</b></summary>
  B
</details>

---

> You are developing a C# application named Application1 by using Microsoft Visual Studio 2017.  
> You plan to compare the memory usage between different builds of Application1.  
> You need to record the memory usage of each build.  
> What should you use from Visual Studio?

* A. `IntelliTrace`
* B. `Memory Usage` from Performance Profiler
* C. `Performance Wizard` from Performance Profiler
* D. `Code Analysis`

<details> 
  <summary><b><i>Correct</i> answer</b></summary>
  B
</details>

---

> You are debugging a 64-bit C# application.  
> Users report `System.OutOfMemoryException` exceptions. The system is attempting to use arrays larger than 2 GB in size.  
> You need to ensure that the application can use arrays larger than 2 GB.  
> What should you do?

* A. Add the `/3GB switch` to the boot.ini file for the operating system
* B. Set the `IMAGE_FILE_LARGE_ADDRESS_AWARE flag` in the image header for the application executable file
* C. Set the value of the `gcAllowVeryLargeObjects` property to `true` in the application configuration file
* D. Set the value of the `user-mode virtual address space` setting for the operating system to `MAX`

<details> 
  <summary><b><i>Correct</i> answer</b></summary>
  C
</details>

---

> You have a C# application.  
> The application requires 500 MB of available memory.  
> You need to identify whether there is enough available memory when the application starts.  
> Which class should you use?

* A. `OutOfmemoryException`
* B. `MemoryStream`
* C. `PerformanceCounter`
* D. `DiagnosticsConfigurationHandler`

<details> 
  <summary><b><i>Correct</i> answer</b></summary>
  C
</details>

---

> You are developing an application by using C#. You have the following requirements:  
> * Support 32-bit and 64-bit system configurations
> * Include pre-processor directives that are specific to the system configuration
> * Deploy an application version that includes both system configurations to testers
> * Ensure that stack traces include accurate line numbers
>
> You need to configure the project to avoid changing individual configuration settings every time you deploy the application to testers.  
> Which two actions should you perform?

* A. Update the `platform target` and `conditional compilation symbols` for each application configuration
* B. Create two application configurations based on the default `Release configuration`
* C. Optimize the application through `address rebasing` in the 64-bit configuration
* D. Create two application configurations based on the default `Debug configuration`

<details> 
  <summary><b><i>Correct</i> answer</b></summary>
  B D
</details>

---

> You are creating an application that reads from a database.  
> You need to use different databases during the development phase and the testing phase by using conditional compilation techniques.  
> What should you do?

* A. Configure the assembly metadata to use the pre-existing public key for the assembly identity by using the `AssemblySignatureKeyAttribute` attribute
* B. `Disable the strong-name bypass` feature of Microsoft .NET Framework in the registry
* C. Configure the `Define DEBUG constant` setting in Microsoft Visual Studio
* D. Decorate the code by using the `[assembly:AssemblyDelaySignAttribute(true)]` attribute

<details> 
  <summary><b><i>Correct</i> answer</b></summary>
  C
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


## :heavy_exclamation_mark:  **NETWORKING**


> You need to write a method that retrieves data from a Microsoft Access 2013 database.  
> The method must meet the following requirements:  
> * Be read-only
> * Be able to use the data before the entire data set is retrieved
> * Minimize the amount of system overhead and the amount of memory usage
>
> Which type of object should you use in the method?

* A. `SqlDataAdapter`
* B. `DataContext`
* C. `DbDataAdapter`
* D. `OleDbDataReader`

<details> 
  <summary><b><i>Correct</i> answer</b></summary>
  D
</details>

---

> You need to write a method that retrieves data from a Microsoft Access 2013 database.  
> The method must meet the following requirements:  
> * Be read-only
> * Be able to use the data before the entire data set is retrieved
> * Minimize the amount of system overhead and the amount of memory usage
>
> Which type of object should you use in the method?

* A. `DbDataReader`
* B. `DataContext`
* C. `unTyped DataSet`
* D. `DbDataAdapter`

<details> 
  <summary><b><i>Correct</i> answer</b></summary>
  A
</details>

---

> You need to write a method that retrieves data from a Microsoft Access 2013 database.  
> The method must meet the following requirements:  
> * Be read-only
> * Be able to use the data before the entire data set is retrieved
> * Minimize the amount of system overhead and the amount of memory usage
>
> Which type of object should you use in the method?

* A. `DbDataAdapter`
* B. `unTyped DataSet`
* C. `OleDbDataAdapter`
* D. `DbDataReader`

<details> 
  <summary><b><i>Correct</i> answer</b></summary>
  D
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


## :heavy_exclamation_mark:  **SECURITY**


> You are developing an application that will process personnel records.  
> The application must encrypt highly sensitive data.  
> You need to ensure that the application uses the strongest available encryption.  
> Which class should you use?

* A. `System.Security.Cryptography.DES`
* B. `System.Security.Cryptography.Aes`
* C. `System.Security.Cryptography.TripleDES`
* D. `System.Security.Cryptography.RC2`

<details> 
  <summary><b><i>Correct</i> answer</b></summary>
  B
</details>

---

> You plan to store passwords in a Windows Azure SQL Database database.  
> You need to ensure that the passwords are stored in the database by using a hash algorithm.  
> Which cryptographic algorithm should you use?

* A. `ECDSA`
* B. `RSA-768`
* C. `AES-256`
* D. `SHA-256`

<details> 
  <summary><b><i>Correct</i> answer</b></summary>
  D
</details>

---

> You are developing an application that will transmit large amounts of data between a client computer and a server.  
> You need to ensure the validity of the data by using a cryptographic hashing algorithm.  
> Which algorithm should you use?

* A. `ECDSA`
* B. `RNGCryptoServiceProvider`
* C. `Rfc2898DeriveBytes`
* D. `HMACSHA512`

<details> 
  <summary><b><i>Correct</i> answer</b></summary>
  D
</details>

---

> You have an application that will send confidential information to a Web server.  
> You need to ensure that the data is encrypted when it is sent across the network.  
> Which class should you use?

* A. `CryptoStream`
* B. `AuthenticatedStream`
* C. `PipeStream`
* D. `NegotiateStream`

<details> 
  <summary><b><i>Correct</i> answer</b></summary>
  A
</details>

---

> An application uses X509 certificates for data encryption and decryption.  
> The application stores certificates in the Personal certificates collection of the Current User store.  
> On each computer, each certificate subject is unique.  
> The application includes a method named `LoadCertificate`.  
> The *LoadCertificate()* method must load only certificates for which the subject exactly matches the searchValue parameter value.  
> You need to ensure that the *LoadCertificate()* method loads the correct certificates.  
> Which code segment should you insert at *line 06*?

* A. `X509FindType.FindBySubjectName`
* B. `X509FindType.FindBySubjectKeyIdentifier`
* C. `X509FindType.FindByIssuerName`
* D. `X509FindType.FindBySubjectDistinguishedName`

<details> 
  <summary><b><i>Correct</i> answer</b></summary>
  D
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


## :heavy_exclamation_mark:  **THREADING** | **TASKS**


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
