program soma;
uses Crt;
{ Fun��o : Soma dois n�meros}
{ Data : 19/10/2015}
var soma1, soma2, resultado, rep : real;
begin
   rep := 1;
   while rep = 1 do begin
      write ('Digite o primeiro n�mero: ');
      readln (soma1);
      write ('Digite o segundo n�mero: ');
      readln (soma2);
      resultado := soma1 + soma2;
      write ('O resultado �:', resultado);
      write (' / Quer fazer outra soma? Digite 1 para sim e 0 para n�o. ');
      readln (rep);
   end;
end.
