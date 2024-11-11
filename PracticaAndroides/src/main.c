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
	SetConsoleOutputCP(1252);
	SetConsoleCP(1252);
	srand(time(NULL));
	int qttTipus=0;
	TIPUSANDROIDE categoriaTipus[MAXTIPUS];
	int qttAndroide=0;
	ANDROIDE categoriaAndroide[MAXANDROIDE];
	int qttCamp=0;
	CAMP categoriaCamp[MAXCAMP];
	int opcio;
	do
	{
		opcio=preguntaOpcio();
		switch(opcio){
			case INSERIRTIPUSANDROIDE:  omplirTipus(categoriaTipus, &qttTipus); break;
			case INSERIRANDROIDE: omplirAndroide(categoriaTipus,categoriaAndroide, &qttAndroide, &qttTipus); break;
			case MOSTRARANDROIDE: mostrarAndroide(categoriaAndroide, qttAndroide);break;
			case INSERIRCAMP:  omplirCamp(categoriaCamp, &qttCamp) ;break;
			case MOSTRARCAMP: mostrarCampComplet(categoriaCamp, qttCamp); break; 
			case JORNADA:  realitzarJornada(categoriaAndroide, categoriaCamp, &qttAndroide, qttCamp);break;
			case SORTIR: printf("\nADEU"); break;
		}
	} while (opcio!=SORTIR);
	

	acabament();
	return 0;
}
