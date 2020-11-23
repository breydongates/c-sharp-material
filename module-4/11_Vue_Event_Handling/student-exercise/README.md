# Vue.js Event Handling Exercise

In this exercise, you'll build on the previous exercise that asked you to display a list of users in a table. First, you'll start by creating a new user form so that new users can be added to the list. Second, you'll add the ability to select one or more users and then perform actions on them such as enable, disable, and delete. This is what the final application should look like:

![Exercise Final](./img/completed-application.png)

## Step One: Initialize the project

After opening the project folder in Visual Studio Code, open the `Terminal` menu and click on `New Terminal`. Alternatively, you may press `` Ctrl+` `` on Windows and macOS. Next, run the command `npm install` to install any dependencies before working on the project.

## Step Two: Run unit tests

There are unit tests located in `/tests/unit/UserList.spec.js` that you can run as you complete each task. To run the automated tests, run the command `npm run test:unit` from the `Terminal`. There are **17** unit tests. The first test, "should display a list of users with correct data", passes. All others fail before you begin writing any code.

As you complete a feature, run the unit tests, and make sure the tests associated with that feature pass before moving on.

Make sure you follow the requirements and name your properties, methods, and computed properties exactly as they're shown. The tests rely on these names. If you have tests failing and aren't sure why, this could be the reason.

## Step Two: Add a new user form

The markup for the new user form is already in the template. Complete the following tasks:

- The form should be hidden by default.
  - Use a property called `showForm` to track the visibility of the form.
  - Toggle `showForm` with `v-on` when the user clicks the "Add New User" button.
  - Use `v-show` to show/hide form appropriately based on `showForm`.
- Each form field should be bound to the correct property in the `newUser` object.

## Step Three: Add the user when the button is clicked

- Create a `saveUser` method that adds a new user to the `users` array when the form is submitted.
- When the user clicks the "Save User" button, call `saveUser`
- Set the newly-created user's id equal to nextId and increase nextId by 1
- Add the newly-created user to the users array
- Clear the form after the user is saved by setting the `newUser` equal to a new object with default values for firstName, lastName, username, emailAddress, id, and status.
- 
## Step Four: Add an enable/disable button in action column

In the "Action" column of the table, there's a button that enables or disables the user. Complete the following tasks:

- If the user status = 'Active', the button text displays 'Disable.'
- If the user status = 'Disabled', the button text displays 'Enable.'
- When you click the button, it calls a method `flipStatus()` and changes the user's status from 'Active' to 'Disabled', or 'Disabled' to 'Active.'
  - The `flipStatus(id)` method takes the user ID as an argument.
  - You can use the user ID to `find` the user in the users array and change their status.

## Step Five: Enable, disable, and delete selected users

There are three buttons below the user listing table. Complete the following tasks associated with those buttons:

- Add a `selectedUserIDs` property that defaults to an empty array.
- When the `selectedUserIDs` array is empty, the buttons should be disabled.
  - Note: use a computed property named `actionButtonDisabled` for this and bind the individual button's `disabled` property.
- When the checkbox for a row is checked, add the user's ID to the `selectedUserIDs` array.
  - Bind the row's checkbox's model to the `selectedUserIDs` array and verify that checking and unchecking updates the selectedUserIds property in the Vue dev tools.
- Enable Users
  - Sets the status of each selected user to `Active`.
  - Clears all checkboxes when action is completed.
  - Method name: `enableSelectedUsers()`
- Disable Users
  - Sets the status of each selected user to `Disabled`.
  - Clears all checkboxes when action is completed.
  - Method name: `disableSelectedUsers()`
- Delete Users
  - Deletes the user from the `users` array.
  - Clears all checkboxes when action is completed.
  - Method name: `deleteSelectedUsers()`

> Tip: Depending how you retrieve the user ID, Vue may give it to you as a string even though it's a number. This may give you issues with comparison—try converting to a number before adding to `selectedUserIDs` if you have comparison issues.

> Tip: `findIndex` and `splice` are helpful ways of removing things from an array.

> Tip: Setting `selectedUserIds` to an empty array should clear the checkboxes

## Step Six: Select all checkbox

The "select all" checkbox is the checkbox on the first row with the filter inputs. 

Complete these initial tasks for the "select all" checkbox:

- When clicked to "checked" state, add all user ids to `selectedUserIDs`. (hint: calling map on the users array to build an array of ids may be a convenient way of doing this)
- When clicked again to "unchecked" state, set `selectedUserIDs` to an empty array.

> hint: The above steps can be achieved by listening to the changed event and looking at the event.target.checked value.

Once these steps are working:

- Bind the `checked` property of the select all checkbox to a new computed property that returns true if the length of the `selectedUserIDs` array is the same as the length of the `users` array.

Once this is done, the following statements should now be true:

- If some of the boxes are checked, clicking "select all" selects all users. If clicked again, then it deselects all users.
- When all individual checkboxes get checked, then "Select all" is checked too.
