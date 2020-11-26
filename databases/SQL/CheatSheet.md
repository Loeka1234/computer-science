# SQL

### SELECT: Syntax

| SELECT-component <br/>FROM-component<br/>[WHERE-component]<br/> [GROUP BY-component]<br/> [HAVING-component]<br/> [ORDER BY-component] |
|:--------------------------------------------------------------------------------------------------------------------------------------:|

HAVING can only be used when the GROUP BY-component is used.

### SELECT: pseudonym

Example: 

```sql
SELECT foo FROM bar AS b WHERE b.baz = 'foo';
SELECT foo FROM bar b WHERE b.baz = 'foo';
```

**Mandatory use** example:

```sql
SELECT p.playernr, p.name
FROM players as p, players as search
WHERE search.name = 'Loeka' AND p.birthdate < search.birthdate;
```

### SELECT: `DISTINCT`

Inside a table, a column often contains many duplicate values; and sometimes you only want to list the different (distinct) values.

Syntax:

```sql
SELECT DISTINCT Country FROM Customers;
```

### WHERE: operators

Comparison operators:

| =   | Equal                    |
|:---:|:------------------------:|
| >   | Greater than             |
| <   | Less than                |
| >=  | Greater than or equal to |
| <=  | Less than or equal to    |
| <>  | Not equal to             |

Other operators: `AND`, `OR`, `NOT`, `BETWEEN`, `IN`

- `AND`

- `OR`

- `NOT`

- `BETWEEN`:
  
  - ```sql
    SELECT column_name(s)
    FROM table_name
    WHERE column_name BETWEEN value1 AND value2;
    ```

- `IN`:
  
  - ```sql
    SELECT column_name(s)
    FROM table_name
    WHERE column_name IN (value1, value2, ...);
    ```

- `LIKE`:
  
  - ```sql
    SELECT column1, column2, ...
    FROM table_name
    WHERE columnN LIKE pattern;
    ```
  
  - Pattern example: `'loeka%'`
  
  - `%`:  represents zero, one, or multiple characters
  
  - `_`: represents a single character
  
  - `LIKE '30!%' ESCAPE '!'`: Instructs the `LIKE` operator to treat the `%` after the `!` as a regular character.

- `IS NULL`

Subquery:

```sql
SELECT name FROM players
WHERE playernr in (
    SELECT playernr FROM matches WHERE teamnr = 1
)
ORDER BY name;
```


