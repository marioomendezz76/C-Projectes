#ifndef __LLIBRERIA_PROPIA_H__
#define __LLIBRERIA_PROPIA_H__
//incloure les llibreries que es necessiten
#include <stdbool.h>
#define MIDA 80
#define FICADENA '\0'
#define ESPAI ' '
void acabament (void);
int demanaNumUnLimitInt(int);
int demanarNumEntreRangInt(int, int);
int generarNumEntreRang(int, int);
int demanaNum(void);
void intercanvi(int *, int *);
void pintaVector(int [], int);
int posicio(int [], int, int);
bool cerca(int [], int, int);
void iniciarVector(int [], int , int );
void entrarCadena(char cad[], int longitud);
bool esLletra(char car);
#endif