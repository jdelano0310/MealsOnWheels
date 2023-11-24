# Meals on Wheels delivery system

This project aims to give any Meals on Wheels organization a system to track the meal recipients, the workers, and the delivery schedule.

This project is using VB.Net + MDI Winforms. It is an extention of a similar project started in Microsoft Access and thus to keep the code relatively 
similar (MS Access uses Visual Basic for Applications) I decided to stick with Visual Basic.Net and Winforms.   

The Access Database included in this repository has the forms and mostly working portions.

This is a work in progress and there are no guarantees everything will be bug free, I am just 1 person that decided to make this public after a user
on Reddit asked for help with their Meals On Wheels organization, however, there might be others that could use this so as I had started this in Access I 
decided to go ahead with creating a system that may work for any MOW seeking to automate some of their delivery scheduling.

This readme will be updated with screenshots and more as this app comes closer to a finished product.

Copy and paste from a Word OneDrive document I have been building to capture the information about this project:
Meals on Wheels – Visual Basic.net - Windows form desktop application. 

Tech: 

Visual Basic.Net 7.0 (selected given it is a cousin of VBA) 
MS Access database (accdb file) 

Dev tool: Visual Studio Comminuty 2022 

Theme taken from the Meals on Wheels website. 

Feature set: 

Create, update, and delete*  
* where delete is actually a deactivation of recipients or workers so as to not orphan any historical records. 

  - Meal Recipients 
    -First Name 
    -Last Name 
    -Street Address 
    -City 
    -State 
    -Zip 
    -County 
    -Home Phone 
    -Cell Phone 
    -Email Address 
    -Active 
    -Notes 
      -CreatedUser 
      -DateCreated 
      -DateLastModified 
      -LastModifiedUser 
      -DateDeactivated 
      -DeactivatedUser 

  -Workers 
    -First Name 
    -Last Name 
    -Street Address 
    -City 
    -State 
    -Zip 
    -County 
    -Home Phone 
    -Cell Phone 
    -Email Address 
    -Active 
    -Notes 
    -Availability data (saved to tblWorkerAvailability) 
      -CreatedUser 
      -DateCreated 
      -DateLastModified 
      -LastModifiedUser 
      -DateDeactivated 
      -DeactivatedUser 

  -Deliveries 
    -Start Date 
    -Delivery Time 
    -End Date 
    -Frequency 
    -Recipient 
    -Worker 
      -CreatedUser 
      -DateCreated 
      -LastModifiedUser 
      -DateLastModified 

Screens used to Create, Update, and Delete (deactivate) 

