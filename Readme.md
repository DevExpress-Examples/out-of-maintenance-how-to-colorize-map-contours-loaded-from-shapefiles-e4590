<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128570810/12.2.7%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E4590)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [ColorGenerator.cs](./CS/ColorizeMapShapes/ColorGenerator.cs) (VB: [ColorGenerator.vb](./VB/ColorizeMapShapes/ColorGenerator.vb))
* [MainPage.xaml](./CS/ColorizeMapShapes/MainPage.xaml) (VB: [MainPage.xaml](./VB/ColorizeMapShapes/MainPage.xaml))
* [MainPage.xaml.cs](./CS/ColorizeMapShapes/MainPage.xaml.cs) (VB: [MainPage.xaml.vb](./VB/ColorizeMapShapes/MainPage.xaml.vb))
* [RangeColor.cs](./CS/ColorizeMapShapes/RangeColor.cs) (VB: [RangeColor.vb](./VB/ColorizeMapShapes/RangeColor.vb))
<!-- default file list end -->
# How to colorize map contours loaded from Shapefiles
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e4590)**
<!-- run online end -->


<p>This example demonstrates how to paint each map contour in a specific color depending on population data from Shapefiles (<strong>Countries.dbf</strong>, <strong>Countries.shp</strong>).</p><p><br />
</p>


<h3>Description</h3>

<p>For this, handle the <a href="http://documentation.devexpress.com/#Silverlight/DevExpressXpfMapShapeLoaderBase_ShapesLoadedtopic"><u>ShapeLoaderBase.ShapesLoaded</u></a> event and color each map shape in the <strong>PrepareShapesByPopulation</strong> method using information from Shapefiles (a country name, population, country shapes). This information is accessed from Shapefiles by attributes using the <a href="http://documentation.devexpress.com/#Silverlight/DevExpressXpfMapMapItemAttribute_Nametopic"><u>MapItemAttribute.Name</u></a>, <a href="http://documentation.devexpress.com/#Silverlight/DevExpressXpfMapMapItemAttribute_Typetopic"><u>MapItemAttribute.Type</u></a> and <a href="http://documentation.devexpress.com/#Silverlight/DevExpressXpfMapMapItemAttribute_Valuetopic"><u>MapItemAttribute.Value</u></a> properties. </p><br />


<br/>


