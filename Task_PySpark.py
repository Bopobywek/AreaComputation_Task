# В задании между таблицами существует связь многие-ко-многим. 
# Которая привычным образом реализуется через доп. таблицу.
# Так, например, sql-запрос для решения такой задачи приведен в файле Task_SQL.sql
# Однако в задаче указано, что датафрейма всего 2. Из чего можно предположить, что
# датафреймы состоят из следующих колонок:
# Products(id, product_name), Categories(id, category_name, product_id)
# Тогда

def solve(products: pyspark.sql.Dataframe, categories: pyspark.sql.Dataframe):
    result = products.join(categories, products.id == categories.product_id, how='outer')
    return result.select('product_name', 'category_name')