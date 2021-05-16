# Relational integrity

- `CASCADE`
  
  - Will propagate the change when the parent changes
  
  - If you delete a row, rows in constrained tables that reference that row will also be deleted, etc.

- `SET NULL`
  
  - Sets the column value to `NULL` if the parent row goes away

- `RESTRICT` = `NO ACTION` (use `RESTRICT`)
  
  - Causes the attempted `DELETE` of a parent row to fail


