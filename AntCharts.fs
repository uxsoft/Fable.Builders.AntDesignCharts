namespace Fable.Builders.AntDesignCharts

open Fable.Builders.AntDesignCharts.Charts
open Fable.Builders.AntDesignCharts.Maps

[<AutoOpen>]
module AntCharts =
    // Plots
    let Area = AreaBuilder()
    let Bar = BarBuilder()
    let Bullet = BulletBuilder()
    let Column = ColumnBuilder()
    let Funnel = FunnelBuilder()
    let Histogram = HistogramBuilder()
    let Line = LineBuilder()
    let Box = BoxBuilder()
    let Liquid = LiquidBuilder()
    let Heatmap = HeatmapBuilder()
    let Pie = PieBuilder()
    let Gauge = GaugeBuilder()
    let Progress = ProgressBuilder()
    let Radar = RadarBuilder()
    let RingProgress = RingProgressBuilder()
    let Rose = RoseBuilder()
    let Chord = ChordBuilder()
    let Scatter = ScatterBuilder()
    let TinyArea = TinyAreaBuilder()
    let TinyColumn = TinyColumnBuilder()
    let DualAxes = DualAxesBuilder()
    let TinyLine = TinyLineBuilder()
    let Waterfall = WaterfallBuilder()
    let WordCloud = WordCloudBuilder()
    let Sunburst = SunburstBuilder()
    let Stock = StockBuilder()
    let RadialBar = RadialBarBuilder()
    let Sankey = SankeyBuilder()
    let Treemap = TreemapBuilder()
    let Violin = ViolinBuilder()
    let Venn = VennBuilder()
    let CirclePacking = CirclePackingBuilder()
    let Facet = FacetBuilder()
    let MultiView = MultiViewBuilder()
    let Mix = MixBuilder()
    let BidirectionalBar = BidirectionalBarBuilder()
    
    // Graphs
    let OrganizationGraph = OrganizationGraphBuilder()
    let RadialTreeGraph = RadialTreeGraphBuilder()
    let FlowAnalysisGraph = FlowAnalysisGraphBuilder()
    let DecompositionTreeGraph = DecompositionTreeGraphBuilder()
    let FundFlowGraph = FundFlowGraphBuilder()
    
    // Maps
    let DotMap = DotMapBuilder()
    //let GeographicHeatmap = GeographicHeatmapBuilder()
    let GridMap = GridMapBuilder()
    let HexbinMap = HexbinMapBuilder()
    let AreaMap = AreaMapBuilder()
    let ChoroplethMap = ChoroplethMapBuilder()
