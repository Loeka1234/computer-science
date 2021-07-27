# Microsoft Dataverse

- Stores data in tables (=logical set of rows)
  Types:
  
  - **Standard**
    
    - Base set of tables that are created for every instance
    
    - You can't delete columns from this table
  
  - **Complex**
    
    - Contains complex, server-side business logic, ...
    
    - Care must be taken if you add server-side logic
  
  - **Restricted**
    
    - Certain tables that are tied to Dynamics 365 application functionalities require each user to have the corresponding license for that Dynamics 365 application if they want to create, update, or delete rows within the restricted tables
  
  - **Custom**
    
    - Created for specific business applications

- Tables can have relationships
  
  - One-to-many (1:N)
  
  - Many-to-many (N:N)

- You can create multiple database instances (extendable to 4 terabytes per instance)

- Standard table design based upon `Comon Data Model`

- **Invironments**: used to store, manage & share business data, apps, and flows in Microsoft Power Platform

- **Business rules**: apply and maintain business logic at the data layer instead of the app layer (powerfull way to enforce rules, set values, or validate data regardless of the form that is used to input data)

- **Business process flows**: Business process flows guide users to ensure they enter data consistently and follow the same steps every time. Business process flows are currently supported only for model-driven apps.

- **Workflows**: Workflows automate business processes without requiring user interaction.

- **Business logic with code**: Business logic supports advanced developer scenarios that extend the application directly through code.

### Security roles

| Security role        | Description                                                                                                                                                                                                                                |
| -------------------- | ------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------ |
| System administrator | Has full permission to customize or administer the environment, including creating, modifying, and assigning security roles. Can view all data in the environment.                                                                         |
| System Customizer    | Has full permission to customize the environment. However, can only view records for environment entities that they create.                                                                                                                |
| Environment Maker    | Can create new resources that are associated with an environment, including apps, connections, custom APIs, gateways, and flows that are using Power Automate. However, does not have any privileges to access data within an environment. |
| Basic User           | Can run an app within the environment and perform common tasks for the records that they own. Note: This only applies to non-custom entities.                                                                                              |
| Delegate             | Allows code to run as another user or impersonate. Typically used with another security role to allow access to records.                                                                                                                   |

You can create custom security roles.

### Table owners

- **User or team owned**: Actions that can be performed on these records can be controlled at the user level.
- **Organization-owned**: Access to the data is controlled at the organization level.

### Activity tables

`An activity` = an action that a calendar entry can be made for

- They have **time dimensions**

- They have **data**

- They have several sub-status values associated with the `Completed` status

Activity tables can be owned only by a user or team.

**Default activity tables**: Appointment, Email, Fax, Letter, Phone Call, Recurring Appointment, Task 
