   M S B A M L   `   `   `  ????B  >kpz2.UI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:kpz2.UI.Viewskpz2.UI.Views  5      7 clr-namespace:kpz2.UI.Convertorskpz2.UI.Convertors  68   7 clr-namespace:kpz2.UI.ViewModelskpz2.UI.ViewModels  6k   %    kpz2.UI.Views.OrdersUserControl   5      W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      -localclr-namespace:kpz2.UI.Views     5      6	Converter clr-namespace:kpz2.UI.Convertors     68   7
viewmodels clr-namespace:kpz2.UI.ViewModels     6k     ? 	Resources  5	      +   %kpz2.UI.Convertors.ImagePathConvertor   my:ImagePathConvertor??%   &	          5
   
   6'   5      .??5      ? .+?5   
   &   System.Windows.Controls.DataGrid  -   5        $??	dataGrid1??5         AutoGenerateColumns$ False??5      $	??256??6/      CanUserAddRows$
 True??6<   $
??Left=?6S   $	??Top=?5   $   $
??Auto??6<   ??5      ??  ?? Path$ Orders? ?? SelectedItem 5      ?? $ SelectedOrder? ?? Mode$ TwoWay=?   Columns 5      4  .System.Windows.Controls.DataGridTemplateColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ Status??6)      CellTemplate 5      ?? 5      .R?5      ?? $??48??6$   $??48??6/   ??5   !   ?? $ Status?	 ?? 	Converter#	 [  5      5      0  *System.Windows.Controls.DataGridTextColumn  5       $ Id??6%   1  +System.Windows.Controls.DataGridBoundColumn
   Binding
 61   ?? $ Id?$ TwoWay=?  5!      $ Created??6%   
 66   ?? $ Created?$ TwoWay=?  5"      $ 	ProductId??6%   
 68   ?? $ 	ProductId?$ TwoWay=?  5#      $ CustomerName??6%   
 6;   ?? $ CustomerName?$ TwoWay=?  5$      $ CustomerAddress??6%   
 6>   ?? $ CustomerAddress?$ TwoWay=?  5%      $ CustomerNumber??6%   
 6=   ?? $ CustomerNumber?$ TwoWay=?5'      ?? 5(   
   -   5        $??buttonInProgress??5(      $??In progress??6*   $
??Left=?6@   $??156,326,0,0q?6[   $	??Top=?6p    J? RenderTransformOrigin$ 0.361,-0.684&?6?   $??49??6?   $??95??6?   6?   ?? 5)   
   -   5        $??	buttonNew??5)      $	??New??6$   $
??Left=?62   $??49??6M   $??
23,326,0,0q?6Y   $	??Top=?6m   $??93??6?   $ -0.719,-1.193&?6?   6?   ?? 5*   
   -   5        $??buttonInDelivery??5*      $??In delivery??6*   $
??Left=?6@   $??49??6[   $??288,326,0,0q?6g   $	??Top=?6|   $??97??6?   6?   ?? 5+   
   -   5        $??buttonDelivered??5+      $??	Delivered??6)   $
??Left=?6=   $??49??6X   $??428,326,0,0q?6d   $	??Top=?6y   $??88??6?    ? Triggers 5,      :? 5-       :? RoutedEvent$ Button.Click??6   .[?5.      ?? .??5/      ?? .??50      W?  ?? 
TargetName$ buttonDelivered??6.    ?? TargetProperty$ Width?51       W? From 11152      	 W? To 1506    g? Duration$ 0:0:3D?6'   53      54      55      57      59      5:      