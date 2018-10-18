program soma;
uses Crt;
{ Função : Soma dois números}
{ Data : 19/10/2015}
var soma1, soma2, resultado, rep : real;
begin
   rep := 1;
   while rep = 1 do begin
      write ('Digite o primeiro número: ');
      readln (soma1);
      write ('Digite o segundo número: ');
      readln (soma2);
      resultado := soma1 + soma2;
      write ('O resultado é:', resultado);
      write (' / Quer fazer outra soma? Digite 1 para sim e 0 para não. ');
      readln (rep);
   end;
end.
