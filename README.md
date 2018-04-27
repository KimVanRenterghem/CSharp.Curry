# CSharp.Curry
This lib is made to bring Currying to C#
It does not add any functionality but it makes the code more readable. It’s just syntactic sugar!
It is inspired on More functional languages.

## Use
lets say you have these functions :
```cs
   var numbers = new[] { 1, 2, 3 };
   Func<int, int, int> Add = (x, y) => x + y;
   Func<int, int, int> Multyply = (x, y) => x * y;
   Func<string, int, string> toString = (x, y) => $"{x} {y}";

```
and if you want to:
> add 2 to all the values and multiply by 3 end then print them


normally it would look like 
```cs
var resuld = numbers
    .Select(n => Add(2,n))
    .Select(n => Multyply(3,n))
    .Select(n => toString("addet 2 ", n));

foreach(var s in resuld){
    console.WriteLine(s);
}
```
but with the currying it looks like
```cs
var Add2 = Add.Curry(2,_);
var Add2String = toString.Curry("addet 2 ");
var Multyply3 = Multyply.Curry(3,_);

var resuld = numbers
    .Select(Add2)
    .Select(Multyply3)
    .Select(Add2String);

foreach(var s in resuld){
    console.WriteLine(s);
}
```
With the curry it reads more natural. More examples are in the tests

If the function has different parameter types the compiler finds out the correct position for you. In the example you can see that the order dos not mather

```cs
Func<int, string, bool, double, char, string> som = (i, s, b, d, c) => "" + i + s + (b ? "True" : "False") + d + c;

var een = som(1, "0", true, 2.2, 'B');

var twee = som.Curry(2.2).Curry(1,true).Curry("0")('B');
var drie = som.Curry(2.2)(1).Curry("0").Curry('B')(true);
var vier = som.Curry(true).Curry("0", 2.2,'B')(1);
```
If you want to use functions with the same parameters. You can use the spacer class '_' 
```cs
var _ = _.__;//statis property
//ore
var spaser = new _();

Func<string, string, string, string, string, string> som = (i, s, b, h, c) => i + s + b + h + c;

var een = som("1", "0", "3", "4","9");

var twee = som.Curry(_,"0", _, _, "9").Curry(_, "3", _)("1")("4");
var drie = som.Curry("1", "0", spaser, spaser,"9").Curry(spaser, "4")("3");
```
for the moment there is a limit of 5 parameters but in the future there will be more. 

## Install
```
Install-Package CSharp.Curry 
```
```
dotnet add package CSharp.Curry
```
