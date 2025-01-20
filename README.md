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
För att lösa detta problem valde jag att använda **`double`** som datatyp för att kunna hantera både heltal och decimaltal. Dessutom använder jag **`TryParse`** för att hantera ogiltig inmatning som abc eller null.
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

## Metoder

### Addition

#### AddFromInput

- Tar två stränginmatningar (inputA, inputB), försöker konvertera dem till double och returnerar summan. Om inmatningen inte kan konverteras till double, kastar den ett felmeddelande.

  
#### AddFromInputWithValidation

- Liknar AddFromInput. Validerar att inmatningen är korrekt (kan konverteras till double) innan den utför addition.


#### AddNegativePositive

- Beräknar summan av två nummer (negativa eller positiva) från stränginmatningar. Validerar och kastar fel för ogiltig inmatning.

### Division

#### DivideFromInput

- Tar två stränginmatningar, konverterar dem till double och returnerar kvoten (division).
Validerar att det andra talet inte är noll (division med noll är inte tillåten). Om det är ogiltig inmatning eller om det andra talet är noll, kastas ett felmeddelande.


### Multiplikation

#### MultiplyFromInput

- Tar två stränginmatningar, konverterar dem till double och returnerar produkten.
- Validerar att inmatningen är giltig.


#### MultiplyNegativePositive

- Utför multiplikation mellan två nummer (negativa eller positiva). Fungerar som MultiplyFromInput men med särskilt fokus på hantering av negativa och positiva tal.

  
### Substract

#### SubstractFromInput

- Tar två stränginmatningar, konverterar dem till double och returnerar differensen (subtraktion).
- Validerar att inmatningen är giltig.
  
#### SubstractNegativePositive

- Subtraherar två nummer (negativa eller positiva). Liknar SubstractFromInput men hanterar negativa och positiva tal.
  

## Uppgift 2 - Stränghantering 


StringProcessor är en klass som innehåller metoder för att bearbeta och manipulera strängar. Klassen innehåller olika metoder för att hantera vanliga textoperationer som att omvandla text till stora eller små bokstäver, reversera text, samt hantera specialfall som null och svenska tecken.

### Metoder 

1. #### Reverse
Beskrivning: Vänder en sträng baklänges.
Parameter: string? input (sträng som ska vändas).
Returnerar: En omvänd sträng eller en tom sträng om input är null.

3. #### ToLowerWord
Beskrivning: Konverterar hela strängen till små bokstäver.
Parameter: string? input.
Returnerar: En sträng i små bokstäver eller tom sträng om input är null.

5. #### ToUpperWord
Beskrivning: Konverterar hela strängen till stora bokstäver.
Parameter: string? input.
Returnerar: En sträng i stora bokstäver eller tom sträng om input är null.

7. #### ToLowerCaseNull
Beskrivning: Gör den första bokstaven i en sträng liten. Hanterar null och tomma strängar.
Parameter: string? input.
Returnerar: En sträng med första bokstaven i små bokstäver eller tom sträng.3

9. #### ToUpperCaseNull
Beskrivning: Gör den första bokstaven i en sträng stor. Hanterar null och tomma strängar.
Parameter: string? input.
Returnerar: En sträng med första bokstaven i stor bokstav eller tom sträng.

11. #### OnlyEnglsihLetters
Beskrivning: Ersätter svenska tecken (å, ä, ö, Å, Ä, Ö) med deras engelska motsvarigheter (a, o).
Parameter: string? input.
Returnerar: En sträng utan svenska specialtecken.

### Exempel på användning
```
var processor = new StringProcessor();

// Reverse
string reversed = processor.Reverse("Hello");  // Output: "olleH"

// ToLowerWord
string lowercase = processor.ToLowerWord("Hejsan");  // Output: "hejsan"

// ToUpperWord
string uppercase = processor.ToUpperWord("Hej");  // Output: "HEJ"

// OnlyEnglsihLetters
string englishOnly = processor.OnlyEnglsihLetters("Hallå där!");  // Output: "Halla dar!"
```

1. null-strängar
Reverse(null) → Returnerar "".
ToLowerWord(null) → Returnerar "".
2. Tomma strängar
Reverse("") → Returnerar "".
ToLowerCaseNull("") → Returnerar "".
3. Svenska tecken
OnlyEnglsihLetters("Gröt med Å, Ä och Ö") → Returnerar "Grot med A, A och O".
4. Blandade stora och små bokstäver
ToUpperCaseNull("hej") → Returnerar "Hej".
ToLowerCaseNull("HEJ") → Returnerar "hEJ".


### Refaktorisera 
Efter att jag blev klar så skulle jag försöka refaktorisera, dels genom att skapa separata klasser för varje räknesätt. Tyvärr så fanns bara valet "create base class", vilket inte var vad jag hoppats/trott på. Frågade ChatGtp om det var enklast att bara skapa klasserna, kopiera koden och klistra in den, svaret blev ja. Skulle tydligen inte frågat, eftersom allt blev fel.
Minst 17 fel dök upp efter att jag flyttat add, blev 35 efter jag flyttat divide. Tog mig 1,5 h att få till det tillbaka igen. På det så saknades hela FinalAssignmentTest på Git, det tog 1,5 att fixa. 
Så mina planer på att refaktorisera gick inte som jag ville, och då bad jag helt enkelt ChatGtp att snygga till testklassen och Calculator åt mig, för jag mäktade inte med mer fel.
Det blev så bra så jag applicerade det på övriga klasser också.





## Project Tested by Avinash Chowdary Bodduluri

I have started by cloning the project and run all the tests created by Maria. Project seems to be working as it should. It has all essential test scenarios for both Calculator class and StringProcessor class.
I have tested an extra test case that tests StringProcessor ReverseString when give string has space in it. Test passed. Apart from this i couldn't think of what else can be tested. Great work by Maria.
```    
        [TestMethod]
        public void Reverse_StringwithSpace_ReturnsReversedString()
        {
            var processor = new StringProcessor();
            var input = "Hello World!";
            var expected = "!dlroW olleH";
            var actual = processor.Reverse(input);
            Assert.AreEqual(expected, actual);
        }
```

