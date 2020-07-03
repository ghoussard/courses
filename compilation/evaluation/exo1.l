%{
    int indentCount = 0;
%}

mot [a-zA-Z]+
ouvrante "<"{mot}">"
fermante "</"{mot}">"
autonome "<"{mot}"/>"

%%
{mot} {for(int i = 0; i < indentCount; i ++){printf("\t");}; printf("%s", yytext);}
{ouvrante} {for(int i = 0; i < indentCount; i ++){printf("\n");};puts(yytext); indentCount++;}
{fermante} {for(int i = 0; i < indentCount; i ++){printf("\n");};indentCount--; puts(yytext);}
{autonome} {for(int i = 0; i < indentCount; i ++){printf("\n");};printf("%s",yytext);}
.       { }
\n      { }
%%

int yywrap(){
    return 1;
}

int main(int argc, char **argv){
    while(yylex() != 0);
    puts("\nLe fichier est bien formé");
}
