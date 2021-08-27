<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128615284/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2788)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# How to replace standard menus with my own?


<p><br />
This example demonstrates how you can display a custom form instead of default popup menus for DevExpress controls. Most of our components provide the MenuManager property of the IDXMenuManager  type. All you need to do is to implement a custom component that supports this interface. Two main benefits of this approach:<br />
1. You do not need to handle any event. <br />
2. You do not need to create menu items manually. You just need to convert the provided items according to your logic.</p>

<br/>


