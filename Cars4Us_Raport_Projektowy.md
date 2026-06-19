# Cars4Us — system GUI do obsługi salonu samochodowego

**Technologia:** C# / .NET 10.0 / WinForms / MySQL  
**Autorzy:** Sebastian Pająk 
**Data:** 19.06.2026
**Link do demo YouTube:** [LINK DO DEMO YOUTUBE – DO UZUPEŁNIENIA]  

---

## Spis treści
1. [Cel projektu](#1-cel-projektu)
2. [Zakres funkcjonalny projektu](#2-zakres-funkcjonalny-projektu)
3. [Funkcjonalność zaawansowana](#3-funkcjonalność-zaawansowana)
4. [Wzorce projektowe](#4-wzorce-projektowe)
5. [Architektura projektu](#5-architektura-projektu)
6. [Baza danych](#6-baza-danych)
7. [Instrukcja uruchomienia projektu](#7-instrukcja-uruchomienia-projektu)
8. [Scenariusze testowe](#8-scenariusze-testowe)
9. [Ograniczenia projektu](#9-ograniczenia-projektu)
10. [Możliwości rozwoju](#10-możliwości-rozwoju)
11. [Podsumowanie](#11-podsumowanie)

---

## 1. Cel projektu
Celem projektu było stworzenie natywnej aplikacji GUI przeznaczonej do obsługi wybranych procesów wewnątrz salonu samochodowego. Projekt koncentruje się na dostarczeniu intuicyjnego interfejsu dla pracowników salonu, pozwalając na swobodne zarządzanie katalogiem opcji i akcesoriów, kadrą pracowniczą oraz przeprowadzanie kalkulacji wyceny pojazdu w oparciu o elastyczny silnik reguł cenowych. Całość oparta jest na bezpośrednim połączeniu z relacyjną bazą danych MySQL bez użycia warstwy ORM.

## 2. Zakres funkcjonalny projektu
Aplikacja realizuje następujące funkcjonalności podstawowe:

- **Katalog opcji i akcesoriów:** 
  - dodawanie nowych opcji do bazy,
  - edycja istniejących opcji,
  - kategoryzowanie opcji (np. SafetyPackage, Multimedia),
  - określanie cen opcji,
  - dezaktywacja opcji (bez fizycznego usuwania ich z bazy w celu zachowania spójności starych wycen).

- **Zarządzanie pracownikami:**
  - dodawanie i edycja kont pracowników,
  - przypisywanie do konkretnych ról: `Salesperson`, `Manager`, `ServiceTechnician`,
  - dezaktywacja pracowników.

- **Przypisywanie pracowników do transakcji:**
  - powiązanie identyfikatora pracownika (`EmployeeId`) z rekordem sprzedaży,
  - inteligentne filtrowanie przy wyborze handlowca tworzącego transakcję (dostępni tylko pracownicy z rolą `Salesperson`).

- **Podstawowa obsługa transakcji:**
  - rejestr zawartych i przygotowywanych transakcji,
  - przypisywanie powiązań między samochodem, klientem a pracownikiem,
  - określanie ostatecznej ceny końcowej i typu finansowania,
  - nadawanie i modyfikowanie statusu transakcji (np. `Created`, `Cancelled`).

- **Kalkulator wyceny:**
  - wybór bazowego modelu auta z systemu,
  - selekcja dodatkowego wyposażenia,
  - wybór rodzaju finansowania,
  - zastosowanie zniżek (rabat flotowy, promocja sezonowa),
  - generowanie szczegółowego zestawienia cenowego (breakdown ceny).

## 3. Funkcjonalność zaawansowana
Projekt wyróżnia implementacja mechanizmu **Pricing Pipeline**. Jest to wielowarstwowy silnik odpowiedzialny za dynamiczne wyliczenie całkowitego kosztu pojazdu dla klienta. Ścieżka wyceny bierze pod uwagę:
- cenę bazową pojazdu,
- sumaryczną wartość wybranych opcji dodatkowych,
- dodanie określonej marży salonu,
- odliczenie rabatu flotowego (w zależności od kryteriów),
- odliczenie zniżki wynikającej z promocji sezonowej,
- doliczenie prowizji/odsetek w zależności od wariantu finansowania,
- doliczenie wyliczonych składek na ubezpieczenie pojazdu,
- zwrócenie dokładnej ceny końcowej.

## 4. Wzorce projektowe
Aby zrealizować Pricing Pipeline w sposób umożliwiający łatwą rozbudowę i zachowanie zasady Open/Closed Principle (SOLID), projekt korzysta z dwóch klasycznych wzorców projektowych.

### A. Strategy (Strategia)
- **Cel użycia:** Uniezależnienie logiki algorytmów obliczania kosztów finansowania od głównego silnika kalkulacji.
- **Gdzie występuje:** W pakiecie `Services/Pricing/`. Różne formy finansowania posiadają skrajnie różne metody wyliczania kosztów początkowych, odsetek oraz obowiązkowych ubezpieczeń (np. leasing wymusza GAP, kredyt wymusza wyższe RRSO, gotówka jest wolna od odsetek).
- **Klasy implementujące:**
  - `IFinancingStrategy` – interfejs wspólny,
  - `CashFinancingStrategy` – brak kosztów dodatkowych,
  - `LeasingFinancingStrategy` – koszty ubezpieczenia leasingowego i prowizje,
  - `CreditFinancingStrategy` – koszty odsetek kredytowych,
  - `FinancingStrategyFactory` – fabryka dobierająca klasę na podstawie wyboru w GUI.

### B. Decorator (Dekorator)
- **Cel użycia:** Dynamiczne, warstwowe nakładanie (lub odejmowanie) składowych ceny w czasie trwania programu, bez konieczności rozbudowanego dziedziczenia klas modeli.
- **Gdzie występuje:** W pakiecie `Services/Pricing/`. Każda składowa ceny jest dekoratorem "owijającym" poprzednią wartość pojazdu.
- **Klasy implementujące:**
  - `IPriceComponent` – interfejs bazowy dla ceny,
  - `BaseCarPriceComponent` – klasa startowa zwracająca wyjściową kwotę za auto,
  - `PriceDecorator` – klasa abstrakcyjna pozwalająca na zagnieżdżanie komponentów,
  - `AdditionalOptionsDecorator` – dodaje do kwoty sprzęt opcjonalny,
  - `SalonMarginDecorator` – dodaje docelową marżę salonu,
  - `FleetDiscountDecorator` – odejmuje kwotę rabatu,
  - `SeasonalPromotionDecorator` – odejmuje promocję sezonową.

### C. PricingPipelineService
Klasa łącząca Decorator ze Strategy. Odbiera wybrane opcje z UI, konstruuje łańcuch dekoratorów (od ceny bazowej poprzez marżę aż po zniżki) – generując cenę pojazdu brutto. Następnie przekazuje tę cenę do wskazanej strategii finansowania. Ostatecznym wynikiem jest obiekt `PricingResult` zawierający zarówno całkowitą kwotę, jak i przejrzysty, wieloliniowy breakdown (historię modyfikacji kwoty od zera do finału).

## 5. Architektura projektu
Projekt został podzielony na odseparowane warstwy logiczne na poziomie katalogów:
- `Models/` – zawiera klasy odzwierciedlające obiekty bazodanowe (np. `Car.cs`, `Option.cs`, `Employee.cs`, `Customer.cs`, `SalesTransaction.cs`). Reprezentują one same dane.
- `Repositories/` – odpowiadają za interakcję z serwerem bazy danych MySQL (np. `CarRepository.cs`, `TransactionRepository.cs`). Każde repozytorium wykonuje zapytania ADO.NET (metody CRUD) w oparciu o obiekt klasy bazowej, nie wpuszczając kodu SQL do warstwy interfejsu.
- `Services/Pricing/` – centralny ośrodek logiki biznesowej odpowiadający za czyste, obiektowe kalkulacje wyceny pojazdów (nie posiada zależności od bazy danych).
- `Database/` – fizyczne skrypty przeznaczone do zbudowania środowiska bazodanowego.
- `*.cs` (główny katalog) – Formularze WinForms. Klasy te są ściśle odpowiedzialne za pobieranie akcji od użytkownika i aktualizowanie kontrolek na ekranie. Komunikują się one z repozytoriami lub usługami.

## 6. Baza danych
Wykorzystano serwer MySQL/MariaDB. Poniżej zestawienie kluczowych tabel zdefiniowanych w projekcie:
- `cars` – przechowuje parametry aut dostępnych w salonie (VIN, silnik, cena, status).
- `customers` – przechowuje dane personalne i kontaktowe klientów.
- `testdrives` – tablica asocjacyjna planująca testy wybranych aut dla konkretnych klientów.
- `options` – centralny słownik dodatków (kategorie i ceny poszczególnych modyfikacji).
- `employees` – kartoteka zespołu autoryzowanego dealera i zdefiniowane role.
- `transactions` – główny rejestr spinający pojazd (`CarId`), klienta (`CustomerId`) i handlowca (`EmployeeId`) z wynegocjowaną ceną i statusem zakupu.

**Skrypty SQL wdrożone w systemie:**
- `base_schema.sql` – szkielet podstawowych encji: cars, customers, testdrives.
- `options_employees_schema.sql` – rozszerzenie systemu o struktury kadry oraz cennik akcesoriów.
- `transactions_schema.sql` – struktura rejestru dla dokumentów sprzedażowych.
- `seed_demo_data.sql` – napełnia wygenerowane już struktury syntetycznymi danymi demonstracyjnymi gotowymi na testowanie (samochody, pracownicy, początkowe transakcje).

## 7. Instrukcja uruchomienia projektu
Aby prawidłowo wystartować system u siebie, wykonaj poniższe punkty:
1. Uruchom środowisko **XAMPP Control Panel**.
2. Kliknij `Start` obok modułów **Apache** oraz **MySQL**.
3. Wejdź w przeglądarce pod adres: `http://localhost/phpmyadmin/`.
4. Stwórz nową bazę danych i nadaj jej nazwę `cars4us`.
5. Będąc w kontekście wybranej bazy `cars4us`, zaimportuj i wykonaj skrypty w następującej kolejności:
   - `Database/base_schema.sql`
   - `Database/options_employees_schema.sql`
   - `Database/transactions_schema.sql`
   - `Database/seed_demo_data.sql`
6. Otwórz terminal lub wiersz poleceń i przejdź do głównego katalogu repozytorium.
7. Skompiluj i uruchom aplikację komendą:
   `dotnet run --project .\Cars4Us\Cars4Us.csproj`

## 8. Scenariusze testowe

### Test katalogu opcji
- **Kroki:** W głównym menu wejdź w "Opcje i akcesoria". Kliknij dodawanie nowej opcji, wpisz nazwę "Hak holowniczy", kategorię "Comfort", cenę "2500", zapisz.
- **Oczekiwany rezultat:** Opcja od razu wyświetla się w siatce (DataGridView), a status w bazie zapisuje ją jako aktywną.

### Test pracowników
- **Kroki:** W menu kliknij "Pracownicy". Dodaj pracownika z rolą `Manager`. Następnie dodaj drugiego z rolą `Salesperson`.
- **Oczekiwany rezultat:** Obaj są na liście głównych pracowników. Pracownik z rolą Salesperson będzie widoczny później przy zakładaniu transakcji.

### Test kalkulatora wyceny
- **Kroki:** Otwórz "Kalkulator wyceny". Zaznacz konkretny samochód. Dobierz z listy kilka akcesoriów, wybierz formę płatności "Leasing".
- **Oczekiwany rezultat:** Po prawej stronie w panelu pokaże się wyczerpujące podsumowanie (breakdown). Ukaże się bazowa kwota, dodane kwoty opcji, dodane ubezpieczenie dla leasingu i ostateczna rata / koszt.

### Test transakcji
- **Kroki:** Otwórz "Transakcje". Wybierz samochód, wybierz klienta, z listy "Handlowiec" wskaż wcześniej utworzonego pracownika (będą tam tylko Ci z rolą Salesperson). Określ kwotę, status `Created` i kliknij "Zapisz".
- **Oczekiwany rezultat:** Wiersz pojawi się w rejestrze. Kliknięcie w niego załaduje go ponownie do formularza, umożliwiając np. anulowanie.

## 9. Ograniczenia projektu
Projekt jest aplikacją demonstracyjną celującą w przejrzystość architektury. W obecnym kształcie należy jasno podkreślić:
- Projekt nie jest kompletnym, całościowym systemem ERP.
- Transakcje stanowią ewidencyjny rejestr – dodanie transakcji o statusie sprzedaży w obecnej wersji aplikacji **nie zdejmuje** automatycznie samochodu z asortymentu w bazie pojazdów (`Status` w tabeli `cars` nie aktualizuje się z zachowaniem w 100% transakcyjności).
- Pełny proces magazynowy oparty np. na architekturze Command/Memento nie został tu zaimplementowany, by nie komplikować struktury repozytoriów.
- Moduł jazd próbnych, choć ma swoje odzwierciedlenie w tabeli `testdrives`, wymaga dalszego oprogramowania GUI od strony aplikacji.

## 10. Możliwości rozwoju
Aplikacja została zaprojektowana na solidnych fundamentach, co pozostawia otwartą furtkę na wiele kluczowych usprawnień:
- **Zarządzanie stanem pojazdu:** Rozbudowa repozytoriów do w pełni transakcyjnych i wdrożenie wzorców operacyjnych reagujących na tworzenie umowy.
- **Pełny moduł CRM:** Budowa rozszerzonych formularzy dla modułu klientów z historią relacji.
- **Kalendarz:** Dedykowana podstrona GUI planująca i weryfikująca zderzenia czasowe dla jazd próbnych.
- **Autoryzacja i logowanie:** Wprowadzenie ekranu logowania autoryzującego pracownika.
- **Wydruki raportów:** Automatyczne eksportowanie historii sprzedaży do PDF/Excel.
- **Rozszerzone walidacje biznesowe:** Wdrożenie powłoki blokującej sprzedaż pojazdów aktualnie zarezerwowanych przez innego handlowca.

## 11. Podsumowanie
Aplikacja zrealizowała wszystkie zaplanowane funkcjonalności interfejsowe i bazodanowe pozwalające na skuteczną administrację kluczowymi słownikami dealera samochodowego. Kod oparto na zasadach SOLID, a proces Pricing Pipeline udowodnił zdolność systemu do adaptowania bardzo złożonych, zmiennych modeli finansowych z użyciem standardowych wzorców Strategy oraz Decorator, nie angażując przy tym ciężkich frameworków bazodanowych. Oprogramowanie to silny fundament gotowy do dalszej rozbudowy.
