program matrizMultiplica2Diagonal;
uses Crt;
{Algoritimo que checa as entradas do usuário e }
{armazena na matriz os número e multiplica os }
{elementos da diagonal principal por 2 e imprima }
{a matrizresultante} }
var aMatriz :array [1..3,1..3] of integer;
aLinha,aColuna : integer;
begin
   {Começa a estrutura de repetição}
   for aLinha := 1 to 3 do begin
      for aColuna := 1 to 3 do begin
         {Entrada de dados}
         write ('Entre com o número ', aLinha, ',', aColuna,': ');
         readln (aMatriz[aLinha,aColuna]);
         writeln ('');

         {Verifica e calcula se for o elemento da diagonal}
         if aLinha = aColuna then begin
            aMatriz[aLinha,aColuna] := aMatriz[aLinha,aColuna]*2;
         end;
      end;
   end;

   ClrScr;
   {Saida de dados}
   writeln ('Mostrando os valores: ');
   for aLinha := 1 to 3 do begin
      for aColuna := 1 to 3 do begin
         write (aMatriz[aLinha,aColuna]: 4,'|');
      end;
      writeln ('');
   end;
end.
