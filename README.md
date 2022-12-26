# EF6 to EF Core 6 Migration Steps for Dot Net 6.0

First migrate the Dot Net 4.8 Project into Dot Net 6.0 using upgrade-assistant.
After upgrading is complete, you will get errors. 
Don't worry about those. First ignore the DbContext related errors. Then fix the errors which are occurring due to framework upgradation.
After all errors are fixed, then check the dbContext errors again.
install the EF Core Power Tools extension into the Visual studio 2022.
Check the .csproj file to get the installed Entity framework packages for migration. 
Install all the packages before proceeding.
After installation is over restart visual studio.
Right click on the project name -> EF Core Power Tools -> Reverse Engineer -> select the configuration as per your requirement.
You are done.
Note: Disable the pluralization.
