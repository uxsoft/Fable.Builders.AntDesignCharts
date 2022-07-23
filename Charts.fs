module Fable.Builders.AntDesignCharts.Charts

open Core
open Fable.Core.JsInterop

// Plots
type AreaBuilder() =
    inherit ChartBuilder("Area", "@ant-design/charts")
    
type BarBuilder() =
    inherit ChartBuilder("Bar", "@ant-design/charts")
    
type BulletBuilder() =
    inherit ChartBuilder("Bullet", "@ant-design/charts")
    
type ColumnBuilder() =
    inherit ChartBuilder("Column", "@ant-design/charts")
    
type FunnelBuilder() =
    inherit ChartBuilder("Funnel", "@ant-design/charts")
    
type HistogramBuilder() =
    inherit ChartBuilder("Histogram", "@ant-design/charts")
    
type LineBuilder() =
    inherit ChartBuilder("Line", "@ant-design/charts")
    
type BoxBuilder() =
    inherit ChartBuilder("Box", "@ant-design/charts")
    
type LiquidBuilder() =
    inherit ChartBuilder("Liquid", "@ant-design/charts")
    
type HeatmapBuilder() =
    inherit ChartBuilder("Heatmap", "@ant-design/charts")
    
type PieBuilder() =
    inherit ChartBuilder("Pie", "@ant-design/charts")
    
type GaugeBuilder() =
    inherit ChartBuilder("Gauge", "@ant-design/charts")
    
type ProgressBuilder() =
    inherit ChartBuilder("Progress", "@ant-design/charts")
    
type RadarBuilder() =
    inherit ChartBuilder("Radar", "@ant-design/charts")
    
type RingProgressBuilder() =
    inherit ChartBuilder("RingProgress", "@ant-design/charts")
    
type RoseBuilder() =
    inherit ChartBuilder("Rose", "@ant-design/charts")
    
type ChordBuilder() =
    inherit ChartBuilder("Chord", "@ant-design/charts")
    
type ScatterBuilder() =
    inherit ChartBuilder("Scatter", "@ant-design/charts")
    
type TinyAreaBuilder() =
    inherit ChartBuilder("TinyArea", "@ant-design/charts")
    
type TinyColumnBuilder() =
    inherit ChartBuilder("TinyColumn", "@ant-design/charts")
    
type DualAxesBuilder() =
    inherit ChartBuilder("DualAxes", "@ant-design/charts")
    
type TinyLineBuilder() =
    inherit ChartBuilder("TinyLine", "@ant-design/charts")
    
type WaterfallBuilder() =
    inherit ChartBuilder("Waterfall", "@ant-design/charts")
    
type WordCloudBuilder() =
    inherit ChartBuilder("WordCloud", "@ant-design/charts")
    
type SunburstBuilder() =
    inherit ChartBuilder("Sunburst", "@ant-design/charts")
    
type StockBuilder() =
    inherit ChartBuilder("Stock", "@ant-design/charts")
    
type RadialBarBuilder() =
    inherit ChartBuilder("RadialBar", "@ant-design/charts")
    
type SankeyBuilder() =
    inherit ChartBuilder("Sankey", "@ant-design/charts")
    
type TreemapBuilder() =
    inherit ChartBuilder("Treemap", "@ant-design/charts")
    
type ViolinBuilder() =
    inherit ChartBuilder("Violin", "@ant-design/charts")
    
type VennBuilder() =
    inherit ChartBuilder("Venn", "@ant-design/charts")
    
type CirclePackingBuilder() =
    inherit ChartBuilder("CirclePacking", "@ant-design/charts")
    
type FacetBuilder() =
    inherit ChartBuilder("Facet", "@ant-design/charts")
    
type MultiViewBuilder() =
    inherit ChartBuilder("MultiView", "@ant-design/charts")
    
type MixBuilder() =
    inherit ChartBuilder("Mix", "@ant-design/charts")
    
type BidirectionalBarBuilder() =
    inherit ChartBuilder("BidirectionalBar", "@ant-design/charts")
    
// Graphs
type OrganizationGraphBuilder() =
    inherit ChartBuilder("OrganizationGraph", "@ant-design/charts")
    
type RadialTreeGraphBuilder() =
    inherit ChartBuilder("RadialTreeGraph", "@ant-design/charts")
    
type FlowAnalysisGraphBuilder() =
    inherit ChartBuilder("FlowAnalysisGraph", "@ant-design/charts")
    
type DecompositionTreeGraphBuilder() =
    inherit ChartBuilder("DecompositionTreeGraph", "@ant-design/charts")
    
type FundFlowGraphBuilder() =
    inherit ChartBuilder("FundFlowGraph", "@ant-design/charts")
    
// Maps
type DotMapBuilder() =
    inherit ChartBuilder("DotMap", "@ant-design/charts")
    
type GeographicHeatmapBuilder() =
    inherit ChartBuilder("GeographicHeatmap", "@ant-design/charts")
    
type GridMapBuilder() =
    inherit ChartBuilder("GridMap", "@ant-design/charts")
    
type HexbinMapBuilder() =
    inherit ChartBuilder("HexbinMap", "@ant-design/charts")
    
type PathMapBuilder() =
    inherit ChartBuilder("PathMap", "@ant-design/charts")
    
type FlowMapBuilder() =
    inherit ChartBuilder("FlowMap", "@ant-design/charts")
    
type AreaMapBuilder() =
    inherit ChartBuilder("AreaMap", "@ant-design/charts")
    
type ChoroplethMapBuilder() =
    inherit ChartBuilder("ChoroplethMap", "@ant-design/charts")
    
