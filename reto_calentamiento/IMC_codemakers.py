#Aqui es donde obtenemos la cantidad de personas
personas = int(input( "personas: "))

#Aqui verificamos que la cantidad sea mayor a 0 si no, no tiene sentido pedir nada
while personas > 0:
    #Le pedimos el nombre y lo guardamos en un input (Si usara Python 2.7 seria raw_input y no input pero usa python 3.7)
    n = input("Su nombre por favor: ")
       
    #como la altura es en metros y no centimetros hay que ponerle punto y por ende es un flotante float()
    a = float(input ("Su altura en metros por favor: "))
    #Aqui se duplica codigo pero bueno... decimos que est (de estatura) es igual a altura (No me diga)
    est = a
    #La masa en kilogramos si puede tener decimales asi que la dejamos flotante
    m = float (input("Su masa en kilogramos por favor :"))
    #Calculo del IMC, masa (En kilogramos) entre la estatura (En metros) elevada al cuadrado
    IMC = m / est**2
    
    #Le imprimos el IMC 
    print("IMC: " + str(IMC) )

    #Hacemos las distintas validaciones
    if IMC >= 0 and IMC <= 15.99:
        print ("Delgadez severa")
    elif IMC >= 16.00 and IMC <= 16.99:
        print ("Delgadez moderada")
    elif IMC >= 17.00 and IMC <= 18.49:
        print ("Delgadez aceptable")
    elif IMC >= 18.50 and IMC <= 24.99:
        print ("Peso Normal")
    elif IMC >= 25.00 and IMC <= 29.99:
        print ("Sobrepeso")
    elif IMC >= 30.00 and IMC <= 34.99:
        print ("Obesidad tipo I")
    elif IMC >= 35.00 and IMC <= 39.99:
        print ("Obesidad tipo II")
    elif IMC >= 40.00 and IMC <= 49.99:
        print ("Obesidad tipo III o morbida")    
    elif IMC >= 50.00:
        print ("Obesidad tipo IV o extrema")

    
  