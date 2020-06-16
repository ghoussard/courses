/* Base de faits */
homme(albert).
homme(jean).
homme(paul).
homme(bertrand).
homme(louis).
homme(benoit).
femme(germaine).
femme(christiane).
femme(simone).
femme(marie).
femme(sophie).
pere(albert,jean).
pere(jean,paul).
pere(paul,bertrand).
pere(paul,sophie).
pere(jean,simone).
pere(louis,benoit).
mere(germaine,jean).
mere(christiane,simone).
mere(christiane,paul).
mere(simone,benoit).
mere(marie,bertrand).
mere(marie,sophie).


personne(luc).
age(luc, 15).
mineur(X) :- personne(X), age(X,Y), Y<18.

parent(X,Y) :- mere(X,Y).
parent(X,Y) :- pere(X,Y).

fils(X,Y) :- homme(X), parent(Y, X).
fille(X,Y) :- femme(X), parent(Y, X).
grand-pere(X,Y) :- homme(X), parent(Fils, Y), parent(X, Fils).
grand-mere(X,Y) :- femme(X), parent(Fils, Y), parent(X, Fils).

frere(X,Y) :- homme(X), pere(Pere, X), pere(Pere, Y), mere(Mere, X), mere(Mere, Y).
soeur(X,Y) :- femme(X), pere(Pere, X), pere(Pere, Y), mere(Mere, X), mere(Mere, Y).

aimer(X, vin) :- femme(X).
aimer(pierre, Y) :- aimer(Y, vin).
voleur(pierre).

vole(X, Y) :- voleur(X), aimer(X, Y).
