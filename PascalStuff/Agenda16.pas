program matrizMultiplica2Diagonal;
uses Crt;
{Algoritimo que checa as entradas do usu�rio e }
{armazena na matriz os n�mero e multiplica os }
{elementos da diagonal principal por 2 e imprima }
{a matrizresultante} }
var aMatriz :array [1..3,1..3] of integer;
aLinha,aColuna : integer;
begin
   {Come�a a estrutura de repeti��o}
   for aLinha := 1 to 3 do begin
      for aColuna := 1 to 3 do begin
         {Entrada de dados}
         write ('Entre com o n�mero ', aLinha, ',', aColuna,': ');
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
