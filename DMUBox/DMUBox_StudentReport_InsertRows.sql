CREATE PROCEDURE sprocInsertStudentRows

AS

-- DELETE FROM tblStudent;
-- DELETE FROM tblHall;

-- tblHall data --
-- HallNo:int, HallName:varchar(7), PostalAddress:varchar(13), PostCode:varchar(8) --

SET IDENTITY_INSERT tblHall ON
INSERT INTO tblHall (HallNo, HallName, PostalAddress, PostCode) VALUES (999, 'Citadel', 'Castle Street', ' LE1 5LX'); 
SET IDENTITY_INSERT tblHall OFF

-- tblStudent data --
-- StudentNo:varchar(9), Title:varchar(4), ForeName:varchar(11), FamilyName:varchar(17), HallNo:int, ApartmentNo:int --

INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765432','Mr','Andrew','Windsor', 1, 1);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765433','Ms','Andrea','Summer', 1, 2);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765434','Mr','Philip','Cramer', 1, 3);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765435','Ms','Ann','Devon', 1, 4);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765436','Mr','Francisco','Chang', 1, 5);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765437','Mr','Laurence','Lebihan', 1, 6);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765438','Mr','Paul','Henriot', 1, 7);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765439','Mr','Sven','Ottlieb', 1, 8);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765440','Ms','Rita','Muller', 1, 10);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765441','Ms','Maria','Pontes', 1, 11);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765442','Ms','Janine','Labrune', 1, 12);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765443','Mr','Carlos','Hernadez', 1, 14);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765444','Ms','Victoria','Ashworth', 1, 15);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765445','Ms','Lesley','Brown', 1, 16);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765446','Ms','Anabela','Domingues', 1, 17);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765447','Ms','Martine','Rance', 1, 18);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765448','Mr','Peter','Franken', 1, 19);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765449','Mr','Daniel','Tonini', 1, 20);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765450','Ms','Helen','Bennett', 1, 21);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765451','Mr','Paolo','Accorti', 1, 22);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765452','Ms','Elizabeth','Lincoln', 1, 23);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765453','Mr','Ranjit','Varkey Chudukatil', 1, 24);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765454','Ms','Ingrid','Burkhardt', 1, 25);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765455','Mr','Oscar','Alpuerto', 1, 26);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765456','Mr','Gary','Vargas', 1, 27);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765457','Mr','Shane','Kim', 1, 28);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765458','Ms','Joan','Campbell', 1, 29);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765459','Mr','Maxwell','Amland', 1, 30);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765460','Ms','Ramona','Antrim', 1, 31);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765461','Ms','Karan','Khanna', 1, 32);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765462','Ms','Sharon','Crow', 1, 33);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765511','Mr','Gary','Thomas', 2, 1);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765463','Mr','Imtiaz','Khan', 2, 2);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765464','Mr','Jack','Creasey', 2, 3);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765465','Ms','Teresa','Atkinson', 2, 4);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765466','Ms','Tammy','Khan', 2, 5);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765467','Mr','Bruno','Costa Da Silva', 2, 6);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765468','Mr','Krishna','Sunkammurali', 2, 7);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765469','Mr','Martin','Svoboda', 2, 8);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765470','Mr','Abraham','Swearengin', 2, 9);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765471','Mr','Dragan','Tomic', 2, 10);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765472','Mr','David','Givens', 2, 11);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765473','Ms','Diane','Tibbott', 2, 12);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765475','Ms','Yuping','Tian', 2, 14);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765476','Mr','John','Brooks', 2, 15);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765477','Mr','Nancy','McPhearson', 2, 16);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765478','Mr','Jinghao','Liu', 2, 17);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765479','Mr','Sandeep','Katyal', 2, 18);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765480','Mr','John','Kelly', 2, 19);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765481','Mr','Robert','Kelly', 2, 20);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765482','Mr','David','Lawrence', 2, 21);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765483','Mr','Vamsi','Kuppa', 2, 22);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765484','Ms','Jane','Greer', 2, 24);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765485','Mr','Deepak','Kumar', 2, 25);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765486','Mr','Christopher','Bright', 2, 26);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765487','Mr','Aidan','Delaney', 2, 27);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765488','Mr','Eric','Brumfield', 2, 28);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765489','Mr','Prashanth','Desai', 2, 29);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765490','Mr','Eugene','Kogan', 2, 30);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765491','Ms','Jane','Carmichael', 2, 31);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765492','Mr','William','Conner', 2, 32);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765493','Ms','Andrea','Thomsen', 2, 33);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765494','Mr','Scott','Colvin', 2, 34);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765495','Mr','Hao','Chen', 2, 35);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765496','Ms','Diane','Krane', 2, 36);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765497','Mr','Michael','Lee', 2, 37);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765498','Mr','Frank','Mart¡nez', 2, 38);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765499','Mr','Robert','Jones', 2, 39);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765500','Mr','James','McCoy', 2, 40);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765501','Mr','Sunil','Uppal', 2, 41);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765502','Mr','Richard','Irwin', 2, 42);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765503','Ms','Beth','Inghram', 2, 43);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765504','Ms','Phyllis','Tuffield', 2, 44);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765505','Mr','Richard','Byham', 2, 45);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765506','Ms','Janet','Gilliat', 2, 46);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765474','Ms','Helen','Meyer', 2, 47);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765514','Mr','Martin','Sommer', 999, 1);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765515','Mr','Roland','Mendel', 999, 2);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765516','Mr','Howard','Snyder', 999, 3);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765517','Mr','Timothy','O''Rourke', 999, 4);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765518','Ms','Karin','Josephs', 999, 5);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765519','Mr','Diego','Roel', 999, 6);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765520','Ms','Maria','Larsson', 999, 7);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765521','Ms','Paula','Parente', 999, 8);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765522','Ms','Margaret','Smith', 999, 9);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765523','Ms','Aria','Cruz', 999, 10);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765524','Mr','Miguel','Paolino', 999, 11);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765525','Mr','Yoshi','Latimer', 999, 12);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765527','Mr','Pedro','Afonso', 999, 14);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765528','Ms','Annette','Roulet', 999, 15);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765529','Mr','Helvetius','Nagy', 999, 16);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765530','Mr','Manuel','Pereira', 999, 17);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765531','Ms','Karla','Jablonski', 999, 18);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765532','Mr','Pirkko','Koskitalo', 999, 19);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765533','Ms','Patricia','McKenna', 999, 20);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765507','Ms','Wanda','Vernon', 999, 21);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765508','Mr','Matti','Karttunen', 999, 22);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765509','Mr','Palle','Ibsen', 999, 23);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765510','Ms','Mary','Saveley', 999, 24);
INSERT INTO tblStudent (StudentNo, Title, ForeName, FamilyName, HallNo, ApartmentNo) VALUES ('P98765526','Ms','Carine','Schmitt', 999, 25);


