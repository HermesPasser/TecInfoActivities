program Game_Mexendo_No_VisualG;
uses Crt;
{ Função : Perguntas e respostas para fixação da matéria do módulo1 do curso de Informática do CPS}
{ Autor : Adriano Ribeiro , Douglas Silva , Leonardo Oliveira}
{ Data : 29/11/2015}
{ Seção de Declarações}
var
X : array [1..30] of integer;
Y , P : integer;
Cont : boolean  { ADICIONADO};

begin
   {-----------------------------------------------------------------}
   {  INTRODUÇÃO AO JOGO}
   {-----------------------------------------------------------------}
   writeln ('Seja bem vindo ao nosso quiz!');
   writeln ('Escolha a alternativa correta e confira seus pontos.');
   writeln ('BOA SORTE!!!');
   writeln ('No final saberemos o seu nível de Conhecimento!');
   writeln ('Vamos Começar? ');
   writeln ('');
   writeln ('Digite o NÚMERO da alternativa correta');
   writeln ('');
   writeln ('');


   {-----------------------------------------------------------------}
   {  PERGUNTA 01}
   {-----------------------------------------------------------------}
   Y := 1;
   P := 0;
   Cont := true;
   writeln ('01 Onde está o erro no código:');
   writeln ('   cachaça : caractere');
   writeln ('   INÍCIO');
   writeln ('   cachaça <- ''Boa''');
   writeln ('');
   writeln ('1 - Não possui valor específico');
   writeln ('2 - A variável apresenta caracteres especiais');
   writeln ('3 - O valor atribuído não corresponte ao tipo de variável');
   writeln ('');

   {  Teste lógico pergunta}
   while Cont = true  do begin

      write ('Digite a resposta certa: ');
      readln (X[Y]);
      if (X[Y]=2) then begin
         writeln ('Resposta certa, Parabéns! ');
         P := P+10;
         writeln ('Você fez ',P, ' pontos.');
         cont := false;

      end else begin
         if (X[Y]=1) or (X[Y]=3) then begin
            writeln ('Ops, você errou! :(');
            writeln ('Alternativa correta é: 2 - Apresenta caracteres especiais');
            writeln ('Você continua com',P,' pontos');
            cont := false;
         end else begin
            writeln ('Comando Inválido!');
         end;
      end;
   end;
   writeln ('-----------------------------------------------------------');

   {-----------------------------------------------------------------}
   {  PERGUNTA 02}
   {-----------------------------------------------------------------}
   Cont := true;
   writeln ('02 Por que que uma variável que contenha CPF não pode ser do tipo');
   writeln ('''inteira'' ou ''real''?');
   writeln ('');
   writeln ('1 - Porque apagaria os zeros à esquerda e traço seria removido');
   writeln ('2 - Porque fica muito feio');
   writeln ('3 - CPF não pode ser considerado variável');
   writeln ('');

   {  Teste lógico pergunta}
   while Cont = true  do begin

      write ('Digite a resposta certa: ');
      readln (X[Y]);
      if (X[Y]=1) then begin
         writeln ('Resposta certa, Parabéns! ');
         P := P+10;
         writeln ('Você fez ',P, ' pontos.');
         cont := false;

      end else begin
         if (X[Y]=2) or (X[Y]=3) then begin
            writeln ('Ops, você errou! :(');
            writeln ('1 - Porque apagaria os zeros à esquerda e traço seria removido');
            writeln ('Você continua com',P,' pontos');
            cont := false;
         end else begin
            writeln ('Comando Inválido!');
         end;
      end;
   end;
   writeln ('-----------------------------------------------------------');

   {-----------------------------------------------------------------}
   {  PERGUNTA 03}
   {-----------------------------------------------------------------}
   Cont := true;
   writeln ('03 A variável CPF deve ser do tipo o que?');
   writeln ('');
   writeln ('1 - Inteira - pois tem numeros');
   writeln ('2 - Vetor - por que indica um documento');
   writeln ('3 - Caractere - por que é para consulta');
   writeln ('');

   {  Teste lógico pergunta}
   while Cont = true  do begin

      write ('Digite a resposta certa: ');
      readln (X[Y]);
      if (X[Y]=3) then begin
         writeln ('Resposta certa, Parabéns! ');
         P := P+10;
         writeln ('Você fez ',P, ' pontos.');
         cont := false;

      end else begin
         if (X[Y]=1) or (X[Y]=2) then begin
            writeln ('Ops, você errou! :(');
            writeln ('Alternativa correta é: 3 - Caractere - por que é para consulta');
            writeln ('Você continua com',P,' pontos');
            cont := false;
         end else begin
            writeln ('Comando Inválido!');
         end;
      end;
   end;
   writeln ('-----------------------------------------------------------');

   {-----------------------------------------------------------------}
   {  PERGUNTA 04}
   {-----------------------------------------------------------------}
   Cont := true;
   writeln ('04 Escolha a alternativa correta em que se apresente um texto e o');
   writeln ('valor da variável (nesta pergunta variável =R)');
   writeln ('');
   writeln ('1 - escreva (''soma = R'')');
   writeln ('2 - escreva (''soma='',R)');
   writeln ('3 - escreva (''soma=''+R)');
   writeln ('');

   {  Teste lógico pergunta}
   while Cont = true  do begin

      write ('Digite a resposta certa: ');
      readln (X[Y]);
      if (X[Y]=2) then begin
         writeln ('Resposta certa, Parabéns! ');
         P := P+10;
         writeln ('Você fez ',P, ' pontos.');
         cont := false;

      end else begin
         if (X[Y]=1) or (X[Y]=3) then begin
            writeln ('Ops, você errou! :(');
            writeln ('Alternativa correta é: 2 - escreva (''soma='',R)');
            writeln ('Você continua com',P,' pontos');
            cont := false;
         end else begin
            writeln ('Comando Inválido!');
         end;
      end;
   end;
   writeln ('-----------------------------------------------------------');

   {-----------------------------------------------------------------}
   {  PERGUNTA 05}
   {-----------------------------------------------------------------}
   Cont := true;
   writeln ('05 Porque uma estrutura de repetição precisa de uma variavel contadora?');
   writeln ('');
   writeln ('1 - Por que sem ela a repetição não teria fim');
   writeln ('2 - Por que fica bonito');
   writeln ('3 - Por que o contador é a variável e estrutura de repetição o seu tipo');
   writeln ('');

   {  Teste lógico pergunta}
   while Cont = true  do begin

      write ('Digite a resposta certa: ');
      readln (X[Y]);
      if (X[Y]=1) then begin
         writeln ('Resposta certa, Parabéns! ');
         P := P+10;
         writeln ('Você fez ',P, ' pontos.');
         cont := false;

      end else begin
         if (X[Y]=2) or (X[Y]=3) then begin
            writeln ('Ops, você errou! :(');
            writeln ('Alternativa correta é: 1 - Por que sem ela a repetição não teria fim');
            writeln ('Você continua com',P,' pontos');
            cont := false;
         end else begin
            writeln ('Comando Inválido!');
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
   writeln ('3 - Faltou o entao depois de numero no cabeçalho');
   writeln ('');

   {  Teste lógico pergunta}
   while Cont = true  do begin

      write ('Digite a resposta certa: ');
      readln (X[Y]);
      if (X[Y]=3) then begin
         writeln ('Resposta certa, Parabéns! ');
         P := P+10;
         writeln ('Você fez ',P, ' pontos.');
         cont := false;

      end else begin
         if (X[Y]=1) or (X[Y]=2) then begin
            writeln ('Ops, você errou! :(');
            writeln ('Alternativa correta é: 3 - Faltou o entao depois de numero no cabeçalho');
            writeln ('Você continua com',P,' pontos');
            cont := false;
         end else begin
            writeln ('Comando Inválido!');
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
   writeln ('dão:');
   writeln ('');
   writeln ('1 - Resultados iguais');
   writeln ('2 - Erro');
   writeln ('3 - Resultados diferentes');
   writeln ('');

   {  Teste lógico pergunta}
   while Cont = true  do begin

      write ('Digite a resposta certa: ');
      readln (X[Y]);
      if (X[Y]=1) then begin
         writeln ('Resposta certa, Parabéns! ');
         P := P+10;
         writeln ('Você fez ',P, ' pontos.');
         cont := false;

      end else begin
         if (X[Y]=2) or (X[Y]=3) then begin
            writeln ('Ops, você errou! :(');
            writeln ('Alternativa correta é: 1 - Resultados iguais');
            writeln ('Você continua com',P,' pontos');
            cont := false;
         end else begin
            writeln ('Comando Inválido!');
         end;
      end;
   end;
   writeln ('-----------------------------------------------------------');

   {----------------------------------------------------------------}
   { FIM DO QUIZ E DECLARAÇÃO DOS TESTES}
   {----------------------------------------------------------------}
   writeln ('');
   writeln ('');
   writeln ('Parabéns! Você terminou o nosso jogo!');
   passo;
   writeln ('');
   writeln ('');
   writeln ('Você fez ',P,'/70 pontos');
   if(P<=20) then begin
      writeln ('Melhor estudar um pouco mais.');
   end;
   if(P>=30) and (P<=40) then begin
      writeln ('Bom, mas pode melhorar.');
   end;
   if (P>=50) then begin
      writeln ('Parabéns! Você entendeu muito bem a matéria!');
   end;
   writeln ('');
   writeln ('');
   writeln ('OBRIGADO POR NOS DAR TODO ESSE SUPORTE!');
   writeln ('');
   writeln ('Douglas Silva - Suporte e análise');
   writeln ('Adriano Ribeiro - Testes Finais');
   writeln ('Leonardo Oliveira - Desenvolvimento');
end.