Starting Screen
![Screenshot 2023-11-07 082310](https://github.com/jdelano0310/MealsOnWheels/assets/8117229/0cfde04e-7481-4eb7-8184-5af2baab7369)



Adding a recipient  

Pretty self-explanatory here. Fill it in and click Save – currently no required fields I figure everything should be except County, Cell Phone, and Notes makes sense to me (maybe email?) 


![Screenshot 2023-11-07 134423](https://github.com/jdelano0310/MealsOnWheels/assets/8117229/16da6dc0-364c-4eb1-bcc9-6cc83ad89352)


 

To edit a recipient, click the Manage Recipients button, to display a list of active recipients (to be added, a function to view deactivated recipients to allow for reactivation) 

 ![Screenshot 2023-11-07 134941](https://github.com/jdelano0310/MealsOnWheels/assets/8117229/5cc4cddd-72bd-407c-a5c9-3ebeec516ee5)


Double click the recipient to view or edit 


![Screenshot 2023-11-07 135549](https://github.com/jdelano0310/MealsOnWheels/assets/8117229/7792d33f-d16e-4136-b912-e8c6f49bba35)

 

Click the edit button if you decide it needs editing 


![Screenshot 2023-11-07 135509](https://github.com/jdelano0310/MealsOnWheels/assets/8117229/12e888a0-6f57-4c12-9242-7fcb8c638ec1)

 

Saved 


![Screenshot 2023-11-07 140059](https://github.com/jdelano0310/MealsOnWheels/assets/8117229/8ab7b467-72e9-4db2-9636-76aa85c1d800)
 

 

Deactivating (switching recipients to one that has deliveries remaining in my DB), clicking Edit and then unchecking Active. The system checks if the recipient has remaining deliveries and if they do the user is warned that continuing will cancel them. 


![Screenshot 2023-11-07 140456](https://github.com/jdelano0310/MealsOnWheels/assets/8117229/25db40ac-4936-418e-ac84-dffe26ca3b84)
 

Clicking Yes, they are then given a Notes screen to indicate why they are being deactivated.  
![Screenshot 2023-11-07 140726](https://github.com/jdelano0310/MealsOnWheels/assets/8117229/5d756472-62e6-44ae-92df-d070fbb15ccc)
 

Clicking cancel here resets the active status (the deliveries are not cancelled in the database until the recipient is saved as deactivated) 


There is a table for “calculated deliveries”, the records there are created when a delivery is created. It holds all the dates between the start and end dates separated by the frequency. When a recipient is deactivated, those records are updated with why and marked as cancelled.  

Here is an example of one I did earlier when I added that feature 

![Screenshot 2023-11-07 141651](https://github.com/jdelano0310/MealsOnWheels/assets/8117229/535b8539-5525-4a5e-9fb4-7df4d205d180)

 

As you might expect Workers works much the same way as recipients does. The difference is that I plan on asking for a replacement person to handle any remaining deliveries that have been previously assigned to the Worker being deactivated. 

![Screenshot 2023-11-18 123900](https://github.com/jdelano0310/MealsOnWheels/assets/8117229/da292357-437c-4eb9-a3d2-2253a7f783ed)

Added availability grid to this form ***************** data is not used in scheduling as of yet 

 

Click the edit button to start edit mode, double click a day cell to enter or edit the From – To times (this record was saved with the previous row heading, it has since been changed) press enter when the desired time has been selected / entered 

![Screenshot 2023-11-18 124040](https://github.com/jdelano0310/MealsOnWheels/assets/8117229/d211ea1c-d36b-4985-96eb-43291238da60)

![Screenshot 2023-11-18 124253](https://github.com/jdelano0310/MealsOnWheels/assets/8117229/135de454-4a04-4e1f-bd77-4a9d34ff8d51)

Then click Save to commit the changes. 

![Screenshot 2023-11-18 124344](https://github.com/jdelano0310/MealsOnWheels/assets/8117229/5ebef2c8-0ec5-4d7f-8114-6d5ade18839d)
 
Creating a delivery 

![Screenshot 2023-11-07 143808](https://github.com/jdelano0310/MealsOnWheels/assets/8117229/fa6699f7-8bbe-4359-8629-cff62a8027af)
 

Thinking about the availability of the worker, my thought was when the start and end date and the time of the deliveries selected here. Would then affect which Workers are available in the Worker dropdown. 

I thought displaying the recipient's demographic data here was a good double check and will allow for editing this information if need be. Currently, frequency consists of Weekly, Bi-Weekly, and Monthly. Upon saving this, the system creates each of the individual delivery records (for scheduling) required to fulfill the delivery setup.  
 

This data is viewable via the (drumroll) View Delivery Calendar, I know I’m a master at creative nomenclature.  

Only those recipients with upcoming deliveries are selectable. This is also true for the view by Worker. 

![Screenshot 2023-11-07 144530](https://github.com/jdelano0310/MealsOnWheels/assets/8117229/99112482-4aad-44d7-bfe2-31b62c8d3705)
![Screenshot 2023-11-07 144747](https://github.com/jdelano0310/MealsOnWheels/assets/8117229/f38313f8-f84e-4e5a-a304-c1ca068a26cf)

![Screenshot 2023-11-07 144914](https://github.com/jdelano0310/MealsOnWheels/assets/8117229/25e2edde-cb0f-47b6-9b7a-fb8557a33537)

NEWLY added is the ability to include cancelled upcoming deliveries in the view
![Screenshot 2023-11-24 085150](https://github.com/jdelano0310/MealsOnWheels/assets/8117229/7201acd2-145d-4189-898e-4e035ba20634)


You can add notes to multiple scheduled delivery dates, by selecting and then right clicking the grid 
![Screenshot 2023-11-09 095827](https://github.com/jdelano0310/MealsOnWheels/assets/8117229/a886cef5-921c-4247-b0b2-66411c652620)
![Screenshot 2023-11-09 095920](https://github.com/jdelano0310/MealsOnWheels/assets/8117229/4dac5a06-5313-4022-9914-c42ecca63ef0)
![Screenshot 2023-11-09 095927](https://github.com/jdelano0310/MealsOnWheels/assets/8117229/0788eafe-ec19-4e83-ad1f-756da3e996e9)

 
 

Added cancel multiple scheduled delivery dates to this form *************** need to insert screenshots 
![Screenshot 2023-11-18 124734](https://github.com/jdelano0310/MealsOnWheels/assets/8117229/24405586-feec-4f34-b51d-81e7ba90ad5c)
![Screenshot 2023-11-18 124837](https://github.com/jdelano0310/MealsOnWheels/assets/8117229/b83ba784-48d5-409d-969e-6575f8516150)
![Screenshot 2023-11-18 124856](https://github.com/jdelano0310/MealsOnWheels/assets/8117229/cff05333-8273-45fa-afad-9b76843fb18c)

If you then decide to include cancelled deliveries in the Calendar View:
![Screenshot 2023-11-24 085702](https://github.com/jdelano0310/MealsOnWheels/assets/8117229/80e93dae-4f7f-4f84-b9d2-e1fa9b6cbaef)


The data after the cancellation  
![Screenshot 2023-11-18 124940](https://github.com/jdelano0310/MealsOnWheels/assets/8117229/a167643a-3827-404a-9440-18600bb3e6e5)


As they were the only two records displayed when they were cancelled (and the view shows only active deliveries) the screen needs to be updated accordingly  
![Screenshot 2023-11-18 125143](https://github.com/jdelano0310/MealsOnWheels/assets/8117229/9c86a13c-8adb-450d-b4bc-8b66f8179a3b)
 
