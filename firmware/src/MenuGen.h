#ifndef MenuGen_h
#define MenuGen_h

// Tp3  manipulation MenuGen avec PEC12
// C. HUBER  03.02.2016
// Fichier MenuGen.h
// Gestion du menu  du g�n�rateur
// Traitement cyclique � 1 ms du Pec12

#include <stdbool.h>
#include <stdint.h>
#include "app.h"

void MENU_Initialize(S_ParamGen *pParam);

void MENU_Execute(S_ParamGen *pParam, bool local);

void MENU_DemandeSave (void);



#endif




  
   







