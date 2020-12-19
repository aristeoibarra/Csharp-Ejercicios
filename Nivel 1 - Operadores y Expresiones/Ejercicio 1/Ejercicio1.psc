Algoritmo Ejercicio_1
	// 1. Pedir 2 números al usuario y sumarlos, restarlos, multiplicarlos y dividirlos.
	Definir num1,num2,resultado Como Real
	Escribir 'Digite num1: '
	Leer num1
	Escribir 'Digite num2: '
	Leer num2
	resultado <- num1+num2
	Escribir 'La suma es: ',resultado
	resultado <- num1-num2
	Escribir 'La resta es: ',resultado
	resultado <- num1*num2
	Escribir 'La multi. es: ',resultado
	Si num2!=0 Entonces
		resultado <- num1/num2
		Escribir 'La división es: ',resultado
	SiNo
		Escribir 'No se puede llevar acabo la división'
	FinSi
FinAlgoritmo
