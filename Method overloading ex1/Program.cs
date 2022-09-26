using Method_overloading_ex1;

var x = 0;
var y = 1;


var addAnswer = Add.Adds(x, y, true);

var a = 22.1m;
var b = 33.6m;

var decimalAnswer = Add.Adds(a, b);

Console.WriteLine($"{addAnswer}");

if (decimalAnswer > 1 || decimalAnswer < 1)
{
    Console.WriteLine($"{decimalAnswer} dollars");   
}
else
{
    Console.WriteLine($"{decimalAnswer} dollar");
}
;
