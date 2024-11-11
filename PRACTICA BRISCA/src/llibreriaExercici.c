#include <stdio.h>
#include <stdlib.h>
#include <time.h>  
#include <windows.h>
#include <string.h>
#include <stdbool.h>
#include "rlutil.h"
#include "llibreriaPropia.h"
#include "llibreriaExercici.h"

void omplirVector(int v[], int qtt){
    int carta=1;
    for(int i=0; i<qtt; i++){
            if(i==12){carta=101;}
            else if(i==24){carta=201;}
            else if(i==36) {carta=301;}
            v[i]=carta;
            carta++;
    }
}
// Palo=0** bastos
// Palo=1** espadas
// Palo=2** copas
// Palo=3** oros,
int traspasarCarta(char palo, int numero){
    if(palo=='O'){numero=300+numero;}
    else if(palo=='C'){numero=200+numero;}
    else if(palo=='E'){numero=100+numero;}
    else{numero=numero;}
    return numero;
}
void cambiarCarta(int carta,char *palo,int *numero){
    int val;
    (*numero)= carta%100;
    val=carta-(carta%100);
    if(val==300){(*palo)='O';}
    else if(val==200){(*palo)='C';}
    else if(val==100){(*palo)='E';}
    else{(*palo)='B';}
}
int sacarCarta(int cartas[],int *qtt){
    int cartaVal, carta;
    if((*qtt>0)){
	carta=rand() % ((*qtt) - (0) + 1) + (0);
    }else{carta=0;}
    cartaVal=cartas[carta];
    cartas[carta]=cartas[(*qtt)-1];
    (*qtt)--;
    return cartaVal;
}
void repartirCartes(int jugador[],int cartas[],int *qtt){
    for(int i=0; i<3; i++){
        jugador[i]=sacarCarta(cartas,&(*qtt));
    }

}
int puntsCarta(int carta,int numero1, int puntos){
    int vPuntos[]={11,0,10,0,0,0,0,0,0,2,3,4};
    puntos=vPuntos[numero1-1];
    return puntos;
}
bool mismoPalo(char pal1,char pal2){
    bool igual=false;
    if (pal1==pal2){igual=true;};
    return igual;
}
int posicioCarta(int jugador[], int carta, int qtt){
    int numero, numero2, posicion=0;
    char palo, palo2;
    
    for(int i=0; i<qtt; i++){
        cambiarCarta(jugador[i], &palo, &numero);
        printf("\n%d%c", numero, palo);
    }
    printf("\nIntroduce numero y palo de la carta: ");
    scanf("%d%c", &numero2, &palo2);
    carta=traspasarCarta(palo2, numero2);
    for(int i=0; i<qtt; i++){
        if (carta==jugador[i]){posicion++;}
    }
    if(posicion==0){posicion=-1;}
    return posicion;
} 
pintaJugador(int jugador[], int qtt){
    int numero;
    char palo;
    for(int i=0; i<qtt;i++){
        cambiarCarta(jugador[i], &palo, &numero);
        printf("%d%c  ", numero, palo);
    }
}
int ganarCarta(char palGanador, int numGanador, int numero1, char palo1, int numero2, char palo2){
    int jugador=0;
    if((palo1==palGanador && palo2==palGanador && ((numero1>numero2 && numero2!=1 && numero2!=3) || (numero2==3 && numero1==1))) || (palo1==palGanador && palo2!=palGanador) || (palo1!=palGanador && palo1!=palo2 && palo2!=palGanador) || (palo1==palo2 && numero1>numero2 || numero1==1 || numero1==3 && numero2!=1)){
        jugador=1;
    }
    else{
        jugador=2;
    }
    return jugador;
}


