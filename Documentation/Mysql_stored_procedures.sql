   
use invmanagedbtest;

DELIMITER $$

Drop procedure if exists get_customers$$

CREATE PROCEDURE get_customers
(
	IN last VARCHAR(255)
)
BEGIN
	SELECT * 
 	FROM customer
	WHERE Lname = last;
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
    IN firstName VARCHAR(255),
    IN lastName VARCHAR(255),
    IN streetAddress VARCHAR(255),
    IN state_id_code char(2),
    IN zipCode char(5),
    IN phoneNumber char(10),
    IN emailAddress VARCHAR(255)
)
BEGIN
	 insert into customer
     (
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
         firstName,
         lastName,
         streetAddress,
         state_id_code,
         zipCode,
         phoneNumber,
         emailAddress
     );
END$$

DELIMITER ;

DELIMITER $$

Drop procedure if exists add_new_stock$$

CREATE PROCEDURE add_new_stock 
(
	IN upcVal VARCHAR(12),
    IN Product VARCHAR(255),
    IN quantityAmount int

)
BEGIN
	 insert into stock
     (
         UPC,
         Prod_Name,
         Quantity
     )
     values
     (
         upcVal,
         Product,
         quantityAmount
     );
END$$

DELIMITER ;

DELIMITER $$

Drop procedure if exists update_stock_add$$

CREATE PROCEDURE update_stock_add 
(
    IN Product VARCHAR(12),
    IN quantityAmount int

)
BEGIN
	 UPDATE stock
     SET Quantity = Quantity + quantityAmount
     WHERE Prod_Name = Product;
END$$

DELIMITER ;

DELIMITER $$

Drop procedure if exists update_stock_reduce$$

CREATE PROCEDURE update_stock_reduce
(
    IN Product VARCHAR(12),
    IN quantityAmount int

)
BEGIN
	 UPDATE stock
     SET Quantity = Quantity - quantityAmount
     WHERE Prod_Name = Product;
END$$

DELIMITER ;


DELIMITER $$

Drop procedure if exists update_customer$$

CREATE PROCEDURE update_customer 
(
    IN firstName VARCHAR(255),
    IN lastName VARCHAR(255),
    IN streetAddress VARCHAR(255),
    IN state_id_code char(2),
    IN zipCode char(5),
    IN phoneNumber char(10),
    IN emailAddress VARCHAR(255)
)
BEGIN
	 UPDATE customer
     SET Fname = firstName, Lname = lastName, 
     Street = streetAddress, State_ID = state_id_code, Zip = zipcode,
     Phone = phoneNumber, Email = emailAddress
     WHERE Lname = lastName;
END$$

DELIMITER ;

DELIMITER $$

Drop procedure if exists delete_stock$$

CREATE PROCEDURE delete_stock 
(
    IN Product VARCHAR(12)

)
BEGIN
	 delete from stock
     where Prod_Name = Product;
END$$

DELIMITER ;

DELIMITER $$

Drop procedure if exists delete_customer$$

CREATE PROCEDURE delete_customer 
(
    IN lastName VARCHAR(12)

)
BEGIN
	 delete from customer
     where Lname = lastName;
END$$

DELIMITER ;