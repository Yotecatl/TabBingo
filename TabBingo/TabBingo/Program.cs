//Generar un programa que cree un cartón de bingo aleatorio y lo muestre por pantalla

//1)    Cartón de 3 filas por 9 columnas
//2)    El cartón debe tener 15 números y 12 espacios en blanco
//3)    Cada fila debe tener 5 números
//4)    Cada columna debe tener 1 o 2 números
//5)    Ningún número puede repetirse
//6)     La primer columna contiene los números del 1 al 9, la segunda del 10 al 19, la tercera del 20 al 29,
//así sucesivamente hasta la última columna la cual contiene del 80 al 90


Random aleatorio = new Random();
int filas = 3;                    // filas de la matriz
int columnas = 9;                 // columnas de la matriz
int largoB = filas * columnas;                  // largo del vector para llenar la matriz
int largoV = 30;                  // largo del vector numeros aleatorios
int contador = 0;
int b = 0;                        // variable auxiliar indice del vector b


int[] vector = new int[largoV];    //vector numeros aleatorios
int[] numeros = new int[largoB];   //vector para llenar la matriz

int[,] carton = new int[filas, columnas]; // matriz carton bingo

//Se crea un vector con los valores para llenar la matriz 

int numero = 0;

while (b < numeros.Length)
{
	//llenado del vector
	for (int i = 0; i < vector.Length; i++)
	{
		vector[i] = aleatorio.Next(1, 9);
	}

	//Comparación de numeros
	for (int j = 0; j < vector.Length; j++)
	{
		numero = vector[j];
		for (int i = j + 1; i < vector.Length; i++)
		{
			if (vector[i] == numero)
			{
				contador++;
			}

		}
		if (contador == 0)
		{
			numeros[b] = numero;
			b++;
			if (b == numeros.Length)
			{
				break;
			}
		}
		contador = 0;

	}

}

b = 3;
while (b < numeros.Length)
{
	//llenado del vector
	for (int i = 0; i < vector.Length; i++)
	{
		vector[i] = aleatorio.Next(10, 19);
	}

	//Comparación de numeros
	for (int j = 0; j < vector.Length; j++)
	{
		numero = vector[j];
		for (int i = j + 1; i < vector.Length; i++)
		{
			if (vector[i] == numero)
			{
				contador++;
			}

		}
		if (contador == 0)
		{
			numeros[b] = numero;
			b++;
			if (b == numeros.Length)
			{
				break;
			}
		}
		contador = 0;
		
	}

}

b = 6;
while (b < numeros.Length)
{
	//llenado del vector
	for (int i = 0; i < vector.Length; i++)
	{
		vector[i] = aleatorio.Next(20, 29);
	}

	//Comparación de numeros
	for (int j = 0; j < vector.Length; j++)
	{
		
		numero = vector[j];
		for (int i = j + 1; i < vector.Length; i++)
		{
			
			if (vector[i] == numero)
			{
				contador++;
			}

		}
		if (contador == 0)
		{
			numeros[b] = numero;
			b++;
			if (b == numeros.Length)
			{
				break;
			}
		}
		contador = 0;
		
	}

}

b = 9;
while (b < numeros.Length)
{
	//llenado del vector
	for (int i = 0; i < vector.Length; i++)
	{
		vector[i] = aleatorio.Next(30, 39);
	}

	//Comparación de numeros
	for (int j = 0; j < vector.Length; j++)
	{
		numero = vector[j];
		for (int i = j + 1; i < vector.Length; i++)
		{
			
			if (vector[i] == numero)
			{
				contador++;
			}

		}
		if (contador == 0)
		{
			numeros[b] = numero;
			b++;
			if (b == numeros.Length)
			{
				break;
			}
		}
		contador = 0;
		
	}

}

b = 12;
while (b < numeros.Length)
{
	//llenado del vector
	for (int i = 0; i < vector.Length; i++)
	{
		vector[i] = aleatorio.Next(40, 49);
	}

	//Comparación de numeros
	for (int j = 0; j < vector.Length; j++)
	{
		numero = vector[j];
		for (int i = j + 1; i < vector.Length; i++)
		{

			if (vector[i] == numero)
			{
				contador++;
			}

		}
		if (contador == 0)
		{
			numeros[b] = numero;
			b++;
			if (b == numeros.Length)
			{
				break;
			}
		}
		contador = 0;

	}

}

b = 15;
while (b < numeros.Length)
{
	//llenado del vector
	for (int i = 0; i < vector.Length; i++)
	{
		vector[i] = aleatorio.Next(50, 59);
	}

	//Comparación de numeros
	for (int j = 0; j < vector.Length; j++)
	{
		numero = vector[j];
		for (int i = j + 1; i < vector.Length; i++)
		{

			if (vector[i] == numero)
			{
				contador++;
			}

		}
		if (contador == 0)
		{
			numeros[b] = numero;
			b++;
			if (b == numeros.Length)
			{
				break;
			}
		}
		contador = 0;

	}

}

