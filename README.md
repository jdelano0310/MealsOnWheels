# Meals on Wheels delivery system

This project aims to give any Meals on Wheels organization a system to track the meal recipients, the workers, and the delivery schedule.

This project is using VB.Net + MDI Winforms. It is an extention of a similar project started in Microsoft Access and thus to keep the code relatively 
similar (MS Access uses Visual Basic for Applications) I decided to stick with Visual Basic.Net and Winforms.

This is a work in progress and there are no guarantees everything will be bug free, I am just 1 person that decided to make this public after a user
on Reddit asked for help with their Meals On Wheels organization, however, they then never returned to the thread. As I had started this in Access I 
decided to go ahead with creating a system that may work for any MOW seeking to automate some of their delivery scheduling.

This readme will be updated with screenshots and more as this app comes closer to a finished product.

Current features:
  - Recipient Management
    - Add & Modify
      - When deactivating a recipient, it cancels all remaining delivery dates on or after the date deactivated
  - Workers
    - Add & Modify
    - When deactivating a worker, it cancels all remaining deliveries assigned to the worker and request a replacement be selected.
  - Delivery
    - Add & Modity
    - When cancelling a delivery, all calculated delivery dates for the assigned recipient are cancelled.
  - Calculation of all delvieries determined by a delivery record
  - View all Recipients, Workers, or Deliveries
