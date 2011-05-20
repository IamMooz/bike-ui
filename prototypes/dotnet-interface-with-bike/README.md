Prototype: .NET Interface to BIKE
=================================

Aim
------
Make sure BIKE's C++ library can connect to a .NET library.

Project Notes
-------------
Custom Build step copies DLL files from dll folder to build target directory on successful build

Program.cs: Test harness only

Interface.cs: Prototype code

Methodology
-----------
* Set up a project including Core, Storage, Expressions.dll
* Used Dependency Walker to find all exports of Core.dll
* Used DllInvoke to reference Core.dll; entry points taken from Dependency Walker
* Called endBulkUpdate() successfully
* Calling createToolkit() throws AccessViolationException; likely error is faulty first parameter (std::list<string>)
** Need to find a way to create the std::list<string> to pass in

Findings
--------
* C# knows nothing about the types of methods it's calling; we have to set that up on our end
* Setting up a .NET type to be used by a pointer in C++ is known as "marshaling"; sets up an area of memory and passes the pointer to the C++ code
* AccessViolationException occurs whenever a bad pointer is hit in BIKE
* ITS FRIDAY FRIDAY GOTTA GET DOWN ON FRIDAY
