// Задайте произвольный массив. Выведите
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.

void print(int [] array, int n) 
    { 
      if (n > 0) 
      { 
      	Console.Write(array[n] + " "); 
      	print(array, n - 1); 
      } 
      else Console.WriteLine(array[0]); 
    } 
  
      int [] array = {1, 2, 5, 0, 10, 34}; 
      int n = 6;
      print(array, n-1); 
     
