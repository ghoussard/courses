%%
%%

int yywrap() {
  return 1;
}

int main(int argc, char ** argv) {
  while(yylex() != 0);
}
