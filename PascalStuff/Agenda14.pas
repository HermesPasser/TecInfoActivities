program paresAtéCem;
uses Crt;
{ Autor :   douglas silva lacerda}
var n : integer;
begin
   writeln ('Na estrutura para...fimpara');
   for n := 1 to 100 do begin
      if n mod 2 = 0 then begin
         writeln (n);
      end;
   end;
   n := 1;
   writeln ('Na estrutura enquanto...fimenquanto');
   while n<101 do begin
      if n mod 2 = 0 then begin
         writeln (n);
      end;
      n := n + 1;
   end;
   n := 1;
   writeln ('Na estrutura repita...fimrepita');
   repeat
      if n mod 2 = 0 then begin
         writeln (n);
      end;
      n := n + 1;
   until n>=101;
   fimrepita;
end.