CREATE PROCEDURE GetClients
AS
BEGIN
    SELECT FirstName, LastName, ID FROM Clients
END
