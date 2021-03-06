# CRM Web API Documentation

BetConstruct Coding Bootcamp team Bet-D

Narek Yegoryan, Meri Sahakyan

Microsoft Innovation Center Armenia

State Engineering University of Armenia, Building #10, 6th Floor

Yerevan

## Contacts
* Get (returns all contacts from database)
* Put (updates specific contact)
* Post (creates new contact)
* Delete (deletes contact by GuId)
* Delete (deletes contact by GuId list)
* Post (uploads contacts from Excel or CSV file to database)
* Post (returns contacts by paiges filtered and ordered by specific fields)


## Email Lists

* Get (returns all email lists from database)
* Get By Id (returns specific email list and contacts of that list)
* Post (creates new email list)
* Put (updates specific email list)
* Put (updates specific email list contacts)
* Delete (deletes all contacts from given emaillist)
* Delete (deletes email list by Id)

## Send Email
* Post (sends emails to contacts by contacts guid list, and template id)
* Post (sends emails to contacts by email list id and template id)

## Email Templates
* Get (returns all templates from database)

## Accounts
* Get (returns all users in database)
* Get (resets database to stock)
* Delete (deletes user by guid)
* Put (updates user information)
* Post (creates new user)

# 1 Contacts

## <b>1.1 Get</b> </br>
Gets all contacts from database without email lists</br></br>
<b>Request</b></br>
<table>
<tr>
<td>Method</td>
<td>URL</td>
</tr>
<tr>
<td>Get</td>
<td><a href="http://crmbetd.azurewebsitesnet/api/contacts">http://crmbetd.azurewebsitesnet/api/contacts</a></td>
</tr>
</table>

<b>Response</b>

<table>
<tr>
<td>Status Code</td>
<td>Responce Body</td>
</tr>
<tr>
<td>200 OK</td>
<td>{ "Full Name": "Aghasi Lorsabyan", "Company Name": "TUMO", "Position": "Mentor", "Country": "Armenia", "Email": "lorsabyan@gmail.com", "GuID": "1d8cecd5-2d4c-43c1-bcd1-085664eb6bdc" }, { "Full Name": "Siranush Aslanyan", "Company Name": "Mic Armenia", "Position": "Developer", "Country": "Armenia", "Email": "siranushik94@gmail.com", "GuID": "7d4866ed-4cc1-40c1-a552-ee28f4cacee6" } ]</td>
</tr>
<tr>
<td>400</td>
<td>Exception and InnerException Message</td>
</tr>
<tr>
<td>404</td>
<td></td>
</tr>
</table>


## <b>1.2 Put</b> </br>
Updates specific contact</br></br>
<b>Request</b></br>
<table>
<tr>
<td>Method</td>
<td>URL</td>
</tr>
<tr>
<td>Put</td>
<td><a href="http://crmbetd.azurewebsitesnet/api/contacts">http://crmbetd.azurewebsitesnet/api/contacts</a></td>
</tr>
</table>

<table>
<tr>
<td>Type</td>
<td>Values</td>
</tr>
<tr>
<td>Post_Body_Param</td>
<td>{ "FullName": "Narek Yegoryan", "CompanyName": "Mic Armenia", "Position": "Back-End Developer", "Country": "Armenia", "Email": "yegoryan.narek@gmail.com", "GuID": "943d9186-6350-4ecb-a826-048a0306228a", "EmailLists": [1, 2] } The "EmailLists": field is optional and can be ignored in request (in this case the email lists of contact will not be changed)</td>
</tr>
</table>

<b>Response</b>
<table>
<tr>
<td>Status</td>
<td>Responce</td>
</tr>
<tr>
<td>200 OK</td>
<td>{ "FullName": "Narek Yegoryan", "CompanyName": "Mic Armenia", "Position": "Back-End Developer", "Country": "Armenia", "Email": "yegoryan.narek@gmail.com", "GuID": "943d9186-6350-4ecb-a826-048a0306228a", "EmailLists": [1, 2] } The "EmailLists": field is optional and can be ignored in request (in this case the email lists of contact will not be changed)</td>
</tr>
<tr>
<td>404</td>
<td>If in database Contact with such guid is not found</td>
</tr>
<tr>
<td>400</td>
<td>Exception and InnerException Message</td>
</tr>
</table>

