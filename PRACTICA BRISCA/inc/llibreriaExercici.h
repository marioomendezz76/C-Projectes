#ifndef D8E5564E_A998_46E6_9A70_0B73488F1AF3
#define D8E5564E_A998_46E6_9A70_0B73488F1AF3
//incloure les llibreries que es necessiten
#include <stdbool.h>
#define MAXVECTOR 48
#define MAXVECPUNTOS 13
#define MAXJUGADOR 3
void omplirVector(int [], int );
int traspasarCarta(char, int);
void cambiarCarta(int ,char *,int *);
int sacarCarta(int [],int *);
void repartirCartes(int [],int [],int *);
int puntsCarta(int, int, int );
bool mismoPalo(char ,char );
int posicioCarta(int [],int ,int);
pintaJugador(int [], int );
int ganarCarta(char , int , int , char , int , char );
#endif /* D8E5564E_A998_46E6_9A70_0B73488F1AF3 */
