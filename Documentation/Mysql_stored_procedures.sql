   
use invmanagdbtest;

DELIMITER $$

Drop procedure if exists get_customers$$

CREATE PROCEDURE get_customers
(
	IN lname VARCHAR(255)
)
BEGIN
	SELECT * 
 	FROM customers
	WHERE Lname = lname;
END$$

DELIMITER ;

DELIMITER $$

Drop procedure if exists get_inventory$$

CREATE PROCEDURE get_inventory
(
	IN Product VARCHAR(255)
)
BEGIN
	SELECT * 
 	FROM stock
	WHERE Prod_Name = Product;
END$$

DELIMITER ;

DELIMITER $$
Drop procedure if exists add_customers$$

CREATE PROCEDURE add_customers 
(
	IN ID int(10),
    IN fname VARCHAR(255),
    IN lname VARCHAR(255),
    IN street VARCHAR(255),
    IN state_id char(2),
    IN zip char(5),
    IN phone char(10),
    IN email VARCHAR(255)
)
BEGIN
	 insert into customer
     (
         Customer_ID,
         Fname,
         Lname,
         Street,
         State_ID,
         Zip,
         Phone,
         Email
     )
     values
     (
         ID,
         fname,
         lname,
         street,
         state_id,
         zip,
         phone,
         email
     );
END$$

DELIMITER ;

DELIMITER $$

Drop procedure if exists add_new_stock$$

CREATE PROCEDURE add_new_stock 
(
	IN upc VARCHAR(12),
    IN prod_name VARCHAR(255),
    IN serial_number_required VARCHAR(255),
    IN quantity int,
    IN Serial_Number char(2)

)
BEGIN
	 insert into stock
     (
         UPC,
         Prod_Name,
         Serial_Number_Required,
         Quantity,
         serial_number
     )
     values
     (
         upc,
         prod_name,
         serial_number_required,
         quantity,
         Serial_Number
     );
END$$

DELIMITER ;

DELIMITER $$

Drop procedure if exists update_stock_add$$

CREATE PROCEDURE update_stock_add 
(
    IN prod_name VARCHAR(12),
    IN quantity int

)
BEGIN
	 UPDATE stock
     SET Quantity = Quantity + quantity
     WHERE Prod_Name = prod_name;
END$$

DELIMITER ;

DELIMITER $$

Drop procedure if exists update_stock_reduce$$

CREATE PROCEDURE update_stock_reduce
(
    IN prod_name VARCHAR(12),
    IN quantity int

)
BEGIN
	 UPDATE stock
     SET Quantity = Quantity - quantity
     WHERE Prod_Name = prod_name;
END$$

DELIMITER ;


DELIMITER $$

Drop procedure if exists update_customer$$

CREATE PROCEDURE update_customer 
(
    IN ID int(10),
    IN fname VARCHAR(255),
    IN lname VARCHAR(255),
    IN street VARCHAR(255),
    IN state_id char(2),
    IN zip char(5),
    IN phone char(10),
    IN email VARCHAR(255)

)
BEGIN
	 UPDATE customer
     SET Customer_ID = ID, fname = Fname, Lname = lname, 
     Street = street, State_ID = state_id, Zip = zip,
     Phone = phone, Email = email
     WHERE Lname = lname;
END$$

DELIMITER ;

DELIMITER $$

Drop procedure if exists delete_stock$$

CREATE PROCEDURE delete_stock 
(
    IN prod_name VARCHAR(12)

)
BEGIN
	 delete from stock
     where Prod_Name = prod_name;
END$$

DELIMITER ;

DELIMITER $$

Drop procedure if exists delete_customer$$

CREATE PROCEDURE delete_customer 
(
    IN lname VARCHAR(12)

)
BEGIN
	 delete from customer
     where Lname = lname;
END$$

DELIMITER ;