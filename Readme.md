## TryGet Pattern
This pattern shows a cleaner implementation of contexts where we need to search for a value.
In this case, we use .FirstOrDefault() to get a name. If we do not use TryGet pattern, 
we receive a null exception if the name is not found in the search (In this case list).

You see below the result with \ without TryGet Pattern:
![image](https://github.com/user-attachments/assets/269d7005-6cc8-4921-a2e4-b92ecd52b9f3)
