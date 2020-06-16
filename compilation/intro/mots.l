mot [a-zA-Z]+
entier [0-9]+
%%
{mot} { puts("mot"); }
{entier} { puts("entier"); }
%%

int yywrap() {
  return 1;
}

int main(int argc, char ** argv) {
  while(yylex() != 0);
}
