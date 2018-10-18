program verQualOMaior;
uses Crt;
var n, nn : integer;

begin
   write ('Adicione os dois números. ');
   readln (n,nn);
   if n> nn then begin
      write ('Número 1 é o maior');
   end else begin
      write ('Número 2 é o maior');
   end;
end.