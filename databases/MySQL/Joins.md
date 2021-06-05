# SQL Joins

- `(INNER) JOIN`
  Returns records that have matching values in both tables
  
  - **Compares each** row from the **first table** with everyrow from the **second table**.
  
  - **Values both rows** cause **join condition evaluates** to **true** --> creates a **new row** whose column **contains all columns** of the **two rows** from **both tables** and include this new row in the final result set
  
  - ```sql
    SELECT column_list
    FROM table_1
    INNER JOIN table_2 ON join_condition;
    ```

- `LEFT (OUTER) JOIN`
  Returns all records from the left table, and the matched records from the right table
  
  - **Selects data starting** from the **left table**. For **each row** in the **left table**, the left join **compares** with every row in the **right table**. 
  
  - **Values both two rows** cause the **join condition evaluates** to **true** --> **creates** a **new row** whose columns contain **all columns** of the rows in both tables and includes this row in the result set
  
  - If the **values** in the **two rows** are **not matched**, the left join clause still **creates** a **new row** whose columns **contains columns of the row in the left table** and **`NULL` for columns of the row in the right table**
  
  - ```sql
    SELECT column_list 
    FROM table_1 
    LEFT JOIN table_2 ON join_condition;
    ```

- `RIGHT (OUTER) JOIN`
  Returns all records from the right table, and the matched records from the left table
  
  - Similar to the left join clause except that the treatment of tables is reversed. The right join starts selecting data from the right table instead of the left table.
  
  - ```sql
    SELECT column_list 
    FROM table_1 
    RIGHT JOIN table_2 ON join_condition;
    ```

- `CROSS JOIN`
  Returns all records when there is a match in either left or right table
  
  - The result set will include **all rows** from **both tables**, where **each row** is the **combination** of the **row** in the **first table** with the **row** in the **second table**.
  
  - ```sql
    SELECT * FROM t1
    CROSS JOIN t2;
    ```

![](joins.png)


