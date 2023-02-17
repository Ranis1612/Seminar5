// **Задача 32:** Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] array = XZArray(5, -10,10);
Console.WriteLine(String.Join(" ",array));

int[] res =  InversArray(array);
Console.WriteLine(String.Join(" ",res));


int[] InversArray(int[] xyi)
{
for(int i =0; i < xyi.Length;i++){
  xyi [i] *= -1; 
}
return xyi;
}


int[] XZArray(int size, int minValue, int maxValue)
{
  int[] res = new int[size];
  for(int i = 0; i < size; i++){
    res[i] = new Random().Next(minValue, maxValue+1);
  }
  return res;
} 

