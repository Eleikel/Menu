Algoritmo Menu
	Definir Captura,Seleccionado  Como Entero
	
	
	Repetir
		Escribir ("-----------------------------------------------------------------")
		Escribir ("********************** Menu de Operaciones **********************")
		Escribir ("-----------------------------------------------------------------")
		
		Escribir ("1. Capturar Valor")	
		Escribir ("2. Generar Tabla de Multiplicar")	
		Escribir ("3. Determinar Si es Primo o No Primo*")	
		Escribir ("4. Capturar una Matriz 4 x 4: Desplegar la Diagonal Principal* y Secundaria*")
		Escribir ("5. Salir del Programa")
		Escribir (" ")
		Escribir (" ------> Seleccione la operacion a realizar: <------- ")
		
		Leer Seleccionado
		
		Segun Seleccionado Hacer
			1:
				Limpiar Pantalla
				Escribir "Digite el valor a capturar : "
				Leer Captura
				Escribir "**Presione cualquier tecla para volver al menu principal**"
				Esperar Tecla
				Limpiar Pantalla
				
			2:
				Limpiar Pantalla
				ProcedimientoTablaMultiplicar(Captura)
				Esperar Tecla
				Escribir "**Presione cualquier tecla para volver al menu principal**"
				Limpiar Pantalla
				
				
			3: 
				Limpiar Pantalla
				ProcedimientoMostrarEvaluacionPrimo(Captura)
				Limpiar Pantalla
				
			4:
				Limpiar Pantalla
				ProcedimientoDiagonalesMatriz()
				Limpiar Pantalla
				
				
			5: 
				Limpiar Pantalla
				Escribir "*****  Acabas de salir del programa, espero verlo pronto ***** "
				
				
			De Otro Modo:
				Limpiar Pantalla
				Escribir ("Opcion no valida")
				Escribir "**Presione cualquier tecla para volver al menu principal**"
				Esperar Tecla
				Limpiar Pantalla
		Fin Segun
		
		
	Hasta Que Seleccionado = 5
	
FinAlgoritmo


// Opcion 2
SubProceso ProcedimientoTablaMultiplicar(Captura)
	Definir x Como Entero
		Escribir "El numero a multiplicar es ", Captura
		x = 1
		
		Mientras x <= 12 Hacer
			Escribir Captura," X ",x," = ", Captura * x
			x = x+1
		FinMientras
		Escribir "**Presione cualquier tecla para volver al menu principal**"
		Esperar Tecla
		
FinSubProceso



// Opcion 3
SubProceso ProcedimientoMostrarEvaluacionPrimo(Captura)
	Para i <- 1 Hasta Captura Hacer
		si Captura%i=0 Entonces
			cont<-cont+1
		FinSi
	FinPara
	
	si cont=2 Entonces
		Escribir "El numero ", Captura, " Es un numero primo"
	SiNo
		Escribir  "El numero ", Captura, " No es un numero primo"
	FinSi
	Escribir "**Presione cualquier tecla para volver al menu principal**"
	Esperar Tecla
	
FinSubProceso


// Opcion 4
SubProceso ProcedimientoDiagonalesMatriz()
	Dimension matrix[4,4] 
	Dimension vect(4,4);
	Definir m Como Entero
	Definir n Como Entero
	
	Escribir 'ingrese el numero filas';
	Leer m;
	Escribir 'ingrese el numero columnas';
	Leer n;
	Escribir 'Digite los valores:';
	Para i<-1 Hasta m Con Paso 1 Hacer
		Escribir 'Fila ',i
		Para j<-1 Hasta n Con Paso 1 Hacer
			Leer vect(i,j);
			
		FinPara
	FinPara
	Escribir 'La diagonal pincipal de la matriz es: ';
	Para i<-1 Hasta m Con Paso 1 Hacer
		Para j<-1 Hasta n Con Paso 1 Hacer
			Si (i=j)Entonces
				Escribir vect(i,j);
			FinSi
		FinPara
	FinPara
	Escribir 'La diagonal secundaria de la matriz es: ';
	Para i<-1 Hasta m Con Paso 1 Hacer
		Para j<-n Hasta n Con Paso 1 Hacer
			Escribir vect(i,j);
			n<-n-1;
		FinPara
	FinPara
	Escribir "**Presione cualquier tecla para volver al menu principal**"
	Esperar Tecla
	
FinSubProceso
	