## <b>1.3 Post</b> </br>
Creates new contact</br></br>
<b>Request</b></br>
<table>
<tr>
<td>Method</td>
<td>URL</td>
</tr>
<tr>
<td>Put</td>
<td><a href="http://crmbetd.azurewebsitesnet/api/contacts">http://crmbetd.azurewebsitesnet/api/contacts</a></td>
</tr>
</table>

<table>
<tr>
<td>Type</td>
<td>Values</td>
</tr>
<tr>
<td>Post_Body_Param</td>
<td>{ "FullName": "Narek Yegoryan", "CompanyName": "Mic Armenia", "Position": "Back-End Developer", "Country": "Armenia", "Email": "yegoryan.narek@gmail.com", "GuID": "943d9186-6350-4ecb-a826-048a0306228a", "EmailLists": [1, 2] } The "EmailLists": field is optional and can be ignored in request (in this case the email lists of contact will not be changed)</td>
</tr>
</table>

<b>Response</b>
<table>
<tr>
<td>Status</td>
<td>Responce</td>
</tr>
<tr>
<td>200 OK</td>
<td>{ "FullName": "Narek Yegoryan", "CompanyName": "Mic Armenia", "Position": "Back-End Developer", "Country": "Armenia", "Email": "yegoryan.narek@gmail.com", "GuID": "943d9186-6350-4ecb-a826-048a0306228a", "EmailLists": [1, 2] } The "EmailLists": field is optional and can be ignored in request (in this case the email lists of contact will not be changed)</td>
</tr>
<tr>
<tr>
<td>400</td>
<td>Exception and InnerException Message</td>
</tr>
</table>

## <b>1.4 Delete (by GuID)</b> </br>
Deletes contact by GuID</br></br>
<b>Request</b></br>
<table>
<tr>
<td>Method</td>
<td>URL</td>
</tr>
<tr>
<td>Delete</td>
<td><a href="http://crmbetd.azurewebsites.net/api/contacts?guid=a1e1ce1c-2c04-494b-add1-340bad88b6e8">http://crmbetd.azurewebsites.net/api/contacts?guid=a1e1ce1c-2c04-494b-add1-340bad88b6e8</a></td>
</tr>
</table>

<table>
<tr>
<td>Type</td>
<td>Param Name</td>
<td>Values</td>
</tr>
<tr>
<td>URL_PARAM</td>
<td>guid</td>
<td>dab7e4fb-171f-4e65-8a5a-7640fb113fe5</td>
</tr>
</table>

<b>Response</b>
<table>
<tr>
<td>Status</td>
<td>Responce</td>
</tr>
<tr>
<td>200 OK</td>
<td></td>
</tr>
<tr>
<tr>
<td>400</td>
<td>Exception and InnerException Message</td>
</tr>
<tr>
<td>404</td>
<td>If in database Contact with such guid is not found</td>
</tr>
</table>

## <b>1.5 Delete (by GuID list)</b> </br>
Deletes contact by GuID list</br></br>
<b>Request</b></br>
<table>
<tr>
<td>Method</td>
<td>URL</td>
</tr>
<tr>
<td>Delete</td>
<td><a href="http://crmbetd.azurewebsites.net/api/contacts?guid=a1e1ce1c-2c04-494b-add1-340bad88b6e8">http://crmbetd.azurewebsites.net/api/contacts?guid=a1e1ce1c-2c04-494b-add1-340bad88b6e8</a></td>
</tr>
</table>

<table>
<tr>
<td>Type</td>

<td>Values</td>
</tr>
<tr>
<td>Delete_Body_Param</td>

