# Faits
professeur(jean).
personne(luc).
age(luc,15).

# Règles

personne(X) :- professeur(X).
mineur(X) :- personne(X), age(X, Y), Y<18.
