# SQL

### SQL: Structure

- **DDL** (Data Definition Language): structural adjustments to the construction of the DB
  
  - `CREATE`
  
  - `DROP`
  
  - `ALTER`

- **DML** (Data Manipulation Language): data management in the DB
  
  - `SELECT`
  
  - `INSERT`
  
  - `UPDATE`
  
  - `DELETE`

- **DCL** (Data Control language): security procedures / user access
  
  - `CONNECT`
  
  - `COMMIT`
  
  - ...

## DDL: `Data Definition Language`

Elements in creating a database:

- Creation of tables with specification of fields and integrity rules

- Creation of keys: primary keys, alternative keys, reference keys

- Creation of indexes and their impact on the processing speed of the SQL statements

- Securing the data by granting user privileges

Creating **database**:

```sql
CREATE DATABASE DatabaseName;
```

Creating **table**:

1. ```sql
   CREATE TABLE tableName
   (
       myNr      bigint auto_increment primary key,
       name      varchar(25) not null,
       birthDate date,
       price     decimal(5, 2)
   );
   ```

2. Column definition:
   
   - Name, database type & possibly integrity rule
   
   - Specifying a data type is required

3. Definition of the primary key
   
   - = column where every value is unique
   
   - in this example the primary key is `myNr`

### Data Types

Whole numbers

| Type     | Info        |
|:--------:|:-----------:|
| TINYINT  |  0 to 255   |
| SMALLINT | 3.2768      |
| INTEGER  |             |

Not whole numbers

| Type             | Info                                                                                          |
|:----------------:|:---------------------------------------------------------------------------------------------:|
| DECIMAL          | e.g. `DECIMAL(12, 4)`: number with 8 digits before the decimal and 4 digits after the decimal |
| DOUBLE PRECISION | Numbers with a floating point (REAL = often used synonym)                                     |
| FLOAT            | Floating point numbers with a specified precision                                             |

Alphanumeric values

| Type          | Info                               |
|:-------------:|:----------------------------------:|
| CHAR(size)    | Fixed length, max length: 255      |
| VARCHAR(size) | Variable length, max length: 65535 |

Date Times

| Type     | Info                                 |
|:--------:|:------------------------------------:|
| DATE     | Date:  year, month, day              |
| TIME     | Time of day: hours, minutes, seconds |
| TIMETAMP | Date + Time of day                   |

Sound, video, photo, images, ...

`BINARY`, `VARBINARY` & `LONG VARBINARY`

### Copying a table

```sql
CREATE TABLE tableName AS SELECT * FROM tableToCopyFrom;

# Only copy structure
CREATE TABLE tableName AS SELECT * FROM tableToCopyFrom WHERE 1 = 2;
```

### Naming conventions for tables and columns

- **Table name** must be **unique**

- Column names must be **unique**

- **Max** length of **18** characters

- Must begin with a **letter**

- Be careful with _, $, # and double quotes

- Don't use reserved SQL words

### INDEXES

- `CREATE INDEX`
  
  - ```sql
    CREATE INDEX gameName
    ON players (postalCode ASC);
    ```
    
    - An index with name `gameName` is created in the table `players` and this is for the column `postalCode` where the contents of this column are sorted in ascending order. 
  
  - ```sql
    CREATE INDEX gameNr
    ON GAMES (win, lose);
    ```
    
    - A composite index is created on the columns `won` and `lose`
    
    - The concerned columns must come from same table
  
  - ```sql
    CREATE UNIQUE INDEX name
    ON players (names, preLetters);
    ```
    
    - A composite index is created on the columns `names` and `preLetters`
    
    - This instruction also ensures that the combination of both fields in the table must always be unique

- `DROP INDEX`
  
  - ```sql
    DROP INDEX myIndex;
    ```
  
  - Removes an index

### ALTER TABLE

```sql
ALTER TABLE teams ADD name VARCHAR(1); # Adds column
ALTER TABLE teams DROP name; # Removes column
ALTER TABLE teams CHANGE birthDate bDate Date; # Modifies coumn name
ALTER TABLE teams MODIFY name VARCHAR(20); # Modifies the length of the column
ALTER TABLE players MODIFY playerNr INTEGER; # Changes datatype of the column
ALTER TABLE players MODIFY SCHEMA Loeka; # Loeka becomes the new owner of the table
```

### DROP TABLE

```sql
DROP TABLE players; # Deletes the table
DROP TABLE players CASCADE; # Deletes the table and its related tables
 
```



## DML: `Data Manipulation Language`

### INSERT INTO

| INSERT INTO table (columns)<br/> VALUES (values)<br/> |
| ----------------------------------------------------- |

```sql
# Inserts a new row
INSERT INTO teams (teamNr, playerNr, division) VALUES (3, 100, 'third');
INSERT INTO teams VALUES (3, 100, 'third');

# Inserting with date from other table
INSERT INTO tableName (column1, column2, column3)
SELECT (column1, column2, column3)
FROM oldTable;
```

### UPDATE

```sql
UPDATE players
SET playerNr = 2000
WHERE playersNr = 95;


UPDATE fines
SET amount = amount * 1,05;


UPDATE players
SET street = 'my street', place = 'Ghent'
WHERE name = 'Loeka';
```

### DELETE

```sql
DELETE FROM tableName WHERE column1 = 'example';

DELETE
FROM players
WHERE yearClosed >
      (SELECT AVG(yearClosed)
       FROM players
       WHERE place = ‘Den Haag’)
```




