%{
  int nbv = 0, nbc = 0, nbp =0;
%}
voyelle [aeiouyAEIOUY]
consonne [b-df-hj-np-tv-xzB-DF-HJ-NP-TV-XZ]
ponctuation [,;\.\?\!]
%%
{voyelle} { nbv++; }
{consonne} { nbc++; }
{ponctuation} { nbp++; }
%%

int yywrap() {
  return 1;
}

int main(int argc, char ** argv) {
  while(yylex() != 0);
  printf("%d voyelles \n", nbv);
  printf("%d consonnes \n", nbc);
  printf("%d ponctuations \n", nbp);
}


