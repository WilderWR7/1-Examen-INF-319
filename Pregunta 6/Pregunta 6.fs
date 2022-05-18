// Más información acerca de F# en http://fsharp.net
// Vea el proyecto "Tutorial de F#" para obtener más ayuda.
open System


let suma a b = a + b;
let resta a b = a-b;
let division a b = a/b;
let multiplicacion a b = a*b;


[<EntryPoint>]
let main argv = 
    //preguntamos por la operacion a realizar
    Console.WriteLine("Que Operacion desea realizar?
    1: Suma
    2: Resta
    3: Multiplicación
    4: Division");

    let tecla = Console.ReadLine();
    let valor = Convert.ToInt32(tecla);
    Console.WriteLine("Inserte un numero:");
    //Obtengo el primer numero ingresado por el usuario
    let str1 = Console.ReadLine();
    Console.WriteLine("Inserte un numero:");
    //Obtengo el segundo numero ingresado por el usuario
    let str2 = Console.ReadLine();
    let numero1 = Convert.ToInt32(str1);
    let numero2 = Convert.ToInt32(str2);
    //De acuerdo a la opción seleccionada realizamos llamamos a la funcion necesaria. 
    if valor = 1 then
        Console.WriteLine("La Suma es:");
        Console.WriteLine( suma numero1 numero2);
    if valor = 2 then
        Console.WriteLine("La resta es:");
        Console.WriteLine( resta numero1 numero2);

    if valor = 3 then
        Console.WriteLine("multiplicacion");
        Console.WriteLine( multiplicacion numero1 numero2);

    if valor = 4 then
        Console.WriteLine("division");
        Console.WriteLine( division numero1 numero2);

    let c = Console.ReadKey(); 
    0
