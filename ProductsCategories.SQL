SELECT p.Name, c.Name
FROM Product p
LEFT JOIN ProductsCategories pc
    ON pc.CategoryId = p.Id
LEFT JOIN Category c
    ON c.Id = pc.CategoryId
