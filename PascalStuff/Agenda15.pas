program verValorDiv2e3;
uses Crt;
{Algoritimo que checa as entradas do usu�rio e }
{armazena no vetor e imprime se os valores forem }
{divisiveis por 2 ou 3.} }
var aVetor :array [1..12] of integer;
nRecebe,nContador,nResto : integer;
begin
   nContador := 1;
   while nContador <=12 do begin
      writeln ('(s� ser�o aceitos n�meros divisiveis por 2 ou 3)');
      write ('Entre com o n�mero ',nContador,': ');
      readln (nRecebe);
      nResto := nRecebe mod 2                                       {Calcula o resto};
      if nResto = 0 then begin                                           {Verifica se � divisivel por 2};
         aVetor[nContador] := nRecebe                            { Adiciona o valor ao vetor no local do vetor};
         nContador := nContador+1                                { Incrementa ao contador};
      end else begin
         nResto := nRecebe mod 3                                    {Calcula o resto};
         if nResto = 0 then begin                                        { Verifica se � divisivel por 3};
            aVetor[nContador] := nRecebe                            { Adiciona o valor ao vetor no local do vetor};
            nContador := nContador+1                                { Incrementa ao contador};
         end else begin                                                      {Mando mensagem de erro se n�o � divisuvel por 2 ou 3};
            writeln ('  N�mero inv�lido. Por Favor, insira outro.');
         end;
      end;
   end;
   writeln ('__________________________________________');
   writeln ('Mostrando os valores: ');
   writeln ('vetor 01: ',aVetor[1], ' vetor 02: ',aVetor[2], ' vetor 03: ',aVetor[3], ' vetor 04: ',aVetor[4]);
   writeln ('vetor 05: ',aVetor[5], ' vetor 06: ',aVetor[6], ' vetor 07: ',aVetor[7], ' vetor 08: ',aVetor[8]);
   writeln ('vetor 09: ',aVetor[9], ' vetor 10: ',aVetor[10],' vetor 11: ',aVetor[11], ' vetor 04: ',aVetor[12]);
end.