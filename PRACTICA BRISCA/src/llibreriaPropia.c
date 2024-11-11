#include <stdio.h>
#include <stdlib.h>
#include <time.h>  
#include <windows.h>
#include <string.h>
#include <stdbool.h>
#include "rlutil.h"
#include "llibreriaPropia.h"
#include "llibreriaExercici.h"

void acabament (void)
{
	printf("\nPrem una tecla per finalitzar");
	getch();
}
//Pedir numero entre un rango minimo y un maximo
int demanaNumEntreRangInt(int minim,int maxim)
{
    int n;
    do
    {
        scanf("%d",&n);
        if (n<minim || n>maxim)
        {
            printf("Introdueix un numero entre [%d-%d]: ",minim,maxim);
        }
    } while (n<minim || n>maxim);
    return n;
}

//Generar un numeor entre un rango minimo y maximo
int generarNumEntreRang(int minim,int maxim)
{
	return (rand()%(maxim-minim+1)+minim);
}

//rep un minim que aceptamos i retorna un numeros superior o igual a aquest minim
//0  -->    >=0
int demanaNumUnLimitInt(int minim)
{
    int n;
    do
    {
       scanf("%d",&n);
       if (n<minim)
       {
            printf("Introdueix un numero superior o igual a %d: ",minim);
       }
    } while (n<minim);
    return n;
}
char demanaCaracter(void)
{
    char car;
    scanf("%c",&car);
    while(getchar()!='\n');
    return car;
}
int demanaNumInt()
{
    int n;
    scanf("%d",&n);
    return n;
}
void intercanvi(int *num1,int *num2)
{
    int aux;
    aux=*num1;
    *num1=*num2;
    *num2=aux;
}
void pintaVector(int v[], int qtt)
{
    if (qtt == 0)
    {
        printf("\nVector buit");
    }

    else
    {   
            for (int i = 0; i < qtt; i++)
            {
                if (i%5==0){printf("\n");}
                printf("[%02d]: %02d\t", i, v[i]);
            }
    }
}


int posicio(int v[],int qtt,int numCerca)
{
    int i=0, pos=-1;
    while(i<qtt && pos==-1)
    {
        if(v[i]==numCerca)
        {
            pos=i;
        }
        else
        {
            i++;
        }
    }
    return pos;
}
bool cerca(int v[], int qtt, int numUsuari)
{
    bool trobat = false;
    int i = 0;
    while (i < qtt && !trobat)
    {
        if (v[i] <= numUsuari)
        {
            trobat = true;
        }
        else
        {
            i++;
        }
    }
    return trobat;
}
void ordenar(int v[], int qtt)
{
    bool canvi=false;
    for(int i=0; i<qtt-1 && !canvi; i++)
    {
        for(int j=0; j<qtt-i-1;j++)
        {
            if(v[j]>v[j+1])
            {
                canvi=true;
                intercanvi(&v[j], &v[j+1]);
            }
        }
        canvi=!canvi;
    }
}