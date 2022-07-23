namespace Fable.Builders.AntDesignCharts

open Fable.Builders.Common
open Fable.Core

module Maps =

    type MapConfig =
        { ``type``: string
          style: string
          center: float array
          zoom: int
          pitch: int }
    
    type MapBuilder(import: obj) =
        inherit ReactBuilder(import)
        
        [<CustomOperation("map")>]
        member inline _.map (x: DSLElement, v: MapConfig) = x.attr "map" v