// Number 
int a = 2100000000;
int b = 2100000000;
// long c = checked(a + b);

// Kalo dicast ?

long c = (long)a + (long)b;
Console.WriteLine(c);


// decimal untuk penjumlahan double dan float
double z = 90.2;
float y = 70.2f;
// kamu perlu decimal to be more specific
decimal x = (decimal)z + (decimal)y; 
Console.WriteLine($"the value is {x}");