#include <stdio.h>
#include <stdlib.h>
#include <time.h>  
#include <windows.h>
#include <string.h>
#include <stdbool.h>
#include "rlutil.h"
#include "llibreriaPropia.h"
#include "llibreriaExercici.h"

int main(){
	SetConsoleOutputCP(CP_UTF8);
	SetConsoleCP(CP_UTF8);
	srand(time(NULL));
	
	int cartas[MAXVECTOR], num, numero, qtt=MAXVECTOR, cartaValor, gana, jugador[3], jugador2[3], puntos, posicion, posicion2, cartaGanadora, numGanador, numero1, numero2, ganador, empieza=1,carta1, carta2, qttJugador1=3, qttJugador2=3, puntos1=0, puntos2=0;
	char palo,paloM='O', palo1, palo2, palGanador;
	bool igual, compro=false;

	// omplirVector(cartas, MAXVECTOR);
	// pintaVector(cartas, MAXVECTOR);
	// do{
    //     printf("\nIntroduce el numero y palo de la carta: ");
    //     scanf("%d%c", &numero, &palo);
    // } while((numero<1 || numero>12) || (palo!='O' && palo!='C' && palo!='E' && palo!='B'));
	// num=traspasarCarta(palo, numero); 
	// printf("La carta codificada es: %d", num);
	// cambiarCarta(num, &palo, &numero);
	// printf("\nLa carta %d esta codificada como %d%c", num, numero, palo);
	// cartaValor=sacarCarta(cartas, &qtt);
	// repartirCartes(jugador,cartas,&qtt);
	// puntos=puntsCarta(numero);
	// printf("\nEl numero de carta %d tiene %d puntos.",numero, puntos);
	// igual=mismoPalo(palo, paloM);
	// printf("Los palos %c y %c: %d", palo, paloM, igual);
	// qtt=3;
	// posicion=posicioCarta(jugador, numero, qtt);
	// printf("%d", posicion);

	
	omplirVector(cartas, MAXVECTOR);
	printf("BARAJA:");
	pintaVector(cartas, MAXVECTOR);
	repartirCartes(jugador,cartas,&qtt);
	repartirCartes(jugador2,cartas,&qtt);
	pintaJugador(jugador, MAXJUGADOR);
	printf("\nSE HAN REPARTIDO 6 CARTAS DE LA BARAJA, 3 PARA CADA JUGADOR.");
	cartaGanadora=sacarCarta(cartas, &qtt);
	printf("\nSE HA SACADO LA CARTA GANADORA.");
	cambiarCarta(cartaGanadora, &palGanador, &numGanador);
	printf("\nEL PALO GANADOR ES %c Y LA CARTA %d%c", palGanador, numGanador, palGanador);
	pintaVector(cartas, qtt);
	printf("\nPULSA UNA TECLA PARA CONTINUAR");
		do
		{
							
				while (empieza==1)
				{
				if(qtt==0 && compro==false){jugador2[posicion]=cartaGanadora;cartaGanadora=0; compro=true;}
				printf("\nEL PALO GANADOR ES %c Y LA CARTA %d%c", palGanador, numGanador, palGanador);
				printf("\nEscoge carta JUGADOR 1");
				printf("\n\tTus cartas son: ");
				pintaJugador(jugador, MAXJUGADOR);
				printf("\nIntroduce numero y palo de la carta: ");
				scanf("%d%c", &numero1, &palo1);
				carta1=traspasarCarta(palo1, numero1);
				posicion=posicio(jugador, MAXJUGADOR, carta1);
				if(qtt>0){jugador[posicion]=sacarCarta(cartas, &qtt);}
				else {qttJugador1--;jugador[posicion]=0;}
				printf("\nEscoge carta JUGADOR 2");
				printf("\n\tTus cartas son: ");
				pintaJugador(jugador2, MAXJUGADOR);
				printf("\nIntroduce numero y palo de la carta: ");
				scanf("%d%c", &numero2, &palo2);
				carta2=traspasarCarta(palo2, numero2);
				posicion2=posicio(jugador2, MAXJUGADOR, carta2);
				if(qtt>0){jugador2[posicion2]=sacarCarta(cartas, &qtt);}
				else{qttJugador2--; jugador2[posicion2]=0;} 	
				// pintaVector(jugador, qttJugador1);
				ganador=ganarCarta(palGanador, numGanador, numero1, palo1, numero2, palo2);
				if(ganador==1){puntos1=puntos1+(puntsCarta(carta1, numero1, puntos))+(puntsCarta(carta2, numero2, puntos));}
				else if(ganador==2){puntos2=puntos2+(puntsCarta(carta1, numero1, puntos))+(puntsCarta(carta2, numero2, puntos));}
				printf("\nRESUMEN RONDA: Ha ganado el jugador %d", ganador);
				empieza=ganador;
				printf("\nPUNTOS ACUMULADOS: jugador1=%d, jugador2=%d\n", puntos1, puntos2);
				pintaVector(cartas,qtt);}
				while (empieza==2)
				{
				if(qtt==0 && compro==false){jugador[posicion]=cartaGanadora;cartaGanadora=0; compro=true;}
				
				printf("\nEL PALO GANADOR ES %c Y LA CARTA %d%c", palGanador, numGanador, palGanador);
				cartaGanadora=0;
				printf("\nEscoge carta JUGADOR 2");
				printf("\n\tTus cartas son: ");
				pintaJugador(jugador2, MAXJUGADOR);
				printf("\nIntroduce numero y palo de la carta: ");
				scanf("%d%c", &numero2, &palo2);
				carta2=traspasarCarta(palo2, numero2);
				posicion2=posicio(jugador2, MAXJUGADOR, carta2);
				if(qtt>0){jugador2[posicion2]=sacarCarta(cartas, &qtt);}
				else{qttJugador2--;jugador2[posicion2]=0;}
				printf("\nEscoge carta JUGADOR 1");
				printf("\n\tTus cartas son: ");
				pintaJugador(jugador, MAXJUGADOR);
				printf("\nIntroduce numero y palo de la carta: ");
				scanf("%d%c", &numero1, &palo1);
				carta1=traspasarCarta(palo1, numero1);
				posicion=posicio(jugador, MAXJUGADOR, carta1);
				if(qtt>0){jugador[posicion]=sacarCarta(cartas, &qtt);}
				else{qttJugador1--;jugador[posicion]=0;}
				ganador=ganarCarta(palGanador, numGanador, numero1, palo1, numero2, palo2);
				if(ganador==1){puntos1=puntos1+(puntsCarta(carta1, numero1, puntos))+(puntsCarta(carta2, numero2, puntos));}
				else if(ganador==2){puntos2=puntos2+(puntsCarta(carta1, numero1, puntos))+(puntsCarta(carta2, numero2, puntos));}
				printf("\nRESUMEN RONDA: Ha ganado el jugador %d", ganador);
				empieza=ganador;
				printf("\nPUNTOS ACUMULADOS: jugador1=%d, jugador2=%d\n", puntos1, puntos2);
				pintaVector(cartas,qtt);
				}
					
			} while (qtt!=0 && qttJugador1!=0 && qttJugador2!=0);
		if(puntos1>puntos2){printf("\nFelicidades jugador 1, has ganado con %d puntos, jugador 2 pierde con %d puntos.", puntos1, puntos2);}
		else if(puntos2>puntos1){{printf("\nFelicidades jugador 2, has ganado con %d puntos, jugador 1 pierde con %d puntos.", puntos2, puntos1);}}
		else{printf("\nHabeis quedado empate");}

	acabament();
	return 0;
}
