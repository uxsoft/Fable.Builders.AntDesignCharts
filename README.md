# Fable.Builders.AntDesignCharts

<img src="https://buildstats.info/nuget/Fable.Builders.AntDesignCharts" alt="badge"/>

## Getting Started

### Manual Installation

```bash
dotnet package add Fable.Builders.AntDesignCharts
```

```bash
yarn add @ant-design/charts
```

### Installation with Femto

Use [Femto](https://github.com/Zaid-Ajaj/Femto), then it can install everything for you in one go
```
femto install Fable.Builders.AntDesignCharts
```

## Usage

```fsharp
let plotData =
    [| 
        {| Id = ""
           Name = "Toyota"
           Count = 38 |}
        {| Id = ""
           Name = "Volkswagen"
           Count = 27 |}
        {| Id = ""
           Name = "Opel"
           Count = 5 |}
        {| Id = ""
           Name = "BMW"
           Count = 16 |}
    |]

Column {
    height 128
    autoFit true
    data plotData
    xField "Name"
    yField "Count"
    seriesField "Name"
}
```
