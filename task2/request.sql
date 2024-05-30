CREATE TABLE Categories (
    Name VARCHAR(255),
    Id SERIAL PRIMARY KEY
);

CREATE TABLE Products (
    Name VARCHAR(255),
    Id SERIAL PRIMARY KEY
);

CREATE TABLE ProductCategories (
    ProductId int,
    CategoryId int 
);

INSERT INTO Categories (Name) VALUES ('Celebrities');
INSERT INTO Products (Name) VALUES ('Magazine');
INSERT INTO ProductCategories (ProductId, CategoryId) VALUES (1, 1);

SELECT 
    P.Name AS ProductName,
    C.Name AS CategoryName
FROM 
    Products P
LEFT JOIN 
    ProductCategories PC ON P.Id = PC.ProductId
LEFT JOIN 
    Categories C ON PC.CategoryId = C.Id;
