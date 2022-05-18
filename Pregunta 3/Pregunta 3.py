# -*- coding: utf-8 -*-
"""
Spyder Editor

This is a temporary script file.
"""
from pyswip import Prolog
prolog = Prolog()
prolog.assertz("padres(rosa,roberto,wilder)");
prolog.assertz("padres(rosa,roberto,carlos)");
prolog.assertz("padres(ignacia,valentin,rosa)");
prolog.assertz("padres(flora,pascual,roberto)");
prolog.assertz("padres(ines,gonzalo,oscar)");
prolog.assertz("padres(aydee,luis,alan)");
 
prolog.assertz("hermano(aydee,roberto)");
prolog.assertz("hermano(gonzalo,rosa)");

prolog.assertz("hermanos(A,B):- padres(M,P,A),padres(M,P,B),A\=B");
prolog.assertz("abuelo(X,Y):- padres(Z,W,Y),(padres(U,X,Z);padres(U,X,W))");
prolog.assertz("tio(X,Y):- padres(M,P,Y),(hermano(X,P);hermano(X,M))");
prolog.assertz("primo(X,Y):- (tio(Z,X),padres(Z,U,Y));(tio(Z,X),padres(U,Z,Y))");
prolog.assertz("nieto(X,Y):- abuelo(Y,X)");

for elemento in prolog.query("abuelo(X,Y)"):
        print(elemento["X"]," es el abuelo de ",elemento["Y"]) 
for elemento in prolog.query("primo(X,Y)"):
        print(elemento["X"]," es el primo de ",elemento["Y"])
for elemento in prolog.query("nieto(X,Y)"):
        print(elemento["X"]," es el nieto de ",elemento["Y"])
        
"""
    Resultado obtenido en consola:
        
        valentin  es el abuelo de  wilder
        pascual  es el abuelo de  wilder
        valentin  es el abuelo de  carlos
        pascual  es el abuelo de  carlos
        wilder  es el primo de  alan
        carlos  es el primo de  alan
        wilder  es el primo de  oscar
        carlos  es el primo de  oscar
        wilder  es el nieto de  valentin
        wilder  es el nieto de  pascual
        carlos  es el nieto de  valentin
        carlos  es el nieto de  pascual
"""