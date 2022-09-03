# HotPlate-Online-Restaurant

![Untitled_Artwork (3)](https://user-images.githubusercontent.com/109395254/188254265-401c1f77-cfad-4b2d-aede-adc77861c48c.png)

HotPlate Online is a simple program that allows customers to order food online and have it delivered. At the moment, this program only works for Windows operating systems, but there are plans to expand to Android, IOS and MacOS. Software and illustrations was created by Andrew Collin (<a href = https://github.com/AndrewCollin32> Link </a>) 

# Table of Contents
<hr>
<ul>
  <li><a href = #Technologies>Technologies</a></li>
  <li><a href = #Overview>Overview</a></li>
  <ul>
    <li><a href = #Main_Store_Page> Main Store </a></li>
    <li><a href = #Checkout_Page> Checkout </a></li>
    <li><a href = #Confirmation_Page> Confirmation Page </a></li>
    <li><a href = #User_Settings> User Settings </a></li>
  </ul>
  <li><a href = #setup>Setup</a></li>
  <ul>
    <li><a href = #Installation>Install</a></li>
    <li><a href = #Setup_SQL> Setup SQL</a></li>
  </ul>
</ul>

# Technologies
Here is a list of technologies I've used.
<ul>
  <li>Programming Language: C#</li>
  <li>WinForms</li>
  <li>MySQL (NuGet Plugin: MySQL.Data 8.0.30)</li>
  <li>.Net Framework (4.7.2)</li>
</ul>

# Overview

Here is an overview of how to use this program (as a customer)

# Main_Store_Page
![HotPlateFirstPage](https://user-images.githubusercontent.com/109395254/188253677-9e2e9f8f-2a6c-4337-bc41-2edd454305b1.PNG)

<hr>

When you first open this program, you'll be greeted with the Main Store Page. On this page you can add your favorite food into the cart. There are multiple categories you can choose from for faster and more organized user experience. Once you add an item, the button will change color and the text will change to "add more". This means that you have 1 or more of this item in the cart. You can check your shopping cart or remove items by clicking on the shopping cart icon on the lower left. This will transfer you to the <a href = #Checkout_Page>Checkout Page</a>. On the main page, you also have access to your account information. Just click on the cat icon on the upper right and it will transfer you to the <a href = #User_Settings> User Settings </a> 

# Checkout_Page

![HotPlateCheckout](https://user-images.githubusercontent.com/109395254/188253679-8337e168-b56c-468a-97ee-362053b328e5.PNG)

<hr>

This is the checkout page. On this page you'll enter your information to place an order. You can also edit your order to delete them on the very left. Note that by deleting them, you are removing the entire item out of the basket, that means if you have 3 of the same item in the basket and you remove it, you'll remove all 3 of the items from the basket. You'll have to go back to the main page to add the item again. 
<br>
You can only use a U.S. phone number for checkout. Your address must be in U.S. territory. Your email has to be in this format <i>youremail@email.com</i> 
To change your address, you'll have to click on the change button. This will take you to your user settings where you can change your address. 
<br>
Once you click submit, the program will validate all the input. If valid, it will move onwards to the confirmation page. It will also save the order's data to the database with a unique confirmation number generated by GUID.

# Confirmation_Page

![HotPlateConfirmationPage](https://user-images.githubusercontent.com/109395254/188253687-4ab6255e-b561-4527-be73-42bb44fdeecb.PNG)

<hr>

Once the check out page validates all of your input, it will bring you to the confirmation page. This is where you'll get a unique confirmation code that is used to trace your order. The confirmation code is used as a primary key for the database as an ID to identify a specific order made. By clicking ok, your shopping cart will reset and it will bring you back to the main page. 

# User_Settings

![Hotplate UserSettings](https://user-images.githubusercontent.com/109395254/188253682-e05caac0-c728-4c02-8bde-c2a8f8412646.PNG)

<hr>

Clicking your name or the icon on the upper right will take you to user settings. In user settings, you can change your address, your name, your email and your phone number. This is the only location where you can change your address. Additionally you can also give a note to the driver on how to access your property. By clicking the submit button, it will validate your input and save it to the program. 

# Setup

# Installation

To install this program, you'll have to open up Git Bash in your ideal location. Then type this command down: <br>
<code> git clone https://github.com/AndrewCollin32/HotPlate-Online-Restaurant.git </code>
It will automatically download everything into your prefered file. 

# Setup_SQL

MySQL is required for this program. You'll need to create a database first before you can use this program. 

