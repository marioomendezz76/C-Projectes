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

int demanarNumEntreRangInt(int min, int max)
{
    int num;
    do
    {
        scanf("%d", &num);
        if (num<min||num>max)
        {
            printf("Introdueix un valor entre [%d - %d]: ", min, max);
        }
    } while (num<min||num>max);
    while(getchar()!='\n');
    return(num);
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

int generarNumEntreRang(int minim,int maxim)
{
    return (rand()%(maxim-minim+1)+minim);
}

void intercanvi(int *num1, int *num2)
{
    int copia;
    copia=*num1;
    *num1=*num2;
    *num2=copia;
}

int demanaNum(void)
{
    int num;
    scanf("%d", &num);
    return num;
}

void pintaVector(int v[], int qtt)
{
    if (qtt==0)
    {
        printf("\nVector buit.");
    }
    else
    {
        for (int i=0; i<qtt; i++)
        {
            printf("\n[%02d]: %d", i, v[i]);
        }
    }
    printf("\n\n");
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

bool cerca(int v[], int qtt, int num)
{
    int i=0;
    bool apareix = false;
    while(!apareix&&i<qtt)
    {
        if (v[i]==num)
        {
            apareix=true;
        }
        i++;
    }
    return apareix;
}
void iniciarVector(int v[], int qtt, int valor)
{
    for (int i = 0; i < qtt; i++)
    {
        v[i] = valor;
    }
}
void entrarCadena(char cad[], int longitud){
    fgets(cad, longitud, stdin);
    if (strlen(cad)>0 && cad[strlen(cad)-1]=='\n'){
        cad[strlen(cad)-1]='\0';
    }
}
bool esLletra(char car){
    char lletres[]= "ABCDEFGHIJKLMNOPQRSTUVWXYZÀÁÈÉÍÏÒÓÚÜÑÇabcdefghijklmnopqrstuvwxyzàáèéíïòóúüñç";
    bool trobada=false;
    int i=0;
    int longitud=sizeof(lletres);
    while(i<longitud && !trobada){
        if(lletres[i]==car){
            trobada=true;
        }
        i++;
    }

    return trobada;
}