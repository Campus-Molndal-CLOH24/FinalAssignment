 # Final Assignment

## Syfte - testning med TDD-Cykel (AAA)

 I det här projektet fick vi ett antal uppgifter att lösa, som vi skulle applicera TDD-cykeln på (AAA).
 TDD-cykeln består av tre huvudsteg;

 1. Arrange: Förbered indata och skapa objekt
 2. Act: Anropa metoden som ska testas
 3. Assert: Kontrollera att resultatet stämmer överens med det resultat som förväntas.

 ### Uppgift 1- Calculator 

Det här projektet är en enkel applikation som hanterar fyra grundläggande räknesätt: **addition**, **subtraktion**, **multiplikation** och **division**. Projektet följer **Test Driven Development (TDD)**, 
där metoder först testas med olika typer av indata och sedan implementeras för att få testerna att passera.


---

### **Anledning till att använda `double` och `TryParse`**

#### Problemet med `int`:
När jag började implementera metoderna för de olika räknesätten, använde jag först **`int`** som datatyp. Jag insåg snart att **`int`** har begränsningar, vilket vi gått igenom under tidigare kurser:
- **`int`** hanterar endast heltal.
- Om någon försöker mata in ett decimaltal (t.ex. `4.5`) eller en ogiltig inmatning som `"abc"`, skulle applikationen krascha.

#### Lösningen – `double` och `TryParse`:
För att lösa detta problem valde jag att använda **`double`** för att kunna hantera både heltal och decimaltal. Dessutom använder jag **`TryParse`** för att hantera ogiltig inmatning.
Innan jag gav mig på lösningen så frågade jag ChatGtp om min tanke var korrekt, och att detta skulle kunna säkerställa bättre "säkerhet", för eventuella försöka att krasha koden. Svaret blev ja!

**Fördelarna:**
- **`double`** kan hantera både heltal och decimaltal.
- **`TryParse`** försöker konvertera stränginmatning till ett tal och returnerar `false` om det misslyckas. Det kastar inte ett undantag, utan vi kan själva kasta ett anpassat undantag, som **`ArgumentException`**.

### Exempel på kod för division

```csharp
public double DivideFromInput(string inputA, string inputB)
{
    if (double.TryParse(inputA, out double a) && double.TryParse(inputB, out double b))
    {
        if (b == 0)
        {
            throw new ArgumentException("Kan inte dela med noll.");  // Undvik division med noll
        }
        return a / b;  // Utför divisionen om båda inmatningarna är giltiga
    }
    else
    {
        throw new ArgumentException("Ogiltig inmatning! Ange giltiga siffror.");  // Kasta undantag för ogiltig inmatning
    }
}
```
### Refaktorisera 
Efter att jag blev klar så skulle jag försöka refaktorisera, dels genom att skapa separata klasser för varje räknesätt. Tyvärr så fanns bara valet "create base class", vilket inte var vad jag hoppats/trott på. Frågade ChatGtp om det var enklast att bara skapa klasserna, kopiera koden och klistra in den, svaret blev ja. Skulle tydligen inte frågat, eftersom allt blev fel.
Minst 17 fel dök upp efter att jag flyttat add, blev 35 efter jag flyttat divide. Tog mig 1,5 h att få till det tillbaka igen. På det så saknades hela FinalAssignmentTest på Git, det tog 1,5 att fixa. 
Så mina planer på att refaktorisera gick inte som jag ville, och då bad jag helt enkelt ChatGtp att snygga till testklassen och Calculator åt mig, för jag mäktade inte med mer fel. 


## Uppgift 2 - Stränghantering 





