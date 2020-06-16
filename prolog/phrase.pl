sujet(john).
sujet(je).
sujet(ils).
sujet(les).
sujet(tu).
sujet(nous).

verbe(couche).
verbe(mange).
verbe(boit).
verbe(roule).
verbe(ferme).

complement(voiture).
complement(maison).
complement(pomme).
complement(nuage).
complement(ordinateur).

composer(S,V,C) :- sujet(S), verbe(V), complement(C).
