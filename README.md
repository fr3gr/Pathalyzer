# Ping & Net Tester v4

![Wersja .NET](https://img.shields.io/badge/.NET_Framework-4.7.2+-blueviolet)
![Licencja](https://img.shields.io/badge/Licencja-MIT-blue)
![Status](https://img.shields.io/badge/Status-Ukończony-brightgreen)

Zaawansowane narzędzie desktopowe do diagnostyki sieci, łączące w sobie funkcjonalność wielowątkowego pingu oraz testu prędkości połączenia internetowego. Aplikacja została napisana w C# z użyciem Windows Forms i posiada nowoczesny, responsywny interfejs użytkownika w ciemnym motywie.



## Główne Funkcje

-   **🌐 Testowanie Ping:**
    -   Możliwość pingowania wielu predefiniowanych serwerów DNS jednocześnie.
    -   Opcja wpisania własnego hosta (adresu IP lub domeny) do testów.
    -   Konfigurowalna liczba pakietów wysyłanych do każdego hosta.
    -   Szczegółowe statystyki dla każdego celu: czas średni, minimalny i maksymalny.

-   **🔄 Ping Cykliczny:**
    -   Tryb "Auto Ping" do ciągłego monitorowania stabilności połączenia w określonych interwałach.

-   **⚡ Test Prędkości:**
    -   **Download:** Mierzy realną prędkość pobierania, korzystając z dużego pliku testowego umieszczonego na stabilnym serwerze akademickim ICM w Warszawie.
    -   **Upload:** Mierzy prędkość wysyłania poprzez wysłanie wygenerowanych danych do serwera testowego.
    -   **Ping:** Wyświetla opóźnienie do serwera używanego w teście prędkości.

-   **💾 Logowanie i Zapis Wyników:**
    -   Wszystkie wyniki testów ping są automatycznie zapisywane w czasie rzeczywistym.
    -   **Plik tekstowy (`ping_log.txt`):** Czytelny dla człowieka log ze znacznikami czasu.
    -   **Plik CSV (`ping_results.csv`):** Dane w formacie przyjaznym dla arkuszy kalkulacyjnych (np. Excel), idealne do dalszej analizy i tworzenia wykresów.

-   **🎨 Nowoczesny Interfejs Użytkownika:**
    -   Ciemny motyw, inspirowany profesjonalnymi narzędziami deweloperskimi.
    -   Czysty, przejrzysty layout z logicznie pogrupowanymi funkcjami.
    -   Ikony i spójna typografia dla lepszej czytelności.
    -   Pełna obsługa anulowania długotrwałych operacji.

## Uruchomienie

Projekt został stworzony w Visual Studio 2022 i jest gotowy do kompilacji.

### Wymagania

-   **System operacyjny:** Windows 7 lub nowszy
-   **Platforma:** .NET Framework 4.7.2 (lub nowsza)

### Instalacja

1.  Sklonuj repozytorium na swój dysk:
    ```sh
    git clone https://github.com/fr3gr/Pathalyzer.git
    ```
2.  Otwórz plik rozwiązania (`PingTester.sln`) w programie Visual Studio.
3.  Upewnij się, że wszystkie zależności (jeśli istnieją) zostały przywrócone.
4.  Naciśnij `F5` lub kliknij przycisk "Start", aby skompilować i uruchomić aplikację.

## Zastosowane Technologie

-   **C#** - Główny język programowania.
-   **Windows Forms (.NET Framework)** - Platforma do budowy interfejsu graficznego.
-   **HttpClient** - Do realizacji zapytań HTTP i pobierania plików.
-   **Ping Class** - Do wysyłania pakietów ICMP.

## Licencja

Projekt jest udostępniany na licencji MIT. Zobacz plik `LICENSE`, aby uzyskać więcej informacji.

## Podziękowania

-   **ICM, Uniwersytet Warszawski** - za udostępnienie publicznego i stabilnego serwera lustrzanego (`ftp.icm.edu.pl`), który jest kluczowy dla miarodajnych testów prędkości.
-   **httpbin.org** - za doskonałe narzędzie do testowania zapytań HTTP, używane w teście wysyłania.
