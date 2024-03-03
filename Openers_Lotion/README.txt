﻿OPNERSLOTION
SUBJECT : 		WEB APPLICATION SECURITY (CYB206)
PROFESER :		 Andrew Steel
Product: 		 Lotion	
Team Members:	Sreekanth Pandinjareppatt (0850243) [Leader]
Foram Jhaveri (0849796)
Jaspreet Singh (0827369)

2024-02-15
1433
We got LOTION as our product.
Each of us did research on various types of lotion before deciding which one to use.
Next, we conducted research to determine which properties we might utilize for our database solution.
Next, we investigated several names for our project.
After a bit of discussion, we opted for OpnersLotion for our project.
Next, we divided the task between us.
Lastly, we created this README.txt file.


2024-02-18
1722
Foram Jhaveri
I opened Visual Studio and started a new OpnersLotion project.
Then, I made the Home page image in Canva app and updated the Home page.
Then, I added the following fields to the database solution: Name, Type, Price, and Review.
I then created Create, Read, Update, and Delete pages for the lotion model by adding NuGet packages to the scaffolding tool.
Then I added Migration and updated the database.
There was error while running this one 
Add-Migration -Context Openers_LotionContext
Update Database -Context Openers_LotionContext
After that, I pressed view design and expressed SQL Server in LocalDB. It was successfully displayed.
I updated the README.txt file with my work.
When the task was over, I used GitHub to send the project to Sreekanth for the remaining parts.


2024-02-19
1234
Sreekanth Padinjareppatt Sethumadhavan
At first, I examined the project parts that Foram had finished.
Next, I made a new class in the Models folder called SeedData and used it to seed the database.
Next, I changed the code in the program.cs file to add the seed initializer.
I then added the information to the database.
After that, I ran the project and the database displayed correctly and successfully.
I then made changes to the edit.cshtml file.
I verified that the edit action method and it was operating properly.
Next, I updated the Index method and added the parameters named search string for the filter.
I updated the README.txt file with my work.
When the task was over, I used GitHub to send the project to Jaspreet for the remaining parts.


2024-02-20
1845
Jaspreeth
Firstly, I examined the project parts that were finished by Foram and Sreekanth.
Next, I added a search method in the model folder's LotionViewModel class.
Next, I changed the LotionsController.cs Index method code.
I then updated the search method's index view.
After that, when I ran the project, it displayed the results with the correct data.
Then I added the validation method in Lotion class.
Then I examined the details and deleted the method.
I updated the README.txt file with my work.
After the assignment was completed, I sent the project to Foram and Sreekanth for review via GitHub. 

2024-02-21
1422
Finally, we examined our Lotion product web application together and saw that it was operating successfully and made the necessary changes.

2024-03-03
1400
Changed the parameters and added more (Product Name, Item Form, Skin Type, Quantity, Description, Price, Review ). 
Occured error while running
Deleted database and builded new database with same steps other team members followed
Changed LotionViewModel to LotionTypeViewModel
