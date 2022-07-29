create database AddressBook_linq;
DROP TABLE AddressBookLinq;
create table AddressBookLinq(
  ID int, 
          FirstName varchar(200), 
         LastName varchar(200),
         Address varchar(200),
        City varchar(200),
        State varchar(200),
        Zip varchar(200),
        PhoneNumber varchar(200),
        Email varchar(200),
        AddressBookName varchar(200),
        AddressBookType varchar(200));
		select * from AddressBookLinq;


insert into AddressBookLinq values(  1, 'Gurpreet', 'Singh', 'Aberdeen Bazar', 'Port Blair', 'Andamans', '4232', '12345', 'gsgurpreet766@gmail.com', 'AddressBook1', 'Family' ),
(  2, 'Lokesh', 'Raj', 'School Line', 'Port Blair', 'Andamans', '4232', '12343', 'Kolki@gmail.com', 'AddressBook1', 'Friends' ),
(  3, 'jagan', 'rao', 'HCR', 'Hydrabad', 'Telangana', '4232', '12345', 'Jagan@gmail.com', 'AddressBook2', 'Professional' ),
(  4, 'jadesh', 'kumar', 'omr', 'Mahabalipuram', 'chennai', '4232', '12345', 'Jagesh@gmail.com', 'AddressBook1', 'Professional' ),
(  5, 'kavari', 'Kumari', 'HSG', 'VijayaWada', 'AndraPradesh', '4232', '12345', 'Kavari@gmail.com', 'AddressBook2', 'Friends' ),
(  6, 'Sekhar', 'Rao', 'DMR', 'VijayaWada', 'AndraPradesh', '4232', '12345', 'Vikadd@gmail.com', 'AddressBoo3', 'Family' ),
(  7, 'sheela', 'Kumari', 'Mount Road', 'Bengaluru', 'Karnataka', '4232', '12345', 'Sheela@gmail.com', 'AddressBook1', 'Friends' );
                