SELECT Products.name, Categories.name
	FROM Products
	LEFT JOIN Listing
		ON Products.id = Listing.productID
	LEFT JOIN Categories
		ON Listing.categoryID = Categories.id