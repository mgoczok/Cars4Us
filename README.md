# Cars4Us — Car Dealership GUI

Aplikacja WinForms do obsługi salonu samochodowego. Umożliwia zarządzanie opcjami i akcesoriami, pracownikami, transakcjami sprzedażowymi oraz wycenę pojazdów z wykorzystaniem systemu kalkulacji cen.

## Technologie

- **Język:** C#
- **Framework:** .NET 10.0
- **GUI:** Windows Forms (WinForms)
- **Baza danych:** MySQL/MariaDB (uruchamiana poprzez XAMPP)
- **Dostęp do danych:** MySql.Data (czysty ADO.NET, brak ORM)
- **Kontrola wersji:** Git/GitHub

## Zrealizowane funkcjonalności podstawowe

Projekt realizuje wybrane funkcjonalności podstawowe:
- **Katalog opcji i akcesoriów:** Zarządzanie asortymentem, kategoryzowanie oraz definiowanie cen opcji.
- **Zarządzanie pracownikami:** Baza pracowników z przypisaniem ról (`Salesperson`, `Manager`, `ServiceTechnician`).
- **Przypisywanie pracowników do transakcji:** Możliwość wyboru handlowca (`EmployeeId`) odpowiedzialnego za daną transakcję.
- **Podstawowa obsługa transakcji:** Zapisywanie informacji o sprzedaży, wskazanie pojazdu, klienta, pracownika oraz statusu transakcji. Transakcje mają charakter rejestru i nie modyfikują jeszcze dostępności samochodów.
- **Kalkulator wyceny:** Formularz (`PricingForm`) do sprawdzania cen przy wyborze różnych opcji i metod płatności.

## Funkcjonalność zaawansowana: Pricing Pipeline

Projekt zawiera zaawansowany silnik wielopoziomowego obliczania cen (`PricingPipelineService`), obsługujący różne scenariusze finansowania oraz nakładanie i odejmowanie składników ceny (np. opcje dodatkowe, rabaty). 

### Opis wykorzystanych wzorców projektowych

1. **Strategy (Strategia)**
   - **Gdzie jest użyty:** Kalkulacja kosztów w zależności od rodzaju finansowania (w pakiecie `Services/Pricing`).
   - **Jakie klasy go implementują:** Interfejs `IFinancingStrategy` oraz warianty finansowania: `CashFinancingStrategy`, `CreditFinancingStrategy`, `LeasingFinancingStrategy`. Klasa `FinancingStrategyFactory` dostarcza odpowiedni algorytm.
   - **Za co odpowiada:** Odseparowanie metod liczenia całkowitego kosztu od głównego kodu wyceny. Wybór strategii płatności zmienia sposób wyliczenia ostatecznego narzutu (lub jego braku).

2. **Decorator (Dekorator)**
   - **Gdzie jest użyty:** Modyfikowanie ceny bazowej pojazdu poprzez warstwowe modyfikatory (w pakiecie `Services/Pricing`).
   - **Jakie klasy go implementują:** Interfejs `IPriceComponent`, implementacja wyjściowa `BaseCarPriceComponent`, abstrakcyjny dekorator `PriceDecorator` oraz konkretne składowe: `AdditionalOptionsDecorator`, `SalonMarginDecorator`, `FleetDiscountDecorator`, `SeasonalPromotionDecorator`.
   - **Za co odpowiada:** Umożliwia dynamiczne dodawanie kwot (np. marża salonu, opcje) oraz ich odejmowanie (np. zniżki) na zasadzie "matrioszki". Dekoratory odpowiadają także za poprawne generowanie wieloliniowego podsumowania elementów ceny (breakdown).

## Struktura projektu

- `Models/` – klasy odwzorowujące modele z bazy danych (np. `Car`, `Employee`, `Option`, `SalesTransaction`, `Customer`).
- `Repositories/` – klasy odpowiedzialne za dostęp do bazy przy użyciu parametryzowanych zapytań SQL bez użycia ORM (np. `CarRepository`, `EmployeeRepository`, `TransactionRepository`).
- `Services/Pricing/` – silnik do wyceny i implementacje wzorców projektowych.
- `Database/` – skrypty SQL (DDL i DML) do utworzenia schematów tabel i danych demonstracyjnych.
- Formularze WinForms – logika prezentacji (np. `MainForm`, `CarsForm`, `OptionsForm`, `EmployeesForm`, `PricingForm`, `TransactionsForm`).

## Instrukcja uruchomienia

1. Uruchom **XAMPP**.
2. Włącz moduły **Apache** oraz **MySQL**.
3. Wejdź do przeglądarki pod adres `http://localhost/phpmyadmin/`.
4. Utwórz nową bazę danych o nazwie `cars4us`.
5. Uruchom skrypty SQL opisane w następnym rozdziale.
6. Uruchom projekt wpisując w konsoli (w katalogu głównym projektu):
   `dotnet run --project .\Cars4Us\Cars4Us.csproj`

### Instrukcja przygotowania bazy danych

W kliencie phpMyAdmin dla bazy `cars4us` wykonaj kolejno następujące skrypty SQL z folderu `Database/`:

1. `Database/base_schema.sql` – utworzy tabele podstawowe (`cars`, `customers`, `testdrives`).
2. `Database/options_employees_schema.sql` – utworzy tabele asortymentu i pracowników.
3. `Database/transactions_schema.sql` – utworzy tabelę transakcji i klucze obce.
4. `Database/seed_demo_data.sql` – uzupełni tabele przykładowymi danymi demonstracyjnymi.

## Jak przetestować aplikację

- **Moduł opcji:** W oknie "Opcje i akcesoria" przetestuj siatkę danych oraz dodawanie nowej opcji.
- **Moduł pracowników:** W oknie "Pracownicy" przejrzyj listę ról i sprawdź poprawne filtrowanie handlowców.
- **Kalkulator wyceny:** W oknie "Kalkulator wyceny" dodawaj rabaty oraz różne opcje finansowania, sprawdzając kalkulacje.
- **Moduł transakcji:** W oknie "Transakcje" wyselekcjonuj samochód, klienta i sprzedawcę (rolę handlowca) z list rozwijanych i dodaj transakcję.

## Status projektu

Projekt realizuje wybrane funkcjonalności podstawowe oraz zaawansowany proces wyceny (Pricing Pipeline). 
Nie jest to pełny system ERP. W szczególności:
- Transakcje stanowią na razie prosty rejestr ewidencyjny i nie zmieniają automatycznie statusu w bazie pojazdów (`cars`).
- Proces biznesowy sprzedaży nie wykorzystuje jeszcze pełnego wzorca Command/Memento do zapisywania, realizowania czy cofania operacji magazynowych na poziomie systemu.
