# symmetric_cryptogrpahy_password_manager
--------------------------------------------------------------------
THIS IS THE README
--------------------------------------------------------------------

Password Manager Project
by Rachael Carpenter
7/16/21
CSCE 3550

ABOUT THIS PROJECT:

A password manager is a program for storing and protecting passwords for online 
services. Many people make the mistake of reusing passwords for multiple sites. Using a 
password manager can offer a greater level of security by keeping multiple complex passwords 
organized and accessible. A password manager is designed so that the user only really needs to 
keep track of one password: the master password for accessing their account. Some form of 
encryption is used to ensure passwords are stored in a form that conceals the actual password.
When a user is ready to access a stored password, the encryption is reversible so that the original
password is once again accessible.

The method used for password protection in this program is as follows:
Whenever it is time for a password to be stored, whether it is a master password, or a 
service-related password, a user specific key is generated. This is done by first concatenating a 
salt onto the end of the user name, and then hashed using the ’computeHash’ method from the 
‘System.Security.Cryptography’ namespace. User specific key and password are then passed to 
the Triple DES (Triple Data Encryption Algorithm) also included in the C# cryptography library.
Encoded passwords are stored in one of two Microsoft access database tables. ‘Tbl_users’ stores 
master passwords and usernames. ‘Tbl_passwords’ stores usernames, services, and passwords to 
services. Passwords are not stored in plain text.

This was my first time creating a program using C# to write windows forms apps with 
Visual Studio, as well as implementing cryptography. I learned about how to populate combo 
boxes using information from a database, and how to connect a Microsoft access database to a 
C# program. It was an enjoyable project because I got to teach myself some new things.

If I had more time to dedicate to this project, I would work on refining small aspects of 
the account and registration system regarding checking for valid user input. For example, there is 
currently no way to deal with a user trying to create an account with a username that already 
exists. I would add an if statement to catch this input so that the program does not show an error
in such cases. I did not place limits on how much text the user can type into textboxes either. I 
should have capped it at about 30 characters.

--------------------------------------------------------------------
How to run the project on your computer:

1.	Unzip folder containing project.
2.	Open Visual Studio 2019.
3.	Under ‘Get Started’ click ‘Open a project or solution’.
4.	Browse your files and navigate to the project folder.
5.	Select the ‘CarpenterPass.sln’ file.
6.	Under ‘Build’, select ‘Build Solution’.
7.	Under ‘Debug’, select ‘Start without Debugging’.
8.	A windows form will appear, and you can follow the user demo 
    steps listed in the Results section of the Project Report. It 
    will tell you everything you need to click on. See the video 
    link near the end of the project report for a video of the user
    demo. If you want to look at the database files they are located
    in the debug folder inside the Bin folder.

Note: You may have to use Visual Studio Installer to download the 
.Net Desktop Development Workload


--------------------------------------------------------------------

User demo listing steps on how to use the program:

1. You are on the Registration form. Enter your username as ‘Demo1’ and password
‘1234’ twice in the text boxes. 
2. Click the ‘Register’ button.
3. A pop up appears signaling successful registration. Click ok.
4. Click on the blue link that says, ‘Go to Login’.
5. Enter ‘Demo1’ in the username textbox and ‘1234’ in the password text box.
6. Click ‘login’ button.
7. You are on the home page. Enter ‘Google’ in the name of service text box and
‘password1’ in the password and confirm password text boxes.
8. Click ‘store a new password’ button.
9. A pop appears signaling that password has been stored successfully. Click OK.
10. Click ‘refresh service list’ button.
11. Select ‘Google’ from drop down menu.
12. Click checkbox. Notice ‘password1’ displayed in text box.
13. Click ‘Log out’ button.
14. Click ‘Back to Registration’
15. Enter ‘Demo2’ as username and ‘5678’ as password in text boxes.
16. Click ‘Register’ button.
17. A pop up appears signaling successful registration. Click ok.
18. Click on the blue link that says, ‘Go to Login’.
19. Enter ‘Demo2’ in the username textbox and ‘5678’ in the password text box.
20. Click ‘login’ button.
21. You are on the home page. Enter ‘Google’ in the name of service text box and
‘password2’ in the password and confirm password text boxes.
22. Click ‘store a new password’ button.
23. A pop appears signaling that password has been stored successfully. Click OK.
24. Enter ‘Apple’ in the name of service text box and ‘password3’ in the password and 
confirm password text boxes.
25. Click ‘store a new password’ button.
26. A pop appears signaling that password has been stored successfully. Click OK.
27. Click ‘Refresh service list’ button.
28. Select ‘Google’ from drop down menu.
29. Click checkbox.
30. Select ‘Apple’ from drop down men

Please see the link below for a video of me following the user demo.
VIDEO LINK HERE: https://youtu.be/K2uu0Hpet-A

Please note that if you want to follow the demo more than once
that you will have to create different usernames for account 
registration as usernames must be unique. Attempts to create
duplicate accounts on the registration page will result in an 
error and the program must be restarted.


--------------------------------------------------------------------
