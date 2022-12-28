module Fable.Builders.AntDesignCharts.Maps

open Core
open Fable.Core.JsInterop
    
type DotMapBuilder() =
    inherit ChartBuilder(import "DotMap" "@ant-design/maps")
    
type HeatMapBuilder() =
    inherit ChartBuilder(import "HeatMap" "@ant-design/maps")
    
type GridMapBuilder() =
    inherit ChartBuilder(import "GridMap" "@ant-design/maps")
    
type HexbinMapBuilder() =
    inherit ChartBuilder(import "HexbinMap" "@ant-design/maps")

type AreaMapBuilder() =
    inherit ChartBuilder(import "AreaMap" "@ant-design/maps")
    
type ChoroplethMapBuilder() =
    inherit ChartBuilder(import "ChoroplethMap" "@ant-design/maps")
    
