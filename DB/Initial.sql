CREATE SCHEMA shop;

CREATE TABLE shop.product (
    product_id INT PRIMARY KEY IDENTITY(1,1),
    product_name NVARCHAR(100) NOT NULL
);

CREATE TABLE shop.category (
    category_id INT PRIMARY KEY IDENTITY(1,1),
    category_name NVARCHAR(100) NOT NULL
);

CREATE TABLE shop.product_category (
    product_id INT NOT NULL,
    category_id INT NOT NULL,
    PRIMARY KEY (product_id, category_id),
    FOREIGN KEY (product_id) REFERENCES shop.product(product_id),
    FOREIGN KEY (category_id) REFERENCES shop.category(category_id)
);

INSERT INTO shop.product (product_name) VALUES ('bread');
INSERT INTO shop.product (product_name) VALUES ('milk');
INSERT INTO shop.product (product_name) VALUES ('apple');
INSERT INTO shop.product (product_name) VALUES ('audi');
INSERT INTO shop.product (product_name) VALUES ('duck');

INSERT INTO shop.category (category_name) VALUES ('food');
INSERT INTO shop.category (category_name) VALUES ('drink');
INSERT INTO shop.category (category_name) VALUES ('technic');
INSERT INTO shop.category (category_name) VALUES ('car');

INSERT INTO shop.product_category (product_id, category_id) VALUES (1, 1);
INSERT INTO shop.product_category (product_id, category_id) VALUES (2, 2);
INSERT INTO shop.product_category (product_id, category_id) VALUES (3, 1);
INSERT INTO shop.product_category (product_id, category_id) VALUES (4, 3);
INSERT INTO shop.product_category (product_id, category_id) VALUES (4, 4);

SELECT 
    p.product_name,
    c.category_name
FROM 
    shop.product p
LEFT JOIN 
    shop.product_category pc ON p.product_id = pc.product_id
LEFT JOIN 
    shop.category c ON pc.category_id = c.category_id;
    