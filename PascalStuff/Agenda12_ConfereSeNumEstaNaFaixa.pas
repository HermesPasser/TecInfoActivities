program Confere_se_num_está_na_faixa;
uses Crt;
var n1 : integer;
begin
   readln (n1);
   if n1>1 and n1<10 then begin
      write ('O valor fornecido está na faixa permitida.');
   end else begin
      write ('O valor fornecido está fora da faixa permitida.');
   end;
end.
