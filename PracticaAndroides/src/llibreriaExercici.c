#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#include <windows.h>
#include <string.h>
#include <stdbool.h>
#include "rlutil.h"
#include "llibreriaPropia.h"
#include "llibreriaExercici.h"

int preguntaOpcio(void)
{
    char menu[SORTIR][MAXCARMENU] = {
        " Inserir tipus Androide",
        " Inserir Androide",
        " Mostrar Androide",
        " Inserir Camp",
        " Mostrar camps",
        " Jornada de Treball",
        " Sortir"};
    int op;
    printf("MENU:\n");
    for (int i = 0; i < SORTIR; i++)
    {
        printf("%d.- %s\n", i + 1, menu[i]);
    }

    printf("\nIntrodueix quina opcio vols fer? [%d-%d]: ", 1, SORTIR);
    op = demanarNumEntreRangInt(INSERIRTIPUSANDROIDE, SORTIR);
    if (op!=3 && op!=5){cls();}
    else{Sleep(300);cls();}
    return op;
}
void altaTipus(char tipus[], char descripcio[])
{
    char total[MAXTOTAL];
    int j = 0;
    bool canvi = false;
    printf("\nIntrodueix tipus d'androide (tipus:descripció): ");
    entrarCadena(total, MAXTOTAL);
    for (int i = 0; i < strlen(total); i++)
    {
        if (total[i] == ':')
        {
            canvi = true;
            tipus[i] = '\0';
        }
        else if (!canvi)
        {
            tipus[i] = total[i];
        }
        else
        {
            descripcio[j] = total[i];
            j++;
        }
    }
    descripcio[j] = '\0';
}
void omplirTipus(TIPUSANDROIDE categoriaTipus[], int *qttTipus)
{
    char nouTipus[MAXTIPUS];
    char nouDes[MAXDESCRIPCIO];
    mostrarTipus(categoriaTipus, *qttTipus);
    if ((*qttTipus) == MAXTIPUS)
    {
        comentaris(1);
    }
    else
    {
        do
        {
            altaTipus(nouTipus, nouDes);
            printf("tipus: %s\n", nouTipus);
            printf("descripcio: %s\n", nouDes);
            if (buscarSiExisteix(nouTipus, categoriaTipus, *qttTipus))
            {
                printf("\nIntrodueix un tipus que no existeixi.");
            }
        } while (buscarSiExisteix(nouTipus, categoriaTipus, (*qttTipus)));
        strcpy(categoriaTipus[*qttTipus].tipus, nouTipus);
        strcpy(categoriaTipus[*qttTipus].descripcio, nouDes);
        (*qttTipus)++;
        mostrarTipus(categoriaTipus, (*qttTipus));
    }
}
void omplirAndroide(TIPUSANDROIDE categoriaTipus[], ANDROIDE categoriaAndroide[], int *qttAndroide, int *qttTipus)
{
    int novaSerie=(*qttAndroide)+100;
    int novaVelocitat=generarNumEntreRang(10,100);
    char tipus[MAXTIPUS];
    mostrarTipus(categoriaTipus, *qttTipus);
        do
        {
            printf("Introdueix el tipus d'Androide: ");
            entrarCadena(tipus, MAXTIPUS);
            if (!buscarSiExisteix(tipus, categoriaTipus, *qttTipus))
            {
                printf("\nIntrodueix un tipus que existeixi\n");
            }
        } while (!buscarSiExisteix(tipus, categoriaTipus, (*qttTipus)));
    categoriaAndroide[*qttAndroide].numeroSerie=novaSerie;
    strcpy(categoriaAndroide[*qttAndroide].tipus, tipus);
    categoriaAndroide[*qttAndroide].velocitat=novaVelocitat;
    printf("--Androide inserit correctament--\n");
    (*qttAndroide)++;
}
void omplirCamp(CAMP categoriaCamp[], int *qttCamp){
    char nouCamp[MAXCAMP];
    bool sortir=false;
    int j=0;
    mostrarCamp(categoriaCamp, *qttCamp);
    do
    {
        printf("Introdueix el nom del camp (S/s per sortir): ");
        entrarCadena(nouCamp, MAXCAMP);
        if(nouCamp[0]=='s' && nouCamp[1]=='\0' || nouCamp[0]=='S' && nouCamp[1]=='\0'){
            sortir=true;
        }
        else if (buscarSiExisteixCamp(nouCamp, categoriaCamp, *qttCamp))
        {
            printf("\nIntrodueix un camp que no existeixi\n");
        }
    } while (buscarSiExisteixCamp(nouCamp, categoriaCamp, (*qttCamp)) && sortir==false);
    if(sortir==false){
        strcpy(categoriaCamp[*qttCamp].nom,nouCamp);
        (*qttCamp)++;
    }
} 
void mostrarCamp(CAMP categoriaCamp[], int qttCamp){
printf("Camps de cultiu existents:\n");
    if (qttCamp != 0)
    {
        for (int i = 0; i < qttCamp; i++)
        {
            printf("%s\n", categoriaCamp[i].nom);
        }
    }
    else
    {
        printf("No hi ha camps de cultiu\n");
    }
}
void mostrarCampComplet(CAMP categoriaCamp[], int qttCamp){
setColor(GREEN);
printf("CAMPS DE CULTIU:\n");
    if (qttCamp != 0)
    {
        for (int i = 0; i < qttCamp; i++)
        {
            setColor(BLUE);
            printf("%s (%d)\n", categoriaCamp[i].nom, categoriaCamp[i].productes);
            setColor(RED);
            if(categoriaCamp[i].qttAndroide==0)printf("No n'hi ha cap androide inserit.\n");
            else printf("%s\n", categoriaCamp[i].androide);
            setColor(GREY);
        }
    }
    else
    {
        setColor(GREY);
        printf("No hi ha camps de cultiu\n");
    }
}
void mostrarAndroide(ANDROIDE androide[], int qttAndroide){
    printf("Androides registrats:\n");
    if (qttAndroide != 0)
    {
        for (int i = 0; i < qttAndroide; i++)
        {
            setColor(RED);
            printf("[Tipus: %s Num.Serie: %d Velocitat: %d]\n", androide[i].tipus, androide[i].numeroSerie, androide[i].velocitat);
            setColor(GREY);
        }
    }
    else
    {
        printf("\nNo s'ha inserit cap androide encara. \n");
    }
}
void mostrarTipus(TIPUSANDROIDE tipos[], int qttTipus)
{
    printf("Tipus d'androides registrats:\n");
    if (qttTipus != 0)
    {
        for (int i = 0; i < qttTipus; i++)
        {
            printf("%s: %s\n", tipos[i].tipus, tipos[i].descripcio);
        }
    }
    else
    {
        printf("\nNo hi ha cap tipus d'androide registrat. \n");
    }
}
void comentaris(int num)
{
    printf("\n");
    switch (num)
    {
    case 1:
        printf("Màxim de tipus introduits.");
        break;
    }
    printf("\n");
}
bool buscarSiExisteix(char nouTipus[], TIPUSANDROIDE tipos[], int qttTipus)
{
    bool existeix = false;
    int i = 0;
    while (existeix == false && i < qttTipus)
    {
        if (strcmpi(tipos[i].tipus, nouTipus) == 0)
        {
            existeix = true;
        }
        else
        {
            i++;
        }
    }
    return existeix;
}
bool buscarSiExisteixCamp(char nouTipus[], CAMP tipos[], int qttTipus)
{
    bool existeix = false;
    int i = 0;
    while (existeix == false && i < qttTipus)
    {
        if (strcmpi(tipos[i].nom, nouTipus) == 0)
        {
            existeix = true;
        }
        else
        {
            i++;
        }
    }
    return existeix;
}
void realitzarJornada(ANDROIDE categoriaAndroide[],CAMP categoriaCamp[], int * qttAndroide, int qttCamp){
    char campNou[MAXCAMP];
    int posCamp;
    int nouProd;
    printf("PAS 1: INSERIR PRODUCTES PER RECOLECTAR ALS CAMPS\n");
    mostrarCampComplet(categoriaCamp, qttCamp);
    introduirProductes(campNou, categoriaCamp, qttCamp, &posCamp, &nouProd);
    printf("PAS 2: LLISTAT PRODUCTES A RECOLECTAR\n");
    mostrarCampComplet(categoriaCamp, qttCamp);
    Sleep(200);
    cls();
    printf("PAS 3: ASSIGNACIÓ ANDROIDES ALS DIFERENTS CAMPS\n");
    asignarAndroides(categoriaAndroide, categoriaCamp, &(*qttAndroide), qttCamp);
    
}
int posicion(char campNou[], CAMP categoriaCamp[], int qttCamp){
    int i=0;
    bool igual=false;
    while (igual==false && i<qttCamp){
        if(strcmp(campNou, categoriaCamp[i].nom)==0){
            igual=true;
        }
        i++;
    }
    return i-1;
}
void introduirProductes(char campNou[], CAMP categoriaCamp[], int qttCamp, int *posCamp, int *nouProd){
    bool sortir=false;
    do{
    printf("Introdueix el nom del camp: ");
    entrarCadena(campNou, MAXCAMP);
        if(campNou[0]=='f' && campNou[1]=='\0') sortir=true;
        while(!buscarSiExisteixCamp(campNou, categoriaCamp, qttCamp) && !sortir){
            printf("Introdueix un camp vàlid: ");
            entrarCadena(campNou, MAXCAMP);
            if(campNou[0]=='f' && campNou[1]=='\0') sortir=true;
        }
        if(!sortir){
            (*posCamp)=posicion(campNou, categoriaCamp, qttCamp);
            printf("Introdueix la quantitat de productes: ");
            scanf("%d", &(*nouProd));
            categoriaCamp[*posCamp].productes=categoriaCamp[*posCamp].productes+(*nouProd);
            printf("\nCamp inserit correctament.");
        }
    }while(!sortir);
    Sleep(200);
    cls();
}
void asignarAndroides(ANDROIDE categoriaAndroide[], CAMP categoriaCamp[], int *qttAndroide,int  qttCamp){
    int qttCampPetit=categoriaCamp[0].qttAndroide;
    int indexCampPetit=0;
    int indexMesRapid=0;
    char campPetit[MAXCAMP];
    do{
        treureCampPetit(categoriaCamp, &qttCampPetit, &indexCampPetit, qttCamp, campPetit);
        indexMesRapid=androideMesRapid(categoriaAndroide, (*qttAndroide));
        categoriaCamp[indexCampPetit].androide[categoriaCamp[indexCampPetit].qttAndroide]=categoriaAndroide[indexMesRapid];
        categoriaCamp[indexCampPetit].qttAndroide++;
        ordenarAndroides(categoriaAndroide, &(*qttAndroide), indexCampPetit);
    } while((*qttAndroide)>0);
    mostrarCampComplet(categoriaCamp, qttCamp);
}
void treureCampPetit(CAMP categoriaCamp[], int *qttCampPetit, int *index, int qttCamp, char campPetit[]){
    // int i=0;
    // while (categoriaCamp[i].productes==0 && i<qttCamp){
    //     i++;
    // }
    // (*index)=i;
    // for(i=(*index)+1;i<qttCamp;i++){
    //     if(categoriaCamp[i].productes>0){
    //         if(categoriaCamp[i].qttAndroide<categoriaCamp[(*index)].qttAndroide){(*index)=i;}
    //         else if(categoriaCamp[i].qttAndroide==categoriaCamp[(*index)].qttAndroide && categoriaCamp[i].productes>categoriaCamp[(*index)].productes){
    //         (*index)=i;
    //         }
    //         }
    // }
    for(int i=0;i<qttCamp;i++){
                if(categoriaCamp[i+1].qttAndroide<qttCampPetit){
                    qttCampPetit=categoriaCamp[i+1].qttAndroide;
                    index=i+1;
                    strcpy(campPetit,categoriaCamp[i+1].nom);
                }
                else if(categoriaCamp[i+1].qttAndroide=qttCampPetit){
                    (*index)=treureMesProducte(categoriaCamp, &(*qttCampPetit), qttCamp);
                }
    };
}
int treureMesProducte(CAMP categoriaCamp[], int *qttCampPetit,int qttCamp){
    int index;
    for(int i=0;i<qttCamp;i++){
        if(categoriaCamp[i+1].productes>categoriaCamp[i].productes){
            index=i+1;
        }
        else if(categoriaCamp[i+1].productes==categoriaCamp[i].productes){
            index=i;
        }
    }
    return index;
}
int androideMesRapid(ANDROIDE categoriaAndroide[], int qttAndroide){
    int index;
    for(int i=0;i<qttAndroide;i++){
        if(categoriaAndroide[i+1].velocitat>categoriaAndroide[i].velocitat){
            index=i+1;
        }else if(categoriaAndroide[i+1].velocitat==categoriaAndroide[i].velocitat){
            index=i;
        }
    }
    return index;
}
void ordenarAndroides(ANDROIDE categoriaAndroide[], int *qtt, int index){
    for (int i=index; i<(*qtt);i++)
    {
        categoriaAndroide[index]=categoriaAndroide[index+1];
    }
    (*qtt)--;
}
