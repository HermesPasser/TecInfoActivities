program Imprime_n_maior_que3;
uses Crt;
var n1 : integer;
begin
   readln (n1);
   if n1>3 then begin
      write ('É maior que 3');
   end else begin
      if n1=3  then begin
         write ('É igual a 3');
      end else begin
         write ('É menor que 3');
      end;
   end;
end.
