program Verificar a prprocedência;
uses Crt;
{ Data : 03/11/2015}
var x, rep : integer;
begin
   rep := 1;
   while rep = 1 do begin
      writeln ('Digite o código do produto: ');
      readln (x);
      {Atenção: As restrições de case ... of no Pascal são maiores que de
      escolha ... fimescolha no Visualg.} 
      case x of
      1 : 
      begin
         writeln ('O produto vem do SUL.');
      end;
      2 : 
      begin
         writeln ('O produto vem do NORTE.');
      3 : 
      begin
         writeln ('O produto vem do LESTE.');
      end;
      4 : 
      begin
         writeln ('O produto vem do  OESTE.');
      5 : 
      begin
         writeln ('O produto vem do NORDESTE.');
      end;
      6 : 
      begin
         writeln ('O produto vem do SUDESTE.');
      7 : 
      begin
         writeln ('O produto vem do  CENTRO OESTE.');
      end;
      8 : 
      begin
         writeln ('O produto vem do NOROESTE.');
      end;
      else
      begin
         writeln ('O produto não consta no banco de dados.');
      end;
      end;
      writeln ('Deseja verificar outro código? Digite 1 para sim e 0 para não. ');
      readln (rep);
   end;
end.