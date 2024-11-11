#ifndef D8E5564E_A998_46E6_9A70_0B73488F1AF3
#define D8E5564E_A998_46E6_9A70_0B73488F1AF3
//incloure les llibreries que es necessiten
#include <stdbool.h>
#define MAXTIPUS 10
#define MAXDESCRIPCIO 40
#define MAXCARMENU 40
#define MAXTOTAL 100
#define MAXANDROIDE 40
#define MAXCAMP 20

enum OPCIONSMENU{
    INSERIRTIPUSANDROIDE=1,
    INSERIRANDROIDE,
    MOSTRARANDROIDE,
    INSERIRCAMP,
    MOSTRARCAMP,   
    JORNADA,
    SORTIR
};
typedef struct
{
    char tipus[MAXTIPUS];
    char descripcio[MAXDESCRIPCIO];
}TIPUSANDROIDE;

typedef struct
{
int numeroSerie;
char tipus[MAXTIPUS];
int velocitat;
}ANDROIDE;

typedef struct {
    char nom[MAXCAMP];
    int productes;
    ANDROIDE androide[MAXANDROIDE];
    int qttAndroide;
}CAMP;

int preguntaOpcio(void);
void altaTipus(char [], char []);
void omplirTipus(TIPUSANDROIDE [], int *);
void omplirAndroide(TIPUSANDROIDE [], ANDROIDE [], int *, int *);
void omplirCamp(CAMP [], int *);
void mostrarCamp(CAMP [], int );
void mostrarCampComplet(CAMP [], int );
void mostrarAndroide(ANDROIDE [], int );
void mostrarTipus(TIPUSANDROIDE [], int );
void comentaris(int );
bool buscarSiExisteix(char [], TIPUSANDROIDE [], int );
bool buscarSiExisteixCamp(char [], CAMP [], int );
void realitzarJornada(ANDROIDE [],CAMP [], int * , int );
int posicion(char [], CAMP [], int );
void introduirProductes(char [], CAMP [], int , int *, int *);
void asignarAndroides(ANDROIDE [], CAMP [], int *,int  );
void treureCampPetit(CAMP [], int *, int *, int , char []);
int treureMesProducte(CAMP [], int *,int );
int androideMesRapid(ANDROIDE [], int );
void ordenarAndroides(ANDROIDE [], int *, int );




#endif /* D8E5564E_A998_46E6_9A70_0B73488F1AF3 */
