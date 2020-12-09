# Collections in C#

<img title="" src="file:///C:/Users/loeka/Documents/01%20Github/computer-science/programming/C%23/collections.PNG" alt="collections" width="414" data-align="center">

This markdown file contains some of the collections in C#.

### Generic

- `Dictionary<TKey, TValue>`
  
  - Contains key-value pairs
  
  - Keys must be unique and cannot be null
  
  - Values can be null or duplicate
  
  - Values accessed: `myDictionary[key]`

- `List<T>`
  
  - Contains elements of specified type
  
  - Grows automatically
  
  - Elements can be added using the `Add()`,  `AddRange()` 
  
  - Values accessed: `myList[0]`
  
  - Faster and less error-prone than the `ArrayList`

- `Queue<T>`
  
  - Stores the values in FIFO style (First In First Out)
  
  - Keeps the order in which the values were added
  
  - `Enqueue()` method to add values
  
  - `Dequeue()` method to retrieve values

### Non-generic

- `ArrayList`
  
  - Stores objects of any type like an array
  
  - No need to specify the size
  
  - Grows automatically

- `Hashtable`
  
  - Stores key and value pairs
  
  - Retrieves the values by comparing the hash value of the keys
  
  - Keys must be unique and cannot be null
  
  - Values can be null or duplicate
  
  - Values accessed: `myHashtable[key]`
  
  - Difference with **Dictionary**:
    
    - Dictionaries store key/value pairs of same type
    
    - Dictionaries need to specify the type of the key and value


