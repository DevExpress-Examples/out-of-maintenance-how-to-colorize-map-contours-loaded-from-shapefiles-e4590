<!-- default file list -->
*Files to look at*:

* [ColorGenerator.cs](./CS/ColorizeMapShapes/ColorGenerator.cs) (VB: [ColorGenerator.vb](./VB/ColorizeMapShapes/ColorGenerator.vb))
* [MainPage.xaml](./CS/ColorizeMapShapes/MainPage.xaml) (VB: [MainPage.xaml](./VB/ColorizeMapShapes/MainPage.xaml))
* [MainPage.xaml.cs](./CS/ColorizeMapShapes/MainPage.xaml.cs) (VB: [MainPage.xaml](./VB/ColorizeMapShapes/MainPage.xaml))
* [RangeColor.cs](./CS/ColorizeMapShapes/RangeColor.cs) (VB: [RangeColor.vb](./VB/ColorizeMapShapes/RangeColor.vb))
<!-- default file list end -->
# How to colorize map contours loaded from Shapefiles


<p>This example demonstrates how to paint each map contour in a specific color depending on population data from Shapefiles (<strong>Countries.dbf</strong>, <strong>Countries.shp</strong>).</p><p><br />
</p>


<h3>Description</h3>

<p>For this, handle the <a href="http://documentation.devexpress.com/#Silverlight/DevExpressXpfMapShapeLoaderBase_ShapesLoadedtopic"><u>ShapeLoaderBase.ShapesLoaded</u></a> event and color each map shape in the <strong>PrepareShapesByPopulation</strong> method using information from Shapefiles (a country name, population, country shapes). This information is accessed from Shapefiles by attributes using the <a href="http://documentation.devexpress.com/#Silverlight/DevExpressXpfMapMapItemAttribute_Nametopic"><u>MapItemAttribute.Name</u></a>, <a href="http://documentation.devexpress.com/#Silverlight/DevExpressXpfMapMapItemAttribute_Typetopic"><u>MapItemAttribute.Type</u></a> and <a href="http://documentation.devexpress.com/#Silverlight/DevExpressXpfMapMapItemAttribute_Valuetopic"><u>MapItemAttribute.Value</u></a> properties. </p><br />


<br/>


