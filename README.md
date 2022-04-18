# Fable.Builders.AntDesignCharts

<img src="https://buildstats.info/nuget/Fable.Builders.AntDesignCharts" alt="badge"/>

## Getting Started

```bash
dotnet package add Fable.Builders.AntDesignCharts
```

```bash
yarn add @ant-design/charts
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
