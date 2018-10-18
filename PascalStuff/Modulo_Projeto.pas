program Game_Mexendo_No_VisualG;
uses Crt;
{ Fun��o : Perguntas e respostas para fixa��o da mat�ria do m�dulo1 do curso de Inform�tica do CPS}
{ Autor : Adriano Ribeiro , Douglas Silva , Leonardo Oliveira}
{ Data : 29/11/2015}
{ Se��o de Declara��es}
var
X : array [1..30] of integer;
Y , P : integer;
Cont : boolean  { ADICIONADO};

begin
   {-----------------------------------------------------------------}
   {  INTRODU��O AO JOGO}
   {-----------------------------------------------------------------}
   writeln ('Seja bem vindo ao nosso quiz!');
   writeln ('Escolha a alternativa correta e confira seus pontos.');
   writeln ('BOA SORTE!!!');
   writeln ('No final saberemos o seu n�vel de Conhecimento!');
   writeln ('Vamos Come�ar? ');
   writeln ('');
   writeln ('Digite o N�MERO da alternativa correta');
   writeln ('');
   writeln ('');


   {-----------------------------------------------------------------}
   {  PERGUNTA 01}
   {-----------------------------------------------------------------}
   Y := 1;
   P := 0;
   Cont := true;
   writeln ('01 Onde est� o erro no c�digo:');
   writeln ('   cacha�a : caractere');
   writeln ('   IN�CIO');
   writeln ('   cacha�a <- ''Boa''');
   writeln ('');
   writeln ('1 - N�o possui valor espec�fico');
   writeln ('2 - A vari�vel apresenta caracteres especiais');
   writeln ('3 - O valor atribu�do n�o corresponte ao tipo de vari�vel');
   writeln ('');

   {  Teste l�gico pergunta}
   while Cont = true  do begin

      write ('Digite a resposta certa: ');
      readln (X[Y]);
      if (X[Y]=2) then begin
         writeln ('Resposta certa, Parab�ns! ');
         P := P+10;
         writeln ('Voc� fez ',P, ' pontos.');
         cont := false;

      end else begin
         if (X[Y]=1) or (X[Y]=3) then begin
            writeln ('Ops, voc� errou! :(');
            writeln ('Alternativa correta �: 2 - Apresenta caracteres especiais');
            writeln ('Voc� continua com',P,' pontos');
            cont := false;
         end else begin
            writeln ('Comando Inv�lido!');
         end;
      end;
   end;
   writeln ('-----------------------------------------------------------');

   {-----------------------------------------------------------------}
   {  PERGUNTA 02}
   {-----------------------------------------------------------------}
   Cont := true;
   writeln ('02 Por que que uma vari�vel que contenha CPF n�o pode ser do tipo');
   writeln ('''inteira'' ou ''real''?');
   writeln ('');
   writeln ('1 - Porque apagaria os zeros � esquerda e tra�o seria removido');
   writeln ('2 - Porque fica muito feio');
   writeln ('3 - CPF n�o pode ser considerado vari�vel');
   writeln ('');

   {  Teste l�gico pergunta}
   while Cont = true  do begin

      write ('Digite a resposta certa: ');
      readln (X[Y]);
      if (X[Y]=1) then begin
         writeln ('Resposta certa, Parab�ns! ');
         P := P+10;
         writeln ('Voc� fez ',P, ' pontos.');
         cont := false;

      end else begin
         if (X[Y]=2) or (X[Y]=3) then begin
            writeln ('Ops, voc� errou! :(');
            writeln ('1 - Porque apagaria os zeros � esquerda e tra�o seria removido');
            writeln ('Voc� continua com',P,' pontos');
            cont := false;
         end else begin
            writeln ('Comando Inv�lido!');
         end;
      end;
   end;
   writeln ('-----------------------------------------------------------');

   {-----------------------------------------------------------------}
   {  PERGUNTA 03}
   {-----------------------------------------------------------------}
   Cont := true;
   writeln ('03 A vari�vel CPF deve ser do tipo o que?');
   writeln ('');
   writeln ('1 - Inteira - pois tem numeros');
   writeln ('2 - Vetor - por que indica um documento');
   writeln ('3 - Caractere - por que � para consulta');
   writeln ('');

   {  Teste l�gico pergunta}
   while Cont = true  do begin

      write ('Digite a resposta certa: ');
      readln (X[Y]);
      if (X[Y]=3) then begin
         writeln ('Resposta certa, Parab�ns! ');
         P := P+10;
         writeln ('Voc� fez ',P, ' pontos.');
         cont := false;

      end else begin
         if (X[Y]=1) or (X[Y]=2) then begin
            writeln ('Ops, voc� errou! :(');
            writeln ('Alternativa correta �: 3 - Caractere - por que � para consulta');
            writeln ('Voc� continua com',P,' pontos');
            cont := false;
         end else begin
            writeln ('Comando Inv�lido!');
         end;
      end;
   end;
   writeln ('-----------------------------------------------------------');

   {-----------------------------------------------------------------}
   {  PERGUNTA 04}
   {-----------------------------------------------------------------}
   Cont := true;
   writeln ('04 Escolha a alternativa correta em que se apresente um texto e o');
   writeln ('valor da vari�vel (nesta pergunta vari�vel =R)');
   writeln ('');
   writeln ('1 - escreva (''soma = R'')');
   writeln ('2 - escreva (''soma='',R)');
   writeln ('3 - escreva (''soma=''+R)');
   writeln ('');

   {  Teste l�gico pergunta}
   while Cont = true  do begin

      write ('Digite a resposta certa: ');
      readln (X[Y]);
      if (X[Y]=2) then begin
         writeln ('Resposta certa, Parab�ns! ');
         P := P+10;
         writeln ('Voc� fez ',P, ' pontos.');
         cont := false;

      end else begin
         if (X[Y]=1) or (X[Y]=3) then begin
            writeln ('Ops, voc� errou! :(');
            writeln ('Alternativa correta �: 2 - escreva (''soma='',R)');
            writeln ('Voc� continua com',P,' pontos');
            cont := false;
         end else begin
            writeln ('Comando Inv�lido!');
         end;
      end;
   end;
   writeln ('-----------------------------------------------------------');

   {-----------------------------------------------------------------}
   {  PERGUNTA 05}
   {-----------------------------------------------------------------}
   Cont := true;
   writeln ('05 Porque uma estrutura de repeti��o precisa de uma variavel contadora?');
   writeln ('');
   writeln ('1 - Por que sem ela a repeti��o n�o teria fim');
   writeln ('2 - Por que fica bonito');
   writeln ('3 - Por que o contador � a vari�vel e estrutura de repeti��o o seu tipo');
   writeln ('');

   {  Teste l�gico pergunta}
   while Cont = true  do begin

      write ('Digite a resposta certa: ');
      readln (X[Y]);
      if (X[Y]=1) then begin
         writeln ('Resposta certa, Parab�ns! ');
         P := P+10;
         writeln ('Voc� fez ',P, ' pontos.');
         cont := false;

      end else begin
         if (X[Y]=2) or (X[Y]=3) then begin
            writeln ('Ops, voc� errou! :(');
            writeln ('Alternativa correta �: 1 - Por que sem ela a repeti��o n�o teria fim');
            writeln ('Voc� continua com',P,' pontos');
            cont := false;
         end else begin
            writeln ('Comando Inv�lido!');
         end;
      end;
   end;
   writeln ('-----------------------------------------------------------');

   {-----------------------------------------------------------------}
   {  PERGUNTA 06}
   {-----------------------------------------------------------------}
   Cont := true;
   writeln ('06 O que falta ao codigo abaixo?');
   writeln ('  se valor  = numero');
   writeln ('  fimse');
   writeln ('');
   writeln ('1 - Faltou o valor de numero');
   writeln ('2 - Faltou o senao');
   writeln ('3 - Faltou o entao depois de numero no cabe�alho');
   writeln ('');

   {  Teste l�gico pergunta}
   while Cont = true  do begin

      write ('Digite a resposta certa: ');
      readln (X[Y]);
      if (X[Y]=3) then begin
         writeln ('Resposta certa, Parab�ns! ');
         P := P+10;
         writeln ('Voc� fez ',P, ' pontos.');
         cont := false;

      end else begin
         if (X[Y]=1) or (X[Y]=2) then begin
            writeln ('Ops, voc� errou! :(');
            writeln ('Alternativa correta �: 3 - Faltou o entao depois de numero no cabe�alho');
            writeln ('Voc� continua com',P,' pontos');
            cont := false;
         end else begin
            writeln ('Comando Inv�lido!');
         end;
      end;
   end;
   writeln ('-----------------------------------------------------------');

   {-----------------------------------------------------------------}
   {  PERGUNTA 07}
   {-----------------------------------------------------------------}
   Cont := true;
   writeln ('07 As estruturas');
   writeln ('  se x <falso entao');
   writeln ('e');
   writeln ('  se x !=verdadeiro entao');
   writeln ('d�o:');
   writeln ('');
   writeln ('1 - Resultados iguais');
   writeln ('2 - Erro');
   writeln ('3 - Resultados diferentes');
   writeln ('');

   {  Teste l�gico pergunta}
   while Cont = true  do begin

      write ('Digite a resposta certa: ');
      readln (X[Y]);
      if (X[Y]=1) then begin
         writeln ('Resposta certa, Parab�ns! ');
         P := P+10;
         writeln ('Voc� fez ',P, ' pontos.');
         cont := false;

      end else begin
         if (X[Y]=2) or (X[Y]=3) then begin
            writeln ('Ops, voc� errou! :(');
            writeln ('Alternativa correta �: 1 - Resultados iguais');
            writeln ('Voc� continua com',P,' pontos');
            cont := false;
         end else begin
            writeln ('Comando Inv�lido!');
         end;
      end;
   end;
   writeln ('-----------------------------------------------------------');

   {----------------------------------------------------------------}
   { FIM DO QUIZ E DECLARA��O DOS TESTES}
   {----------------------------------------------------------------}
   writeln ('');
   writeln ('');
   writeln ('Parab�ns! Voc� terminou o nosso jogo!');
   passo;
   writeln ('');
   writeln ('');
   writeln ('Voc� fez ',P,'/70 pontos');
   if(P<=20) then begin
      writeln ('Melhor estudar um pouco mais.');
   end;
   if(P>=30) and (P<=40) then begin
      writeln ('Bom, mas pode melhorar.');
   end;
   if (P>=50) then begin
      writeln ('Parab�ns! Voc� entendeu muito bem a mat�ria!');
   end;
   writeln ('');
   writeln ('');
   writeln ('OBRIGADO POR NOS DAR TODO ESSE SUPORTE!');
   writeln ('');
   writeln ('Douglas Silva - Suporte e an�lise');
   writeln ('Adriano Ribeiro - Testes Finais');
   writeln ('Leonardo Oliveira - Desenvolvimento');
end.