<td>[ "b3e48661-7979-440d-bf33-c8da8ed2cb62, "dab7e4fb-171f-4e65-8a5a-7640fb113fe5", "e621e4c4-5d33-48de-8b36-2596066e4617", "B3b91410-6c3b-42e3-b90b-c0ef9298be58" ]</td>
</tr>
</table>

<b>Response</b>
<table>
<tr>
<td>Status</td>
<td>Responce</td>
</tr>
<tr>
<td>200 OK</td>
<td></td>
</tr>
<tr>
<tr>
<td>400</td>
<td>Exception and InnerException Message</td>
</tr>
<tr>
<td>404</td>
<td>If in database Contact with such guid is not found</td>
</tr>
</table>

## <b>1.6 Post (file uploading)</b> </br>
Uploads Excel or CSV file of contacts into database</br></br>
<b>Request</b></br>
<table>
<tr>
<td>Method</td>
<td>URL</td>
</tr>
<tr>
<td>Post</td>
<td><a href="http://crmbetd.azurewebsites.net/api/contacts/upload">http://crmbetd.azurewebsites.net/api/contacts/upload</a></td>
</tr>
</table>

<b>Use the following formats to upload contacts into csv and excel</b><br>

<table>
<tr>
<td>Excel file</td>
</tr>
<tr>
<td>CSV file</td>
</tr>
<tr>
<td>
FullName,CompanyName,Position,Country,Email Name1,Company1,Position 1,Country1,samplemail25@gmail.com Name2,Company2,Position 2,Country2,samplemail26@gmail.com Name3,Company3,Position 3,Country3,samplemail27@gmail.com Name4,Company4,Position 4,Country4,samplemail28@gmail.com Name5,Company5,Position 5,Country5,samplemail29@gmail.com Name6,Company6,Position,Country6,samplemail30@gmail.com Name7,Company7,Position,Country7,samplemail31@gmail.com Name8,Company8,Position 8,Country8,samplemail32@gmail.com Name9,Company9,Position,Country9,samplemail33@gmail.com
</td>
</tr>
</table>

<b>Response</b>
<table>
<tr>
<td>Status</td>
<td>Responce</td>
</tr>
<tr>
<td>200 OK</td>
<td></td>
</tr>
<tr>
<tr>
<td>400</td>
<td>Exception and InnerException Message</td>
</tr>

</table>

## <b>1.7 Post (Query Contacts)</b> </br>
Returns contacts by paiges filtered and ordered by specific fields</br></br>
<b>Request</b></br>
<table>
<tr>
<td>Method</td>
<td>URL</td>
</tr>
<tr>
<td>Post</td>
<td><a href="http://crmbetd.azurewebsites.net/api/contacts/filter">http://crmbetd.azurewebsites.net/api/contacts/filter</a></td>
</tr>
</table>

<table>
<tr>
<td>Type</td>
<td>Values</td>
</tr>
<tr>
<td>Post_Body_Param</td>
<td>{ "FullName": "Narek Yegoryan", "CompanyName": "Mic Armenia", "Position": "Back-End Developer", "Country": "Armenia", "Email": "yegoryan.narek@gmail.com", "GuID": "943d9186-6350-4ecb-a826-048a0306228a", "EmailLists": [1, 2] } The "EmailLists": field is optional and can be ignored in request (in this case the email lists of contact will not be changed)</td>
</tr>
</table>


<b>Response</b>
<table>
<tr>
<td>Status</td>
<td>Responce</td>
</tr>
<tr>
<td>200 OK</td>
<td>Response is Key Value pair, where key is number of pagies, and value is list of Contacts { "Key": 2, "Value": [ { "Full Name": "Tsovinar Ghazaryan", "Company Name": "MIC Armenia", "Position": "Developer", "Country": "Armenia", "Email": "tsovinar.ghazaryan@yahoo.com", "GuID": "03fba3cf-86fc-4618-a711-e636345e40c4" } ] }</td>
</tr>
<tr>
<tr>
<td>400</td>
<td>Exception and InnerException Message</td>
</tr>
<tr>
<td>404</td>
<td>If Email List with such id is not found in database</td>
</tr>
</table>

# 2 Email Lists
## <b>2.1 Get</b>
Gets all email lists from database without contacts
<b>Request</b></br>
<table>
<tr>
<td>Method</td>
<td>URL</td>
</tr>
<tr>
<td>Get</td>
<td><a href="http://crmbetd.azurewebsites.net/api/emaillists">http://crmbetd.azurewebsites.net/api/emaillists</a></td>
</tr>
</table>
<b>Response</b>
<table>
<tr>
<td>Status</td>
<td>Responce</td>
</tr>
<tr>
<td>200 OK</td>
<td>[ { "EmailListID": 1, "EmailListName": "All" }, { "EmailListID": 2, "EmailListName": "VIP Partners" } ]</td>
</tr>
<tr>
<tr>
<td>400</td>
<td>Exception and InnerException Message</td>
</tr>
<tr>
<td>404</td>
<td></td>
</tr>
</table>

## <b>2.2 Get (by id)</b>
Gets specific email list by Id</br>
<b>Request</b></br>
<table>
<tr>
<td>Method</td>
<td>URL</td>
</tr>
<tr>
<td>Get</td>
<td><a href="http://crmbetd.azurewebsites.net/api/emaillists?id=1">http://crmbetd.azurewebsites.net/api/emaillists?id=1</a></td>
</tr>
</table>

<table>
<tr>
<td>Type</td>
<td>Param Name</td>
<td>Value</td>
</tr>
<tr>
<td>URL_PARAM</td>
<td>id</td>
<td>integer</td>
</tr>
</table>

<b>Response</b>
<table>
<tr>
<td>Status</td>
<td>Responce</td>
</tr>
<tr>
<td>200 OK</td>
<td>{ "EmailListID": 1, "EmailListName": "All", "Contacts": [ { "Full Name": "Aghasi Lorsabyan", "Company Name": "TUMO", "Position": "Mentor", "Country": "Armenia", "Email": "lorsabyan@gmail.com", "GuID": "1d8cecd5-2d4c-43c1-bcd1-085664eb6bdc" } ] }</td>
</tr>
<tr>
<tr>
<td>400</td>
<td>Exception and InnerException Message</td>
</tr>
<tr>
<td>404</td>
<td></td>
</tr>
</table>


## <b>2.3 Post (creates email list)</b>
Creates new email list</br>
<b>Request</b></br>
<table>
<tr>
<td>Method</td>
<td>URL</td>
</tr>
<tr>
<td>Post</td>
<td><a href="http://crmbetd.azurewebsites.net/api/emaillists">http://crmbetd.azurewebsites.net/api/emaillists</a></td>
</tr>
</table>

<table>
<tr>
<td>Type</td>

<td>Value</td>
</tr>
<tr>
<td>Post_Body_Param</td>

<td>{ "EmailListName": "All 2", "Contacts": [ "1d8cecd5-2d4c-43c1-bcd1-085664eb6bdc", "943d9186-6350-4ecb-a826-048a0306228a" ] }
The "Contacts": field is optional and can be ignored in request (in this case the created email list will be empty)</td>
</tr>
</table>

<b>Response</b>
<table>
<tr>
<td>Status</td>
<td>Responce</td>
</tr>
<tr>
<td>200 OK</td>
<td>{ "EmailListID": 22, "EmailListName": "All 2", "Contacts": [ { "Full Name": "Aghasi Lorsabyan", "Company Name": "TUMO", "Position": "Mentor", "Country": "Armenia", "Email": "lorsabyan@gmail.com", "GuID": "1d8cecd5-2d4c-43c1-bcd1-085664eb6bdc" }, { "Full Name": "meri Sahakyan", "Company Name": "Mic Armenia", "Position": "Developer", "Country": "Armenia", "Email": "sahakyan_m@bk.ru", "GuID": "943d9186-6350-4ecb-a826-048a0306228a" } ] }</td>
</tr>
<tr>
<tr>
<td>400</td>
<td>Exception and InnerException Message</td>
</tr>
<tr>
<td>500</td>
<td></td>
</tr>
</table>

## <b>2.4 Put (updates email list)</b>
Updates specific email list</br>
<b>Request</b></br>
<table>
<tr>
<td>Method</td>
<td>URL</td>
</tr>
<tr>
<td>Put</td>
<td><a href="http://crmbetd.azurewebsites.net/api/emaillists">http://crmbetd.azurewebsites.net/api/emaillists</a></td>
</tr>
</table>

<table>
<tr>
<td>Type</td>

<td>Value</td>
</tr>
<tr>
<td>Post_Body_Param</td>

<td>{ "EmailListName": "All 2", "Contacts": [ "1d8cecd5-2d4c-43c1-bcd1-085664eb6bdc", "943d9186-6350-4ecb-a826-048a0306228a" ] }
The "Contacts": field is optional and can be ignored in request (in this case the created email list will be empty)</td>
</tr>
</table>

<b>Response</b>
<table>
<tr>
<td>Status</td>
<td>Responce</td>
</tr>
<tr>
<td>200 OK</td>
<td>{ "EmailListID": 22, "EmailListName": "All 2", "Contacts": [ { "Full Name": "Aghasi Lorsabyan", "Company Name": "TUMO", "Position": "Mentor", "Country": "Armenia", "Email": "lorsabyan@gmail.com", "GuID": "1d8cecd5-2d4c-43c1-bcd1-085664eb6bdc" }, { "Full Name": "meri Sahakyan", "Company Name": "Mic Armenia", "Position": "Developer", "Country": "Armenia", "Email": "sahakyan_m@bk.ru", "GuID": "943d9186-6350-4ecb-a826-048a0306228a" } ] }</td>
</tr>
<tr>
<tr>
<td>400</td>
<td>Exception and InnerException Message</td>
</tr>
<tr>
<td>404</td>
<td>If email list with such id is not found in database</td>
</tr>
<tr>
<td>500</td>
<td></td>
</tr>
</table>


## <b>2.5 Put (updates email list contacts)</b>
Adds specific email list contacts.</br>
<b>Request</b></br>
<table>
<tr>
<td>Method</td>
<td>URL</td>
</tr>
<tr>
<td>Put</td>
<td><a href="http://crmbetd.azurewebsites.net/api/emaillists">http://crmbetd.azurewebsites.net/api/emaillists</a></td>
</tr>
</table>

<table>
<tr>
<td>Type</td>

<td>Value</td>
</tr>
<tr>
<td>Post_Body_Param</td>

<td>{ "EmailListName": "All 2", "Contacts": [ "1d8cecd5-2d4c-43c1-bcd1-085664eb6bdc", "943d9186-6350-4ecb-a826-048a0306228a" ] }
The "Contacts": field is optional and can be ignored in request (in this case the created email list will be empty)</td>
</tr>
</table>

<b>Response</b>
<table>
<tr>
<td>Status</td>
<td>Responce</td>
</tr>
<tr>
<td>200 OK</td>
<td>{ "EmailListID": 22, "EmailListName": "All 2", "Contacts": [ { "Full Name": "Aghasi Lorsabyan", "Company Name": "TUMO", "Position": "Mentor", "Country": "Armenia", "Email": "lorsabyan@gmail.com", "GuID": "1d8cecd5-2d4c-43c1-bcd1-085664eb6bdc" }, { "Full Name": "meri Sahakyan", "Company Name": "Mic Armenia", "Position": "Developer", "Country": "Armenia", "Email": "sahakyan_m@bk.ru", "GuID": "943d9186-6350-4ecb-a826-048a0306228a" } ] }</td>
</tr>
<tr>
<tr>
<td>400</td>
<td>Exception and InnerException Message</td>
</tr>
<tr>
<td>500</td>
<td></td>
</tr>
</table>


## <b>2.6 Delete (deletes contacts)</b>
Deletes contacts from given email list</br>
<b>Request</b></br>
<table>
<tr>
<td>Method</td>
<td>URL</td>
</tr>
<tr>
<td>Delete</td>
<td><a href="http://crmbetd.azurewebsites.net/api/emaillists">http://crmbetd.azurewebsites.net/api/emaillists</a></td>
</tr>
</table>

<table>
<tr>
<td>Type</td>

<td>Value</td>
</tr>
<tr>
<td>Post_Body_Param</td>

<td>{ "EmailListName": "All 2", "Contacts": [ "1d8cecd5-2d4c-43c1-bcd1-085664eb6bdc", "943d9186-6350-4ecb-a826-048a0306228a" ] }
The "Contacts": field is optional and can be ignored in request (in this case the created email list will be empty)</td>
</tr>
</table>

<b>Response</b>
<table>
<tr>
<td>Status</td>
<td>Responce</td>
</tr>
<tr>
<td>200 OK</td>
<td></td>
</tr>
<tr>
<tr>
<td>400</td>
<td>Exception and InnerException Message</td>
</tr>
<tr>
<td>404</td>
<td>If email list with such guid is not found in database</td>
</tr>
</table>

## <b>2.7 Delete (by id)</b>
Deletes the specific email list by Id</br>
<b>Request</b></br>
<table>
<tr>
<td>Method</td>
<td>URL</td>
</tr>
<tr>
<td>Delete</td>
<td><a href="http://crmbetd.azurewebsites.net/api/emaillists?id=1">http://crmbetd.azurewebsites.net/api/emaillists?id=1</a></td>
</tr>
</table>

<table>
<tr>
<td>Type</td>
<td>Param Name</td>
<td>Value</td>
</tr>
<tr>
<td>URL_PARAM</td>
<td>id</td>
<td>integer</td>
</tr>
</table>

<b>Response</b>
<table>
<tr>
<td>Status</td>
<td>Responce</td>
</tr>
<tr>
<td>200 OK</td>
<td></td>
</tr>
<tr>
<tr>
<td>400</td>
<td>Exception and InnerException Message</td>
</tr>
<tr>
<td>404</td>
<td>If email list with such guid is not found in database</td>
</tr>
</table>

# 3 Send Email
## 3.1 Post
Sends emails to contacts by guid</br>
<b>Request</b></br>
<table>
<tr>
<td>Method</td>
<td>URL</td>
</tr>
<tr>
<td>Post</td>
<td><a href="http://crmbetd.azurewebsites.net/api/sendemail?templateid=1">http://crmbetd.azurewebsites.net/api/sendemail?templateid=1</a></td>
</tr>
</table>

<table>
<tr>
<td>Type</td>
<td>Param Name</td>
<td>Value</td>
</tr>
<tr>
<td>URL_PARAM</td>
<td>templateid</td>
<td>integer</td>
</tr>
<tr>
<td>Post_Body_Param</td>
<td>Array of Guids</td>
<td>[ "b3e48661-7979-440d-bf33-c8da8ed2cb62, "Dab7e4fb-171f-4e65-8a5a-7640fb113fe5" ]</td>
</tr>
</table>
<b>Response</b>
<table>
<tr>
<td>Status</td>
<td>Responce</td>
</tr>
<tr>
<td>200 OK</td>
<td></td>
</tr>
<tr>
<tr>
<td>400</td>
<td></td>
</tr>
<tr>
<td>500</td>
<td></td>
</tr>
</table>

## 3.2 Post
Sends emails to contacts by email list id</br>
<b>Request</b></br>
<table>
<tr>
<td>Method</td>
<td>URL</td>
</tr>
<tr>
<td>Post</td>
<td><a href="http://crmbetd.azurewebsites.net/api/sendemailtemplateid=1&id=1">http://crmbetd.azurewebsites.net/api/sendemail/templateid=1&id=1</a></td>
</tr>
</table>

<table>
<tr>
<td>Type</td>
<td>Param Name</td>
<td>Value</td>
</tr>
<tr>
<td>URL_PARAM</td>
<td>templateid</td>
<td>integer</td>
</tr>
<tr>
<td>Post_Body_Param</td>
<td>id</td>
<td>integer</td>
</tr>
</table>
<b>Response</b>
<table>
<tr>
<td>Status</td>
<td>Responce</td>
</tr>
<tr>
<td>200 OK</td>
<td></td>
</tr>
<tr>
<tr>
<td>400</td>
<td></td>
</tr>
<tr>
<td>500</td>
<td></td>
</tr>
</table>

# 4 Email Templates
## 4.1 Get
Gets all templates
<b>Request</b></br>
<table>
<tr>
<td>Method</td>
<td>URL</td>
</tr>
<tr>
<td>Get</td>
<td><a href="http://crmbetd.azurewebsites.net/api/template">http://crmbetd.azurewebsites.net/api/template</a></td>
</tr>
</table>

<b>Response</b>
<table>
<tr>
<td>Status</td>
<td>Responce</td>
</tr>
<tr>
<td>200 OK</td>
<td>An array of templates [ { "TemplateId": 1, "TemplateName": "NewYear.html" }, { "TemplateId": 2, "TemplateName": "BirthdayWish.html" }, { "TemplateId": 3, "TemplateName": "LabourDay.html" } ]</td>
</tr>
<tr>
<tr>
<td>400</td>
<td>Exception and InnerException Message</td>
</tr>
<tr>
<td>404</td>
<td></td>
</tr>
<tr>
<td>500</td>
<td></td>
</tr>
</table>

# 5 Accounts
## 5.1 Get 
Returns all users in database </br>
<b>Request</b></br>
<table>
<tr>
<td>Method</td>
<td>URL</td>
</tr>
<tr>
<td>Get</td>
<td><a href="http://crmbetd.azurewebsites.net/api/account/admin/users">http://crmbetd.azurewebsites.net/api/account/admin/users</a></td>
</tr>
</table>
<b>Response</b>

<table>
<tr>
<td>Status Code</td>
<td>Responce</td>
</tr>
<tr>
<td>200 OK</td>
<td>[{ "UserName": "username", "PhoneNumber": "099999999", "Email": "simple@gmail.com", "Password": "passord1"},{ "UserName": "username2", "PhoneNumber": "099999991", "Email": "simple2@gmail.com", "Password": "password2"]</td>
</tr>
<tr>
<td>400</td>
<td>Exception and InnerException Message</td>
</tr>
<tr>
<td>404</td>
<td></td>
</tr>
</table>

## 5.2 Get (reset)
Resets database to stock </br>
<b>Request</b></br>
<table>
<tr>
<td>Method</td>
<td>URL</td>
</tr>
<tr>
<td>Get</td>
<td><a href="http://crmbetd.azurewebsites.net/api/account/reset">http://crmbetd.azurewebsites.net/api/account/reset</a></td>
</tr>
</table>
<b>Response</b>

<table>
<tr>
<td>Status Code</td>
<td>Responce</td>
</tr>
<tr>
<td>200 OK</td>
<td>"Reseted to defaults"</td>
</tr>
<tr>
<td>400</td>
<td></td>
</tr>
</table>

## 5.3 Delete
Deletes user by guid </br>
<b>Request</b></br>
<table>
<tr>
<td>Method</td>
<td>URL</td>
</tr>
<tr>
<td>Delete</td>
<td><a href="http://crmbetd.azurewebsites.net/api/account/admin/delete">http://crmbetd.azurewebsites.net/api/account/admin/delete</a></td>
</tr>
</table>
<table>
<tr>
<td>Type</td>

<td>Value</td>
</tr>
<tr>
<td>Post_Body_Param</td>

<td>{ [ "1d8cecd5-2d4c-43c1-bcd1-085664eb6bdc"] }</td>
</tr>
</table>
<b>Response</b>

<table>
<tr>
<td>Status Code</td>
<td>Responce</td>
</tr>
<tr>
<td>200 OK</td>
<td></td>
</tr>
<tr>
<td>400</td>
<td></td>
</tr>
<tr>
<td>404</td>
<td></td>
</tr>
</table>

## 5.4 Put
Updates user information </br>
<b>Request</b></br>
<table>
<tr>
<td>Method</td>
<td>URL</td>
</tr>
<tr>
<td>Put</td>
<td><a href="http://crmbetd.azurewebsites.net/api/account/admin/change">http://crmbetd.azurewebsites.net/api/account/admin/change</a></td>
</tr>
</table>

<b>Response</b>

<table>
<tr>
<td>Status Code</td>
<td>Responce</td>
</tr>
<tr>
<td>200 OK</td>
<td></td>
</tr>
<tr>
<td>400</td>
<td></td>
</tr>
<tr>
<td>404</td>
<td></td>
</tr>
</table>

## 5.5 Post
Creates new user </br>
<b>Request</b></br>
<table>
<tr>
<td>Method</td>
<td>URL</td>
</tr>
<tr>
<td>Post</td>
<td><a href="http://crmbetd.azurewebsites.net/api/account/register">http://crmbetd.azurewebsites.net/api/account/register</a></td>
</tr>
</table>

<b>Response</b>

<table>
<tr>
<td>Status Code</td>
<td>Responce</td>
</tr>
<tr>
<td>200 OK</td>
<td></td>
</tr>
<tr>
<td>400</td>
<td></td>
</tr>
<tr>
<td>404</td>
<td></td>
</tr>
</table>
