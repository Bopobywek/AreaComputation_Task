/*
    Ответ на вопрос 3
 */

SELECT products.name, categories.name
FROM products
         LEFT JOIN products_categories
                   ON products.id = products_categories.product_id
         LEFT JOIN categories
                   ON products_categories.category_id = categories.id