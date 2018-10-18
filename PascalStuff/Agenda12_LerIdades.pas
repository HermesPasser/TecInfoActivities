program LerIdades;
uses Crt;
var N1, N2, N3, MEDIA : integer;
begin
   readln (n1,n2,n3);
   media := (n1 + n2 + n3)div3;
   if MEDIA>50 then begin
      write ('A média das idades é maior que 50');
   end else begin
      write ('A média das idades é menor ou igual a 50');
   end;
end.
