# week-47-mini-project
# Produktlista
# Intro
Du ska skriva en console-app som frågar efter produkter. Efter att användaren har skrivit *exit* så visas alla (korrekt) inmatade produkter. Den första nivån av programmet är i nivå med vad du jobbat med första veckan. Nivå 3 är svår. Försök komma så långt du kan. Alla hjälpmedel är tillåtna och ni får prata med varandra.
# Nivå 1
I första nivån behöver du inte bry dig om formatet på den inmatade produkten. Användare anger en produkt och trycker *return*. När användaren fått nog så skriver hon *exit*. Då ska alla produkter visas.

Se följande exempel:

![image](https://github.com/user-attachments/assets/077fec36-ca79-45e0-9adb-9a82f54f5206)

## Nivå 2
Fortsätt med programmet. Lägg till följande:
- Användaren ska kunna skriva *exit* på olika sätt. Stora eller små bokstäver ska inte spela någon roll. Inledande eller avslutande mellanslag ska också accepteras.
- När användaren är klar, visa en sorterad lista
Se följande exempel:

![image](https://github.com/user-attachments/assets/7c8d900e-5c3c-44f0-8dee-2323631dd2bb)

## Nivå 3
Nu ska du validera produktnamnet och bara acceptera ett namn som består av bokstäver - bindestreck - siffror.
Siffer-delen måste vara ett heltal mellan 200 och 500.
Exempel på giltiga produktnamn:
- CE-400
- XX-480
- LABAN-231
Exempel på ogiltiga produktnamn:
- CE400
- XX3-480
- LABAN-100
Ge olika felmeddelande beroende på vilket fel användaren gör.
Se följande exempel

![image](https://github.com/user-attachments/assets/c719005c-ebfd-4902-a649-1dfd9356accc)

