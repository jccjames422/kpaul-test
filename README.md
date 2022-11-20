# KPaul Assessment

## Initial Cleanup
The Home/Index view was missing a `<div>` tag above the `<table>`.
The Home/Index view had a `<thread>` tag where there should be a `<thead>` tag.
## Step One
>First is the Delete button on the table rows. Whenever clicked, it should remove the row and show this change. However, the change is not reflected until the page is refreshed.
### Fixed Delete Functionality
* Added an Id field to the StudentModel in order to be able to reference each student by id.
* This was necessary because there are two students with the same identifiers in the original list.
* Updated delete functions in both javascript and home controller
* Added a delete student confirmation modal window with an `@Html.Partial()`.
### Updated the StudentViewModel
* This view does not need to explicitly define each property of the StudentModel, so I deleted a large portion of this code, which was duplicated in the StudentModel itself.
## Step Two
> The second is the Add Student button, which is showing an error when clicked.
* The Add Student button was pointing to an Add method on the Home controller, but the Add method didn't exist.
* I reworked the Controllers and divided the methods into two separate Controllers - one for Home page content and one for Students.
* After the add button was fixed, I noticed that the form for adding / editing students was poorly formatted so I updated the formatting.
* I also noticed the form's validation wasn't working properly so I added validation attributes to the StudentModel's properties and created more robust form validation in the view.  I renamed the AddStudent view to Edit, and I put it under the Student folder in the Views folder.
* The Add button was not working on the Add Student form.  Fixed.
## Add Edit Student Functionality
> Next, the ability to edit an existing row in the table needs to be added. There should be a button on each row that allows the row to be fixed. The name, major, and age of students should be editable.
* I re-used the newly created Views/Student/Edit view to also display a form for editing a student.
* I created a partial view for reusability.
    * Changed the method that is called by the form
    * Changed the name of the submit button from "Add" to "Save Changes".
## Additional Comments
> Also, document any other issues you find, with explanations of how these issues could be addressed. Include any suggestions you have to improve the current system.
* The organization of the Controllers can be improved by separating methods having to do with Students from methods having to do with the Home page.
* The StudentViewModel does not need to explicitly declare all of the properties of the StudentModel.  The only thing the StudentViewModel needs to do, is contain a list of StudentModels, which can then be referenced in the view.
* The Index method in the HomeController does not need to create a new list of Students.  That is taken care of in the StudentViewModel.
* Two methods with the same name and the same Http attribute cannot be used at the same time in the same controller.
* I renamed several of the methods in the Student Controller to better represent the seven restful actions.  Since the Index method is in the Home controller, and we don't need to Show only one Student, I omitted Index and Show from the Controller.  These are the five methods I included:
    * **New:** show the form for creating a new Student
    * **Create**: Send a Post request to create a new Student in the database
    * **Edit:** show the form for editing an existing Student
    * **Update:** Send a Post request to save the edits to the Student in the database
    * **Destroy:** Delete a Student.