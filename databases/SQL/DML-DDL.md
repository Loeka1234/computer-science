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

### DDL: `Data Definition Language`

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

| TINYINT  | -256 to 255 |
| -------- |:-----------:|
| SMALLINT | 3.2768      |
| INTEGER  |             |

Not whole numbers

| DECIMAL          | e.g. `DECIMAL(12, 4)`: number with 8 digits before the decimal and 4 digits after the decimal |
|:----------------:|:---------------------------------------------------------------------------------------------:|
| DOUBLE PRECISION | Numbers with a floating point (REAL = often used synonym)                                     |
| FLOAT            | Floating point numbers with a specified precision                                             |

Alphanumeric values

| CHAR(size)    | Fixed length, max length: 255      |
| ------------- | ---------------------------------- |
| VARCHAR(size) | Variable length, max length: 65535 |

Date Times

| DATE     | Date:  year, month, day              |
| -------- | ------------------------------------ |
| TIME     | Time of day: hours, minutes, seconds |
| TIMETAMP | Date + Time of day                   |

Sound, video, photo, images, ...

`BINARY`, `VARBINARY` & `LONG VARBINARY`


