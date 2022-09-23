# Supermarket

Die Tabellen müssen auf die Datenbank ausgeführt werden, sowie der Connectionstring muss angepasst werden.

Zusätzlich müssen die claims bei angelegten Users hinzugefügt werden

SELECT * FROM AspNetUsers

SELECT * FROM AspNetUserClaims

insert into AspNetUserClaims values('4917d1d6-ba20-4b08-a3ef-873244817e68','Position','Admin')
insert into AspNetUserClaims values('e56bd087-916c-457b-b84e-850a4de0f1e9','Position','Cashier')

Die GUID hierbei ist die UserId aus AspNetUsers