
--funciones

suma :: Integer -> Integer -> Integer    
suma x y =  x + y                      

resta :: Integer -> Integer -> Integer    
resta x y =  x - y                       

multiplicacion :: Integer -> Integer -> Integer    
multiplicacion x y =  x * y                       

division :: Integer -> Integer -> Integer    
division x y =  div x y                       


main = do 
    putStrLn ("Ingrese dos numeros:")
    n <- getLine
    u <- getLine
    putStrLn (show (suma (read n) (read u))++" Es la suma.")
    putStrLn (show (resta (read n) (read u))++" Es la resta.")
    putStrLn (show (multiplicacion (read n) (read u))++" Es la multiplicacion.")
    putStrLn (show (division (read n) (read u))++" Es la division.")