using DryIoc.ImTools;

Random r = new Random();
int[] arr = new int[5];
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = r.Next(15);
    Console.Write("{0} ", arr[i]);
}
Console.WriteLine();
for(int i = 0; i < arr.Length - 1; i++)
{
    for (int j = i; j < arr.Length; j++)
    {
        if (arr[j] < arr[i])
        {
            int t = 0;
            t = arr[i];
            arr[i] = arr[j];
            arr[j] = t;
        }
    }
}
for(int i = 0; i < arr.Length; i++)
{
    Console.Write("{0} ", arr[i]);
}




Console.WriteLine("\n");
int[,] a = new int[5, 5];
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        a[i, j] = r.Next(15);
        Console.Write("{0} ", a[i, j]);
    }
    Console.WriteLine();
}
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        for (int k = 0; k < 5; k++)
        {
            for (int l = 0; l < 5; l++)
            {
                if (a[i, j] < a[k, l])
                {
                    int t = 0;
                    t = a[i, j];
                    a[i, j] = a[k, l];
                    a[k, l] = t;
                }
            }
        }
    }
}
Console.WriteLine();
for (int i = 0; i < 5; i++)
{
    for (int j = 0; j < 5; j++)
    {
        Console.Write("{0} ", a[i, j]);
    }
    Console.WriteLine();
}






Console.WriteLine("\n");
int[][] b = new int[4][]
{
    new int[5],
    new int[3],
    new int[2],
    new int[4],
};
for(int i = 0; i<5; i++)
{
    b[0][i] = r.Next(10);
    Console.Write("{0} ", b[0][i]);
}
Console.WriteLine();
for (int i = 0; i < 3; i++)
{
    b[1][i] = r.Next(10);
    Console.Write("{0} ", b[1][i]);
}
Console.WriteLine();
for (int i = 0; i < 2; i++)
{
    b[2][i] = r.Next(10);
    Console.Write("{0} ", b[2][i]);
}
Console.WriteLine();
for (int i = 0; i < 4; i++)
{
    b[3][i] = r.Next(10);
    Console.Write("{0} ", b[3][i]);
}
Console.WriteLine("\n");
for(int i = 0; i < 5; i++)
{
    for (int j = i; j < 5; j++)
    {
        if (b[0][i] > b[0][j])
        {
            int t = b[0][i];
            b[0][i] = b[0][j];
            b[0][j] = t;
        }
    }
}
for (int i = 0; i < 3; i++)
{
    for (int j = i; j < 3; j++)
    {
        if (b[1][i] > b[1][j])
        {
            int t = b[1][i];
            b[1][i] = b[1][j];
            b[1][j] = t;
        }
    }
}
for (int i = 0; i < 2; i++)
{
    for (int j = i; j < 2; j++)
    {
        if (b[2][i] > b[2][j])
        {
            int t = b[2][i];
            b[2][i] = b[2][j];
            b[2][j] = t;

        }
    }
}
for (int i=0; i <4;i++)
{
    for (int j=i; j<4; j++)
    {
        if (b[3][i] > b[3][j])
        {
            int t = b[3][i];
            b[3][i] = b[3][j];
            b[3][j] = t;
        }
    }
}
for (int i = 0; i < 5; i++)
{
    Console.Write("{0} ", b[0][i]);
}  
Console.WriteLine();
for (int i = 0; i < 3; i++)
{
    Console.Write("{0} ", b[1][i]);
}  
Console.WriteLine();
for (int i = 0; i < 2; i++)
{
    Console.Write("{0} ", b[2][i]);
}
Console.WriteLine();
for (int i = 0; i < 4; i++)
{
    Console.Write("{0} ", b[3][i]);
}