   M S B A M L   `   `   `  ����?  ;SApp, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null'clr-namespace:SApp.Pages
SApp.Pages  5      U QLiveCharts.Wpf, Version=0.9.7.0, Culture=neutral, PublicKeyToken=0bc1f845d1ebb8dfG4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.WpfLiveCharts.Wpf 6.       SApp.Pages.TrackingPage   5      W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      *localclr-namespace:SApp.Pages     5      Dlvc4clr-namespace:LiveCharts.Wpf;assembly=LiveCharts.Wpf     6.     N� 
FontFamily$  Ubuntu)�5	       N� Title$ TrackingPage��5
      .��5      � $��	50,35,0,0q�6    � RowDefinitions 5   
   �� 5      $��1* �6   �� 5      $��7* �6   .+�5   
   � $��0��6   $��60,0,0,0q�5      .+�5      ��  �� Orientation$ Vertical=�6   $��Center=�5      $
��Left=�5      .+�5      �� $ 
Horizontal=�6   $��Center=�5      $��0,20,0,0q�5      $
��Left=�5      .+�5      �� $<��6Выберите интересующую акцию: ��6    $��20(�5      $��0,0,20,0q�5      �� 5      -   5         ��Name$ ChooseShareCB��5      $	��262��5       $��20,0,0,0q�5!      5#      5%      �� 5'      $ 
Horizontal=�6   $��0,20,0,0q�5(      .+�5)      �� $<��6Введите начальную цену акции:��6    $��20(�5*       $��0,0,20,0q�5+       �� 5-      -   5         ��Name$ InputPriceTB��5.      $	��262��5-      $��38,0,0,0q�5/      50      52      �� 53      -   5         ��Name$ Trackingbtn��56      $'��!Отслеживать акцию��53      $��Center=�54      $��Right=�55      $��0,0,45,0q�57      $	��200��58      59      5;      � 5?   
   $��1��6    � ColumnDefinitions 5@      �� 5A      $��7* �6#   �� 5B      $��2* �6#   .+�5E      #  LiveCharts.Wpf.CartesianChart  $��0��6!   &   LiveCharts.Wpf.Charts.Base.Chart   LegendLocation$ Right=�6U   $��0,0,0,0q�6l   	   Series	 61   �� *SeriesCollection+
   AxisY
 5G        LiveCharts.Wpf.Axis     Title$ Цена��6      LabelFormatter 6,   �� *
YFormatter+6T      AxisX 5J        $ День��6      Labels 6,   �� *Labels+6H   5L      � 5O      $��1��6    5P      �� 5Q      $
��381* �6$   �� 5R      $
��300* �6$   �� 5S      $	��76* �6$   .+�5U      �� $��0��6   $ 
Horizontal=�6*   $��2��6C   .+�5W      �� -   5         ��Name$ DateFamilySP��5X      $ Vertical=�5W   !   .+�5Y      �� -   5         ��Name$ CurrentDateTB��5Y   $   $
��Bold"�6;   5Z      �� 5\      -   5        $ PriceFamilySP��5^   !   $��30,0,0,0q�5\   !   $ Vertical=�5]   !   .+�5_      �� -   5        $ CurrentPriceTB��5_   $   $
��Bold"�6<   5`      �� 5b      -   5        $ 
IDFamilySP��5d   !   $��30,0,0,0q�5b   !   $ Vertical=�5c   !   .+�5e      �� -	   5        $ CurrentIdTB��5e   $   $
��Bold"�69   5f      5g      �� 5i      -
   5        $ SaveDataTracking��5k      $��2��5i      $@��:Сохранить историю отслеживания��5j      $��10(�5m      $��0q�5n      $	��200��5o      ���#00c21d$��22,22,23,22q�5p   .   5q      5r      5s      5t      