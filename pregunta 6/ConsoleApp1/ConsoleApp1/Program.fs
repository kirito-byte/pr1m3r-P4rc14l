// For more information see https://aka.ms/fsharp-console-apps
open System
let suma x y=x+y
let resta x y =x-y
let multiplicacion x y =x*y
let division x y=x/y




[<EntryPoint>]
let main argumentos =
    Console.WriteLine("Ingrese dos numeros para realizar las operaciones")
    let num1 =Console.ReadLine()
    let num2 =Console.ReadLine()

    let valor1=Convert.ToInt32(num1)
    let valor2=Convert.ToInt32(num2)

    Console.WriteLine("Escoja una opcion 1 suma 2 resta 3 multiplicacion 4 division")
    let signo =Console.ReadLine()

    let valor3=suma valor1 valor2
    let valor4=resta valor1 valor2
    let valor5=multiplicacion valor1 valor2
    let valor6=division valor1 valor2

    if signo="1" then Console.WriteLine("La suma de "+num1+" y "+num2+" es igual a: "+valor3.ToString())
    if signo="2" then Console.WriteLine("La resta de "+num1+" y "+num2+" es igual a: "+valor4.ToString())
    if signo="3" then Console.WriteLine("La multupliacion de "+num1+" y "+num2+" es igual a: "+valor5.ToString())
    if signo="4" then Console.WriteLine("La division de "+num1+" y "+num2+" es igual a: "+valor6.ToString())
    
    
    let tecla=Console.ReadKey()
    0


