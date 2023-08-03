/*Task 1
void RandomNum(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int o = 0; o < array.GetLength(1); o++)
        {
            array[i, o] = new Random().Next(0, 10);
        }
    }
}

void PArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int o = 0; o < array.GetLength(1); o++)
        {
            Console.Write(array[i, o] + " ");
        }
        Console.WriteLine("");
    }
}
Console.Write("Cтрок: ");
int line = Convert.ToInt32(Console.ReadLine());
Console.Write("Столбцов: ");
int stolb = Convert.ToInt32(Console.ReadLine());
int[,] num = new int[line, stolb];
RandomNum(num);
Console.WriteLine();
Console.WriteLine("Массив: ");
PArray(num);
for (int i = 0; i < num.GetLength(0); i++)
{
    for (int o = 0; o < num.GetLength(1) - 1; o++)
    {
        for (int z = 0; z < num.GetLength(1) - 1; z++)
        {
            if (num[i, z] < num[i, z + 1])
            {
                int temp = 0;
                temp = num[i, z];
                num[i, z] = num[i, z + 1];
                num[i, z + 1] = temp;
            }
        }
    }
}
Console.WriteLine();
Console.WriteLine("Массив после: ");
PArray(num);
*/

/*Task 2

void RandomNum(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int o = 0; o < array.GetLength(1); o++)
        {
            array[i, o] = new Random().Next(0, 10);
        }
    }
}

void PArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int o = 0; o < array.GetLength(1); o++)
        {
            Console.Write(array[i, o] + " ");
        }
        Console.WriteLine("");
    }
}

Console.Write("Cтрок: ");
int line = Convert.ToInt32(Console.ReadLine());
Console.Write("Столбцов: ");
int stolb = Convert.ToInt32(Console.ReadLine());
int[,] num = new int[line, stolb];
RandomNum(num);
PArray(num);
int min = Int32.MaxValue;
int index = 0;

for (int i = 0; i < num.GetLength(0); i++)
{
    int cou = 0;
    for (int o = 0; o < num.GetLength(1); o++)
    {
        cou = cou + num[i, o];        
    }
    if (cou < min)
    {
        min = cou;
        index++;
    }
}
Console.WriteLine($"Cтрока с наименьшей суммой елементов: {index}, сумма елементов строки: {min}");
*/

/*Task 3

int InI(string concl)
{
    Console.Write(concl);
    return 
    int.Parse(Console.ReadLine());
}

void RandomNum(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int o = 0; o < array.GetLength(1); o++)
        {
            array[i, o] = new Random().Next(0, 10);
        }
    }
}

void PArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int o = 0; o < array.GetLength(1); o++)
        {
            Console.Write(array[i, o] + " ");
        }
        Console.WriteLine("");
    }
}

int size = InI("Размер: ");
int[,] mA = new int[size, size];
int[,] mB = new int[size, size];
RandomNum(mA);
RandomNum(mB);
int[,] mC = new int[size, size];

for (int i = 0; i < size; i++)
{
    for (int o = 0; o < size; o++)
    {
        for (int z = 0; z < size; z++)
        {
            mC[i, o] = mC[i, o] + (mA[i, z] * mB[z, o]);
        }
    }
}
Console.WriteLine("Матрица А: ");
PArray(mA);
Console.WriteLine();
Console.WriteLine("Матрица В: ");
PArray(mB);
Console.WriteLine();
Console.WriteLine("Произведение матриц: ");
PArray(mC);
*/

/*Task 4

int InI(string concl)
{
    Console.Write(concl);
    return 
    int.Parse(Console.ReadLine());
}
int[,,] Mass3D(int size1, int size2, int size3)
{
    int[,,] array = new int[size1, size2, size3];
    int[] val = new int[count];
    int num
     = 10;
    for (int i = 0; i < val.Length; i++)
        val[i] = num
        ++;

    for (int i = 0; i < val.Length; i++)
    {
        int randomIndex = new Random().Next(0, val.Length);
        int temp = val[i];
        val[i] = val[randomIndex];
        val[randomIndex] = temp;
    }

    int valIndex = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int o = 0; o < array.GetLength(1); o++)
        {
            for (int z = 0; z < array.GetLength(2); z++)
            {
                array[i, o, z] = val[valIndex++];
            }
        }
    }
    return array;
}
int sizeA = InI("Введите размер А: ");
int sizeB = InI("Введите размер В: ");
int sizeC = InI("Введите размер С: ");
int count = 8;
if (sizeA * sizeB * sizeC > count)
{
    Console.Write("Массив слишком большой");
    return;
}
int[,,] resNum = Mass3D(sizeA, sizeB, sizeC);
for (int i = 0; i < resNum.GetLength(0); i++)
{
    for (int o = 0; o < resNum.GetLength(1); o++)
    {
        for (int z = 0; z < resNum.GetLength(2); z++)
        {
            Console.WriteLine($"[{i},{o},{z}] - {resNum[i, o, z]}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
*/

/*Task 5

void PArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int o = 0; o < array.GetLength(1); o++)
        {
            Console.Write(array[i, o] + " ");
        }
        Console.WriteLine("");
    }
}
Console.Write("Размер: ");
int size = Convert.ToInt32(Console.ReadLine());
int[,] numsize = new int[size, size];
int num = 1;
int i = 0;
int o = 0;
while (num <= size * size)
{
    numsize[i, o] = num; // Самостоятельно не смог понять как это сделать и случайно нашел такую конструкцию.
    if (i <= o + 1 && i + o < size - 1)
        ++o;
    else if (i < o && i + o >= size - 1)
        ++i;
    else if (i >= o && i + o > size - 1)
        --o;
    else
        --i;
    ++num;
}
PArray(numsize);
*/