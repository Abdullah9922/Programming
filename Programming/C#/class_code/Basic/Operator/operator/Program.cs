
int a = 10;
int b = 5;

// Arithmetic Operators
Console.WriteLine("Arithmetic Operators:");
Console.WriteLine("a + b = " + (a + b));
Console.WriteLine("a - b = " + (a - b));
Console.WriteLine("a * b = " + (a * b));
Console.WriteLine("a / b = " + (a / b));
Console.WriteLine("a % b = " + (a % b));

// Assignment Operators
int x = 10;
x += 5;
x -= 2;
x *= 3;
x /= 2;
Console.WriteLine("\nAssignment Operator Result: " + x);

// Comparison Operators
Console.WriteLine("\nComparison Operators:");
Console.WriteLine("a == b : " + (a == b));
Console.WriteLine("a != b : " + (a != b));
Console.WriteLine("a > b : " + (a > b));
Console.WriteLine("a < b : " + (a < b));
Console.WriteLine("a >= b : " + (a >= b));
Console.WriteLine("a <= b : " + (a <= b));

// Logical Operators
bool p = true;
bool q = false;

Console.WriteLine("\nLogical Operators:");
Console.WriteLine("p && q : " + (p && q));
Console.WriteLine("p || q : " + (p || q));
Console.WriteLine("!p : " + (!p));

// Increment / Decrement
int n = 5;
Console.WriteLine("\nIncrement/Decrement:");
Console.WriteLine("n = " + n);
Console.WriteLine("n++ = " + (n++));
Console.WriteLine("After n++ : " + n);
Console.WriteLine("--n = " + (--n));

// Conditional (Ternary) Operator
string result = (a > b) ? "a is greater" : "b is greater";
Console.WriteLine("\nTernary Operator:");
Console.WriteLine(result);

// Bitwise Operators
Console.WriteLine("\nBitwise Operators:");
Console.WriteLine("a & b = " + (a & b));
Console.WriteLine("a | b = " + (a | b));
Console.WriteLine("a ^ b = " + (a ^ b));
Console.WriteLine("~a = " + (~a));
Console.WriteLine("a << 1 = " + (a << 1));
Console.WriteLine("a >> 1 = " + (a >> 1));


int n1 = 4;
int n2 = 5;


Console.WriteLine(n1 + " + " + n2 + " = " + (n1+n2));

Console.WriteLine($"{n1} + {n2} = " + (n1 + n2));

Console.WriteLine("{0} + {1} + {2}", n1, n2, (n1 + n2));   
