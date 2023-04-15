# Polish.DatesInWords
Friendly library to convert dates to Polish words. 

```cs
Console.WriteLine(DateTime.Now.ToPolishWords());

// 15 kwietnia 2023
```

Polish.NumberInWords offers following features:

### Configure returned text

```cs
DateTime.Now.ToPolishWords()
    .Write(x => $"{x.DaysCountInWords} {x.MonthInWords} {x.YearsCountInWords} {x.YearsInWords}");
    
// piętnasty kwietnia dwa tysiące dwudziestego trzeciego roku
```

### All 7 Polish cases: Nominative, Genitive, Dative, Accusative, Instrumental, Locative, Vocative

```cs
DateTime.Now.ToPolishWords()
    .Case(Case.Dative)
    .Write(x => $"{x.DaysCountInWords} {x.MonthInWords}");

// piętnastemu kwietnia
```

### Convert day of week to words
```cs
DateTime.Now.DayOfWeek.ToPolishWords()

// sobota
```

All 7 cases and plurality setting are available:
```cs
DateTime.Now.DayOfWeek.ToPolishWords(Case.Genitive, isPlural: true);

// sobót
```
