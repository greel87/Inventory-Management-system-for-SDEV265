  use invmanagdbtest;

Create Table if not exists Customer
(
Customer_ID INT UNSIGNED not null AUTO_INCREMENT PRIMARY KEY,
FName varchar(255) Not null,
Lname varchar(255) Not null,
Street varchar(255) Not null,
State_ID char(2) Not null,
Zip char(5) not null, 
Phone char(10) not null,
Email varchar(255)
);

Create Table if not exists Stock
(
UPC varchar(12)  PRIMARY KEY,
Prod_Name varchar(255) Not null,
Serial_Number_Required boolean Not null,
Quantity int unsigned not null,
Serial_number int
);

Create Table if not exists SFS
(
Serial_Number varchar(255) PRIMARY KEY,
UPC varchar(12) Not null,
Sold boolean not null,
Warranty boolean,

FOREIGN KEY (UPC) REFERENCES Stock(UPC)
);

Create Table if not exists F3000
(
Serial_Number varchar(255) PRIMARY KEY,
UPC varchar(12) Not null,
Sold boolean not null,
Warranty boolean,

FOREIGN KEY (UPC) REFERENCES Stock(UPC)
);

Create Table if not exists Orders
(
Order_ID int UNSIGNED not null  AUTO_INCREMENT PRIMARY KEY,
Customer_ID INT UNSIGNED not null,
Order_Date Date not null,

FOREIGN KEY (Customer_ID) REFERENCES customer(Customer_ID)
);

Create Table if not exists Order_Line
(
Order_ID int UNSIGNED not null,
UPC varchar(12),
Serial_Number varchar(255),
Quantity Int Unsigned,

PRIMARY KEY (Order_ID, UPC),
FOREIGN KEY (Order_ID) REFERENCES Orders(Order_ID),
FOREIGN KEY (UPC) REFERENCES Stock(UPC),
FOREIGN KEY (Serial_Number) REFERENCES SFS(Serial_Number),
FOREIGN KEY (Serial_Number) REFERENCES F3000(Serial_Number)
);
