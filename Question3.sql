SELECT p.[Имя продукта], c.[Имя категории] 
    FROM [продуты] p 
    LEFT JOIN [ПродуктыКатегории] pc ON p.[ключ продукта] = pc.[ключ продукта] 
    LEFT JOIN [категории] c ON pc.[ключ категории] = c.[ключ категории];