b = 18;
while (b < numeros.Length)
{
	//llenado del vector
	for (int i = 0; i < vector.Length; i++)
	{
		vector[i] = aleatorio.Next(60, 69);
	}

	//Comparación de numeros
	for (int j = 0; j < vector.Length; j++)
	{
		numero = vector[j];
		for (int i = j + 1; i < vector.Length; i++)
		{

			if (vector[i] == numero)
			{
				contador++;
			}

		}
		if (contador == 0)
		{
			numeros[b] = numero;
			b++;
			if (b == numeros.Length)
			{
				break;
			}
		}
		contador = 0;

	}

}

b = 21;
while (b < numeros.Length)
{
	//llenado del vector
	for (int i = 0; i < vector.Length; i++)
	{
		vector[i] = aleatorio.Next(70, 79);
	}

	//Comparación de numeros
	for (int j = 0; j < vector.Length; j++)
	{
		numero = vector[j];
		for (int i = j + 1; i < vector.Length; i++)
		{

			if (vector[i] == numero)
			{
				contador++;
			}

		}
		if (contador == 0)
		{
			numeros[b] = numero;
			b++;
			if (b == numeros.Length)
			{
				break;
			}
		}
		contador = 0;

	}

}

b = 24;
while (b < numeros.Length)
{
	//llenado del vector
	for (int i = 0; i < vector.Length; i++)
	{
		vector[i] = aleatorio.Next(80, 89);
	}

	//Comparación de numeros
	for (int j = 0; j < vector.Length; j++)
	{
		numero = vector[j];
		for (int i = j + 1; i < vector.Length; i++)
		{

			if (vector[i] == numero)
			{
				contador++;
			}

		}
		if (contador == 0)
		{
			numeros[b] = numero;
			b++;
			if (b == numeros.Length)
			{
				break;
			}
		}
		contador = 0;

	}

}


//ordenar vector de menor a mayor

int temp = 0;
for (int j = 0; j < filas - 1; j++)
{
	for (int i = 0; i < numeros.Length - 1; i++)
	{
		if (numeros[i] > numeros[i + 1])
		{
			temp = numeros[i];
			numeros[i] = numeros[i + 1];
			numeros[i + 1] = temp;
		}
	}
}


//Mostar datos salida
//for (int i = 0; i < vector.Length; i++)
//{
//	Console.Write($"{vector[i]} ");
//}
//Console.WriteLine("");
// Mostrar vector numeros
//for (int i = 0; i < numeros.Length; i++)
//{
//	Console.Write($"{numeros[i]} ");
//}
//Console.WriteLine("");

//Generar la matriz

b =0;
for (int j = 0; j < columnas; j++)
{
	for(int i = 0; i < filas; i++)
	{
		carton[i, j] = numeros[b];
		b++;
	}
}

//Colocamos 0 donde iran los espacios en las 2 primeras filas

int numEspacios = 4;


for (int i = 0; i < filas - 1; i++)
{
	while(numEspacios > 0)
	{
		for (int j = 0; j < columnas; j++)
		{

			int volado = aleatorio.Next(1, 9);
			if (volado < 6)
			{
				carton[i, j] = 0;
				numEspacios--;
			}
			
			if (numEspacios == 0)
			{
				j = columnas;
			}
		}
	}
	numEspacios = 4;
}

// Agramanos los 0 en la ultima columna respetando maximo 2 espacios por filado

// Primero agregamos 0 a los columnas de tres números
numEspacios = 4;
for(int j = 0; j < columnas; j++)
{
	for(int i = 0; i < filas; i++)
	{
		if(carton[i, j] != 0 && carton[i+1,j] != 0)
		{
			carton[i+2, j] = 0;
			i = filas;
			numEspacios--;
		}
		else { i = filas; }
	}
}
//Console.WriteLine(numEspacios); //Mostrar los espacios que faltan

//Mostrar carton con ceros sin formato y falta la ultima fila de 0s 
//for (int i = 0; i < filas; i++)
//{
//	for (int j = 0; j < columnas; j++)
//	{
//		Console.Write($"{carton[i, j]} ");
//	}
//	Console.WriteLine();
//}

// Ponemos los 0 que nos falten
while (numEspacios > 0)
{
	for (int j = 0; j < columnas; j++)
	{
		for (int i = 0; i < filas; i++)
		{
			if (carton[i,j] != 0 && carton[i+1,j] == 0 || carton[i, j] == 0 && carton[i + 1, j] != 0)
			{
				int volado = aleatorio.Next(1, 9);
				if (volado > 4)
				{
					carton[i + 2, j] = 0;
					numEspacios--;
					if (numEspacios == 0)
					{
						break;
					}
				}
				else { i = filas; }

			}
			else { i = filas; }
		}
		if (numEspacios == 0)
		{
			break;
		}

	}
}


//Mostrar carton con formato

Console.WriteLine("----------------------------");
for (int i = 0; i < filas; i++)
{
	for (int j = 0; j < columnas; j++)
	{
		if (carton[i, j] == 0)
		{
			Console.Write("|  ");
		}
		else
		{
			if (i < filas && j == 0)
			{
				Console.Write($"|0{carton[i, j]}");
			}
			else
			{
				Console.Write($"|{carton[i, j]}");
			}
		}
	}
	Console.WriteLine("|");
	//Console.WriteLine();
}

Console.WriteLine("----------------------------");



