# CSharp-.NET-Dynamic-Form-Creation

The purpose of the first form is to select an action (open an empty form to enter data, select a movie or create a list of jobs.) After selection, the second form will be built dynamically, then shown to execute it’s job. When closing the second form, the results of processing data (stored in **myData**) will be shown on the first form (in **lblTransfer**).

![Image](/formOut.png)

The above image displays the user flow of the application. 
1. User actions selections movies from the drop down menu.
2. Build button is pressed.
3. **frmBuilded** is created depending on the selection made.
4. Quit is pressed, exit code is returned from **frmBuilded**
5. **lblTransfer** is populated with **myData** and control is returned to the user.
