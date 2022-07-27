## Вопрос №2
### Часть схемы базы данных взята из моего пробного проекта [Магазин пиццы](https://github.com/MikeKondr99/PizzaStoreSln)
*для огранизации связи многие-ко-многим использовалась
промежуточная таблица `CategoryProduct`*
```mermaid 
erDiagram
    Categories {
        string Name PK
    }

    Products {
        int Id PK
        string Name
        string Description
        string ImageSource
        float Price
        int Discount
        int InStock
    }


    CategoryProduct {
        int ProductId PK
        string categoriesName PK
    }

    Products ||--o{ CategoryProduct : in
    Categories ||--o{ CategoryProduct : in
```

Скрипт для получения всех пар "Имя продукта – Имя категории"

``` sql
SELECT Name, CategoryProduct.CategoriesName
FROM Products
LEFT JOIN CategoryProduct
ON Products.Id = CategoryProduct.ProductsId;
```