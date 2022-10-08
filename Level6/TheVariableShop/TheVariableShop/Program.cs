using System;

byte aSingleByte = 56;
Console.WriteLine("Byte: 0-255 - " + aSingleByte);

short aShortNumber = -2_045;
Console.WriteLine("Short: -32.768-32,767 - " + aShortNumber);

int aIntNumber = 64;
Console.WriteLine("Int: -2,147,483,648-2,147,483,647 - " + aIntNumber);

long aLongNumber = 8_435_263_895_401_576_432;
Console.WriteLine("Long: -9,223,372,036,854,775,808-9,223,372,036,854,775,807 - " + aLongNumber);

sbyte signedByte = -10;
Console.WriteLine("S Byte: -128-127 - " + signedByte);

ushort unsignShortNumber = 105;
Console.WriteLine("Unsigned Short: 0-65,535 - " + unsignShortNumber);

uint unsignIntNumber = 4_132_680_375;
Console.WriteLine("Unsigned Int: 0-4,294,967,295 - " + unsignIntNumber);

ulong unsignLongNumber = 5;
Console.WriteLine("Unsigned Long: 0-18,446,744,073,709,551,615 - " + unsignLongNumber);

char aletter = 'D';
Console.WriteLine("A Char: " + aletter);

string aString = "Hello world!";
Console.WriteLine("A String: " + aString);

float aFloat = 0.024345f;
Console.WriteLine("A float can do pretty small decimals with moderate precision; ~1.0 x 10e-45 to ~3.4 x 10e38 with 7 digits of precision; - " + aFloat);

double aDouble = 3.5623;
Console.WriteLine("A double can store smaller decimals with greater precision; ~5 x 10e-324 to ~1.7 x 10e308 with 15-16 digits of precision; - " + aDouble);

decimal aDecimal = 3.5623m;
Console.WriteLine("A decimal can store relatively small numbers with a very high precision; ~1 x 10e-28 to ~7.9 x 10e28 with 28-29 digits of precision; - " + aDecimal);

bool itWorked = true;
Console.WriteLine("A bool is a true or false: " + itWorked);

//modifications!

aSingleByte = 240;
Console.WriteLine("Byte: 0-255 - " + aSingleByte);

aShortNumber = -2_456;
Console.WriteLine("Short: -32.768-32,767 - " + aShortNumber);

aIntNumber = 80;
Console.WriteLine("Int: -2,147,483,648-2,147,483,647 - " + aIntNumber);

aLongNumber = 2_233_098_186_254_576_492;
Console.WriteLine("Long: -9,223,372,036,854,775,808-9,223,372,036,854,775,807 - " + aLongNumber);

signedByte = -8;
Console.WriteLine("S Byte: -128-127 - " + signedByte);

unsignShortNumber = 32_089;
Console.WriteLine("Unsigned Short: 0-65,535 - " + unsignShortNumber);

unsignIntNumber = 2_555_123_925;
Console.WriteLine("Unsigned Int: 0-4,294,967,295 - " + unsignIntNumber);

unsignLongNumber = 2;
Console.WriteLine("Unsigned Long: 0-18,446,744,073,709,551,615 - " + unsignLongNumber);

aletter = 'W';
Console.WriteLine("A Char: " + aletter);

aString = "Goodbye world!";
Console.WriteLine("A String: " + aString);

aFloat = 0.27943f;
Console.WriteLine("A float can do pretty small decimals with moderate precision; ~1.0 x 10e-45 to ~3.4 x 10e38 with 7 digits of precision; - " + aFloat);

aDouble = 3.5623;
Console.WriteLine("A double can store smaller decimals with greater precision; ~5 x 10e-324 to ~1.7 x 10e308 with 15-16 digits of precision; - " + aDouble);

aDecimal = 3.5623m;
Console.WriteLine("A decimal can store relatively small numbers with a very high precision; ~1 x 10e-28 to ~7.9 x 10e28 with 28-29 digits of precision; - " + aDecimal);

itWorked = false;
Console.WriteLine("A bool is a true or false: " + itWorked);