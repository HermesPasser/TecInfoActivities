program verQualOMaior;
uses Crt;
var n, nn : integer;

begin
   write ('Adicione os dois n�meros. ');
   readln (n,nn);
   if n> nn then begin
      write ('N�mero 1 � o maior');
   end else begin
      write ('N�mero 2 � o maior');
   end;
end.